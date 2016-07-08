<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TurnosdelCliente
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
        Me.TxtDNiCliente = New System.Windows.Forms.TextBox()
        Me.btnbuscarCliente = New System.Windows.Forms.Button()
        Me.RadioDiaDeLafecha = New System.Windows.Forms.RadioButton()
        Me.RadioFechasfuturas = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDNiCliente
        '
        Me.TxtDNiCliente.Location = New System.Drawing.Point(13, 13)
        Me.TxtDNiCliente.Name = "TxtDNiCliente"
        Me.TxtDNiCliente.Size = New System.Drawing.Size(100, 20)
        Me.TxtDNiCliente.TabIndex = 0
        '
        'btnbuscarCliente
        '
        Me.btnbuscarCliente.Location = New System.Drawing.Point(120, 9)
        Me.btnbuscarCliente.Name = "btnbuscarCliente"
        Me.btnbuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscarCliente.TabIndex = 1
        Me.btnbuscarCliente.Text = "Button1"
        Me.btnbuscarCliente.UseVisualStyleBackColor = True
        '
        'RadioDiaDeLafecha
        '
        Me.RadioDiaDeLafecha.AutoSize = True
        Me.RadioDiaDeLafecha.Location = New System.Drawing.Point(13, 40)
        Me.RadioDiaDeLafecha.Name = "RadioDiaDeLafecha"
        Me.RadioDiaDeLafecha.Size = New System.Drawing.Size(169, 17)
        Me.RadioDiaDeLafecha.TabIndex = 2
        Me.RadioDiaDeLafecha.TabStop = True
        Me.RadioDiaDeLafecha.Text = "Buscar Turnos Dia de la fecha"
        Me.RadioDiaDeLafecha.UseVisualStyleBackColor = True
        '
        'RadioFechasfuturas
        '
        Me.RadioFechasfuturas.AutoSize = True
        Me.RadioFechasfuturas.Location = New System.Drawing.Point(13, 64)
        Me.RadioFechasfuturas.Name = "RadioFechasfuturas"
        Me.RadioFechasfuturas.Size = New System.Drawing.Size(170, 17)
        Me.RadioFechasfuturas.TabIndex = 3
        Me.RadioFechasfuturas.TabStop = True
        Me.RadioFechasfuturas.Text = "Buscar Turnos Fechas Futuras"
        Me.RadioFechasfuturas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "BuscarTurnos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(439, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'TurnosdelCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 295)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioFechasfuturas)
        Me.Controls.Add(Me.RadioDiaDeLafecha)
        Me.Controls.Add(Me.btnbuscarCliente)
        Me.Controls.Add(Me.TxtDNiCliente)
        Me.Name = "TurnosdelCliente"
        Me.Text = "TurnosdelCliente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDNiCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscarCliente As System.Windows.Forms.Button
    Friend WithEvents RadioDiaDeLafecha As System.Windows.Forms.RadioButton
    Friend WithEvents RadioFechasfuturas As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
