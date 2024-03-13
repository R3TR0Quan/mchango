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
        btnexpenses = New Button()
        btndepts = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnexpenses
        ' 
        btnexpenses.Image = CType(resources.GetObject("btnexpenses.Image"), Image)
        btnexpenses.Location = New Point(80, 66)
        btnexpenses.Name = "btnexpenses"
        btnexpenses.Size = New Size(303, 240)
        btnexpenses.TabIndex = 0
        btnexpenses.UseVisualStyleBackColor = True
        ' 
        ' btndepts
        ' 
        btndepts.Image = CType(resources.GetObject("btndepts.Image"), Image)
        btndepts.Location = New Point(412, 66)
        btndepts.Name = "btndepts"
        btndepts.Size = New Size(303, 240)
        btndepts.TabIndex = 1
        btndepts.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 14F, FontStyle.Italic)
        Label1.Location = New Point(144, 322)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 27)
        Label1.TabIndex = 2
        Label1.Text = "View Expenses"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 14F, FontStyle.Italic)
        Label2.Location = New Point(476, 322)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 27)
        Label2.TabIndex = 3
        Label2.Text = "View Depts"
        ' 
        ' FormHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(950, 709)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btndepts)
        Controls.Add(btnexpenses)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormHome"
        Text = "FormHome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnexpenses As Button
    Friend WithEvents btndepts As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
