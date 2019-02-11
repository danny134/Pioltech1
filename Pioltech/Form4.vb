

Imports System.Drawing.Printing

Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PrintDocument As New PrintDocument
    End Sub
    Public Function ticket(ArArticulos() As String, ArUniMesTot() As String)
        For i = 0 To ArArticulos.Length
            If ArArticulos(i) <> Nothing Then
                lbTicket.Items.Add(ArArticulos(i))
            End If
        Next
        lbTicket.Items.Add(ArUniMesTot(0) & "    " & ArUniMesTot(1) & "    " & ArUniMesTot(2))
    End Function
End Class