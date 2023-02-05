Public Class PasswordChecker

    ' Simple Password Checker 1.0
    'Provided for non-commercial use. Please refer to Github Repo for more information. 
    'Contact: Sherman_tan@outlook.com
    '(C) Tan Wei Qiang Sherman. 

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        ' Reset all checkers before using
        chkEightChar.Checked = False
        chkNumber.Checked = False
        chkSpecialChar.Checked = False
        chkUpper.Checked = False
        chkCommonPassword.Checked = False

        Dim userinput As String
        Dim lengthcount As Integer
        Dim commonList As New ArrayList 'Loads top 10 Most Common Passwords of 2022
        commonList.Add("password")
        commonList.Add("123456")
        commonList.Add("123456789")
        commonList.Add("guest")
        commonList.Add("qwerty")
        commonList.Add("12345678")
        commonList.Add("111111")
        commonList.Add("12345")
        commonList.Add("12345")
        commonList.Add("123123")

        userinput = txtInput.Text.ToString 'Stores user inputs

        For Each item As String In commonList 'Search if password is common
            If (userinput = item) Then
                chkCommonPassword.Checked = True
            End If
        Next

        ' Triggers everytimes user click on button
        lengthcount = Len(userinput) 'Get length of user password
        If lengthcount >= 8 Then
            chkEightChar.Checked = True
        End If

        For Each c As Char In userinput 'reads each input
            If (c = "A" Or c = "B" Or c = "C" Or c = "D" Or c = "E" Or c = "F" Or c = "G" Or c = "H" Or c = "I" Or c = "J" Or c = "K" Or c = "L" Or c = "M" Or c = "N" Or c = "O" Or c = "P" Or c = "Q" Or c = "R" Or c = "S" Or c = "T" Or c = "U" Or c = "V" Or c = "W" Or c = "X" Or c = "Y" Or c = "Z") Then
                chkUpper.Checked = True
            ElseIf (c = "1" Or c = "2" Or c = "3" Or c = "4" Or c = "5" Or c = "6" Or c = "7" Or c = "8" Or c = "9" Or c = "0") Then
                chkNumber.Checked = True
            ElseIf (c = "!" Or c = "@" Or c = "#" Or c = "$" Or c = "%" Or c = "^" Or c = "&" Or c = "*" Or c = "(" Or c = ")") Then
                chkSpecialChar.Checked = True
            Else
                'Skip Char as its small characters
            End If
        Next
        lblOutput.Text = "Compute completed. Please see results."

    End Sub
End Class
