Imports System.Reflection
Imports System.Xml

Namespace Persistencia
    	''' <summary>
	''' Proporciona los datos de configuracion de una base de datos Para su
	''' funcionamiento se debe crear una nueva clase y generar una shared property  del
	''' tipo configuracion db y asignarle la ruta de configuracion
	''' </summary>
    Public Class ConfiguracionDb

        Public Enum EstrategiasDbEnum
            SqlServer
            MySql
            ACCESS
        End Enum

        Public Property estrategiaElegida As String
        Public Property Servidor As String
        Public Property Catalogo As String
        Public Property NombreUsuario As String
        Public Property Clave As String

        Private Shared documentoXml As XmlWriter



        Public Sub GuardarDatosConexion(ByVal datos As ConfiguracionDb)
            Dim configuracionXml As New XmlWriterSettings()
            configuracionXml.Indent = 2

            'Creo el documento.
            documentoXml = XmlWriter.Create("d:/configuraciones ", configuracionXml)
            documentoXml.WriteStartDocument(True)

            documentoXml.WriteStartElement("Configuracion")

            documentoXml.WriteElementString("Servidor", datos.Servidor)
            documentoXml.WriteElementString("Catalogo", datos.Catalogo)
            documentoXml.WriteElementString("NombreUsuario", datos.NombreUsuario)
            documentoXml.WriteElementString("Clave", datos.Clave)

            documentoXml.WriteEndElement()

            documentoXml.WriteEndDocument()
            documentoXml.Close()

        End Sub
        Public Sub GuardarDatosConexion(ByVal datos As ConfiguracionDb, ByVal Ruta As String)
            Dim configuracionXml As New XmlWriterSettings()
            configuracionXml.Indent = 2

            'Creo el documento.
            documentoXml = XmlWriter.Create(Ruta, configuracionXml)
            documentoXml.WriteStartDocument(True)

            documentoXml.WriteStartElement("Configuracion")
            documentoXml.WriteElementString("estrategiaElegida", datos.estrategiaElegida)
            documentoXml.WriteElementString("Servidor", datos.Servidor)
            documentoXml.WriteElementString("Catalogo", datos.Catalogo)
            documentoXml.WriteElementString("NombreUsuario", datos.NombreUsuario)
            documentoXml.WriteElementString("Clave", datos.Clave)

            documentoXml.WriteEndElement()

            documentoXml.WriteEndDocument()
            documentoXml.Close()

        End Sub
        Public Sub LeerDatosConexion(ByVal Ruta As String)
            '     Dim datos As New DTOConfiguraciondb



            'Reader del documento txt.
            Dim sr = New System.IO.StreamReader(Ruta)

            'Reader xml..
            Dim reader = XmlReader.Create(sr)

            'Mientras que puedas leer...
            While reader.Read()

                reader.MoveToContent()

                While reader.Read()

                    reader.MoveToElement()

                    If (reader.NodeType = XmlNodeType.Element) Then


                        'datos.GetType.GetProperty(reader.Name) ' reader.ReadElementString()

                        Dim InformaciondePropiedad As PropertyInfo = Me.GetType.GetProperty(reader.Name)
                        InformaciondePropiedad.SetValue(Me, reader.ReadElementString())
                        'NombreProperty
                        'MsgBox(reader.Name)

                        'Valor
                        '   MsgBox(reader.ReadElementString())

                    End If

                End While

            End While

            reader.Close()
            reader.Dispose()

        End Sub


    End Class
End Namespace