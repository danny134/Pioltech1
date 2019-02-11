<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.rtbIdArticulo = New System.Windows.Forms.RichTextBox()
        Me.rtbPrecio = New System.Windows.Forms.RichTextBox()
        Me.rtbCantidadActual = New System.Windows.Forms.RichTextBox()
        Me.rtbTipo = New System.Windows.Forms.RichTextBox()
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad Actual"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(476, 46)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ARTICULOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtbIdArticulo
        '
        Me.rtbIdArticulo.Enabled = False
        Me.rtbIdArticulo.Location = New System.Drawing.Point(331, 105)
        Me.rtbIdArticulo.Name = "rtbIdArticulo"
        Me.rtbIdArticulo.Size = New System.Drawing.Size(208, 29)
        Me.rtbIdArticulo.TabIndex = 6
        Me.rtbIdArticulo.Text = ""
        '
        'rtbPrecio
        '
        Me.rtbPrecio.Location = New System.Drawing.Point(331, 199)
        Me.rtbPrecio.Name = "rtbPrecio"
        Me.rtbPrecio.Size = New System.Drawing.Size(208, 29)
        Me.rtbPrecio.TabIndex = 7
        Me.rtbPrecio.Text = ""
        '
        'rtbCantidadActual
        '
        Me.rtbCantidadActual.Location = New System.Drawing.Point(331, 241)
        Me.rtbCantidadActual.Name = "rtbCantidadActual"
        Me.rtbCantidadActual.Size = New System.Drawing.Size(208, 29)
        Me.rtbCantidadActual.TabIndex = 8
        Me.rtbCantidadActual.Text = ""
        '
        'rtbTipo
        '
        Me.rtbTipo.Location = New System.Drawing.Point(331, 284)
        Me.rtbTipo.Name = "rtbTipo"
        Me.rtbTipo.Size = New System.Drawing.Size(208, 29)
        Me.rtbTipo.TabIndex = 9
        Me.rtbTipo.Text = ""
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(331, 151)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(208, 29)
        Me.rtbDescripcion.TabIndex = 10
        Me.rtbDescripcion.Text = ""
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVolver.Location = New System.Drawing.Point(63, 350)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(209, 36)
        Me.btnVolver.TabIndex = 11
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(331, 350)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(208, 36)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(653, 450)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.rtbTipo)
        Me.Controls.Add(Me.rtbCantidadActual)
        Me.Controls.Add(Me.rtbPrecio)
        Me.Controls.Add(Me.rtbIdArticulo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents rtbIdArticulo As Windows.Forms.RichTextBox
    Friend WithEvents rtbPrecio As Windows.Forms.RichTextBox
    Friend WithEvents rtbCantidadActual As Windows.Forms.RichTextBox
    Friend WithEvents rtbTipo As Windows.Forms.RichTextBox
    Friend WithEvents rtbDescripcion As Windows.Forms.RichTextBox
    Friend WithEvents btnVolver As Windows.Forms.Button
    Friend WithEvents btnAgregar As Windows.Forms.Button
End Class
