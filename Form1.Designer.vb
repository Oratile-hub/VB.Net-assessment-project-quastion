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
        btnAdd = New Button()
        btnRemove = New Button()
        TextBox1 = New TextBox()
        txtInput = New ListBox()
        GroupBox1 = New GroupBox()
        radBlue = New RadioButton()
        radUpper = New RadioButton()
        radPurple = New RadioButton()
        radLower = New RadioButton()
        lstWords = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ControlLightLight
        btnAdd.Location = New Point(345, 339)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = SystemColors.ControlLightLight
        btnRemove.Location = New Point(494, 339)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(112, 34)
        btnRemove.TabIndex = 1
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(345, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(261, 31)
        TextBox1.TabIndex = 2
        ' 
        ' txtInput
        ' 
        txtInput.FormattingEnabled = True
        txtInput.ItemHeight = 25
        txtInput.Location = New Point(345, 160)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(261, 129)
        txtInput.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radBlue)
        GroupBox1.Controls.Add(radUpper)
        GroupBox1.Controls.Add(radPurple)
        GroupBox1.Controls.Add(radLower)
        GroupBox1.Location = New Point(12, 160)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 158)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' radBlue
        ' 
        radBlue.AutoSize = True
        radBlue.Location = New Point(6, 100)
        radBlue.Name = "radBlue"
        radBlue.Size = New Size(70, 29)
        radBlue.TabIndex = 0
        radBlue.TabStop = True
        radBlue.Text = "Blue"
        radBlue.UseVisualStyleBackColor = True
        ' 
        ' radUpper
        ' 
        radUpper.AutoSize = True
        radUpper.Location = New Point(6, 65)
        radUpper.Name = "radUpper"
        radUpper.Size = New Size(104, 29)
        radUpper.TabIndex = 0
        radUpper.TabStop = True
        radUpper.Text = "ToUpper"
        radUpper.UseVisualStyleBackColor = True
        ' 
        ' radPurple
        ' 
        radPurple.AutoSize = True
        radPurple.Location = New Point(6, 129)
        radPurple.Name = "radPurple"
        radPurple.Size = New Size(87, 29)
        radPurple.TabIndex = 0
        radPurple.TabStop = True
        radPurple.Text = "Purple"
        radPurple.UseVisualStyleBackColor = True
        ' 
        ' radLower
        ' 
        radLower.AutoSize = True
        radLower.Location = New Point(6, 30)
        radLower.Name = "radLower"
        radLower.Size = New Size(102, 29)
        radLower.TabIndex = 0
        radLower.TabStop = True
        radLower.Text = "ToLower"
        radLower.UseVisualStyleBackColor = True
        ' 
        ' lstWords
        ' 
        lstWords.AutoSize = True
        lstWords.Location = New Point(352, 52)
        lstWords.Name = "lstWords"
        lstWords.Size = New Size(64, 25)
        lstWords.TabIndex = 5
        lstWords.Text = "Words"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstWords)
        Controls.Add(GroupBox1)
        Controls.Add(txtInput)
        Controls.Add(TextBox1)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtInput As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radUpper As RadioButton
    Friend WithEvents radPurple As RadioButton
    Friend WithEvents radLower As RadioButton
    Friend WithEvents lstWords As Label
End Class
