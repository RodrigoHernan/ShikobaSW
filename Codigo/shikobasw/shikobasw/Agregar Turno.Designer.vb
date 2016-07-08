<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Agregar_Turno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Turno))
        Me.TextDNI = New System.Windows.Forms.TextBox()
        Me.BtnBuscarDNI = New System.Windows.Forms.Button()
        Me.lblNombreyApellido = New System.Windows.Forms.Label()
        Me.LblNumero = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.ComboServicios = New System.Windows.Forms.ComboBox()
        Me.ComboTurnosDisponibles = New System.Windows.Forms.ComboBox()
        Me.Calendario1 = New System.Windows.Forms.DateTimePicker()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.LblTurnosDisponibles = New System.Windows.Forms.Label()
        Me.BtnRegistrarTurno = New System.Windows.Forms.Button()
        Me.LblOsoPrePa = New System.Windows.Forms.Label()
        Me.LblEnFalta = New System.Windows.Forms.Label()
        Me.BuscarTurnos = New System.Windows.Forms.Button()
        Me.txtEsSobreturno = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TextDNI
        '
        Me.TextDNI.Location = New System.Drawing.Point(30, 35)
        Me.TextDNI.Name = "TextDNI"
        Me.TextDNI.Size = New System.Drawing.Size(100, 20)
        Me.TextDNI.TabIndex = 0
        Me.TextDNI.Text = "123"
        '
        'BtnBuscarDNI
        '
        Me.BtnBuscarDNI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnBuscarDNI.BackgroundImage = CType(resources.GetObject("BtnBuscarDNI.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBuscarDNI.Location = New System.Drawing.Point(136, 35)
        Me.BtnBuscarDNI.Name = "BtnBuscarDNI"
        Me.BtnBuscarDNI.Size = New System.Drawing.Size(34, 31)
        Me.BtnBuscarDNI.TabIndex = 1
        Me.BtnBuscarDNI.UseVisualStyleBackColor = True
        '
        'lblNombreyApellido
        '
        Me.lblNombreyApellido.AutoSize = True
        Me.lblNombreyApellido.Location = New System.Drawing.Point(30, 71)
        Me.lblNombreyApellido.Name = "lblNombreyApellido"
        Me.lblNombreyApellido.Size = New System.Drawing.Size(92, 13)
        Me.lblNombreyApellido.TabIndex = 2
        Me.lblNombreyApellido.Text = "Nombre y Apellido"
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Location = New System.Drawing.Point(30, 88)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(103, 13)
        Me.LblNumero.TabIndex = 3
        Me.LblNumero.Text = "Numero de telefono:"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(30, 105)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LblDomicilio.TabIndex = 4
        Me.LblDomicilio.Text = "Domicilio"
        '
        'ComboServicios
        '
        Me.ComboServicios.FormattingEnabled = True
        Me.ComboServicios.Location = New System.Drawing.Point(33, 144)
        Me.ComboServicios.Name = "ComboServicios"
        Me.ComboServicios.Size = New System.Drawing.Size(121, 21)
        Me.ComboServicios.TabIndex = 5
        '
        'ComboTurnosDisponibles
        '
        Me.ComboTurnosDisponibles.FormattingEnabled = True
        Me.ComboTurnosDisponibles.Location = New System.Drawing.Point(30, 242)
        Me.ComboTurnosDisponibles.Name = "ComboTurnosDisponibles"
        Me.ComboTurnosDisponibles.Size = New System.Drawing.Size(121, 21)
        Me.ComboTurnosDisponibles.TabIndex = 6
        Me.ComboTurnosDisponibles.Visible = False
        '
        'Calendario1
        '
        Me.Calendario1.Location = New System.Drawing.Point(30, 186)
        Me.Calendario1.Name = "Calendario1"
        Me.Calendario1.Size = New System.Drawing.Size(200, 20)
        Me.Calendario1.TabIndex = 7
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Location = New System.Drawing.Point(30, 128)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(45, 13)
        Me.lblServicio.TabIndex = 8
        Me.lblServicio.Text = "Servicio"
        '
        'LblTurnosDisponibles
        '
        Me.LblTurnosDisponibles.AutoSize = True
        Me.LblTurnosDisponibles.Location = New System.Drawing.Point(30, 226)
        Me.LblTurnosDisponibles.Name = "LblTurnosDisponibles"
        Me.LblTurnosDisponibles.Size = New System.Drawing.Size(97, 13)
        Me.LblTurnosDisponibles.TabIndex = 9
        Me.LblTurnosDisponibles.Text = "Turnos Disponibles"
        '
        'BtnRegistrarTurno
        '
        Me.BtnRegistrarTurno.Location = New System.Drawing.Point(24, 278)
        Me.BtnRegistrarTurno.Name = "BtnRegistrarTurno"
        Me.BtnRegistrarTurno.Size = New System.Drawing.Size(168, 23)
        Me.BtnRegistrarTurno.TabIndex = 10
        Me.BtnRegistrarTurno.Text = "Registrar Turno"
        Me.BtnRegistrarTurno.UseVisualStyleBackColor = True
        '
        'LblOsoPrePa
        '
        Me.LblOsoPrePa.AutoSize = True
        Me.LblOsoPrePa.Location = New System.Drawing.Point(191, 71)
        Me.LblOsoPrePa.Name = "LblOsoPrePa"
        Me.LblOsoPrePa.Size = New System.Drawing.Size(57, 13)
        Me.LblOsoPrePa.TabIndex = 11
        Me.LblOsoPrePa.Text = "OSoPrePa"
        '
        'LblEnFalta
        '
        Me.LblEnFalta.AutoSize = True
        Me.LblEnFalta.Location = New System.Drawing.Point(191, 105)
        Me.LblEnFalta.Name = "LblEnFalta"
        Me.LblEnFalta.Size = New System.Drawing.Size(43, 13)
        Me.LblEnFalta.TabIndex = 12
        Me.LblEnFalta.Text = "EnFalta"
        Me.LblEnFalta.Visible = False
        '
        'BuscarTurnos
        '
        Me.BuscarTurnos.Location = New System.Drawing.Point(237, 182)
        Me.BuscarTurnos.Name = "BuscarTurnos"
        Me.BuscarTurnos.Size = New System.Drawing.Size(75, 23)
        Me.BuscarTurnos.TabIndex = 13
        Me.BuscarTurnos.Text = "Buscar"
        Me.BuscarTurnos.UseVisualStyleBackColor = True
        '
        'txtEsSobreturno
        '
        Me.txtEsSobreturno.AutoSize = True
        Me.txtEsSobreturno.Location = New System.Drawing.Point(194, 146)
        Me.txtEsSobreturno.Name = "txtEsSobreturno"
        Me.txtEsSobreturno.Size = New System.Drawing.Size(91, 17)
        Me.txtEsSobreturno.TabIndex = 14
        Me.txtEsSobreturno.Text = "Es sobreturno"
        Me.txtEsSobreturno.UseVisualStyleBackColor = True
        '
        'Agregar_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 356)
        Me.Controls.Add(Me.txtEsSobreturno)
        Me.Controls.Add(Me.BuscarTurnos)
        Me.Controls.Add(Me.LblEnFalta)
        Me.Controls.Add(Me.LblOsoPrePa)
        Me.Controls.Add(Me.BtnRegistrarTurno)
        Me.Controls.Add(Me.LblTurnosDisponibles)
        Me.Controls.Add(Me.lblServicio)
        Me.Controls.Add(Me.Calendario1)
        Me.Controls.Add(Me.ComboTurnosDisponibles)
        Me.Controls.Add(Me.ComboServicios)
        Me.Controls.Add(Me.LblDomicilio)
        Me.Controls.Add(Me.LblNumero)
        Me.Controls.Add(Me.lblNombreyApellido)
        Me.Controls.Add(Me.BtnBuscarDNI)
        Me.Controls.Add(Me.TextDNI)
        Me.Name = "Agregar_Turno"
        Me.Text = "Agregar_Turno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextDNI As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscarDNI As System.Windows.Forms.Button
    Friend WithEvents lblNombreyApellido As System.Windows.Forms.Label
    Friend WithEvents LblNumero As System.Windows.Forms.Label
    Friend WithEvents LblDomicilio As System.Windows.Forms.Label
    Friend WithEvents ComboServicios As System.Windows.Forms.ComboBox
    Friend WithEvents ComboTurnosDisponibles As System.Windows.Forms.ComboBox
    Friend WithEvents Calendario1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblServicio As System.Windows.Forms.Label
    Friend WithEvents LblTurnosDisponibles As System.Windows.Forms.Label
    Friend WithEvents BtnRegistrarTurno As System.Windows.Forms.Button
    Friend WithEvents LblOsoPrePa As System.Windows.Forms.Label
    Friend WithEvents LblEnFalta As System.Windows.Forms.Label
    Friend WithEvents BuscarTurnos As System.Windows.Forms.Button
    Friend WithEvents txtEsSobreturno As System.Windows.Forms.CheckBox
End Class
