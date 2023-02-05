<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordChecker
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkUpper = New System.Windows.Forms.CheckBox()
        Me.chkNumber = New System.Windows.Forms.CheckBox()
        Me.chkSpecialChar = New System.Windows.Forms.CheckBox()
        Me.chkEightChar = New System.Windows.Forms.CheckBox()
        Me.chkCommonPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password"
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(204, 288)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(75, 23)
        Me.btnVerify.TabIndex = 2
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(183, 66)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtInput.Size = New System.Drawing.Size(153, 22)
        Me.txtInput.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(120, 268)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(240, 17)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = "Click ""Verify"" to check your password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(388, 34)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Check your passwords against common unscured password " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "practice or leaked passwo" &
    "rds."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkUpper
        '
        Me.chkUpper.AutoSize = True
        Me.chkUpper.Enabled = False
        Me.chkUpper.Location = New System.Drawing.Point(107, 112)
        Me.chkUpper.Name = "chkUpper"
        Me.chkUpper.Size = New System.Drawing.Size(156, 21)
        Me.chkUpper.TabIndex = 9
        Me.chkUpper.Text = "Contains uppercase"
        Me.chkUpper.UseVisualStyleBackColor = True
        '
        'chkNumber
        '
        Me.chkNumber.AutoSize = True
        Me.chkNumber.Enabled = False
        Me.chkNumber.Location = New System.Drawing.Point(107, 139)
        Me.chkNumber.Name = "chkNumber"
        Me.chkNumber.Size = New System.Drawing.Size(144, 21)
        Me.chkNumber.TabIndex = 10
        Me.chkNumber.Text = "Contains numbers"
        Me.chkNumber.UseVisualStyleBackColor = True
        '
        'chkSpecialChar
        '
        Me.chkSpecialChar.AutoSize = True
        Me.chkSpecialChar.Enabled = False
        Me.chkSpecialChar.Location = New System.Drawing.Point(107, 166)
        Me.chkSpecialChar.Name = "chkSpecialChar"
        Me.chkSpecialChar.Size = New System.Drawing.Size(204, 21)
        Me.chkSpecialChar.TabIndex = 11
        Me.chkSpecialChar.Text = "Contains special characters"
        Me.chkSpecialChar.UseVisualStyleBackColor = True
        '
        'chkEightChar
        '
        Me.chkEightChar.AutoSize = True
        Me.chkEightChar.Enabled = False
        Me.chkEightChar.Location = New System.Drawing.Point(107, 193)
        Me.chkEightChar.Name = "chkEightChar"
        Me.chkEightChar.Size = New System.Drawing.Size(218, 21)
        Me.chkEightChar.TabIndex = 12
        Me.chkEightChar.Text = "Contains 8 characters at least"
        Me.chkEightChar.UseVisualStyleBackColor = True
        '
        'chkCommonPassword
        '
        Me.chkCommonPassword.AutoSize = True
        Me.chkCommonPassword.Enabled = False
        Me.chkCommonPassword.Location = New System.Drawing.Point(107, 220)
        Me.chkCommonPassword.Name = "chkCommonPassword"
        Me.chkCommonPassword.Size = New System.Drawing.Size(235, 21)
        Me.chkCommonPassword.TabIndex = 13
        Me.chkCommonPassword.Text = "Found in common password list?"
        Me.chkCommonPassword.UseVisualStyleBackColor = True
        '
        'PasswordChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 325)
        Me.Controls.Add(Me.chkCommonPassword)
        Me.Controls.Add(Me.chkEightChar)
        Me.Controls.Add(Me.chkSpecialChar)
        Me.Controls.Add(Me.chkNumber)
        Me.Controls.Add(Me.chkUpper)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PasswordChecker"
        Me.Text = "Simple Password Checker 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnVerify As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkUpper As CheckBox
    Friend WithEvents chkNumber As CheckBox
    Friend WithEvents chkSpecialChar As CheckBox
    Friend WithEvents chkEightChar As CheckBox
    Friend WithEvents chkCommonPassword As CheckBox
End Class
