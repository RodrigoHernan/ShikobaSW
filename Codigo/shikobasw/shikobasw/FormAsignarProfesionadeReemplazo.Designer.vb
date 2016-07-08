<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAsignarProfesionadeReemplazo
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
        Me.ComboSolicitudesReemplazoNoConcretadas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboTurnosAfectados = New System.Windows.Forms.ComboBox()
        Me.ComboProfesionalesdeReemplazo = New System.Windows.Forms.ComboBox()
        Me.lblProfesionalesDeReemplazo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboSolicitudesReemplazoNoConcretadas
        '
        Me.ComboSolicitudesReemplazoNoConcretadas.FormattingEnabled = True
        Me.ComboSolicitudesReemplazoNoConcretadas.Location = New System.Drawing.Point(12, 42)
        Me.ComboSolicitudesReemplazoNoConcretadas.Name = "ComboSolicitudesReemplazoNoConcretadas"
        Me.ComboSolicitudesReemplazoNoConcretadas.Size = New System.Drawing.Size(191, 21)
        Me.ComboSolicitudesReemplazoNoConcretadas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Solicitudes de reemplazo no asignadas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Servicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Turnos Afectados"
        '
        'ComboTurnosAfectados
        '
        Me.ComboTurnosAfectados.FormattingEnabled = True
        Me.ComboTurnosAfectados.Location = New System.Drawing.Point(12, 124)
        Me.ComboTurnosAfectados.Name = "ComboTurnosAfectados"
        Me.ComboTurnosAfectados.Size = New System.Drawing.Size(121, 21)
        Me.ComboTurnosAfectados.TabIndex = 5
        '
        'ComboProfesionalesdeReemplazo
        '
        Me.ComboProfesionalesdeReemplazo.FormattingEnabled = True
        Me.ComboProfesionalesdeReemplazo.Location = New System.Drawing.Point(211, 122)
        Me.ComboProfesionalesdeReemplazo.Name = "ComboProfesionalesdeReemplazo"
        Me.ComboProfesionalesdeReemplazo.Size = New System.Drawing.Size(121, 21)
        Me.ComboProfesionalesdeReemplazo.TabIndex = 6
        '
        'lblProfesionalesDeReemplazo
        '
        Me.lblProfesionalesDeReemplazo.AutoSize = True
        Me.lblProfesionalesDeReemplazo.Location = New System.Drawing.Point(208, 106)
        Me.lblProfesionalesDeReemplazo.Name = "lblProfesionalesDeReemplazo"
        Me.lblProfesionalesDeReemplazo.Size = New System.Drawing.Size(141, 13)
        Me.lblProfesionalesDeReemplazo.TabIndex = 7
        Me.lblProfesionalesDeReemplazo.Text = "Profesionales de Reemplazo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Telefono cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "nombre cliente"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Reasignar Profesional"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Reconfirmar Turno"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 278)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Cancelar Turno"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormAsignarProfesionadeReemplazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 325)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblProfesionalesDeReemplazo)
        Me.Controls.Add(Me.ComboProfesionalesdeReemplazo)
        Me.Controls.Add(Me.ComboTurnosAfectados)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboSolicitudesReemplazoNoConcretadas)
        Me.Name = "FormAsignarProfesionadeReemplazo"
        Me.Text = "FormAsignarProfesionadeReemplazo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboSolicitudesReemplazoNoConcretadas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboTurnosAfectados As System.Windows.Forms.ComboBox
    Friend WithEvents ComboProfesionalesdeReemplazo As System.Windows.Forms.ComboBox
    Friend WithEvents lblProfesionalesDeReemplazo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
