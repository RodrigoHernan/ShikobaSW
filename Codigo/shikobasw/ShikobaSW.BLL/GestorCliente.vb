Imports ShikobaSW.Biz.BIZ.Entities
Imports ShikobaSW


Namespace BLL




    Public Class GestionCliente
        ''' <summary>
        ''' guarda el cliente en la BD 
        ''' </summary>
        ''' <param name="unCliente"></param>
        ''' <returns>en caso de existir un error o que no se pueda guardar, devuelve False</returns>
        ''' <remarks></remarks>
        Public Function GuardarCliente(ByVal unCliente As Cliente) As Boolean
            Try
                If ExisteCliente(unCliente) Then
                    Return False
                Else
                    Dim DalCliente As New DAL.DAL.Cliente

                    DalCliente.GuardarCliente(unCliente)





                End If



                Return True
            Catch ex As Exception
                Return False
            End Try




        End Function
        ''' <summary>
        ''' Verifica si el cliente ya  existe en el sistema 
        ''' </summary>
        ''' <param name="unCliente"></param>
        ''' <returns>En caso de existir el cliente devuelve true </returns>
        ''' <remarks></remarks>
        Private Function ExisteCliente(ByVal unCliente As Cliente) As Boolean
            Dim DalCliente As New DAL.DAL.Cliente

            If DalCliente.Comprobar(unCliente.DNI, "DNI") Then
                Return True
            Else
                Return False
            End If




        End Function
        ''' <summary>
        ''' Busca un cliente en la base de datos antes comprueba que el DNI exista. en Caso de no existir se llama a la excepcion 
        ''' </summary>
        ''' <param name="DNI"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function BuscarCliente(ByVal DNI As Integer) As Biz.BIZ.Entities.Cliente
            Dim unCliente As New Cliente
            Dim DalCliente As New DAL.DAL.Cliente
            unCliente.DNI = DNI
            comprobarDNI(unCliente.DNI)

            If Me.ExisteCliente(unCliente) Then
                unCliente = DalCliente.BuscarCliente(unCliente.DNI)

            Else
                ' llamar  a interrupcion 
            End If


            Return unCliente
        End Function
        ''' <summary>
        ''' Comprueba si el Nro de DNI es un numero valido en caso de no existir se llama a la excepcion exClienteNoExiste
        ''' </summary>
        ''' <param name="DNI">DNI que se desea buscar en la BD</param>
        ''' <remarks></remarks>
        Private Sub comprobarDNI(ByVal DNI As Integer)
            'ingresar codigo para validar DNI
            'sino llama a interrupcion
        End Sub


    End Class

End Namespace