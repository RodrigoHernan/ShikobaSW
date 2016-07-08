
Imports ShikobaSW.Biz.BIZ
Imports Ramos.Framework.Persistencia


Namespace DAL

    Public Class Cliente


        ''' <summary>
        ''' comprueba si el si la informacion a buscar existe en la celda elegida de la base de datos
        ''' </summary>
        ''' <param name="InformacionABuscar">informacion que se desea comprobar si existe en la base de datos</param>
        ''' <param name="NombreDeCelda">nombre del atributo que se desea buscar en la base de datos</param>
        ''' <returns>TRUE si la informacion buscada existe en BD</returns>
        ''' <remarks></remarks>
        Public Function Comprobar(ByVal InformacionABuscar As Integer, ByVal NombreDeCelda As String) As Boolean

            '' conectar 
            ' select from....

            Return True

        End Function
        ''' <summary>
        ''' Guarda en la base de datos el Cliente que es enviado en la funcion como un nuevo registro 
        ''' </summary>
        ''' <param name="unCliente">Cliete que se desea guarda</param>
        ''' <remarks></remarks>
        Public Sub GuardarCliente(ByVal unCliente As Biz.BIZ.Entities.Cliente)
            ' conectar 
            'conexion 
            'ejecutar sin resultados

        End Sub
        ''' <summary>
        ''' Se ingresa un DNI y el mismo retorna una instancia de la clase cliente que pertenece el DNI
        ''' </summary>
        ''' <param name="DNI"></param>
        ''' <returns>Cliente si el cliente no existe retorna nothing</returns>
        ''' <remarks></remarks>
        Public Function BuscarCliente(ByVal DNI As Integer) As Biz.BIZ.Entities.Cliente
            Dim unCliente As New Biz.BIZ.Entities.Cliente
            Dim c As New Conexion()
            Dim Listaparametros As New List(Of Parametro)
            Listaparametros.Add(New Parametro("@DNI", DNI))
            c.ConexionIniciar()
            c.TransaccionIniciar()
            unCliente = c.EjecutarTupla(Of Entities.Cliente)("select * from Cliente WHERE DNI=@DNI", Listaparametros).First
            Dim Listaparametros2 As New List(Of Parametro)
            Listaparametros2.Add(New Parametro("@idOSoPrePa", unCliente.IdOsoPrePa))
            unCliente.unOsPrePa = c.EjecutarTupla(Of Entities.OsoPrePa)("select * from OSoPrePa WHERE idOSoPrePa=@idOSoPrePa", Listaparametros2).First


            c.TransaccionAceptar()
            c.conexionFinalizar()
            Return unCliente
        End Function



    End Class



End Namespace
