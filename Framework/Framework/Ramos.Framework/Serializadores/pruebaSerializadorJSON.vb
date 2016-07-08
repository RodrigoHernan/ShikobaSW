Imports System.Web
Public Class pruebaSerializadorJSON
    Implements IHttpHandler

    ''' <summary>
    '''  Debe configurar este controlador en el archivo web.config de su 
    '''  web y registrarlo en IIS para poder usarlo. Para obtener más información
    '''  vea el siguiente vínculo: http://go.microsoft.com/?linkid=8101007
    ''' </summary>
#Region "Miembros de IHttpHandler"

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            ' Devuelve false si el controlador administrado no se puede reutilizar para otra solicitud.
            ' Suele ser false si hay información de estado reservada por solicitud.
            Return True
        End Get
    End Property

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        ' Escriba aquí la implementación del controlador.

    End Sub

#End Region

End Class
