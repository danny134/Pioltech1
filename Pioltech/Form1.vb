
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms


Public Class Form1
    Friend WithEvents botones As System.Windows.Forms.Button
    Public ventanaTicket As New Form4
    Public ventanaArticulos As New Form2
    Public ventanaPedidos As New Form3
    Public funcionesTiempo As Class2 = New Class2()
    Public ticket() As String
    Public DataAdapterEmpleados, DataAdapterArticulos, DataAdapterStock, DataAdapterDispositivosUso, DataAdapterProveedores,
        DataAdapterPedidos, DataAdapterLineaPedidos, DataAdapterDispositivos, DataAdapterComandas, DataAdapterCajaDiaria,
        DataAdapterLineaComandas As SqlDataAdapter
    Private fila1 As Integer
    Private fila2 As Integer
    Private fila3 As Integer
    Private fila4 As Integer
    Private fila5 As Integer
    Private fila6 As Integer
    Private fila7 As Integer
    Private fila8 As Integer
    Private fila9 As Integer
    Private fila10 As Integer
    Private fila11 As Integer
    Private fila12 As Integer
    Private cont As Integer
    Private descripcion As String
    Private cantidadActual As Integer
    Private tipo As String
    Private precioArticulo As Double
    Private precioTotal As Double
    Private miDataSet As DataSet
    Private miDataRow As DataRow
    Dim stockMinimo As Integer
    Private printDocument As PrintDocument = New PrintDocument()
    Private Const idDispositivo = 1000


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim miConexion As New SqlConnection
        miConexion.ConnectionString = "SERVER = LAPTOP-KS9DH17T\SQLEXPRESS;Integrated Security = SSPI;DATABASE = Pioltech"

        DataAdapterArticulos = New SqlDataAdapter("SELECT * FROM Articulos", miConexion)
        DataAdapterEmpleados = New SqlDataAdapter("SELECT * FROM Empleados", miConexion)
        DataAdapterStock = New SqlDataAdapter("SELECT * FROM Stock", miConexion)
        DataAdapterDispositivosUso = New SqlDataAdapter("SELECT * FROM UsoDispositivos", miConexion)
        DataAdapterProveedores = New SqlDataAdapter("SELECT * FROM Proveedores", miConexion)
        DataAdapterPedidos = New SqlDataAdapter("SELECT * FROM Pedidos", miConexion)
        DataAdapterLineaPedidos = New SqlDataAdapter("SELECT * FROM LineaPedidos", miConexion)
        DataAdapterDispositivos = New SqlDataAdapter("SELECT * FROM Dispositivos", miConexion)
        DataAdapterComandas = New SqlDataAdapter("SELECT * FROM Comandas", miConexion)
        DataAdapterCajaDiaria = New SqlDataAdapter("SELECT * FROM CajaDiaria", miConexion)
        DataAdapterLineaComandas = New SqlDataAdapter("SELECT * FROM LineaComandas", miConexion)


        Dim CommandBuilderEmpleados As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterEmpleados)
        Dim CommandBuilderArticulos As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterArticulos)
        Dim CommandBuilderStock As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterStock)
        Dim ComandBuilderDispositivosUso As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterDispositivosUso)
        Dim CommandBuilderProveedores As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterProveedores)
        Dim CommandBuilderPedidos As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterPedidos)
        Dim CommandBuilderLineaPedidos As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterLineaPedidos)
        Dim CommandBuilderDispositivos As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterDispositivos)
        Dim CommandBuilderComandas As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterComandas)
        Dim CommandBuilderCajaDiaria As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterCajaDiaria)
        Dim CommandBuilderLineaComandas As SqlCommandBuilder = New SqlCommandBuilder(DataAdapterLineaComandas)


        miDataSet = New DataSet

        miConexion.Open()

        DataAdapterArticulos.Fill(miDataSet, "Articulos")
        DataAdapterEmpleados.Fill(miDataSet, "Empleados")
        DataAdapterStock.Fill(miDataSet, "Stock")
        DataAdapterDispositivosUso.Fill(miDataSet, "UsoDispositivos")
        DataAdapterProveedores.Fill(miDataSet, "Proveedores")
        DataAdapterPedidos.Fill(miDataSet, "Pedidos")
        DataAdapterLineaPedidos.Fill(miDataSet, "LineaPedidos")
        DataAdapterDispositivos.Fill(miDataSet, "Dispositivos")
        DataAdapterComandas.Fill(miDataSet, "Comandas")
        DataAdapterCajaDiaria.Fill(miDataSet, "CajaDiaria")
        DataAdapterLineaComandas.Fill(miDataSet, "LineaComandas")
        miConexion.Close()

        miDataSet.Relations.Add("Stock_Articulos", miDataSet.Tables("Articulos").Columns("idArticulo"), miDataSet.Tables("Stock").Columns("idArticulo"))
        miDataSet.Relations.Add("Comandas_CajaDiaria", miDataSet.Tables("CajaDiaria").Columns("idCajaDiaria"), miDataSet.Tables("Comandas").Columns("idCajaDiaria"))
        miDataSet.Relations.Add("Comandas_Dispositivos", miDataSet.Tables("Dispositivos").Columns("idDispositivo"), miDataSet.Tables("Comandas").Columns("idDispositivo"))
        miDataSet.Relations.Add("LineaComandas_Comandas", miDataSet.Tables("Comandas").Columns("idComanda"), miDataSet.Tables("LineaComandas").Columns("idComanda"))
        miDataSet.Relations.Add("UsoDispositivos_Dispositivos", miDataSet.Tables("Dispositivos").Columns("idDispositivo"), miDataSet.Tables("UsoDispositivos").Columns("idDispositivo"))
        miDataSet.Relations.Add("UsoDispositivos_Empleados", miDataSet.Tables("UsoDispositivos").Columns("idEmpleado"), miDataSet.Tables("Empleados").Columns("idEmpleado"))
        miDataSet.Relations.Add("LineaComandas_Articulos", miDataSet.Tables("Articulos").Columns("idArticulo"), miDataSet.Tables("LineaComandas").Columns("idArticulo"))
        miDataSet.Relations.Add("LineaPedidos_Pedidos", miDataSet.Tables("Pedidos").Columns("idPedido"), miDataSet.Tables("LineaPedidos").Columns("idPedido"))
        miDataSet.Relations.Add("LineaPedidos_Articulos", miDataSet.Tables("Articulos").Columns("idArticulo"), miDataSet.Tables("LineaPedidos").Columns("idArticulo"))
        miDataSet.Relations.Add("Proveedores_Pedidos", miDataSet.Tables("Proveedores").Columns("idProveedor"), miDataSet.Tables("Pedidos").Columns("idProveedor"))
        Dim miDataRow As DataRow
        Dim miDataRow2 As DataRow

        For Each miDataRow In miDataSet.Tables("Articulos").Rows
            For Each miDataRow2 In miDataSet.Tables("Stock").Rows
                If miDataRow("idArticulo") Like miDataRow2("idArticulo") Then
                    miDataRow2("CantArticuloStock") = miDataRow("CantidadActual")
                End If
            Next
        Next
        funcionesTiempo.descargarXML()
    End Sub


    Private Sub btnRefrescos_Click(sender As Object, e As EventArgs) Handles btnRefrescos.Click

        Dim i As Integer
        cont = 0
        i = 1
        miDataRow = miDataSet.Tables("Articulos").Rows(0)

        If btnRefrescos.Enabled Then
            Panel1.Controls.Clear()
            For Each miDataRow In miDataSet.Tables("Articulos").Rows
                tipo = miDataRow("Tipo")

                If (tipo.Equals("Refresco") And tipo <> Nothing) Then

                    Dim botones As New Button()

                    botones.Name = String.Format("btn{0}", i)
                    botones.Height = 60
                    botones.Width = 100
                    If (botones.Name.Equals("btn1")) Then

                        botones.Location = New System.Drawing.Point(10, 12)
                        botones.Image = Image.FromFile("..\..\Resources\cocacola.png")
                        fila1 = cont

                        AddHandler botones.Click, AddressOf btn1_Click
                    ElseIf (botones.Name.Equals("btn2")) Then

                        botones.Location = New System.Drawing.Point(110, 12)
                        'botones.Image = Image.FromFile("..\..\Resources\kas.png")
                        fila2 = cont

                        AddHandler botones.Click, AddressOf btn2_Click
                    ElseIf (botones.Name.Equals("btn3")) Then

                        botones.Location = New System.Drawing.Point(210, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila3 = cont

                        AddHandler botones.Click, AddressOf btn3_Click
                    ElseIf (botones.Name.Equals("btn4")) Then

                        botones.Location = New System.Drawing.Point(310, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila4 = cont

                        AddHandler botones.Click, AddressOf btn4_Click
                    ElseIf (botones.Name.Equals("btn5")) Then

                        botones.Location = New System.Drawing.Point(10, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila5 = cont

                        AddHandler botones.Click, AddressOf btn5_Click
                    ElseIf (botones.Name.Equals("btn6")) Then

                        botones.Location = New System.Drawing.Point(110, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila6 = cont

                        AddHandler botones.Click, AddressOf btn6_Click
                    ElseIf (botones.Name.Equals("btn7")) Then

                        botones.Location = New System.Drawing.Point(210, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila7 = cont

                        AddHandler botones.Click, AddressOf btn7_Click
                    ElseIf (botones.Name.Equals("btn8")) Then

                        botones.Location = New System.Drawing.Point(310, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila8 = cont

                        AddHandler botones.Click, AddressOf btn8_Click
                    ElseIf (botones.Name.Equals("btn9")) Then

                        botones.Location = New System.Drawing.Point(10, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila9 = cont

                        AddHandler botones.Click, AddressOf btn9_Click
                    ElseIf (botones.Name.Equals("btn10")) Then

                        botones.Location = New System.Drawing.Point(110, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila10 = cont

                        AddHandler botones.Click, AddressOf btn10_Click
                    ElseIf (botones.Name.Equals("btn11")) Then

                        botones.Location = New System.Drawing.Point(210, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila11 = cont

                        AddHandler botones.Click, AddressOf btn11_Click
                    ElseIf (botones.Name.Equals("btn12")) Then

                        botones.Location = New System.Drawing.Point(310, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila12 = cont

                        AddHandler botones.Click, AddressOf btn12_Click
                    End If
                    Panel1.Controls.Add(botones)

                    i = i + 1
                End If
                cont = cont + 1

            Next
        End If
    End Sub

    Private Sub btnCafe_Click(sender As Object, e As EventArgs) Handles btnCafe.Click


        Dim i As Integer
        i = 1
        cont = 0
        miDataRow = miDataSet.Tables("Articulos").Rows(0)
        If btnCafe.Enabled Then
            Panel1.Controls.Clear()



            For Each miDataRow In miDataSet.Tables("Articulos").Rows


                tipo = miDataRow("Tipo")

                If (tipo.Equals("cafe") And tipo <> Nothing) Then

                    Dim botones As New Button()

                    botones.Name = String.Format("btn{0}", i)
                    botones.Height = 60
                    botones.Width = 100
                    If (botones.Name.Equals("btn1")) Then

                        botones.Location = New System.Drawing.Point(10, 12)
                        botones.Image = Image.FromFile("..\..\Resources\cafesolo.png")
                        fila1 = cont

                        AddHandler botones.Click, AddressOf btn1_Click
                    ElseIf (botones.Name.Equals("btn2")) Then

                        botones.Location = New System.Drawing.Point(110, 12)
                        botones.Image = Image.FromFile("..\..\Resources\cafecurasan.png")
                        fila2 = cont

                        AddHandler botones.Click, AddressOf btn2_Click
                    ElseIf (botones.Name.Equals("btn3")) Then

                        botones.Location = New System.Drawing.Point(210, 12)
                        botones.Image = Image.FromFile("..\..\Resources\cafenavidad.png")
                        fila3 = cont

                        AddHandler botones.Click, AddressOf btn3_Click
                    ElseIf (botones.Name.Equals("btn4")) Then

                        botones.Location = New System.Drawing.Point(310, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila4 = cont

                        AddHandler botones.Click, AddressOf btn4_Click
                    ElseIf (botones.Name.Equals("btn5")) Then

                        botones.Location = New System.Drawing.Point(10, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila5 = cont

                        AddHandler botones.Click, AddressOf btn5_Click
                    ElseIf (botones.Name.Equals("btn6")) Then

                        botones.Location = New System.Drawing.Point(110, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila6 = cont

                        AddHandler botones.Click, AddressOf btn6_Click
                    ElseIf (botones.Name.Equals("btn7")) Then

                        botones.Location = New System.Drawing.Point(210, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila7 = cont

                        AddHandler botones.Click, AddressOf btn7_Click
                    ElseIf (botones.Name.Equals("btn8")) Then

                        botones.Location = New System.Drawing.Point(310, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila8 = cont

                        AddHandler botones.Click, AddressOf btn8_Click
                    ElseIf (botones.Name.Equals("btn9")) Then

                        botones.Location = New System.Drawing.Point(10, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila9 = cont

                        AddHandler botones.Click, AddressOf btn9_Click
                    ElseIf (botones.Name.Equals("btn10")) Then

                        botones.Location = New System.Drawing.Point(110, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila10 = cont

                        AddHandler botones.Click, AddressOf btn10_Click
                    ElseIf (botones.Name.Equals("btn11")) Then

                        botones.Location = New System.Drawing.Point(210, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila11 = cont

                        AddHandler botones.Click, AddressOf btn11_Click
                    ElseIf (botones.Name.Equals("btn12")) Then

                        botones.Location = New System.Drawing.Point(310, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila12 = cont

                        AddHandler botones.Click, AddressOf btn12_Click
                    End If
                    Panel1.Controls.Add(botones)

                    i = i + 1
                End If
                cont = cont + 1
            Next
        End If
    End Sub

    Private Sub btnCombinados_Click(sender As Object, e As EventArgs) Handles btnCombinados.Click



        Dim i As Integer
        i = 1
        cont = 0
        miDataRow = miDataSet.Tables("Articulos").Rows(0)
        If btnCombinados.Enabled Then
            Panel1.Controls.Clear()


            For Each miDataRow In miDataSet.Tables("Articulos").Rows



                tipo = miDataRow("Tipo")

                If (tipo.Equals("Combinado") And tipo <> Nothing) Then

                    Dim botones As New Button()

                    botones.Name = String.Format("btn{0}", i)
                    botones.Height = 60
                    botones.Width = 100
                    If (botones.Name.Equals("btn1")) Then

                        botones.Location = New System.Drawing.Point(10, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("..\..\Pioltech\background1.png")
                        fila1 = cont

                        AddHandler botones.Click, AddressOf btn1_Click
                    ElseIf (botones.Name.Equals("btn2")) Then

                        botones.Location = New System.Drawing.Point(110, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila2 = cont

                        AddHandler botones.Click, AddressOf btn2_Click
                    ElseIf (botones.Name.Equals("btn3")) Then

                        botones.Location = New System.Drawing.Point(210, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila3 = cont

                        AddHandler botones.Click, AddressOf btn3_Click
                    ElseIf (botones.Name.Equals("btn4")) Then

                        botones.Location = New System.Drawing.Point(310, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila4 = cont

                        AddHandler botones.Click, AddressOf btn4_Click
                    ElseIf (botones.Name.Equals("btn5")) Then

                        botones.Location = New System.Drawing.Point(10, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila5 = cont

                        AddHandler botones.Click, AddressOf btn5_Click
                    ElseIf (botones.Name.Equals("btn6")) Then

                        botones.Location = New System.Drawing.Point(110, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila6 = cont

                        AddHandler botones.Click, AddressOf btn6_Click
                    ElseIf (botones.Name.Equals("btn7")) Then

                        botones.Location = New System.Drawing.Point(210, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila7 = cont

                        AddHandler botones.Click, AddressOf btn7_Click
                    ElseIf (botones.Name.Equals("btn8")) Then

                        botones.Location = New System.Drawing.Point(310, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila8 = cont

                        AddHandler botones.Click, AddressOf btn8_Click
                    ElseIf (botones.Name.Equals("btn9")) Then

                        botones.Location = New System.Drawing.Point(10, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila9 = cont

                        AddHandler botones.Click, AddressOf btn9_Click
                    ElseIf (botones.Name.Equals("btn10")) Then

                        botones.Location = New System.Drawing.Point(110, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila10 = cont

                        AddHandler botones.Click, AddressOf btn10_Click
                    ElseIf (botones.Name.Equals("btn11")) Then

                        botones.Location = New System.Drawing.Point(210, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila11 = cont

                        AddHandler botones.Click, AddressOf btn11_Click
                    ElseIf (botones.Name.Equals("btn12")) Then

                        botones.Location = New System.Drawing.Point(310, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila12 = cont

                        AddHandler botones.Click, AddressOf btn12_Click
                    End If
                    Panel1.Controls.Add(botones)
                    i = i + 1
                End If

                cont = cont + 1
            Next
        End If
    End Sub

    Private Sub btnAlcoholes_Click(sender As Object, e As EventArgs) Handles btnAlcoholes.Click


        Dim i As Integer
        i = 1
        cont = 0
        miDataRow = miDataSet.Tables("Articulos").Rows(0)
        If btnAlcoholes.Enabled Then
            Panel1.Controls.Clear()


            For Each miDataRow In miDataSet.Tables("Articulos").Rows



                tipo = miDataRow("Tipo")

                If (tipo.Equals("Alcohol") And tipo <> Nothing) Then

                    Dim botones As New Button()

                    botones.Name = String.Format("btn{0}", i)
                    botones.Height = 60
                    botones.Width = 100
                    If (botones.Name.Equals("btn1")) Then

                        botones.Location = New System.Drawing.Point(10, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("..\..\Pioltech\background1.png")
                        fila1 = cont

                        AddHandler botones.Click, AddressOf btn1_Click
                    ElseIf (botones.Name.Equals("btn2")) Then

                        botones.Location = New System.Drawing.Point(110, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila2 = cont

                        AddHandler botones.Click, AddressOf btn2_Click
                    ElseIf (botones.Name.Equals("btn3")) Then

                        botones.Location = New System.Drawing.Point(210, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila3 = cont

                        AddHandler botones.Click, AddressOf btn3_Click
                    ElseIf (botones.Name.Equals("btn4")) Then

                        botones.Location = New System.Drawing.Point(310, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila4 = cont

                        AddHandler botones.Click, AddressOf btn4_Click
                    ElseIf (botones.Name.Equals("btn5")) Then

                        botones.Location = New System.Drawing.Point(10, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila5 = cont

                        AddHandler botones.Click, AddressOf btn5_Click
                    ElseIf (botones.Name.Equals("btn6")) Then

                        botones.Location = New System.Drawing.Point(110, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila6 = cont

                        AddHandler botones.Click, AddressOf btn6_Click
                    ElseIf (botones.Name.Equals("btn7")) Then

                        botones.Location = New System.Drawing.Point(210, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila7 = cont

                        AddHandler botones.Click, AddressOf btn7_Click
                    ElseIf (botones.Name.Equals("btn8")) Then

                        botones.Location = New System.Drawing.Point(310, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila8 = cont

                        AddHandler botones.Click, AddressOf btn8_Click
                    ElseIf (botones.Name.Equals("btn9")) Then

                        botones.Location = New System.Drawing.Point(10, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila9 = cont

                        AddHandler botones.Click, AddressOf btn9_Click
                    ElseIf (botones.Name.Equals("btn10")) Then

                        botones.Location = New System.Drawing.Point(110, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila10 = cont

                        AddHandler botones.Click, AddressOf btn10_Click
                    ElseIf (botones.Name.Equals("btn11")) Then

                        botones.Location = New System.Drawing.Point(210, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila11 = cont

                        AddHandler botones.Click, AddressOf btn11_Click
                    ElseIf (botones.Name.Equals("btn12")) Then

                        botones.Location = New System.Drawing.Point(310, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila12 = cont

                        AddHandler botones.Click, AddressOf btn12_Click
                    End If
                    Panel1.Controls.Add(botones)
                    i = i + 1
                End If

                cont = cont + 1
            Next
        End If
    End Sub

    Private Sub btnEnsaladas_Click(sender As Object, e As EventArgs) Handles btnEnsaladas.Click


        Dim i As Integer
        i = 1
        cont = 0
        miDataRow = miDataSet.Tables("Articulos").Rows(0)

        If btnEnsaladas.Enabled Then
            Panel1.Controls.Clear()
            For Each miDataRow In miDataSet.Tables("Articulos").Rows



                tipo = miDataRow("Tipo")

                If (tipo.Equals("Ensalada") And tipo <> Nothing) Then

                    Dim botones As New Button()

                    botones.Name = String.Format("btn{0}", i)
                    botones.Height = 60
                    botones.Width = 100
                    If (botones.Name.Equals("btn1")) Then

                        botones.Location = New System.Drawing.Point(10, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("..\..\Pioltech\background1.png")
                        fila1 = cont

                        AddHandler botones.Click, AddressOf btn1_Click
                    ElseIf (botones.Name.Equals("btn2")) Then

                        botones.Location = New System.Drawing.Point(110, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila2 = cont

                        AddHandler botones.Click, AddressOf btn2_Click
                    ElseIf (botones.Name.Equals("btn3")) Then

                        botones.Location = New System.Drawing.Point(210, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila3 = cont

                        AddHandler botones.Click, AddressOf btn3_Click
                    ElseIf (botones.Name.Equals("btn4")) Then

                        botones.Location = New System.Drawing.Point(310, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila4 = cont

                        AddHandler botones.Click, AddressOf btn4_Click
                    ElseIf (botones.Name.Equals("btn5")) Then

                        botones.Location = New System.Drawing.Point(10, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila5 = cont

                        AddHandler botones.Click, AddressOf btn5_Click
                    ElseIf (botones.Name.Equals("btn6")) Then

                        botones.Location = New System.Drawing.Point(110, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila6 = cont

                        AddHandler botones.Click, AddressOf btn6_Click
                    ElseIf (botones.Name.Equals("btn7")) Then

                        botones.Location = New System.Drawing.Point(210, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila7 = cont

                        AddHandler botones.Click, AddressOf btn7_Click
                    ElseIf (botones.Name.Equals("btn8")) Then

                        botones.Location = New System.Drawing.Point(310, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila8 = cont

                        AddHandler botones.Click, AddressOf btn8_Click
                    ElseIf (botones.Name.Equals("btn9")) Then

                        botones.Location = New System.Drawing.Point(10, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila9 = cont

                        AddHandler botones.Click, AddressOf btn9_Click
                    ElseIf (botones.Name.Equals("btn10")) Then

                        botones.Location = New System.Drawing.Point(110, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila10 = cont

                        AddHandler botones.Click, AddressOf btn10_Click
                    ElseIf (botones.Name.Equals("btn11")) Then

                        botones.Location = New System.Drawing.Point(210, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila11 = cont

                        AddHandler botones.Click, AddressOf btn11_Click
                    ElseIf (botones.Name.Equals("btn12")) Then

                        botones.Location = New System.Drawing.Point(310, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila12 = cont

                        AddHandler botones.Click, AddressOf btn12_Click
                    End If
                    Panel1.Controls.Add(botones)
                    i = i + 1
                End If

                cont = cont + 1
            Next
        End If
    End Sub

    Private Sub btnSandwiches_Click(sender As Object, e As EventArgs) Handles btnSandwiches.Click


        Dim i As Integer
        i = 1
        cont = 0
        miDataRow = miDataSet.Tables("Articulos").Rows(0)
        If btnSandwiches.Enabled Then
            Panel1.Controls.Clear()


            For Each miDataRow In miDataSet.Tables("Articulos").Rows



                tipo = miDataRow("Tipo")

                If (tipo.Equals("Sandwich") And tipo <> Nothing) Then

                    Dim botones As New Button()

                    botones.Name = String.Format("btn{0}", i)
                    botones.Height = 60
                    botones.Width = 100
                    If (botones.Name.Equals("btn1")) Then

                        botones.Location = New System.Drawing.Point(10, 12)
                        botones.Image = Image.FromFile("..\..\Resources\sandwichmixto.png")
                        fila1 = cont

                        AddHandler botones.Click, AddressOf btn1_Click
                    ElseIf (botones.Name.Equals("btn2")) Then

                        botones.Location = New System.Drawing.Point(110, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila2 = cont

                        AddHandler botones.Click, AddressOf btn2_Click
                    ElseIf (botones.Name.Equals("btn3")) Then

                        botones.Location = New System.Drawing.Point(210, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila3 = cont

                        AddHandler botones.Click, AddressOf btn3_Click
                    ElseIf (botones.Name.Equals("btn4")) Then

                        botones.Location = New System.Drawing.Point(310, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila4 = cont

                        AddHandler botones.Click, AddressOf btn4_Click
                    ElseIf (botones.Name.Equals("btn5")) Then

                        botones.Location = New System.Drawing.Point(10, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila5 = cont

                        AddHandler botones.Click, AddressOf btn5_Click
                    ElseIf (botones.Name.Equals("btn6")) Then

                        botones.Location = New System.Drawing.Point(110, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila6 = cont

                        AddHandler botones.Click, AddressOf btn6_Click
                    ElseIf (botones.Name.Equals("btn7")) Then

                        botones.Location = New System.Drawing.Point(210, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila7 = cont

                        AddHandler botones.Click, AddressOf btn7_Click
                    ElseIf (botones.Name.Equals("btn8")) Then

                        botones.Location = New System.Drawing.Point(310, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila8 = cont

                        AddHandler botones.Click, AddressOf btn8_Click
                    ElseIf (botones.Name.Equals("btn9")) Then

                        botones.Location = New System.Drawing.Point(10, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila9 = cont

                        AddHandler botones.Click, AddressOf btn9_Click
                    ElseIf (botones.Name.Equals("btn10")) Then

                        botones.Location = New System.Drawing.Point(110, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila10 = cont

                        AddHandler botones.Click, AddressOf btn10_Click
                    ElseIf (botones.Name.Equals("btn11")) Then

                        botones.Location = New System.Drawing.Point(210, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila11 = cont

                        AddHandler botones.Click, AddressOf btn11_Click
                    ElseIf (botones.Name.Equals("btn12")) Then

                        botones.Location = New System.Drawing.Point(310, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila12 = cont

                        AddHandler botones.Click, AddressOf btn12_Click
                    End If
                    Panel1.Controls.Add(botones)
                    i = i + 1
                End If

                cont = cont + 1
            Next
        End If
    End Sub

    Private Sub btnGastroTurca_Click(sender As Object, e As EventArgs) Handles btnGastroTurca.Click


        Dim i As Integer
        i = 1
        cont = 0
        miDataRow = miDataSet.Tables("Articulos").Rows(0)
        If btnGastroTurca.Enabled Then
            Panel1.Controls.Clear()

            For Each miDataRow In miDataSet.Tables("Articulos").Rows



                tipo = miDataRow("Tipo")

                If (tipo.Equals("Gastro Turca") And tipo <> Nothing) Then

                    Dim botones As New Button()

                    botones.Name = String.Format("btn{0}", i)
                    botones.Height = 60
                    botones.Width = 100
                    If (botones.Name.Equals("btn1")) Then

                        botones.Location = New System.Drawing.Point(10, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("..\..\Pioltech\background1.png")
                        fila1 = cont

                        AddHandler botones.Click, AddressOf btn1_Click
                    ElseIf (botones.Name.Equals("btn2")) Then

                        botones.Location = New System.Drawing.Point(110, 12)
                        botones.Image = Image.FromFile("..\..\Resources\Durum.png")
                        fila2 = cont

                        AddHandler botones.Click, AddressOf btn2_Click
                    ElseIf (botones.Name.Equals("btn3")) Then

                        botones.Location = New System.Drawing.Point(210, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila3 = cont

                        AddHandler botones.Click, AddressOf btn3_Click
                    ElseIf (botones.Name.Equals("btn4")) Then

                        botones.Location = New System.Drawing.Point(310, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila4 = cont

                        AddHandler botones.Click, AddressOf btn4_Click
                    ElseIf (botones.Name.Equals("btn5")) Then

                        botones.Location = New System.Drawing.Point(10, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila5 = cont

                        AddHandler botones.Click, AddressOf btn5_Click
                    ElseIf (botones.Name.Equals("btn6")) Then

                        botones.Location = New System.Drawing.Point(110, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila6 = cont

                        AddHandler botones.Click, AddressOf btn6_Click
                    ElseIf (botones.Name.Equals("btn7")) Then

                        botones.Location = New System.Drawing.Point(210, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila7 = cont

                        AddHandler botones.Click, AddressOf btn7_Click
                    ElseIf (botones.Name.Equals("btn8")) Then

                        botones.Location = New System.Drawing.Point(310, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila8 = cont

                        AddHandler botones.Click, AddressOf btn8_Click
                    ElseIf (botones.Name.Equals("btn9")) Then

                        botones.Location = New System.Drawing.Point(10, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila9 = cont

                        AddHandler botones.Click, AddressOf btn9_Click
                    ElseIf (botones.Name.Equals("btn10")) Then

                        botones.Location = New System.Drawing.Point(110, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila10 = cont

                        AddHandler botones.Click, AddressOf btn10_Click
                    ElseIf (botones.Name.Equals("btn11")) Then

                        botones.Location = New System.Drawing.Point(210, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila11 = cont

                        AddHandler botones.Click, AddressOf btn11_Click
                    ElseIf (botones.Name.Equals("btn12")) Then

                        botones.Location = New System.Drawing.Point(310, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila12 = cont

                        AddHandler botones.Click, AddressOf btn12_Click
                    End If
                    Panel1.Controls.Add(botones)

                    i = i + 1
                End If
                cont = cont + 1
            Next
        End If
    End Sub

    Private Sub btnPostre_Click(sender As Object, e As EventArgs) Handles btnPostre.Click


        Dim i As Integer
        i = 1
        cont = 0
        miDataRow = miDataSet.Tables("Articulos").Rows(0)
        If btnPostre.Enabled Then
            Panel1.Controls.Clear()


            For Each miDataRow In miDataSet.Tables("Articulos").Rows



                tipo = miDataRow("Tipo")

                If (tipo.Equals("Postre") And tipo <> Nothing) Then

                    Dim botones As New Button()

                    botones.Name = String.Format("btn{0}", i)
                    botones.Height = 60
                    botones.Width = 100
                    If (botones.Name.Equals("btn1")) Then

                        botones.Location = New System.Drawing.Point(10, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("..\..\Pioltech\background1.png")
                        fila1 = cont

                        AddHandler botones.Click, AddressOf btn1_Click
                    ElseIf (botones.Name.Equals("btn2")) Then

                        botones.Location = New System.Drawing.Point(110, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila2 = cont

                        AddHandler botones.Click, AddressOf btn2_Click
                    ElseIf (botones.Name.Equals("btn3")) Then

                        botones.Location = New System.Drawing.Point(210, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila3 = cont

                        AddHandler botones.Click, AddressOf btn3_Click
                    ElseIf (botones.Name.Equals("btn4")) Then

                        botones.Location = New System.Drawing.Point(310, 12)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila4 = cont

                        AddHandler botones.Click, AddressOf btn4_Click
                    ElseIf (botones.Name.Equals("btn5")) Then

                        botones.Location = New System.Drawing.Point(10, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila5 = cont

                        AddHandler botones.Click, AddressOf btn5_Click
                    ElseIf (botones.Name.Equals("btn6")) Then

                        botones.Location = New System.Drawing.Point(110, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila6 = cont

                        AddHandler botones.Click, AddressOf btn6_Click
                    ElseIf (botones.Name.Equals("btn7")) Then

                        botones.Location = New System.Drawing.Point(210, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila7 = cont

                        AddHandler botones.Click, AddressOf btn7_Click
                    ElseIf (botones.Name.Equals("btn8")) Then

                        botones.Location = New System.Drawing.Point(310, 72)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila8 = cont

                        AddHandler botones.Click, AddressOf btn8_Click
                    ElseIf (botones.Name.Equals("btn9")) Then

                        botones.Location = New System.Drawing.Point(10, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila9 = cont

                        AddHandler botones.Click, AddressOf btn9_Click
                    ElseIf (botones.Name.Equals("btn10")) Then

                        botones.Location = New System.Drawing.Point(110, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila10 = cont

                        AddHandler botones.Click, AddressOf btn10_Click
                    ElseIf (botones.Name.Equals("btn11")) Then

                        botones.Location = New System.Drawing.Point(210, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila11 = cont

                        AddHandler botones.Click, AddressOf btn11_Click
                    ElseIf (botones.Name.Equals("btn12")) Then

                        botones.Location = New System.Drawing.Point(310, 132)
                        botones.Image = My.Resources.ResourceManager.GetObject("background1.png")
                        fila12 = cont

                        AddHandler botones.Click, AddressOf btn12_Click
                    End If
                    Panel1.Controls.Add(botones)
                    i = i + 1

                End If

                cont = cont + 1
            Next
        End If
    End Sub
    'carga de los articulos de los botones en ejecucion
    Private Sub cargarDatosArticulo(fila As Integer)
        miDataRow = miDataSet.Tables("Articulos").Rows(fila)
        descripcion = miDataRow("Descripcion")
        precioArticulo = miDataRow("PrecioArticulo")
        cantidadActual = miDataRow("CantidadActual")
    End Sub

    'pasa los datos al listbox
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila1)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila2)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub



    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila3)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila4)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub



    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila5)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub



    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila6)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub


    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila7)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub



    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila8)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila9)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub
    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila10)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        Else
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub
    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila11)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub
    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles botones.Click
        cargarDatosArticulo(fila12)
        If (cantidadActual > 0 And ComboBox1.SelectedItem <> Nothing) Then
            lbVenta.Items.Add(descripcion & "      " & precioArticulo)
            rtbMesa.Text = ComboBox1.SelectedItem
            If (rtbPrecioTotal.Text <> Nothing) Then
                rtbPrecioTotal.Text = precioArticulo + rtbPrecioTotal.Text
            Else
                rtbPrecioTotal.Text = precioArticulo
            End If
            If (rtbUnidades.Text <> Nothing) Then
                rtbUnidades.Text = rtbUnidades.Text + 1
            Else
                rtbUnidades.Text = 1
            End If
            miDataRow("CantidadActual") = cantidadActual - 1
        ElseIf (ComboBox1.SelectedItem Like Nothing) Then
            MsgBox("No ha seleccionado ninguna mesa")
        ElseIf (cantidadActual = 0) Then
            MsgBox("No quedan " & descripcion & ", cantidad actual = " & cantidadActual)
        End If
    End Sub

    Private Sub btnAnularUno_Click(sender As Object, e As EventArgs) Handles btnAnularUno.Click
        If (lbVenta.Text <> Nothing) Then
            If MessageBox.Show("¿Desea cancelar el articulo seleccionado?", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Dim obj As String
                obj = lbVenta.Text
                Dim arrObj As String()
                arrObj = obj.Split("      ")
                descripcion = arrObj(0)
                For Each miDataRow In miDataSet.Tables("Articulos").Rows
                    If (descripcion Like miDataRow("Descripcion")) Then
                        miDataRow("CantidadActual") = miDataRow("CantidadActual") + 1
                        rtbPrecioTotal.Text = rtbPrecioTotal.Text - miDataRow("PrecioArticulo")
                    End If
                Next
                lbVenta.Items.Remove(lbVenta.SelectedItem)
                rtbUnidades.Text = rtbUnidades.Text - 1
            End If
        Else
            MsgBox("No ha seleccionado ningun articulo")
        End If
    End Sub

    Private Sub btnEliminarTodo_Click(sender As Object, e As EventArgs) Handles btnEliminarTodo.Click
        Dim a As Integer

        If (lbVenta.Items.GetEnumerator IsNot Nothing) Then
            If MessageBox.Show("¿Desea cancelar la comanda?", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                For a = 0 To lbVenta.Items.Count - 1

                    Dim obj As String
                    obj = lbVenta.Items(a)
                    Dim arrObj As String()
                    arrObj = obj.Split("      ")
                    descripcion = arrObj(0)
                    For Each miDataRow In miDataSet.Tables("Articulos").Rows
                        If (descripcion Like miDataRow("Descripcion")) Then
                            miDataRow("CantidadActual") = miDataRow("CantidadActual") + 1
                        End If
                    Next

                    rtbUnidades.Clear()
                    rtbPrecioTotal.Clear()
                    rtbMesa.Clear()

                Next a
                lbVenta.Items.Clear()
            End If
        Else
            MsgBox("No se ha realizado ninguna comanda")

        End If

    End Sub



    Private Sub btnRealizar_Click(sender As Object, e As EventArgs) Handles btnRealizar.Click
        Dim a As Integer
        Dim idComanda As Integer
        Dim idCajaDiaria As Integer
        Dim fecha As Date
        Dim fecha2 As Date
        Dim mesa As Double
        Dim arrMesa As String()
        idCajaDiaria = 1000
        Dim miConexion As New SqlConnection
        miConexion.ConnectionString = "SERVER = LAPTOP-KS9DH17T\SQLEXPRESS;Integrated Security = SSPI;DATABASE = Pioltech"


        If (lbVenta.Items.GetEnumerator IsNot Nothing) Then
            If MessageBox.Show("¿Desea realizar la comanda?", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then


                For Each miDataRow In miDataSet.Tables("Comandas").Rows
                    idComanda = miDataRow("idComanda")
                Next
                If (idComanda Like Nothing) Then

                    idComanda = 1000
                Else
                    idComanda = idComanda + 1
                End If
                fecha2 = Date.Now.ToString("yyyy/MM/dd")
                For Each miDataRow In miDataSet.Tables("CajaDiaria").Rows
                    idCajaDiaria = miDataRow("idCajaDiaria")
                    fecha = miDataRow("Fecha")
                Next
                If (idCajaDiaria Like Nothing) Then
                    idCajaDiaria = 1000
                Else
                    idCajaDiaria = idCajaDiaria + 1
                End If

                If (fecha <> fecha2) Then

                    miDataSet.Tables("CajaDiaria").Rows.Add(idCajaDiaria, rtbPrecioTotal.Text, DateTime.Now)


                Else
                    For Each miDataRow In miDataSet.Tables("CajaDiaria").Rows
                        If (miDataRow("Fecha") Like fecha2) Then
                            miDataRow("PrecioTotalDia") = miDataRow("precioTotalDia") + rtbPrecioTotal.Text
                            idCajaDiaria = idCajaDiaria - 1
                        End If
                    Next
                End If

                arrMesa = rtbMesa.Text.Split(" ")
                mesa = Convert.ToDouble(arrMesa(1))


                DataAdapterCajaDiaria.Update(miDataSet, "CajaDiaria")

                miDataSet.Tables("Comandas").Rows.Add(idComanda, mesa, rtbPrecioTotal.Text, idDispositivo, idCajaDiaria)

                DataAdapterComandas.Update(miDataSet, "Comandas")
                DataAdapterArticulos.Update(miDataSet, "Articulos")

                MsgBox("Comanda realizada")

                For a = 0 To lbVenta.Items.Count - 1
                    For Each miDataRow In miDataSet.Tables("Articulos").Rows
                        Dim obj As String
                        obj = lbVenta.Items(a)
                        Dim arrObj As String()
                        arrObj = obj.Split("      ")
                        descripcion = arrObj(0)
                        If (miDataRow("Descripcion") Like descripcion) Then
                            miDataSet.Tables("LineaComandas").Rows.Add(idComanda, miDataRow("idArticulo"), 1)

                            DataAdapterLineaComandas.Update(miDataSet, "LineaComandas")

                        End If
                    Next
                Next a
                If MessageBox.Show("¿Desea imprimir el ticket?", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Try
                        Dim cont As Integer = 0
                        Dim UniMesTot(3) As String
                        Dim objWriter As New System.IO.StreamWriter("../../ficheroTickets.txt", True)
                        For a = 0 To lbVenta.Items.Count - 1
                            cont += 1
                        Next a
                        Dim obj(cont) As String
                        For a = 0 To lbVenta.Items.Count - 1
                            obj(a) = lbVenta.Items(a)
                        Next a
                        For i = 0 To obj.Length - 1
                            objWriter.WriteLine(obj(i))
                        Next i

                        objWriter.WriteLine(rtbUnidades.Text & "      " & rtbMesa.Text & "      " & rtbPrecioTotal.Text)
                        UniMesTot(0) = rtbUnidades.Text
                        UniMesTot(1) = rtbMesa.Text
                        UniMesTot(2) = rtbPrecioTotal.Text

                        objWriter.WriteLine("Total        " & rtbPrecioTotal.Text & "$")
                        objWriter.Close()
                        ventanaTicket.Show()
                        ventanaTicket.ticket(obj, UniMesTot)


                    Catch ex As Exception
                        MsgBox("No se pudo imprimir el ticket")
                    End Try
                End If
                lbVenta.Items.Clear()
                rtbUnidades.Clear()
                rtbPrecioTotal.Clear()
                rtbMesa.Clear()
                ComboBox1.SelectedItem = Nothing
                For Each miDataRow In miDataSet.Tables("Articulos").Rows
                    For Each miDataRow2 In miDataSet.Tables("Stock").Rows
                        If miDataRow("idArticulo") Like miDataRow2("idArticulo") Then
                            miDataRow2("CantArticuloStock") = miDataRow("CantidadActual")
                            descripcion = miDataRow("descripcion")
                            If (miDataRow2("CantArticuloStock") < 15) Then
                                If MessageBox.Show("Es necesario realizar un pedido de " & descripcion & " ¿Desea ir a la ventana de pedidos?", "Titulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                    Me.Hide()
                                    ventanaPedidos.Show()
                                End If
                            End If
                        End If
                    Next
                Next
            End If
        End If
    End Sub

    Private Sub btnGestion_Click(sender As Object, e As EventArgs) Handles btnGestion.Click
        Me.Hide()
        ventanaArticulos.Show()
    End Sub
    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        Me.Hide()
        ventanaPedidos.Show()
    End Sub
    Public Function getMiDataSet()
        Return miDataSet
    End Function


    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        DataAdapterStock.Update(miDataSet, "Stock")
    End Sub
End Class
