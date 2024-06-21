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
        Label1 = New Label()
        ViewButton_Click = New Button()
        CreateButton_Click = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 15F)
        Label1.ForeColor = Color.OrangeRed
        Label1.Location = New Point(155, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(510, 29)
        Label1.TabIndex = 0
        Label1.Text = "John Doe, Slidely Task 2 - Slidely Form App"
        ' 
        ' ViewButton_Click
        ' 
        ViewButton_Click.BackColor = Color.Yellow
        ViewButton_Click.FlatStyle = FlatStyle.Popup
        ViewButton_Click.Font = New Font("Microsoft Sans Serif", 10F)
        ViewButton_Click.Location = New Point(69, 177)
        ViewButton_Click.Name = "ViewButton_Click"
        ViewButton_Click.Size = New Size(661, 51)
        ViewButton_Click.TabIndex = 1
        ViewButton_Click.Text = "&VIEW SUBMISSIONS (CTRL + V)"
        ViewButton_Click.UseVisualStyleBackColor = False
        ' 
        ' CreateButton_Click
        ' 
        CreateButton_Click.BackColor = Color.Cyan
        CreateButton_Click.FlatStyle = FlatStyle.Popup
        CreateButton_Click.Font = New Font("Microsoft Sans Serif", 10F)
        CreateButton_Click.Location = New Point(69, 271)
        CreateButton_Click.Name = "CreateButton_Click"
        CreateButton_Click.Size = New Size(661, 51)
        CreateButton_Click.TabIndex = 2
        CreateButton_Click.Text = "&CREATE NEW SUBMISSION (CTRL + N)"
        CreateButton_Click.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 753)
        Controls.Add(CreateButton_Click)
        Controls.Add(ViewButton_Click)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ViewButton_Click As Button
    Friend WithEvents CreateButton_Click As Button

End Class
