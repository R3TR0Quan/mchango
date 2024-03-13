<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExpenditure
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
        lbNoAction = New Label()
        btnadd = New Button()
        btnview = New Button()
        PanelCon = New Panel()
        SuspendLayout()
        ' 
        ' lbNoAction
        ' 
        lbNoAction.AutoSize = True
        lbNoAction.Font = New Font("Pristina", 17F)
        lbNoAction.Location = New Point(293, 267)
        lbNoAction.Name = "lbNoAction"
        lbNoAction.Size = New Size(202, 39)
        lbNoAction.TabIndex = 0
        lbNoAction.Text = "No action performed"
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(523, 12)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(104, 47)
        btnadd.TabIndex = 1
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnview
        ' 
        btnview.Location = New Point(633, 12)
        btnview.Name = "btnview"
        btnview.Size = New Size(104, 47)
        btnview.TabIndex = 2
        btnview.Text = "View"
        btnview.UseVisualStyleBackColor = True
        ' 
        ' PanelCon
        ' 
        PanelCon.Location = New Point(49, 119)
        PanelCon.Name = "PanelCon"
        PanelCon.Size = New Size(734, 382)
        PanelCon.TabIndex = 3
        ' 
        ' FormExpenditure
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(812, 556)
        Controls.Add(btnview)
        Controls.Add(btnadd)
        Controls.Add(lbNoAction)
        Controls.Add(PanelCon)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormExpenditure"
        Text = "FormExpenditure"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbNoAction As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents btnview As Button
    Friend WithEvents PanelCon As Panel
End Class
