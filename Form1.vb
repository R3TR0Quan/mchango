Imports FontAwesome.Sharp

Public Class Form1

    Private currentBtn As Button
    Private leftBorderBtn As Panel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_menu("HOME")
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 71)
        SidePanel.Controls.Add(leftBorderBtn)

    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)

        DisabledButton()

        If senderBtn IsNot Nothing Then
            currentBtn = senderBtn
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub

    Private Sub DisabledButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro

        End If
    End Sub

    Private Sub addForm(frm As Form)
        PanelContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm) '  Add the form to the panel container
        frm.Show()

    End Sub

    Private Sub change_menu(menu As String)
        Select Case menu
            Case "HOME"
                addForm(Me)
            Case "EXPENDITURE"
                addForm(FormExpenditure)
            Case "DEPT"
                addForm(FormDepts)
            Case "EXPENSES"
                addForm(FormExpenditureView)
        End Select
    End Sub


    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        ActivateButton(btnhome, RGBColors.color1)
        change_menu("HOME")

    End Sub

    Private Sub btnexpenditure_Click(sender As Object, e As EventArgs) Handles btnexpenditure.Click
        ActivateButton(btnexpenditure, RGBColors.color1)
        change_menu("EXPENDITURE")
    End Sub

    Private Sub btndept_Click(sender As Object, e As EventArgs) Handles btndept.Click
        ActivateButton(btndept, RGBColors.color1)
        change_menu("DEPT")
    End Sub

    Private Sub PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles PanelContainer.Paint

    End Sub
End Class
