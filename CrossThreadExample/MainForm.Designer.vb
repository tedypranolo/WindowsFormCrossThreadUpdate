<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.TestLabel = New System.Windows.Forms.Label()
        Me.TestRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.MainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainListBox = New System.Windows.Forms.ListBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        CType(Me.MainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(274, 199)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(174, 23)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add In Background"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'TestLabel
        '
        Me.TestLabel.AutoSize = True
        Me.TestLabel.Location = New System.Drawing.Point(185, 9)
        Me.TestLabel.Name = "TestLabel"
        Me.TestLabel.Size = New System.Drawing.Size(39, 13)
        Me.TestLabel.TabIndex = 1
        Me.TestLabel.Text = "Label1"
        '
        'TestRichTextBox
        '
        Me.TestRichTextBox.Location = New System.Drawing.Point(188, 25)
        Me.TestRichTextBox.Name = "TestRichTextBox"
        Me.TestRichTextBox.Size = New System.Drawing.Size(260, 168)
        Me.TestRichTextBox.TabIndex = 2
        Me.TestRichTextBox.Text = ""
        '
        'MainListBox
        '
        Me.MainListBox.DataSource = Me.MainBindingSource
        Me.MainListBox.FormattingEnabled = True
        Me.MainListBox.Location = New System.Drawing.Point(3, 18)
        Me.MainListBox.Name = "MainListBox"
        Me.MainListBox.Size = New System.Drawing.Size(175, 199)
        Me.MainListBox.TabIndex = 3
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(271, 234)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(176, 25)
        Me.UpdateButton.TabIndex = 4
        Me.UpdateButton.Text = "Update in Background"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 348)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.MainListBox)
        Me.Controls.Add(Me.TestRichTextBox)
        Me.Controls.Add(Me.TestLabel)
        Me.Controls.Add(Me.AddButton)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        CType(Me.MainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents TestLabel As System.Windows.Forms.Label
    Friend WithEvents TestRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents MainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainListBox As System.Windows.Forms.ListBox
    Friend WithEvents UpdateButton As System.Windows.Forms.Button

End Class
