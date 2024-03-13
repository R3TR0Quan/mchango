<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDepts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDepts))
        Label1 = New Label()
        cbdep = New ComboBox()
        btncheck = New Button()
        lvdept = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 20)
        Label1.TabIndex = 0
        Label1.Text = "DEPT"
        ' 
        ' cbdep
        ' 
        cbdep.FormattingEnabled = True
        cbdep.Items.AddRange(New Object() {"OWED", "OWING"})
        cbdep.Location = New Point(107, 27)
        cbdep.Name = "cbdep"
        cbdep.Size = New Size(210, 28)
        cbdep.TabIndex = 1
        ' 
        ' btncheck
        ' 
        btncheck.Location = New Point(672, 26)
        btncheck.Name = "btncheck"
        btncheck.Size = New Size(94, 29)
        btncheck.TabIndex = 2
        btncheck.Text = "Check"
        btncheck.UseVisualStyleBackColor = True
        ' 
        ' lvdept
        ' 
        lvdept.BackgroundImage = CType(resources.GetObject("lvdept.BackgroundImage"), Image)
        lvdept.Location = New Point(33, 71)
        lvdept.Name = "lvdept"
        lvdept.Size = New Size(720, 462)
        lvdept.TabIndex = 3
        lvdept.UseCompatibleStateImageBehavior = False
        ' 
        ' FormDepts
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(812, 556)
        Controls.Add(lvdept)
        Controls.Add(btncheck)
        Controls.Add(cbdep)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormDepts"
        Text = "FormDepts"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbdep As ComboBox
    Friend WithEvents btncheck As Button
    Friend WithEvents lvdept As ListView
End Class
