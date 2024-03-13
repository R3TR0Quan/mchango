Public Class FormExpenditure

    Private currentBtn As Button

    Private Sub FormExpenditure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub addForm(frm As Form)
        PanelCon.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelCon.Controls.Add(frm)
        frm.Show()

    End Sub

    Private Sub change_menu(menu As String)
        Select Case menu
            Case "Add"
                addForm(FormExpenditureAdd)
            Case "View"
                addForm(FormExpenditureView)
        End Select
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ActivateButton(btnadd, RGBColors.color1)
        change_menu("Add")
        lbNoAction.Hide()
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        ActivateButton(btnview, RGBColors.color1)
        change_menu("View")
        lbNoAction.Hide()
    End Sub

End Class