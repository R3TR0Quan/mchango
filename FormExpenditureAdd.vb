Imports MySql.Data.MySqlClient
Imports Microsoft.Data.SqlClient
Imports System.Data
Public Class FormExpenditureAdd

    Private currentBtn As Button

    Private Sub FormExpenditureAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)

        DisabledButton()

        If senderBtn IsNot Nothing Then
            currentBtn = senderBtn
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor

        End If
    End Sub

    Private Sub DisabledButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro

        End If
    End Sub
    Private Sub rbnormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbnormal.CheckedChanged
        'hide "clbpaid_by" and "lbPaidBy" if "rbnormal" is checked
        If rbnormal.Checked Then
            clbpaid_by.Hide()
            lbPaidBy.Hide()
        End If
    End Sub

    'txtExName should only accept numbers,letters and spaces and should not be empty
    Private Sub txtExName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExName.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub rbcustom_CheckedChanged(sender As Object, e As EventArgs) Handles rbcustom.CheckedChanged
        If rbcustom.Checked Then
            clbpaid_by.Show()
            lbPaidBy.Show()
        End If
    End Sub

    Private Sub clbpaid_by_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbpaid_by.SelectedIndexChanged
        'should get the list from database and display it in the checkedlistbox using the usernames in the user table in the database "crib_plans'
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Dim str As String
        str = "server=localhost; user id=root; password= ''; database=crib_plans"
        conn.ConnectionString = str
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = "SELECT username FROM user"
        dr = cmd.ExecuteReader
        While dr.Read
            clbpaid_by.Items.Add(dr("username"))
        End While
        conn.Close()
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        'Save the data to the database in the table "dbo.normal_expenditure.sql" if "rbnormal" is checked and in the table "dbo.custom_expenditure.sql" if "rbcustom" is checked
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim str As String
        str = "server=localhost; user id=root; password= ''; database=crib_plans"
        conn.ConnectionString = str
        conn.Open()
        cmd.Connection = conn
        If rbnormal.Checked Then
            cmd.CommandText = "INSERT INTO normal_expenditure (expenditure_name, amount) VALUES ('" & txtExName.Text & "', '" & txtamount.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data saved successfully")
        ElseIf rbcustom.Checked Then
            cmd.CommandText = "INSERT INTO custom_expenditure (expenditure_name, amount, paid_by) VALUES ('" & txtExName.Text & "', '" & txtamount.Text & "', '" & clbpaid_by.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data saved successfully")
        End If
        conn.Close()

    End Sub
End Class