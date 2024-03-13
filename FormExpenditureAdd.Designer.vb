<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExpenditureAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtExName = New TextBox()
        txtamount = New TextBox()
        rbnormal = New RadioButton()
        rbcustom = New RadioButton()
        clbpaid_by = New CheckedListBox()
        lbPaidBy = New Label()
        btnADD = New Button()
        btnclose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(61, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 28)
        Label1.TabIndex = 0
        Label1.Text = "Add Your Expenses:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 20)
        Label2.TabIndex = 1
        Label2.Text = "Expense Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(92, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 2
        Label3.Text = "Amount:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(77, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 20)
        Label4.TabIndex = 3
        Label4.Text = "Expense Type:"
        ' 
        ' txtExName
        ' 
        txtExName.Location = New Point(227, 208)
        txtExName.Name = "txtExName"
        txtExName.Size = New Size(171, 27)
        txtExName.TabIndex = 4
        ' 
        ' txtamount
        ' 
        txtamount.Location = New Point(227, 258)
        txtamount.Name = "txtamount"
        txtamount.Size = New Size(171, 27)
        txtamount.TabIndex = 5
        ' 
        ' rbnormal
        ' 
        rbnormal.AutoSize = True
        rbnormal.Location = New Point(232, 165)
        rbnormal.Name = "rbnormal"
        rbnormal.Size = New Size(80, 24)
        rbnormal.TabIndex = 6
        rbnormal.TabStop = True
        rbnormal.Text = "Normal"
        rbnormal.UseVisualStyleBackColor = True
        ' 
        ' rbcustom
        ' 
        rbcustom.AutoSize = True
        rbcustom.Location = New Point(350, 166)
        rbcustom.Name = "rbcustom"
        rbcustom.Size = New Size(80, 24)
        rbcustom.TabIndex = 7
        rbcustom.TabStop = True
        rbcustom.Text = "Custom"
        rbcustom.UseVisualStyleBackColor = True
        ' 
        ' clbpaid_by
        ' 
        clbpaid_by.FormattingEnabled = True
        clbpaid_by.Location = New Point(163, 308)
        clbpaid_by.Name = "clbpaid_by"
        clbpaid_by.Size = New Size(252, 136)
        clbpaid_by.TabIndex = 8
        ' 
        ' lbPaidBy
        ' 
        lbPaidBy.AutoSize = True
        lbPaidBy.Location = New Point(97, 330)
        lbPaidBy.Name = "lbPaidBy"
        lbPaidBy.Size = New Size(60, 20)
        lbPaidBy.TabIndex = 9
        lbPaidBy.Text = "Paid by:"
        ' 
        ' btnADD
        ' 
        btnADD.Location = New Point(455, 415)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(94, 29)
        btnADD.TabIndex = 10
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = True
        ' 
        ' btnclose
        ' 
        btnclose.Location = New Point(565, 415)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(94, 29)
        btnclose.TabIndex = 11
        btnclose.Text = "CLOSE"
        btnclose.UseVisualStyleBackColor = True
        ' 
        ' FormExpenditureAdd
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(891, 529)
        Controls.Add(btnclose)
        Controls.Add(btnADD)
        Controls.Add(lbPaidBy)
        Controls.Add(clbpaid_by)
        Controls.Add(rbcustom)
        Controls.Add(rbnormal)
        Controls.Add(txtamount)
        Controls.Add(txtExName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormExpenditureAdd"
        Text = "FormExpenditureAdd"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtExName As TextBox
    Friend WithEvents txtamount As TextBox
    Friend WithEvents rbnormal As RadioButton
    Friend WithEvents rbcustom As RadioButton
    Friend WithEvents clbpaid_by As CheckedListBox
    Friend WithEvents lbPaidBy As Label
    Friend WithEvents btnADD As Button
    Friend WithEvents btnclose As Button
End Class
