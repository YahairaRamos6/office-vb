Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop.Excel
Imports System

Public Class Form1
    Private Sub Ptbword_Click(sender As Object, e As EventArgs) Handles Ptbword.Click
        Dim sf As SaveFileDialog = New SaveFileDialog()

        If sf.ShowDialog() = DialogResult.OK Then
            Dim obj As Object = System.Reflection.Missing.Value
            Dim word As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application()
            Dim doc As Microsoft.Office.Interop.Word.Document = word.Documents.Add(obj)
            doc.Activate()
            word.Selection.TypeText(TextBox1.Text)
            doc.SaveAs2(sf.FileName)
            word.Visible = True
        End If

    End Sub

    Private Sub PtbExcel_Click(sender As Object, e As EventArgs) Handles PtbExcel.Click
        Dim sf As SaveFileDialog = New SaveFileDialog()

        If sf.ShowDialog() = DialogResult.OK Then
            Dim obj As Object = System.Reflection.Missing.Value
            Dim excel As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
            Dim file As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(obj)
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet = file.Worksheets.Add()
            file.Activate()
            hoja.Cells(1, 1).Value = TextBox1.Text
            file.SaveAs(sf.FileName)
            excel.Visible = True
        End If
    End Sub
End Class
