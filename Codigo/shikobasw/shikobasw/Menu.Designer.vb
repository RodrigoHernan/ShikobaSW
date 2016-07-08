<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarDeBajaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnosClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProfesionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProfesionalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProfesionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarDeBajaProfesionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoParaProfesionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArgarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DarDeBajaTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(282, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(262, 67)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarTurnoToolStripMenuItem, Me.AgregarClienteToolStripMenuItem, Me.AgregarProfesionalToolStripMenuItem, Me.AusenciaToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(100, 63)
        Me.ToolStripMenuItem1.Text = "menu"
        '
        'AgregarTurnoToolStripMenuItem
        '
        Me.AgregarTurnoToolStripMenuItem.Name = "AgregarTurnoToolStripMenuItem"
        Me.AgregarTurnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AgregarTurnoToolStripMenuItem.Text = "Agregar Turno"
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem1, Me.ModificarClienteToolStripMenuItem, Me.DarDeBajaClienteToolStripMenuItem, Me.TurnosClienteToolStripMenuItem})
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AgregarClienteToolStripMenuItem.Text = " Cliente"
        '
        'AgregarClienteToolStripMenuItem1
        '
        Me.AgregarClienteToolStripMenuItem1.Name = "AgregarClienteToolStripMenuItem1"
        Me.AgregarClienteToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.AgregarClienteToolStripMenuItem1.Text = "Agregar Cliente"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar Cliente "
        '
        'DarDeBajaClienteToolStripMenuItem
        '
        Me.DarDeBajaClienteToolStripMenuItem.Name = "DarDeBajaClienteToolStripMenuItem"
        Me.DarDeBajaClienteToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DarDeBajaClienteToolStripMenuItem.Text = "dar de baja Cliente"
        '
        'TurnosClienteToolStripMenuItem
        '
        Me.TurnosClienteToolStripMenuItem.Name = "TurnosClienteToolStripMenuItem"
        Me.TurnosClienteToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.TurnosClienteToolStripMenuItem.Text = "Turnos Cliente"
        '
        'AgregarProfesionalToolStripMenuItem
        '
        Me.AgregarProfesionalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProfesionalToolStripMenuItem1, Me.ModificarProfesionalToolStripMenuItem, Me.DarDeBajaProfesionalToolStripMenuItem, Me.ProfesionToolStripMenuItem, Me.IngresoParaProfesionalesToolStripMenuItem})
        Me.AgregarProfesionalToolStripMenuItem.Name = "AgregarProfesionalToolStripMenuItem"
        Me.AgregarProfesionalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AgregarProfesionalToolStripMenuItem.Text = "Profesional"
        '
        'AgregarProfesionalToolStripMenuItem1
        '
        Me.AgregarProfesionalToolStripMenuItem1.Name = "AgregarProfesionalToolStripMenuItem1"
        Me.AgregarProfesionalToolStripMenuItem1.Size = New System.Drawing.Size(212, 22)
        Me.AgregarProfesionalToolStripMenuItem1.Text = "Agregar Profesional "
        '
        'ModificarProfesionalToolStripMenuItem
        '
        Me.ModificarProfesionalToolStripMenuItem.Name = "ModificarProfesionalToolStripMenuItem"
        Me.ModificarProfesionalToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ModificarProfesionalToolStripMenuItem.Text = "Modificar Profesional"
        '
        'DarDeBajaProfesionalToolStripMenuItem
        '
        Me.DarDeBajaProfesionalToolStripMenuItem.Name = "DarDeBajaProfesionalToolStripMenuItem"
        Me.DarDeBajaProfesionalToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DarDeBajaProfesionalToolStripMenuItem.Text = "Dar de baja Profesional"
        '
        'ProfesionToolStripMenuItem
        '
        Me.ProfesionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.ProfesionToolStripMenuItem.Name = "ProfesionToolStripMenuItem"
        Me.ProfesionToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ProfesionToolStripMenuItem.Text = "Profesion"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'IngresoParaProfesionalesToolStripMenuItem
        '
        Me.IngresoParaProfesionalesToolStripMenuItem.Name = "IngresoParaProfesionalesToolStripMenuItem"
        Me.IngresoParaProfesionalesToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.IngresoParaProfesionalesToolStripMenuItem.Text = "Ingreso para Profesionales"
        '
        'AusenciaToolStripMenuItem
        '
        Me.AusenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfesionalToolStripMenuItem, Me.ClienteToolStripMenuItem})
        Me.AusenciaToolStripMenuItem.Name = "AusenciaToolStripMenuItem"
        Me.AusenciaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AusenciaToolStripMenuItem.Text = "Ausencia"
        '
        'ProfesionalToolStripMenuItem
        '
        Me.ProfesionalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CToolStripMenuItem, Me.ArgarToolStripMenuItem})
        Me.ProfesionalToolStripMenuItem.Name = "ProfesionalToolStripMenuItem"
        Me.ProfesionalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProfesionalToolStripMenuItem.Text = "Profesional"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.CToolStripMenuItem.Text = "Cargar Solicitud de Ausencia "
        '
        'ArgarToolStripMenuItem
        '
        Me.ArgarToolStripMenuItem.Name = "ArgarToolStripMenuItem"
        Me.ArgarToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ArgarToolStripMenuItem.Text = "asignar profesional de reemplazo"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarDeBajaTurnoToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ShikobaSW.My.Resources.Resources.shikoba_logo
        Me.PictureBox1.Location = New System.Drawing.Point(467, 220)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'DarDeBajaTurnoToolStripMenuItem
        '
        Me.DarDeBajaTurnoToolStripMenuItem.Name = "DarDeBajaTurnoToolStripMenuItem"
        Me.DarDeBajaTurnoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DarDeBajaTurnoToolStripMenuItem.Text = "Dar de baja Turno"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 305)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarTurnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DarDeBajaClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProfesionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProfesionalToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarProfesionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DarDeBajaProfesionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TurnosClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoParaProfesionalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArgarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DarDeBajaTurnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
