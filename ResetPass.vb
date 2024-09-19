Public Class ResetPass
    Public Property passEmail As String
    Public Property passValue As Boolean = False

    Private ReadOnly key() As Byte = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
    Private ReadOnly iv() As Byte = {10, 9, 8, 7, 6, 5, 4, 3}
    Dim des As New PassEnCDeC(key, iv)

    Private Sub ResetPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        If passValue = True Then
            btnBack.Visible = False
        End If
    End Sub

    Private Sub clearFields()
        If txtNewPass.TextLength < 8 Or txtConfirmPass.TextLength < 8 Then
            txtNewPass.Text = ""
            txtConfirmPass.Text = ""
        ElseIf txtNewPass.Text <> txtConfirmPass.Text Then
            txtNewPass.Text = ""
            txtConfirmPass.Text = ""
        ElseIf Not ValidatePassword(txtNewPass.Text) Then
            txtNewPass.Text = ""
            txtConfirmPass.Text = ""
        End If
    End Sub

    Private Function fieldsChecker() As Boolean
        lblError.Location = New Point(14, 210)

        If txtNewPass.Text = Nothing Or txtConfirmPass.Text = Nothing Then
            lblError.Visible = True
            lblError.Text = "Password is invalid!"
            Return False
        ElseIf txtNewPass.TextLength < 8 Or txtConfirmPass.TextLength < 8 Then
            lblError.Visible = True
            lblError.Text = "Password should be more than 8 characters!"
            Return False
        ElseIf txtNewPass.Text <> txtConfirmPass.Text Then
            lblError.Visible = True
            lblError.Text = "Password does not match!"
            Return False
        ElseIf Not ValidatePassword(txtNewPass.Text) Then
            lblError.Visible = True
            lblError.Location = New Point(3, 210)
            lblError.Text = "Password must contain 1 Upper, Number, and Special!"
            Return False
        Else
            Return True
        End If
    End Function

    Function ValidatePassword(ByVal pwd As String,
        Optional ByVal minLength As Integer = 8,
        Optional ByVal numUpper As Integer = 1,
        Optional ByVal numLower As Integer = 5,
        Optional ByVal numNumbers As Integer = 1,
        Optional ByVal numSpecial As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Private Sub NewPassword()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "UPDATE userProfile SET uPass = '" & des.Encrypt(txtNewPass.Text) & "' WHERE uEmail = '" & passEmail & "'"
            connect()

            dr.Close()

            If cmd.ExecuteNonQuery > 0 Then
                donePanel.Visible = True
                resetPanel.Hide()
                donePanel.Show()
                dogPic.Visible = True
                btnBack.Visible = False
            Else
                MessageBox.Show("Error!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If fieldsChecker() Then
            NewPassword()
        End If
    End Sub

    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        lblError.Visible = False

        lblNewPass.Visible = True
        If txtNewPass.Text = Nothing Then
            lblNewPass.Visible = False
        End If
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        lblError.Visible = False

        lblConfirmPass.Visible = True
        If txtConfirmPass.Text = Nothing Then
            lblConfirmPass.Visible = False
        End If
    End Sub

    Private Sub Guna2ImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles newPass.CheckedChanged
        If newPass.Checked = True Then
            txtNewPass.UseSystemPasswordChar = False
        Else
            txtNewPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub confirmPass_CheckedChanged(sender As Object, e As EventArgs) Handles confirmPass.CheckedChanged
        If confirmPass.Checked = True Then
            txtConfirmPass.UseSystemPasswordChar = False
        Else
            txtConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If passValue = True Then
            Me.Close()
        Else
            Dim obj As New Login
            obj.signupPanel.Visible = False
            obj.loginPanel.Visible = True
            obj.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim obj As New Login
        obj.Show()
        Me.Hide()
    End Sub
End Class