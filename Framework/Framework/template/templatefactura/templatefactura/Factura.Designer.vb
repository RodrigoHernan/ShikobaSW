<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Factura
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
        Me.txtfechaFactura = New System.Windows.Forms.TextBox()
        Me.btnGuardarfactura = New System.Windows.Forms.Button()
        Me.GrillaDetallesFactura = New System.Windows.Forms.DataGridView()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboArticulo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        CType(Me.GrillaDetallesFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtfechaFactura
        '
        Me.txtfechaFactura.Location = New System.Drawing.Point(323, 48)
        Me.txtfechaFactura.Name = "txtfechaFactura"
        Me.txtfechaFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtfechaFactura.TabIndex = 19
        Me.txtfechaFactura.Text = "03/10/2015"
        '
        'btnGuardarfactura
        '
        Me.btnGuardarfactura.Location = New System.Drawing.Point(282, 378)
        Me.btnGuardarfactura.Name = "btnGuardarfactura"
        Me.btnGuardarfactura.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarfactura.TabIndex = 18
        Me.btnGuardarfactura.Text = "Guardar factura"
        Me.btnGuardarfactura.UseVisualStyleBackColor = True
        '
        'GrillaDetallesFactura
        '
        Me.GrillaDetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaDetallesFactura.Location = New System.Drawing.Point(39, 175)
        Me.GrillaDetallesFactura.Name = "GrillaDetallesFactura"
        Me.GrillaDetallesFactura.Size = New System.Drawing.Size(384, 150)
        Me.GrillaDetallesFactura.TabIndex = 17
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(313, 135)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(110, 23)
        Me.btnAgregarDetalle.TabIndex = 16
        Me.btnAgregarDetalle.Text = "Agregar Detalle"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(163, 139)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 15
        Me.txtCantidad.Text = "cantidad"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(39, 139)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 14
        Me.txtPrecio.Text = "precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Articulo"
        '
        'ComboArticulo
        '
        Me.ComboArticulo.FormattingEnabled = True
        Me.ComboArticulo.Location = New System.Drawing.Point(39, 112)
        Me.ComboArticulo.Name = "ComboArticulo"
        Me.ComboArticulo.Size = New System.Drawing.Size(121, 21)
        Me.ComboArticulo.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cliente"
        '
        'ComboCliente
        '
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Location = New System.Drawing.Point(39, 47)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(121, 21)
        Me.ComboCliente.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 447)
        Me.Controls.Add(Me.txtfechaFactura)
        Me.Controls.Add(Me.btnGuardarfactura)
        Me.Controls.Add(Me.GrillaDetallesFactura)
        Me.Controls.Add(Me.btnAgregarDetalle)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboArticulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboCliente)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GrillaDetallesFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtfechaFactura As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarfactura As System.Windows.Forms.Button
    Friend WithEvents GrillaDetallesFactura As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregarDetalle As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboArticulo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboCliente As System.Windows.Forms.ComboBox

End Class
