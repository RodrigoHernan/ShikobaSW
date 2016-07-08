Namespace diccionario



    Public Class Diccionario

        Private Sub interrupciones()
            ' Try
            '-
            'If unaFactura.Fechafactura < fecha.Hoy() Then
            'Throw New Exception("fecha menor a hoy") ejecuta la interrupcion
            'End If
            '-
            '-
            '-
            'Catch ex As Exception''' que sucede si se ejecuta la interrucion sea porque la llamo o porque hubo un error
            'MsgBox("ingrese una fecha valida no puede ser menor del dia" & Date.Today)
            'End Try
        End Sub
        Private Sub Eventos()
            '''''''''''''''''''''''''''''''''''''''''''''''''''FORM
            'Dim unaFactura As New Factura (objeto que tiene el evento )
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''' en carga de form
            'AddHandler unaFactura.HaSuperadoCantidadDetalles, AddressOf DetallesMayora4 (asignar manejador)
            '           nombre del evento que se encuentra en el form           'manejador    
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''SUB EN EL FORM
            'Private Sub DetallesMayora4() (manejador de evento)
            '    MsgBox("no puede ingresar mas de 4 detalles por factura")
            '-
            'End Sub
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''EN LA CLASE  
            'Public Class Factura
            ''''Property Cliente As New cliente (propiedades)
            'Public Event HaSuperadoCantidadDetalles()      ''declarar nombre de evento
            '' SUB QUE DEFINE EL EVENTO
            ' Public Sub AgregarDetalle(unDetalle As FacturaDetalle)
            ' If (FacturaDetalle.Count > 3) Then
            ' FacturaDetalle.Add(unDetalle)
            ' RaiseEvent HaSuperadoCantidadDetalles()       ''declaracion que ejecuta el evento
            ' Else
            ' FacturaDetalle.Add(unDetalle)
            ' End If
        End Sub
        Private Sub combobox()
            'ComboCliente.DataSource = Nothing borra los datos
            'ComboCliente.DataSource = RepositorioMemoria.ListaClientes asigna la matriz con que se va a cargar
            'ComboCliente.DisplayMember = "CodigodeCliente"  asigna el asigna la lista que va a mostrar
        End Sub

        Private Sub EliminarDetalleCombo()

            '            FacturaDetalle.RemoveAt(GrillaFactura.CurrentRow.Index)

        End Sub
    End Class


End Namespace