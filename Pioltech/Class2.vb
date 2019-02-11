Imports System.IO
Imports System.Net
Imports System.Windows.Forms
Imports System.Xml

Public Class Class2
    Dim estadohoy As String
    Dim vientoHoy As String
    Dim temperaturaMaxHoy As String
    Dim temperaturaMinHoy As String
    Dim tiempoHoy(3) As String
    Dim fechaHoy As String = DateTime.Now.ToString("yyyy-MM-dd")
    Public Sub descargarXML()
        Try
            Dim cliente As New WebClient
            Dim xmlText As String = cliente.DownloadString("http://www.aemet.es/xml/municipios/localidad_48020.xml")
            File.WriteAllText("..\..\tiempo.xml", xmlText)
            cargarXML()
        Catch ex As Exception
            cargarXML()
            MsgBox("No se ha podido descargar el xml, puede ser que no haya conexión a internet o que la página de AEMET no esté funcionando correctamente, compruebe la conexión a internet.")
        End Try

    End Sub
    Public Sub cargarXML()
        Try
            Dim mensaje As String = ""
            Dim tiempo As XmlDocument
            Dim node As XmlNode
            tiempo = New XmlDocument
            tiempo.Load("..\..\tiempo.xml")
            node = tiempo.SelectSingleNode("//prediccion/dia[@fecha=""" & fechaHoy & """]/estado_cielo[@periodo='18-24']")
            estadohoy = node.Attributes.GetNamedItem("descripcion").Value
            node = tiempo.SelectSingleNode("//prediccion/dia[@fecha=""" & fechaHoy & """]/viento[@periodo='18-24']/velocidad")
            vientoHoy = node.InnerText
            node = tiempo.SelectSingleNode("//prediccion/dia[@fecha=""" & fechaHoy & """]/temperatura/maxima")
            temperaturaMaxHoy = node.InnerText
            node = tiempo.SelectSingleNode("//prediccion/dia[@fecha=""" & fechaHoy & """]/temperatura/minima")
            temperaturaMinHoy = node.InnerText

            tiempoHoy(0) = estadohoy
            tiempoHoy(1) = vientoHoy
            tiempoHoy(2) = temperaturaMaxHoy
            tiempoHoy(3) = temperaturaMinHoy
            Select Case tiempoHoy(0)
                Case "Despejado"
                    mensaje = "No poner toldos"
                Case "Poco nuboso"
                    mensaje = "No poner toldos"
                Case "Intervalos nubosos"
                    mensaje = "No poner toldos"
                Case "Nubes altas"
                    mensaje = "No poner toldos"
                Case "Intervalos nubosos con lluvia escasa"
                    mensaje = "Sacar toldos"
                Case "Intervalos nubosos con nieve escasa"
                    mensaje = "Sacar toldos y preparar calefactores"
                Case "Nuboso con lluvia escasa"
                    mensaje = "Sacar toldos"
                Case "Intervalos nubosos con lluvia"
                    mensaje = "Sacar toldos"
                Case "Intervalos nubosos con nieve"
                    mensaje = "No preparar terraza"
                Case "Intervalos nubosos con tormenta"
                    mensaje = "Sacar toldos"
                Case "Intervalos nubosos con tormenta y lluvia escasa"
                    mensaje = "Sacar toldos"
                Case "Nuboso"
                    mensaje = "No sacar toldos"
                Case "Cubierto con lluvia escasa"
                    mensaje = "Sacar toldos"
                Case "Nuboso con nieve escasa"
                    mensaje = "Sacar toldos y preparar calefactores"
                Case "Nuboso con lluvia"
                    mensaje = "Sacar toldos"
                Case "Nuboso con nieve"
                    mensaje = "No preparar terraza"
                Case "Nuboso con tormenta"
                    mensaje = "Sacar toldos"
                Case "Nuboso con tormenta y lluvia escasa"
                    mensaje = "Sacar toldos"
                Case "Muy nuboso"
                    mensaje = "No sacar toldos, estar atentos a posibles cambios de tiempo"
                Case "Muy nuboso con lluvia"
                    mensaje = "Sacar toldos"
                Case "Muy nuboso con nieve escasa"
                    mensaje = "Sacar toldos y preparar calefactores"
                Case "Cubierto"
                    mensaje = "Sacar toldos"
                Case "Muy nuboso con nieve"
                    mensaje = "No preparar terraza"
                Case "Muy nuboso con tormenta"
                    mensaje = "Sacar toldos"
                Case "Muy nuboso con tormenta y lluvia"
                    mensaje = "Sacar toldos"
                Case "Cubierto con lluvia"
                    mensaje = "Sacar toldos"
                Case "Cubierto con nieve escasa"
                    mensaje = "Sacar toldos"
                Case "Cubierto con tormenta y lluvia escasa"
                    mensaje = "Sacar toldos"
                Case "Cubierto con nieve"
                    mensaje = "No preparar terraza"
                Case "Cubierto con tormenta"
                    mensaje = "Sacar toldos"
            End Select
            If (tiempoHoy(1) >= "30") Then
                mensaje = "Peligro de fuertes vientos, no poner toldos"
            End If

            escribirMensaje(mensaje)
        Catch ex As Exception


            Console.Write(ex)
        End Try

    End Sub



    Public Sub escribirMensaje(ByVal mensaje As String)
        Try
            If tiempoHoy(0) <> Nothing Then
                Grabar(mensaje)
            End If

        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show("No se ha podido enviar el mensage", "Error!", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub Grabar(ByVal mensage As String)
        Dim i As Integer = 0
        '' Se crea el objeto objWriter para señalar dónde guardar la info
        Try
            Dim objWriter As New System.IO.StreamWriter("../../tiempo.txt", True)
            '& = separador entre datos del array + la fecha
            '# = identificador de mensaje
            objWriter.Write(fechaHoy)
            objWriter.Write("&")
            While i < tiempoHoy.Length
                objWriter.Write(tiempoHoy(i))
                objWriter.Write("&")
                i += 1
            End While

            objWriter.Write(mensage)
            objWriter.Write("#")
            objWriter.Close()
            MessageBox.Show("Se ha enviado el siguiente mensage: " & mensage, "Enviado", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show("No se ha podido enviar el mensage", "Error!", MessageBoxButtons.OK)
        End Try
    End Sub
End Class
