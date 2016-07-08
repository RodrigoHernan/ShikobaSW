<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.TextValidaEmail1 = New Ramos.Framework.TextValidaEmail()
        Me.TextValidaCaracterNulo1 = New Ramos.Framework.TextValidaCaracterNulo()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextValidaEmail1
        '
        Me.TextValidaEmail1.Location = New System.Drawing.Point(13, 26)
        Me.TextValidaEmail1.Name = "TextValidaEmail1"
        Me.TextValidaEmail1.Size = New System.Drawing.Size(289, 20)
        Me.TextValidaEmail1.TabIndex = 0
        Me.TextValidaEmail1.Texto = ""
        '
        'TextValidaCaracterNulo1
        '
        Me.TextValidaCaracterNulo1.Location = New System.Drawing.Point(13, 66)
        Me.TextValidaCaracterNulo1.Name = "TextValidaCaracterNulo1"
        Me.TextValidaCaracterNulo1.Size = New System.Drawing.Size(289, 20)
        Me.TextValidaCaracterNulo1.TabIndex = 1
        Me.TextValidaCaracterNulo1.Texto = ""
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(227, 92)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 2
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 139)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.TextValidaCaracterNulo1)
        Me.Controls.Add(Me.TextValidaEmail1)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextValidaEmail1 As Ramos.Framework.TextValidaEmail
    Friend WithEvents TextValidaCaracterNulo1 As Ramos.Framework.TextValidaCaracterNulo
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
End Class
