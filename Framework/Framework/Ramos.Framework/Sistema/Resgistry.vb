Imports System.Net.Mime.MediaTypeNames

Imports Microsoft.Win32


Namespace Sistema

    Public Class Registro

        ''' <summary>
        ''' Se llama a la función de esta manera:---- Framework.Sistema.Registry.iniciarconwindows(Application.ProductName.ToString, Application.ExecutablePath.ToString, True)--'True para activar--  'False para desactivar
        ''' </summary>
        ''' <param name="productname"></param>
        ''' <param name="executablepath"></param>
        ''' <param name="onoff"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function iniciarconwindows(ByVal productname As String, ByVal executablepath As String, ByVal onoff As Boolean) As String
            Const CLAVE As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
            Dim subClave As String = productname
            Dim msg As String = ""
            Try
                Dim Registro As RegistryKey = My.Computer.Registry.CurrentUser.CreateSubKey(CLAVE, RegistryKeyPermissionCheck.ReadWriteSubTree)
                With Registro
                    .OpenSubKey(CLAVE, True)
                    Select Case onoff
                        Case True
                            .SetValue(subClave, executablepath)
                            Return "Ok .. clave añadida"
                        Case False
                            If .GetValue(subClave, "").ToString <> "" Then
                                .DeleteValue(subClave)
                                msg = "Ok .. clave eliminada"
                            Else
                                msg = "No se eliminó , por que el programa" & " no iniciaba con windows"
                            End If
                    End Select
                End With
            Catch ex As System.Exception
                msg = ex.Message.ToString
            End Try
            Return msg
        End Function


        Public Shared Sub CrearKey(ByVal key As String) ' Crea una Key en Current USER
            Try
                Registry.CurrentUser.CreateSubKey(key)
            Catch ErrorCrearKey As Exception
                Throw New Exception("Error al crear la Key", ErrorCrearKey)
            End Try
        End Sub
        Public Shared Sub CrearValue(ByVal directorio As String, ByVal name As String, ByVal valor As Object, ByVal tipo As RegistryValueKind)
            Try
                Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(directorio, True) ' True indica que se abre para escritura
                If key IsNot Nothing Then ' Si key es Nothing significa que no se encontró
                    Select Case tipo
                        Case RegistryValueKind.Binary
                            key.SetValue(name, New Byte() {valor}, tipo)
                        Case RegistryValueKind.MultiString
                            key.SetValue(name, New String() {valor}, tipo)
                        Case Else
                            key.SetValue(name, valor, tipo)
                    End Select
                End If
            Catch ErrorCrearValue As Exception
                Throw New Exception("Error al crear el Value", ErrorCrearValue)
            End Try
        End Sub
        Public Shared Sub EliminarValue(ByVal directorio As String, ByVal value As String)
            Try
                Dim Key As RegistryKey = Registry.CurrentUser.OpenSubKey(directorio, True)
                If Key IsNot Nothing Then
                    If Key.GetValueNames().Contains(value) Then ' Buscamos el nombre del valor en la lista de todos los valores de la clave
                        Key.DeleteValue(value) ' Borramos el valor
                    End If
                End If
            Catch ErrorEliminarValue As Exception
                Throw New Exception("Error al eliminar Valor", ErrorEliminarValue)
            End Try
        End Sub
        Public Shared Sub EliminarKey(ByVal directorio As String)
            Try
                Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(directorio)
                If key IsNot Nothing Then
                    Registry.CurrentUser.DeleteSubKey(directorio) ' Borramos la sub clave
                End If
            Catch ErrorEliminarKey As Exception
                Throw New Exception("Error al eliminar Key", ErrorEliminarKey)
            End Try
        End Sub
        Public Shared Function LeerRegistro(ByVal directorio As String) As String
            Dim values As String()
            Dim listavalues As New List(Of String)
            Dim hola As List(Of String()) = Nothing
            Dim resultado As String
            Try
                Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(directorio, False) ' Abrimos para sólo lectura
                If key IsNot Nothing Then
                    Dim sb As New System.Text.StringBuilder()
                    Dim valores As String()
                    values = key.GetValueNames() ' Obtenemos los nombres de todos los valores en la key
                    For Each value As String In values
                        Dim Tipo As RegistryValueKind = key.GetValueKind(value)
                        Select Case Tipo
                            Case RegistryValueKind.MultiString
                                valores = CType(key.GetValue(value), String())
                                sb.AppendLine(String.Format("{0}   >   {1} ({2})", value, valores(0), key.GetValueKind(value).ToString()))
                            Case RegistryValueKind.Binary
                                Dim bvalores As Byte() = CType(key.GetValue(value), Byte())
                                sb.AppendLine(String.Format("{0}   >   {1} ({2})", value, bvalores(0), key.GetValueKind(value).ToString()))
                            Case Else
                                sb.AppendLine(String.Format("{0}   >   {1} ({2})", value, key.GetValue(value), key.GetValueKind(value).ToString()))
                        End Select
                    Next
                    resultado = sb.ToString() ' Mostramos el resultado en nuestra TextBox Multilínea
                    Return resultado
                Else
                    Return Nothing
                End If
            Catch ErrorLeerRegistro As Exception
                Throw New Exception("Error al leer el registro", ErrorLeerRegistro)

            End Try
        End Function


    End Class
End Namespace