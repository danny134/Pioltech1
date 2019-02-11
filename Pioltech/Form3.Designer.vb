<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rtbIdPedido = New System.Windows.Forms.RichTextBox()
        Me.rtbCantArticulo = New System.Windows.Forms.RichTextBox()
        Me.rtbPrecioPedido = New System.Windows.Forms.RichTextBox()
        Me.rtbIdArticulo = New System.Windows.Forms.RichTextBox()
        Me.rtbTelefono = New System.Windows.Forms.RichTextBox()
        Me.rtbDireccion = New System.Windows.Forms.RichTextBox()
        Me.rtbNombreProv = New System.Windows.Forms.RichTextBox()
        Me.rtbIdProveedores = New System.Windows.Forms.RichTextBox()
        Me.lbPedidos = New System.Windows.Forms.Label()
        Me.lbProveedores = New System.Windows.Forms.Label()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lbPedido = New System.Windows.Forms.ListBox()
        Me.cbPedido = New System.Windows.Forms.CheckBox()
        Me.cbProveedores = New System.Windows.Forms.CheckBox()
        Me.btnRealizar = New System.Windows.Forms.Button()
        Me.rtbTotalArticulos = New System.Windows.Forms.RichTextBox()
        Me.rtbTotalPrecio = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnDeshacer = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbProv = New System.Windows.Forms.ComboBox()
        Me.btCargarPedidos = New System.Windows.Forms.Button()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(371, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(371, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad Articulo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio Articulo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 33)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ID Articulo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(371, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 33)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Telefono"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtbIdPedido
        '
        Me.rtbIdPedido.Enabled = False
        Me.rtbIdPedido.Location = New System.Drawing.Point(191, 82)
        Me.rtbIdPedido.Name = "rtbIdPedido"
        Me.rtbIdPedido.Size = New System.Drawing.Size(170, 33)
        Me.rtbIdPedido.TabIndex = 8
        Me.rtbIdPedido.Text = ""
        '
        'rtbCantArticulo
        '
        Me.rtbCantArticulo.Location = New System.Drawing.Point(191, 231)
        Me.rtbCantArticulo.Name = "rtbCantArticulo"
        Me.rtbCantArticulo.Size = New System.Drawing.Size(170, 33)
        Me.rtbCantArticulo.TabIndex = 9
        Me.rtbCantArticulo.Text = ""
        '
        'rtbPrecioPedido
        '
        Me.rtbPrecioPedido.Enabled = False
        Me.rtbPrecioPedido.Location = New System.Drawing.Point(191, 177)
        Me.rtbPrecioPedido.Name = "rtbPrecioPedido"
        Me.rtbPrecioPedido.Size = New System.Drawing.Size(170, 33)
        Me.rtbPrecioPedido.TabIndex = 10
        Me.rtbPrecioPedido.Text = ""
        '
        'rtbIdArticulo
        '
        Me.rtbIdArticulo.Location = New System.Drawing.Point(191, 127)
        Me.rtbIdArticulo.Name = "rtbIdArticulo"
        Me.rtbIdArticulo.Size = New System.Drawing.Size(170, 33)
        Me.rtbIdArticulo.TabIndex = 11
        Me.rtbIdArticulo.Text = ""
        '
        'rtbTelefono
        '
        Me.rtbTelefono.Enabled = False
        Me.rtbTelefono.Location = New System.Drawing.Point(546, 236)
        Me.rtbTelefono.Name = "rtbTelefono"
        Me.rtbTelefono.Size = New System.Drawing.Size(170, 33)
        Me.rtbTelefono.TabIndex = 12
        Me.rtbTelefono.Text = ""
        '
        'rtbDireccion
        '
        Me.rtbDireccion.Enabled = False
        Me.rtbDireccion.Location = New System.Drawing.Point(546, 182)
        Me.rtbDireccion.Name = "rtbDireccion"
        Me.rtbDireccion.Size = New System.Drawing.Size(170, 33)
        Me.rtbDireccion.TabIndex = 13
        Me.rtbDireccion.Text = ""
        '
        'rtbNombreProv
        '
        Me.rtbNombreProv.Enabled = False
        Me.rtbNombreProv.Location = New System.Drawing.Point(546, 134)
        Me.rtbNombreProv.Name = "rtbNombreProv"
        Me.rtbNombreProv.Size = New System.Drawing.Size(170, 33)
        Me.rtbNombreProv.TabIndex = 14
        Me.rtbNombreProv.Text = ""
        '
        'rtbIdProveedores
        '
        Me.rtbIdProveedores.Enabled = False
        Me.rtbIdProveedores.Location = New System.Drawing.Point(546, 87)
        Me.rtbIdProveedores.Name = "rtbIdProveedores"
        Me.rtbIdProveedores.Size = New System.Drawing.Size(170, 33)
        Me.rtbIdProveedores.TabIndex = 15
        Me.rtbIdProveedores.Text = ""
        '
        'lbPedidos
        '
        Me.lbPedidos.BackColor = System.Drawing.Color.Transparent
        Me.lbPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPedidos.Location = New System.Drawing.Point(27, 23)
        Me.lbPedidos.Name = "lbPedidos"
        Me.lbPedidos.Size = New System.Drawing.Size(334, 49)
        Me.lbPedidos.TabIndex = 16
        Me.lbPedidos.Text = "PEDIDOS"
        Me.lbPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbProveedores
        '
        Me.lbProveedores.BackColor = System.Drawing.Color.Transparent
        Me.lbProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProveedores.Location = New System.Drawing.Point(409, 23)
        Me.lbProveedores.Name = "lbProveedores"
        Me.lbProveedores.Size = New System.Drawing.Size(346, 49)
        Me.lbProveedores.TabIndex = 17
        Me.lbProveedores.Text = "PROVEEDORES"
        Me.lbProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgArticulos
        '
        Me.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgArticulos.Location = New System.Drawing.Point(409, 364)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.RowTemplate.Height = 24
        Me.dgArticulos.Size = New System.Drawing.Size(346, 178)
        Me.dgArticulos.TabIndex = 19
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVolver.Location = New System.Drawing.Point(27, 608)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(334, 38)
        Me.btnVolver.TabIndex = 20
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(409, 554)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(347, 38)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.Text = "Agregar al pedido"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lbPedido
        '
        Me.lbPedido.FormattingEnabled = True
        Me.lbPedido.ItemHeight = 16
        Me.lbPedido.Location = New System.Drawing.Point(30, 325)
        Me.lbPedido.Name = "lbPedido"
        Me.lbPedido.ScrollAlwaysVisible = True
        Me.lbPedido.Size = New System.Drawing.Size(334, 116)
        Me.lbPedido.TabIndex = 22
        '
        'cbPedido
        '
        Me.cbPedido.AutoSize = True
        Me.cbPedido.BackColor = System.Drawing.Color.Transparent
        Me.cbPedido.Checked = True
        Me.cbPedido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPedido.Location = New System.Drawing.Point(35, 288)
        Me.cbPedido.Name = "cbPedido"
        Me.cbPedido.Size = New System.Drawing.Size(113, 33)
        Me.cbPedido.TabIndex = 23
        Me.cbPedido.Text = "Pedido"
        Me.cbPedido.UseVisualStyleBackColor = False
        '
        'cbProveedores
        '
        Me.cbProveedores.AutoSize = True
        Me.cbProveedores.BackColor = System.Drawing.Color.Transparent
        Me.cbProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.Location = New System.Drawing.Point(417, 288)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(148, 33)
        Me.cbProveedores.TabIndex = 24
        Me.cbProveedores.Text = "Proveedor"
        Me.cbProveedores.UseVisualStyleBackColor = False
        '
        'btnRealizar
        '
        Me.btnRealizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRealizar.Location = New System.Drawing.Point(27, 652)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Size = New System.Drawing.Size(729, 42)
        Me.btnRealizar.TabIndex = 25
        Me.btnRealizar.Text = "Realizar"
        Me.btnRealizar.UseVisualStyleBackColor = False
        '
        'rtbTotalArticulos
        '
        Me.rtbTotalArticulos.Location = New System.Drawing.Point(27, 473)
        Me.rtbTotalArticulos.Name = "rtbTotalArticulos"
        Me.rtbTotalArticulos.Size = New System.Drawing.Size(164, 69)
        Me.rtbTotalArticulos.TabIndex = 26
        Me.rtbTotalArticulos.Text = ""
        '
        'rtbTotalPrecio
        '
        Me.rtbTotalPrecio.Location = New System.Drawing.Point(202, 473)
        Me.rtbTotalPrecio.Name = "rtbTotalPrecio"
        Me.rtbTotalPrecio.Size = New System.Drawing.Size(161, 69)
        Me.rtbTotalPrecio.TabIndex = 27
        Me.rtbTotalPrecio.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 446)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 32)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Total articulos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(197, 446)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 32)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Total precio"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(409, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(346, 32)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Lista articulos"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDeshacer
        '
        Me.btnDeshacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeshacer.Location = New System.Drawing.Point(27, 700)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(729, 42)
        Me.btnDeshacer.TabIndex = 31
        Me.btnDeshacer.Text = "Deshacer"
        Me.btnDeshacer.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(27, 549)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 33)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Proveedor"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbProv
        '
        Me.cbProv.FormattingEnabled = True
        Me.cbProv.Location = New System.Drawing.Point(202, 554)
        Me.cbProv.Name = "cbProv"
        Me.cbProv.Size = New System.Drawing.Size(162, 24)
        Me.cbProv.TabIndex = 33
        '
        'btCargarPedidos
        '
        Me.btCargarPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btCargarPedidos.Location = New System.Drawing.Point(409, 608)
        Me.btCargarPedidos.Name = "btCargarPedidos"
        Me.btCargarPedidos.Size = New System.Drawing.Size(342, 38)
        Me.btCargarPedidos.TabIndex = 34
        Me.btCargarPedidos.Text = "Cargar pedidos"
        Me.btCargarPedidos.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 761)
        Me.Controls.Add(Me.btCargarPedidos)
        Me.Controls.Add(Me.cbProv)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnDeshacer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rtbTotalPrecio)
        Me.Controls.Add(Me.rtbTotalArticulos)
        Me.Controls.Add(Me.btnRealizar)
        Me.Controls.Add(Me.cbProveedores)
        Me.Controls.Add(Me.cbPedido)
        Me.Controls.Add(Me.lbPedido)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgArticulos)
        Me.Controls.Add(Me.lbProveedores)
        Me.Controls.Add(Me.lbPedidos)
        Me.Controls.Add(Me.rtbIdProveedores)
        Me.Controls.Add(Me.rtbNombreProv)
        Me.Controls.Add(Me.rtbDireccion)
        Me.Controls.Add(Me.rtbTelefono)
        Me.Controls.Add(Me.rtbIdArticulo)
        Me.Controls.Add(Me.rtbPrecioPedido)
        Me.Controls.Add(Me.rtbCantArticulo)
        Me.Controls.Add(Me.rtbIdPedido)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents rtbIdPedido As Windows.Forms.RichTextBox
    Friend WithEvents rtbCantArticulo As Windows.Forms.RichTextBox
    Friend WithEvents rtbPrecioPedido As Windows.Forms.RichTextBox
    Friend WithEvents rtbIdArticulo As Windows.Forms.RichTextBox
    Friend WithEvents rtbTelefono As Windows.Forms.RichTextBox
    Friend WithEvents rtbDireccion As Windows.Forms.RichTextBox
    Friend WithEvents rtbNombreProv As Windows.Forms.RichTextBox
    Friend WithEvents rtbIdProveedores As Windows.Forms.RichTextBox
    Friend WithEvents lbPedidos As Windows.Forms.Label
    Friend WithEvents lbProveedores As Windows.Forms.Label
    Friend WithEvents dgArticulos As Windows.Forms.DataGridView
    Friend WithEvents btnVolver As Windows.Forms.Button
    Friend WithEvents btnAgregar As Windows.Forms.Button
    Friend WithEvents lbPedido As Windows.Forms.ListBox
    Friend WithEvents cbPedido As Windows.Forms.CheckBox
    Friend WithEvents cbProveedores As Windows.Forms.CheckBox
    Friend WithEvents btnRealizar As Windows.Forms.Button
    Friend WithEvents rtbTotalArticulos As Windows.Forms.RichTextBox
    Friend WithEvents rtbTotalPrecio As Windows.Forms.RichTextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents btnDeshacer As Windows.Forms.Button
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents cbProv As Windows.Forms.ComboBox
    Friend WithEvents btCargarPedidos As Windows.Forms.Button
End Class
