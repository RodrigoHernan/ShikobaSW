Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Ramos.Framework.Funciones.Cadenas
Imports Ramos.Framework.Persistencia

<TestClass()> _
Public Class cadenastest

    <TestMethod()> Public Sub DecorarListaTest()
        'arrange
        Dim unaLista As New List(Of String)
        unaLista.Add("a")
        unaLista.Add("b")
        unaLista.Add("c")

        'act
        Dim actual = DecorarLista(unaLista, "(", ")")

        'assert
        Assert.AreEqual("(a)", actual(0))
        Assert.AreEqual("(b)", actual(1))
        Assert.AreEqual("(c)", actual(2))

    End Sub

    <TestMethod()> Public Sub UnirListaTest()
        'arrange
        Dim unaLista As New List(Of String)
        unaLista.Add("a")
        unaLista.Add("b")
        unaLista.Add("c")

        'act
        Dim actual = UnirLista(";", unaLista)

        'assert
        Assert.AreEqual("a;b;c", actual)

    End Sub
    <TestMethod()> Public Sub CadenareemplazarTest()
        'arrange
        Dim unaLista As New List(Of String)
        unaLista.Add("Hola mundo para reemplazar")
        unaLista.Add("Hola mundo para reemplazar2")
        unaLista.Add("Hola mundo para reemplazar3")
        'act
        Dim actual = Reemplazar(unaLista, "mundo", "cambio")

        'assert
        Assert.AreEqual("Hola cambio para reemplazar", actual(0))
        Assert.AreEqual("Hola cambio para reemplazar2", actual(1))
        Assert.AreEqual("Hola cambio para reemplazar3", actual(2))
    End Sub
    <TestMethod()> Public Sub DataHosttest()
        'arrange
        Dim datos As New ConfiguracionDb
        datos.Servidor = "localhost\instancia"
        datos.Catalogo = "nombreBase"
        datos.NombreUsuario = "usuario"
        datos.Clave = "123456"
        'act
        datos.GuardarDatosConexion(datos)

        Dim LectorDatos As New ConfiguracionDb
        LectorDatos = datos.LeerDatosConexion(CurDir)

        'assert
        Assert.AreEqual("nombreBase", LectorDatos.Catalogo)
        Assert.AreEqual("localhost\instancia", LectorDatos.Servidor)
        Assert.AreEqual("usuario", LectorDatos.NombreUsuario)
        Assert.AreEqual("123456", LectorDatos.Clave)
    End Sub
End Class