Namespace Sistema

    Public Class Windows

        'ApagarSistema(Cuenta regresiva)
        'ReiniciarSistema(Cuenta regresiva)
        'CerrarSesion(Cuenta regresiva)

        ''' <summary>
        ''' Apaga el sistema en un tiempo determinado
        ''' </summary>
        ''' <param name="Tiempo">Tiempo en segundos</param>
        ''' <remarks></remarks>
        Public Shared Sub ApagarSistema(ByVal Tiempo As Integer)
            System.Diagnostics.Process.Start("shutdown", "-s -t " & Tiempo)
        End Sub
        ''' <summary>
        ''' Reinicia el sistema en un tiempo determinado
        ''' </summary>
        ''' <param name="Tiempo">Tiempo en segundos</param>
        ''' <remarks></remarks>
        Public Shared Sub ReiniciarSistema(ByVal Tiempo As Integer)
            System.Diagnostics.Process.Start("shutdown", "-r -t " & Tiempo)
        End Sub
        ''' <summary>
        ''' Cierra la sesion en un tiempo determinado
        ''' </summary>
        ''' <param name="Tiempo">Tiempo en segundos</param>
        ''' <remarks></remarks>
        Public Shared Sub CerrarSesion(ByVal Tiempo As Integer)
            System.Diagnostics.Process.Start("shutdown", "-l -t " & Tiempo)
        End Sub

        ''' <summary>
        ''' Cancelar el apagado del sistema
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Sub CancelarApagado()
            System.Diagnostics.Process.Start("shutdown", "-a")
        End Sub
    End Class

End Namespace