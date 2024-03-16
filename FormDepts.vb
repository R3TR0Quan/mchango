Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Data
Imports Microsoft.Data.SqlClient


Public Class FormDepts


    Function CalculateIndividualDept() As List(Of Object)
        Dim connetionString As String = "server=localhost; user id=root; password= ''; database=crib_plans"
        Dim userCount As Integer = 0
        Dim debts As New List(Of Object)

        Using connection As New SqlConnection(connetionString)
            connection.Open()

            'get count of users in the database

            Dim userCmd As New SqlCommand("SELECT COUNT(*) FROM user", connection)
            Dim userResult = userCmd.ExecuteScalar()
            If userResult IsNot Nothing Then
                userCount = Convert.ToInt32(userResult)
            End If

            'get each expense from the database and calculate the dept
            Dim expenseCmd As New SqlCommand("SELECT expenditure_name, amount from normal_expense", connection)
            Using reader As SqlDataReader = expenseCmd.ExecuteReader()
                While reader.Read()
                    Dim expenseName As String = reader("expenditure_name").ToString()
                    Dim amount As Double = Convert.ToDouble(reader("amount"))
                    Dim indvidualDept As Double = If(userCount > 0, amount / userCount, 0)

                    'get list of usernames
                    Dim usernames As New List(Of String)
                    Dim userNamesCmd As New SqlCommand("SELECT username FROM user", connection)
                    Using userReader As SqlDataReader = userNamesCmd.ExecuteReader()
                        While userReader.Read()
                            usernames.Add(userReader("username").ToString())
                        End While
                    End Using

                    debts.Add(New With {
                          Key .ExpenseName = expenseName,
                          Key .DeptAmount = indvidualDept,
                          Key .OwedBy = usernames
                          })
                End While
            End Using

            connection.Close()
        End Using

        Return debts
    End Function

    Private Sub FormDepts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        'call on calculateindividualdept function and display the result in the listview "lvdept" filtered by the combobox "cbdep" (owing as the amount the user owes other users and owed as the amount the user is owed)
        Try
            Dim debts As List(Of Object) = CalculateIndividualDept()
            lvdept.Items.Clear()

            'populate the listview
            For Each debt In debts
                Dim item As New ListViewItem(debt.ExpenseName.ToString())
                item.SubItems.Add(debt.DeptAmount.ToString())

                'combine the list of usernames into a single string
                Dim owedBy As String = String.Join(",", debt.OwedBy.ToArray())
                item.SubItems.Add(owedBy)

                lvdept.Items.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show("An error occured: " & ex.Message)
        End Try
    End Sub

    Private Sub lvdept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvdept.SelectedIndexChanged
        'set up columns for the listView
        lvdept.Columns.Add("Expense Name", 150, HorizontalAlignment.Left)
        lvdept.Columns.Add("Dept Amount", 100, HorizontalAlignment.Right)
        lvdept.Columns.Add("Owed By", 200, HorizontalAlignment.Left)

        'set up the view to show details
        lvdept.View = View.Details

    End Sub
End Class


