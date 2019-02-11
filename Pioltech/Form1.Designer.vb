<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnRefrescos = New System.Windows.Forms.Button()
        Me.btnCafe = New System.Windows.Forms.Button()
        Me.btnCombinados = New System.Windows.Forms.Button()
        Me.btnAlcoholes = New System.Windows.Forms.Button()
        Me.btnPostre = New System.Windows.Forms.Button()
        Me.btnEnsaladas = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbVenta = New System.Windows.Forms.ListBox()
        Me.btnAnularUno = New System.Windows.Forms.Button()
        Me.btnEliminarTodo = New System.Windows.Forms.Button()
        Me.btnRealizar = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGestion = New System.Windows.Forms.Button()
        Me.rtbUnidades = New System.Windows.Forms.RichTextBox()
        Me.rtbMesa = New System.Windows.Forms.RichTextBox()
        Me.rtbPrecioTotal = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSandwiches = New System.Windows.Forms.Button()
        Me.btnGastroTurca = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRefrescos
        '
        Me.btnRefrescos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRefrescos.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescos.Location = New System.Drawing.Point(576, 184)
        Me.btnRefrescos.Name = "btnRefrescos"
        Me.btnRefrescos.Size = New System.Drawing.Size(123, 126)
        Me.btnRefrescos.TabIndex = 0
        Me.btnRefrescos.Text = "Refrescos"
        Me.btnRefrescos.UseVisualStyleBackColor = False
        '
        'btnCafe
        '
        Me.btnCafe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCafe.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCafe.Location = New System.Drawing.Point(719, 184)
        Me.btnCafe.Name = "btnCafe"
        Me.btnCafe.Size = New System.Drawing.Size(126, 126)
        Me.btnCafe.TabIndex = 1
        Me.btnCafe.Text = "Cafes"
        Me.btnCafe.UseVisualStyleBackColor = False
        '
        'btnCombinados
        '
        Me.btnCombinados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCombinados.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCombinados.Location = New System.Drawing.Point(864, 184)
        Me.btnCombinados.Name = "btnCombinados"
        Me.btnCombinados.Size = New System.Drawing.Size(123, 125)
        Me.btnCombinados.TabIndex = 2
        Me.btnCombinados.Text = "Combinados"
        Me.btnCombinados.UseVisualStyleBackColor = False
        '
        'btnAlcoholes
        '
        Me.btnAlcoholes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAlcoholes.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlcoholes.Location = New System.Drawing.Point(1007, 49)
        Me.btnAlcoholes.Name = "btnAlcoholes"
        Me.btnAlcoholes.Size = New System.Drawing.Size(121, 125)
        Me.btnAlcoholes.TabIndex = 3
        Me.btnAlcoholes.Text = "Alcohol"
        Me.btnAlcoholes.UseVisualStyleBackColor = False
        '
        'btnPostre
        '
        Me.btnPostre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPostre.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostre.Location = New System.Drawing.Point(1007, 184)
        Me.btnPostre.Name = "btnPostre"
        Me.btnPostre.Size = New System.Drawing.Size(121, 126)
        Me.btnPostre.TabIndex = 4
        Me.btnPostre.Text = "Postres"
        Me.btnPostre.UseVisualStyleBackColor = False
        '
        'btnEnsaladas
        '
        Me.btnEnsaladas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEnsaladas.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnsaladas.Location = New System.Drawing.Point(719, 49)
        Me.btnEnsaladas.Name = "btnEnsaladas"
        Me.btnEnsaladas.Size = New System.Drawing.Size(126, 126)
        Me.btnEnsaladas.TabIndex = 7
        Me.btnEnsaladas.Text = "Ensaladas"
        Me.btnEnsaladas.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mesa 1", "Mesa 2", "Mesa 3", "Mesa 4", "Mesa 5", "Mesa 6", "Mesa 7", "Mesa 8", "Mesa 9", "Mesa 10"})
        Me.ComboBox1.Location = New System.Drawing.Point(878, 586)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 37)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.Text = "(Sin seleccion)"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(576, 586)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 47)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mesa seleccionada"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbVenta
        '
        Me.lbVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVenta.FormattingEnabled = True
        Me.lbVenta.ItemHeight = 31
        Me.lbVenta.Location = New System.Drawing.Point(50, 50)
        Me.lbVenta.Name = "lbVenta"
        Me.lbVenta.ScrollAlwaysVisible = True
        Me.lbVenta.Size = New System.Drawing.Size(502, 128)
        Me.lbVenta.TabIndex = 12
        '
        'btnAnularUno
        '
        Me.btnAnularUno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAnularUno.Location = New System.Drawing.Point(50, 324)
        Me.btnAnularUno.Name = "btnAnularUno"
        Me.btnAnularUno.Size = New System.Drawing.Size(502, 47)
        Me.btnAnularUno.TabIndex = 13
        Me.btnAnularUno.Text = "Descartar Seleccion"
        Me.btnAnularUno.UseVisualStyleBackColor = False
        '
        'btnEliminarTodo
        '
        Me.btnEliminarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminarTodo.Location = New System.Drawing.Point(50, 391)
        Me.btnEliminarTodo.Name = "btnEliminarTodo"
        Me.btnEliminarTodo.Size = New System.Drawing.Size(502, 47)
        Me.btnEliminarTodo.TabIndex = 18
        Me.btnEliminarTodo.Text = "Descartar Todo"
        Me.btnEliminarTodo.UseVisualStyleBackColor = False
        '
        'btnRealizar
        '
        Me.btnRealizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRealizar.Location = New System.Drawing.Point(50, 457)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Size = New System.Drawing.Size(502, 47)
        Me.btnRealizar.TabIndex = 19
        Me.btnRealizar.Text = "Realizar Venta"
        Me.btnRealizar.UseVisualStyleBackColor = False
        '
        'btnPedidos
        '
        Me.btnPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPedidos.Location = New System.Drawing.Point(50, 521)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(502, 47)
        Me.btnPedidos.TabIndex = 20
        Me.btnPedidos.Text = "Pedidos"
        Me.btnPedidos.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(576, 324)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 244)
        Me.Panel1.TabIndex = 17
        '
        'btnGestion
        '
        Me.btnGestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGestion.Location = New System.Drawing.Point(50, 586)
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Size = New System.Drawing.Size(502, 47)
        Me.btnGestion.TabIndex = 27
        Me.btnGestion.Text = "Gestion Articulos"
        Me.btnGestion.UseVisualStyleBackColor = False
        '
        'rtbUnidades
        '
        Me.rtbUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbUnidades.Location = New System.Drawing.Point(50, 226)
        Me.rtbUnidades.Name = "rtbUnidades"
        Me.rtbUnidades.Size = New System.Drawing.Size(166, 83)
        Me.rtbUnidades.TabIndex = 28
        Me.rtbUnidades.Text = ""
        '
        'rtbMesa
        '
        Me.rtbMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbMesa.Location = New System.Drawing.Point(222, 226)
        Me.rtbMesa.Name = "rtbMesa"
        Me.rtbMesa.Size = New System.Drawing.Size(158, 83)
        Me.rtbMesa.TabIndex = 29
        Me.rtbMesa.Text = ""
        '
        'rtbPrecioTotal
        '
        Me.rtbPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbPrecioTotal.Location = New System.Drawing.Point(386, 226)
        Me.rtbPrecioTotal.Name = "rtbPrecioTotal"
        Me.rtbPrecioTotal.Size = New System.Drawing.Size(166, 84)
        Me.rtbPrecioTotal.TabIndex = 30
        Me.rtbPrecioTotal.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 30)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "UDS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(386, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 30)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "PRECIO TOTAL "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 30)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "MESA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSandwiches
        '
        Me.btnSandwiches.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSandwiches.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSandwiches.Location = New System.Drawing.Point(576, 50)
        Me.btnSandwiches.Name = "btnSandwiches"
        Me.btnSandwiches.Size = New System.Drawing.Size(123, 125)
        Me.btnSandwiches.TabIndex = 6
        Me.btnSandwiches.Text = "Sandwich"
        Me.btnSandwiches.UseVisualStyleBackColor = False
        '
        'btnGastroTurca
        '
        Me.btnGastroTurca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGastroTurca.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGastroTurca.ForeColor = System.Drawing.Color.Black
        Me.btnGastroTurca.Location = New System.Drawing.Point(864, 49)
        Me.btnGastroTurca.Name = "btnGastroTurca"
        Me.btnGastroTurca.Size = New System.Drawing.Size(123, 125)
        Me.btnGastroTurca.TabIndex = 5
        Me.btnGastroTurca.Text = "Kebabs"
        Me.btnGastroTurca.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1182, 662)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rtbPrecioTotal)
        Me.Controls.Add(Me.rtbMesa)
        Me.Controls.Add(Me.rtbUnidades)
        Me.Controls.Add(Me.btnGestion)
        Me.Controls.Add(Me.btnPedidos)
        Me.Controls.Add(Me.btnRealizar)
        Me.Controls.Add(Me.btnEliminarTodo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAnularUno)
        Me.Controls.Add(Me.lbVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnEnsaladas)
        Me.Controls.Add(Me.btnSandwiches)
        Me.Controls.Add(Me.btnGastroTurca)
        Me.Controls.Add(Me.btnPostre)
        Me.Controls.Add(Me.btnAlcoholes)
        Me.Controls.Add(Me.btnCombinados)
        Me.Controls.Add(Me.btnCafe)
        Me.Controls.Add(Me.btnRefrescos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRefrescos As Windows.Forms.Button
    Friend WithEvents btnCafe As Windows.Forms.Button
    Friend WithEvents btnCombinados As Windows.Forms.Button
    Friend WithEvents btnAlcoholes As Windows.Forms.Button
    Friend WithEvents btnPostre As Windows.Forms.Button
    Friend WithEvents btnGastroTurca As Windows.Forms.Button
    Friend WithEvents btnSandwiches As Windows.Forms.Button
    Friend WithEvents btnEnsaladas As Windows.Forms.Button
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lbVenta As Windows.Forms.ListBox
    Friend WithEvents btnAnularUno As Windows.Forms.Button
    Friend WithEvents btnEliminarTodo As Windows.Forms.Button
    Friend WithEvents btnRealizar As Windows.Forms.Button
    Friend WithEvents btnPedidos As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btnGestion As Windows.Forms.Button
    Friend WithEvents rtbUnidades As Windows.Forms.RichTextBox
    Friend WithEvents rtbMesa As Windows.Forms.RichTextBox
    Friend WithEvents rtbPrecioTotal As Windows.Forms.RichTextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
