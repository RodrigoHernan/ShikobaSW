Imports System
Imports System.Diagnostics

Namespace Sistema

    Public Class ServiciodeTrazas

        Public Enum TipoEvento
            _Warning
            _Error
            _Information
        End Enum

        Private Property Tipo As EventLogEntryType
        Property Mensaje As String



        Public Sub New(ByVal sSource As String, ByVal sLog As String, ByVal sEvent As String, ByVal sMachine As String, ByVal sType As TipoEvento)

            '///Verificamos el tipo evento que vamos a Registrar
            Select Case sType
                Case TipoEvento._Error
                    Tipo = EventLogEntryType.Error
                Case TipoEvento._Warning
                    Tipo = EventLogEntryType.Warning
                Case TipoEvento._Information
                    Tipo = EventLogEntryType.Information
            End Select




            '///En caso de existir el Source se crea dentro del registro de Windows: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\eventlog
            Try
                If Not EventLog.SourceExists(sSource, sMachine) Then
                    Dim sourceData As New EventSourceCreationData(sSource, sLog)
                    sourceData.MachineName = sMachine
                    EventLog.CreateEventSource(sourceData)

                End If
            Catch ex As Security.SecurityException
                Mensaje = "Debe ser admin."
            End Try




            '///Creo un evento y le envio los parametros ya cargados
            Try
                Dim ELog As New EventLog(sLog, sMachine, sSource)
                ELog.WriteEntry(sEvent, Tipo)
                Mensaje = "Registro creado OK"


            Catch Ex As Security.SecurityException
                Mensaje = "Debe ser admin."


            Catch ex As System.ArgumentException
                Dim ELog As New EventLog("Application", ".", Me.ToString)
                ELog.WriteEntry("El Origen de Datos ya se encuentra creado para otro Tipo de Log" & vbCrLf & vbCrLf & ex.ToString, EventLogEntryType.Error)
                Mensaje = "Vea el visor de eventos, Seccion Application"


            End Try

        End Sub
        ''' <summary>
        ''' funcion Shared para Registrar un evento en el visor de eventos
        ''' </summary>
        ''' <param name="Origen">Nombre del documento que guarda el error</param>
        ''' <param name="Tipo">Carpeta personalizada dentro del event view</param>
        ''' <param name="Texto">Descripcion del error</param>
        ''' <param name="TipoDeError">Error, warning o Information</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function RegistrarEvento(ByVal Origen As String, ByVal Tipo As String, ByVal Texto As String, ByVal TipoDeError As TipoEvento) As String

            Dim Evento As ServiciodeTrazas
            Evento = New ServiciodeTrazas(Origen, Tipo, Texto, ".", TipoDeError)
            Return Evento.Mensaje
        End Function

    End Class

End Namespace

