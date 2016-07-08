Imports Ramos.Framework.Persistencia
Imports System.Data.OleDb

''' <summary>
''' Porveedor que permite realizar una conexion a un BD de Access la misma debe ser la version de 2003
''' </summary>
''' <remarks></remarks>
Public Class ProveedorACCESS
	Implements Persistencia.IProveedorBD

    Private _sqlConnection As OleDbConnection
    Private _sqlTransansaction As OleDbTransaction
    Private _servidor As String ' En este caso el servidor es la ruta donde se aloja el *.accdb
    Private _catalogo As String ' en este caso el catalogo es el nombre de la base de datos ej: BD.accdb
    Private _usuario As String
    Private _clave As String

    Public Sub New(ByVal servidor As String, ByVal catalogo As String)
        ' TODO: Complete member initialization 
        _servidor = servidor
        _catalogo = catalogo
    End Sub


    Public Sub conexionFinalizar() Implements IProveedorBD.conexionFinalizar
        _sqlConnection.Close()
    End Sub

    Public Sub Conexioniniciar() Implements IProveedorBD.Conexioniniciar
        _sqlConnection = New OleDbConnection(Me.ObtenerCadenaConexion(_servidor, _catalogo))
        _sqlConnection.Open()
        
    End Sub

    Public Function EjecutarEscalar(Of t)(ByVal query As String, ByVal Parametros As List(Of Parametro)) As Object Implements IProveedorBD.EjecutarEscalar


        Dim unComando As New OleDbCommand

        'Preconfig...
        unComando.Connection = _sqlConnection

        unComando.Transaction = _sqlTransansaction

        unComando.CommandType = CommandType.Text
        unComando.CommandText = query

        For Each item In Parametros

            Dim unParametro As New OleDbParameter(item.NombreParametro, item.Valor)
            unComando.Parameters.Add(unParametro)

        Next
        Dim A = unComando.ExecuteScalar()

        'Ejecucion...
        Return CType(unComando.ExecuteScalar(), t)

    End Function

    Public Sub EjecutarSinResultado(ByVal query As String, ByVal Parametros As List(Of Parametro)) Implements IProveedorBD.EjecutarSinResultado
        Dim unComando As New OleDbCommand

        'Preconfig...
        unComando.Connection = _sqlConnection
        unComando.Transaction = _sqlTransansaction

        unComando.CommandType = CommandType.Text
        unComando.CommandText = query

        For Each item In Parametros

            Dim unParametro As New OleDbParameter(item.NombreParametro, item.Valor)
            unComando.Parameters.Add(unParametro)

        Next

        'Ejecucion...
        unComando.ExecuteNonQuery()

    End Sub

    Public Function EjecutarTupla(Of t As New)(ByVal query As String, ByVal Parametros As List(Of Parametro)) As List(Of t) Implements IProveedorBD.EjecutarTupla
        Dim unComando As New OleDbCommand

        'Preconfig...
        unComando.Connection = _sqlConnection
        unComando.Transaction = _sqlTransansaction

        unComando.CommandType = CommandType.Text
        unComando.CommandText = query

        For Each item In Parametros

            Dim unParametro As New OleDbParameter(item.NombreParametro, item.Valor)
            unComando.Parameters.Add(unParametro)

        Next

        'Ejecucion...
        Dim resultadoDataReader = unComando.ExecuteReader()

        Return MappearResultado(Of t)(resultadoDataReader)
    End Function

    Public Sub TransaccionAceptar() Implements IProveedorBD.TransaccionAceptar
        _sqlTransansaction.Commit()
    End Sub

    Public Sub TransaccionCancelar() Implements IProveedorBD.TransaccionCancelar
        _sqlTransansaction.Rollback()

    End Sub

    Public Sub TransaccionIniciar() Implements IProveedorBD.TransaccionIniciar
        _sqlTransansaction = _sqlConnection.BeginTransaction()
    End Sub
    Private Function ObtenerCadenaConexion(ByVal server As String, ByVal Catalogo As String) As String

        Return String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}{1}", server, Catalogo)


    End Function

    Private Function MappearResultado(Of T As New)(ByVal resultadoDataReader As OleDbDataReader) As List(Of T)


        Dim resultado As New List(Of T)

        'Recorro todos los rows.
        Do While resultadoDataReader.Read()

            'Creo un T.
            Dim unT As New T

            'Recorro las columnas de la tabla.
            For i = 0 To resultadoDataReader.FieldCount - 1

                'A una instancia de T, pegarle cada una de estas propiedades...
                Dim nombreColumna = resultadoDataReader.GetName(i)

                'Obtengo la property
                Dim propiedadInfo = unT.GetType().GetProperty(nombreColumna)

                'Le pego el valor a esa property.
                propiedadInfo.SetValue(unT, resultadoDataReader.GetValue(i))

            Next

            resultado.Add(unT)

        Loop

        resultadoDataReader.Close()
        Return resultado

    End Function

End Class
