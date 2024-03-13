<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExpenditureView
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
        cbtype = New ComboBox()
        cbview = New ComboBox()
        Label2 = New Label()
        Panelvisual = New Panel()
        btnvisualize = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 0
        Label1.Text = "Expense Type:"
        ' 
        ' cbtype
        ' 
        cbtype.FormattingEnabled = True
        cbtype.Items.AddRange(New Object() {"Normal", "Custom"})
        cbtype.Location = New Point(152, 19)
        cbtype.Name = "cbtype"
        cbtype.Size = New Size(194, 28)
        cbtype.TabIndex = 1
        ' 
        ' cbview
        ' 
        cbview.FormattingEnabled = True
        cbview.Items.AddRange(New Object() {"Pie Chart view", "Datagrid view"})
        cbview.Location = New Point(489, 22)
        cbview.Name = "cbview"
        cbview.Size = New Size(196, 28)
        cbview.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(372, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 2
        Label2.Text = "Display View:"
        ' 
        ' Panelvisual
        ' 
        Panelvisual.Location = New Point(35, 103)
        Panelvisual.Name = "Panelvisual"
        Panelvisual.Size = New Size(761, 381)
        Panelvisual.TabIndex = 4
        ' 
        ' btnvisualize
        ' 
        btnvisualize.Location = New Point(608, 56)
        btnvisualize.Name = "btnvisualize"
        btnvisualize.Size = New Size(94, 43)
        btnvisualize.TabIndex = 5
        btnvisualize.Text = "Visualize"
        btnvisualize.UseVisualStyleBackColor = True
        ' 
        ' FormExpenditureView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(865, 496)
        Controls.Add(btnvisualize)
        Controls.Add(Panelvisual)
        Controls.Add(cbview)
        Controls.Add(Label2)
        Controls.Add(cbtype)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormExpenditureView"
        Text = "FormExpenditureView"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbtype As ComboBox
    Friend WithEvents cbview As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panelvisual As Panel
    Friend WithEvents btnvisualize As Button
End Class
