Public Class threding
    'IMPORTANTE ela carga del form debe ir CheckForIllegalCrossThreadCalls = False
    Private Shared Sub crearSistemadeHilos() 'crea el sistema de hilos y establece el semaforo
        Dim s As New System.Threading.Semaphore(2, 2)
    End Sub

    Private Shared Sub creaHilo()
        Dim h1 As New System.Threading.Thread(AddressOf funcion)
        h1.start()

    End Sub

    Private Shared Sub funcion()
        Throw New NotImplementedException
    End Sub


End Class
