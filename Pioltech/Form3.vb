Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Pioltech.Form1

Public Class Form3
    Private miDataRow As DataRow
    Private miDataSet As DataSet
    Private idPedido As Integer
    Private idProveedor As Integer


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miDataSet = PrimeraVentana.getMiDataSet()
        For Each miDataRow In miDataSet.Tables("Pedidos").Rows
            idPedido = miDataRow("idPedido")
        Next
        rtbIdPedido.Text = idPedido + 1
        rtbTotalPrecio.Text = 0
        For Each miDataRow In miDataSet.Tables("Proveedores").Rows
            idProveedor = miDataRow("idProveedor")
            cbProv.Items.Add(miDataRow("Nombre"))
        Next

        rtbIdProveedores.Text = idProveedor + 1

        Me.dgArticulos.DataSource = miDataSet.Tables("Articulos")




    End Sub

    Private Sub cbPedido_CheckedChanged(sender As Object, e As EventArgs) Handles cbPedido.CheckedChanged
        cbProveedores.Checked = False
        rtbIdArticulo.Enabled = True
        rtbCantArticulo.Enabled = True
        rtbNombreProv.Enabled = False
        rtbDireccion.Enabled = False
        rtbTelefono.Enabled = False
    End Sub

    Private Sub cbProveedores_CheckedChanged(sender As Object, e As EventArgs) Handles cbProveedores.CheckedChanged
        cbPedido.Checked = False
        rtbIdProveedores.Text = idProveedor + 1
        rtbNombreProv.Enabled = True
        rtbDireccion.Enabled = True
        rtbTelefono.Enabled = True
        rtbIdArticulo.Enabled = False
        rtbCantArticulo.Enabled = False
        btnAgregar.Enabled = False
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (rtbIdArticulo.Text <> Nothing And rtbCantArticulo.Text <> Nothing And rtbPrecioPedido.Text <> Nothing) Then
            If (rtbCantArticulo.Text < 15) Then
                MsgBox("La cantidad minima son 15 articulos")
                rtbCantArticulo.Clear()
            Else

                lbPedido.Items.Add(rtbIdPedido.Text & "    " & rtbIdArticulo.Text & "    " & rtbPrecioPedido.Text & "    " & rtbCantArticulo.Text)
                rtbTotalArticulos.Text = Val(rtbTotalArticulos.Text) + Val(rtbCantArticulo.Text)
                rtbTotalPrecio.Text = CDbl(rtbTotalPrecio.Text) + (CDbl(rtbPrecioPedido.Text) * Val(rtbCantArticulo.Text))
                For Each miDataRow In miDataSet.Tables("Pedidos").Rows
                    idPedido = miDataRow("idPedido")
                Next
                For Each miDataRow In miDataSet.Tables("Articulos").Rows
                    If (miDataRow("idArticulo") Like rtbIdArticulo.Text) Then
                        miDataRow("CantidadActual") = miDataRow("CantidadActual") + Val(rtbCantArticulo.Text)
                    End If
                Next
                rtbIdPedido.Text = idPedido + 1
                rtbIdArticulo.Clear()
                rtbPrecioPedido.Clear()
                rtbCantArticulo.Clear()
                MsgBox("El articulo ha sido añadido al pedido")
            End If
        Else
            MsgBox("Debe rellenar todos los campos")
            For Each miDataRow In miDataSet.Tables("Articulos").Rows
                If (miDataRow("idArticulo") Like rtbIdArticulo.Text) Then
                    Exit For
                End If
            Next

            If (miDataRow("idArticulo") <> rtbIdArticulo.Text) Then
                If MessageBox.Show("No tenemos registro de ese articulo ¿Desea ir a gestion de articulos?", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    rtbIdArticulo.Clear()
                    PrimeraVentana.ventanaArticulos.Show()
                    Me.Hide()
                Else
                    MsgBox("Cambie la id del articulo")
                    rtbIdArticulo.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub rtbIdArticulo_TextChanged(sender As Object, e As EventArgs) Handles rtbIdArticulo.TextChanged
        If (rtbIdArticulo.Text <> Nothing) Then
            For Each miDataRow In miDataSet.Tables("Articulos").Rows
                If (miDataRow("idArticulo") Like rtbIdArticulo.Text) Then
                    rtbPrecioPedido.Text = miDataRow("PrecioArticulo")
                End If
            Next
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        PrimeraVentana.Show()
    End Sub

    Private Sub btnRealizar_Click(sender As Object, e As EventArgs) Handles btnRealizar.Click
        Dim miConexion As New SqlConnection
        miConexion.ConnectionString = "SERVER = LAPTOP-KS9DH17T\SQLEXPRESS;Integrated Security = SSPI;DATABASE = Pioltech"
        If (cbPedido.Checked) Then
            If MessageBox.Show("¿Desea realizar el siguiente pedido?", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                For Each miDataRow In miDataSet.Tables("Proveedores").Rows
                    If (miDataRow("Nombre") Like cbProv.SelectedItem) Then
                        idProveedor = miDataRow("idProveedor")
                    End If
                Next
                miDataSet.Tables("Pedidos").Rows.Add(idPedido + 1, rtbTotalArticulos.Text, rtbTotalPrecio.Text, idProveedor)
                For a = 0 To lbPedido.Items.Count - 1
                    Dim obj As String
                    Dim arrObj As String()
                    obj = lbPedido.Items(a)
                    arrObj = obj.Split("    ")
                    miDataSet.Tables("LineaPedidos").Rows.Add(arrObj(0), arrObj(4), arrObj(12), arrObj(8))
                Next a

                PrimeraVentana.DataAdapterPedidos.Update(miDataSet, "Pedidos")
                PrimeraVentana.DataAdapterLineaPedidos.Update(miDataSet, "LineaPedidos")
                For Each miDataRow In miDataSet.Tables("Articulos").Rows

                    For Each miDataRow2 In miDataSet.Tables("Stock").Rows
                        If miDataRow("idArticulo") Like miDataRow2("idArticulo") Then
                            miDataRow2("CantArticuloStock") = miDataRow("CantidadActual")
                        End If
                    Next
                Next

                PrimeraVentana.DataAdapterArticulos.Update(miDataSet, "Articulos")
                PrimeraVentana.DataAdapterStock.Update(miDataSet, "Stock")
                MsgBox("Pedido realizado")
                rtbIdPedido.Text = rtbIdPedido.Text + 1

            End If
        ElseIf (cbProveedores.Checked) Then
            If MessageBox.Show("¿Desea añadir el siguiene proveedor al registro?", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                miDataSet.Tables("Proveedores").Rows.Add(rtbIdProveedores.Text + 1, rtbNombreProv.Text, rtbDireccion.Text, rtbTelefono.Text)
                miConexion.Open()
                PrimeraVentana.DataAdapterProveedores.Update(miDataSet, "Proveedores")
                miConexion.Close()
                rtbIdProveedores.Clear()
                rtbNombreProv.Clear()
                rtbDireccion.Clear()
                rtbTelefono.Clear()
            End If
        End If
    End Sub

    Private Sub btnDeshacer_Click(sender As Object, e As EventArgs) Handles btnDeshacer.Click
        If MessageBox.Show("¿Desea deshacer los cambios?", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            rtbIdArticulo.Clear()
            rtbPrecioPedido.Clear()
            rtbCantArticulo.Clear()
            rtbTotalArticulos.Clear()
            rtbTotalPrecio.Clear()

            For a = 0 To lbPedido.Items.Count - 1
                lbPedido.Items.Clear()
            Next a
            rtbIdProveedores.Clear()
            rtbNombreProv.Clear()
            rtbDireccion.Clear()
            rtbTelefono.Clear()
            cbProv.SelectedItem = Nothing
        End If
    End Sub

    Private Sub btCargarPedidos_Click(sender As Object, e As EventArgs) Handles btCargarPedidos.Click
        Dim pedidos() As String = Cargar()
        Dim pedido() As String
        Dim numPedido As Integer = idPedido
        For i = 0 To pedidos.Length - 1
            'formato de pedidos idArticulo/precioArticulo/catidadArticulo/idProveedor
            numPedido = numPedido + 1
            If (pedidos(i) = "") Then
            Else
                pedido = Split(pedidos(i), "&")
                miDataSet.Tables("Pedidos").Rows.Add(numPedido, pedido(2), (pedido(1) * pedido(2)), pedido(3))
                miDataSet.Tables("LineaPedidos").Rows.Add(numPedido, Val(pedido(0)), pedido(2), (pedido(1) * pedido(2)))
            End If
        Next i
        PrimeraVentana.DataAdapterPedidos.Update(miDataSet, "Pedidos")
        PrimeraVentana.DataAdapterLineaPedidos.Update(miDataSet, "LineaPedidos")
    End Sub
    Public Function Cargar()

        Dim sr As New System.IO.StreamReader("../../ficheroPedidos.txt")
        Dim pedidos As String = sr.ReadToEnd()
        Dim pedido() As String
        pedido = Split(pedidos, "#")
        sr.Close()
        Return pedido

    End Function
End Class