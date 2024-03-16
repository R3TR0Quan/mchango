Public Class FormHome

    Private currentBtn As Button
    Private leftBorderBtn As Panel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_menu("HOME")
    End Sub


    Private Sub addForm(frm As Form)
        PanelContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)
        frm.Show()

    End Sub

    Private Sub change_menu(menu As String)
        Select Case menu
            Case "DEPT"
                addForm(FormDepts)
            Case "EXPENSES"
                addForm(FormExpenditureView)
        End Select
    End Sub


    Private Sub btnexpenses_Click(sender As Object, e As EventArgs)
        change_menu("EXPENSES")
        btnexpenses.Hide()
        btndepts.Hide()
        lbviewdp.Hide()
        lbviewex.Hide()

    End Sub

    Private Sub btndepts_Click(sender As Object, e As EventArgs)
        change_menu("DEPTS")
        btnexpenses.Hide()
        btndepts.Hide()
        lbviewdp.Hide()
        lbviewex.Hide()
    End Sub

    Private Sub PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles PanelContainer.Paint

    End Sub


End Class