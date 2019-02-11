Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Pioltech.Form1

Public Class Form2
    Private miDataRow As DataRow
    Private miDataSet As DataSet
    Private idArticulo As Integer
    Private idStock As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        miDataSet = PrimeraVentana.getMiDataSet()
        For Each miDataRow In miDataSet.Tables("Articulos").Rows
            idArticulo = miDataRow("idArticulo")
        Next
        rtbIdArticulo.Text = idArticulo + 1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        idStock = 1000
        For Each miDataRow In miDataSet.Tables("Stock").Rows
            idStock = miDataRow("idStock") + 1
        Next
        If (rtbDescripcion.Text <> Nothing And rtbPrecio.Text <> Nothing And rtbCantidadActual.Text <> Nothing And rtbTipo.Text <> Nothing) Then
            If MessageBox.Show("¿Desea agregar el articulo?", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                miDataSet.Tables("Articulos").Rows.Add(rtbIdArticulo.Text, rtbDescripcion.Text, rtbPrecio.Text, rtbCantidadActual.Text, rtbTipo.Text)
                miDataSet.Tables("Stock").Rows.Add(idStock, 0, rtbIdArticulo.Text, Date.Now.ToString("yyyy/MM/dd"))
                MsgBox("Articulo agregado al registro")
                rtbIdArticulo.Text = idArticulo + 1
                rtbDescripcion.Clear()
                rtbPrecio.Clear()
                rtbCantidadActual.Clear()
                rtbTipo.Clear()

                PrimeraVentana.DataAdapterArticulos.Update(miDataSet, "Articulos")

            End If
        Else
            MsgBox("Debe rellenar todos los campos")
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        PrimeraVentana.Visible = True
        Me.Close()
    End Sub
End Class