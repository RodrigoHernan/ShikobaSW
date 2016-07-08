Public Class Menu



    Private Sub AgregarTurnoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AgregarTurnoToolStripMenuItem.Click
        Agregar_Turno.ShowDialog()
    End Sub

    Private Sub TurnosClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnosClienteToolStripMenuItem.Click
        TurnosdelCliente.ShowDialog()
    End Sub

    Private Sub IngresoParaProfesionalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoParaProfesionalesToolStripMenuItem.Click
        FormProfesionales.ShowDialog()
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        FormAusenciaProfesional.ShowDialog()
    End Sub
End Class