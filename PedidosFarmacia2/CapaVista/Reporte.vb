Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Data.SqlClient

Public Class Reporte



    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim sfd As New SaveFileDialog With {.Filter = "PDF Files (*.pdf) | *pdfs"}
            If sfd.ShowDialog = 1 Then
                Dim doc As New Document(PageSize.A4, 40, 40, 80, 20)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)


        End Try
    End Sub
End Class