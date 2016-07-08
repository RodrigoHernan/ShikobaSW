Imports ShikobaSW.Biz.BIZ.exceptions
Namespace BLL


    Public Class GestorProfesional

        Function VerificarProfesiona(unProfesional As Biz.BIZ.Entities.Profesional)
            Dim DALprofesional As New DAL.DAL.Profesional
            Dim ProfesionalaVerificar As New Biz.BIZ.Entities.Profesional
            ProfesionalaVerificar = DALprofesional.BuscarUsuario(unProfesional)
            If ProfesionalaVerificar.contraseña = unProfesional.contraseña Then
                Return ProfesionalaVerificar
            Else
                Throw New exErrorUseryPass

            End If

        End Function

        Sub BuscarTurnosdiadelaFecha(unProfesional As Biz.BIZ.Entities.Profesional, servicio As Biz.BIZ.Entities.Servicio, p3 As Date)
            Throw New NotImplementedException ' se  deben buscar todos los turnos del dia de la fecha 

        End Sub

    End Class

End Namespace