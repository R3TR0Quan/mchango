<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        SidePanel = New Panel()
        btndept = New Button()
        btnexpenditure = New Button()
        btnhome = New Button()
        PanelContainer = New Panel()
        Panel1.SuspendLayout()
        SidePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(53), CByte(150), CByte(181))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1133, 53)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ravie", 16F)
        Label1.Location = New Point(401, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 36)
        Label1.TabIndex = 0
        Label1.Text = "CRIB_PLANS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.FromArgb(CByte(173), CByte(197), CByte(207))
        SidePanel.Controls.Add(btndept)
        SidePanel.Controls.Add(btnexpenditure)
        SidePanel.Controls.Add(btnhome)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 53)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(281, 608)
        SidePanel.TabIndex = 1
        ' 
        ' btndept
        ' 
        btndept.FlatAppearance.BorderSize = 0
        btndept.FlatStyle = FlatStyle.Flat
        btndept.Font = New Font("Ravie", 13F)
        btndept.Location = New Point(-3, 259)
        btndept.Name = "btndept"
        btndept.Size = New Size(281, 73)
        btndept.TabIndex = 2
        btndept.Text = "DEPT"
        btndept.UseVisualStyleBackColor = True
        ' 
        ' btnexpenditure
        ' 
        btnexpenditure.FlatAppearance.BorderSize = 0
        btnexpenditure.FlatStyle = FlatStyle.Flat
        btnexpenditure.Font = New Font("Ravie", 13F)
        btnexpenditure.Location = New Point(3, 169)
        btnexpenditure.Name = "btnexpenditure"
        btnexpenditure.Size = New Size(281, 73)
        btnexpenditure.TabIndex = 1
        btnexpenditure.Text = "EXPENDITURE"
        btnexpenditure.UseVisualStyleBackColor = True
        ' 
        ' btnhome
        ' 
        btnhome.FlatAppearance.BorderSize = 0
        btnhome.FlatStyle = FlatStyle.Flat
        btnhome.Font = New Font("Ravie", 13F)
        btnhome.Location = New Point(0, 90)
        btnhome.Name = "btnhome"
        btnhome.Size = New Size(281, 73)
        btnhome.TabIndex = 0
        btnhome.Text = "HOME"
        btnhome.UseVisualStyleBackColor = True
        ' 
        ' PanelContainer
        ' 
        PanelContainer.Location = New Point(362, 157)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(729, 216)
        PanelContainer.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1133, 661)
        Controls.Add(PanelContainer)
        Controls.Add(SidePanel)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SidePanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SidePanel As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents btnhome As Button
    Friend WithEvents btnexpenditure As Button
    Friend WithEvents btndept As Button

End Class
