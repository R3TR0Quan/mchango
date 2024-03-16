<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        PanelContainer = New Panel()
        lbviewdp = New Label()
        lbviewex = New Label()
        btnexpenses = New Button()
        btndepts = New Button()
        SuspendLayout()
        ' 
        ' PanelContainer
        ' 
        PanelContainer.Location = New Point(172, 308)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(729, 216)
        PanelContainer.TabIndex = 3
        ' 
        ' lbviewdp
        ' 
        lbviewdp.AutoSize = True
        lbviewdp.Font = New Font("Rockwell", 14F, FontStyle.Italic)
        lbviewdp.Location = New Point(624, 278)
        lbviewdp.Name = "lbviewdp"
        lbviewdp.Size = New Size(134, 27)
        lbviewdp.TabIndex = 13
        lbviewdp.Text = "View Depts"
        ' 
        ' lbviewex
        ' 
        lbviewex.AutoSize = True
        lbviewex.Font = New Font("Rockwell", 14F, FontStyle.Italic)
        lbviewex.Location = New Point(261, 278)
        lbviewex.Name = "lbviewex"
        lbviewex.Size = New Size(172, 27)
        lbviewex.TabIndex = 12
        lbviewex.Text = "View Expenses"
        ' 
        ' btnexpenses
        ' 
        btnexpenses.Image = CType(resources.GetObject("btnexpenses.Image"), Image)
        btnexpenses.Location = New Point(202, 12)
        btnexpenses.Name = "btnexpenses"
        btnexpenses.Size = New Size(303, 240)
        btnexpenses.TabIndex = 11
        btnexpenses.UseVisualStyleBackColor = True
        ' 
        ' btndepts
        ' 
        btndepts.Image = CType(resources.GetObject("btndepts.Image"), Image)
        btndepts.Location = New Point(542, 12)
        btndepts.Name = "btndepts"
        btndepts.Size = New Size(303, 240)
        btndepts.TabIndex = 10
        btndepts.UseVisualStyleBackColor = True
        ' 
        ' FormHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1132, 533)
        Controls.Add(lbviewdp)
        Controls.Add(lbviewex)
        Controls.Add(btnexpenses)
        Controls.Add(btndepts)
        Controls.Add(PanelContainer)
        Name = "FormHome"
        Text = "FormHome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelContainer As Panel
    Friend WithEvents lbviewdp As Label
    Friend WithEvents lbviewex As Label
    Friend WithEvents btnexpenses As Button
    Friend WithEvents btndepts As Button
End Class
