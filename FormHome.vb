Imports System.Windows

Public Class FormHome
    Private Sub btnexpenses_Click(sender As Object, e As EventArgs) Handles btnexpenses.Click
        'link btnexpenses to the button "btnview" in FormExpenditure to perform same action when clicked
        FormExpenditure.btnview.PerformClick()

    End Sub

    Private Sub btndepts_Click(sender As Object, e As EventArgs) Handles btndepts.Click
        Form1.btndept.PerformClick()
    End Sub

End Class