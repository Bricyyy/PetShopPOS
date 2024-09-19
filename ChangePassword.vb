Public Class ChangePassword
    Public Property passEmail As String
    Public Property passUsername As String

    Private ReadOnly key() As Byte = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
    Private ReadOnly iv() As Byte = {10, 9, 8, 7, 6, 5, 4, 3}
    Dim des As New PassEnCDeC(key, iv)

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.userRememberMe = True Then
            passEmail = My.Settings.userEmail
            passUsername = My.Settings.userPassword
        End If

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        Try
            sql = "SELECT * FROM userProfile WHERE uEmail = '" & passEmail & "'"
            connect()

            If dr.Read Then
                lblUsername.Text = dr.GetValue(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        getProfilePic()
    End Sub

    Private Sub getProfilePic()
        Dim arrimage() As Byte

        Try
            sql = "SELECT userPic FROM userProfile WHERE uEmail = '" & passEmail & "'"
            connect()

            If dr.Read Then
                arrimage = dr.Item("userPic")
                Dim mstream As New System.IO.MemoryStream(arrimage)
                picProfile.Image = System.Drawing.Image.FromStream(mstream)
            ElseIf dr.IsDBNull(4) Then
                conn.Close()
            End If
        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub

    'Private Sub fieldsChecker()
    '    If Not txtOldPass.Text.Equals("") And Not txtNewPass.Text.Equals("") And Not txtConfirmNewPass.Text.Equals("") Then
    '        btnChange.Enabled = True
    '    Else
    '        btnChange.Enabled = False
    '    End If
    'End Sub

    'Private Sub changePass()
    '    If conn.State = ConnectionState.Open Then
    '        conn.Close()
    '    End If

    '    Try
    '        sql = "SELECT * FROM userProfile WHERE uEmail = '" & passEmail & "'"
    '        connect()

    '        If dr.Read Then
    '            Dim pass As String = des.Decrypt(dr.GetString("uPass").ToString)
    '            If txtOldPass.Text.Equals(pass) Then
    '                If txtNewPass.Text.Equals(txtConfirmNewPass.Text) Then
    '                    If Not txtNewPass.Text.Length < 8 Or txtConfirmNewPass.Text.Length < 8 Then
    '                        lblPassChecker.Location = New Point(207, 422)

    '                        If ValidatePassword(txtNewPass.Text) Then
    '                            If conn.State = ConnectionState.Open Then
    '                                conn.Close()
    '                            End If

    '                            sql = "UPDATE userProfile SET uPass = '" & des.Encrypt(txtNewPass.Text) & "' WHERE uEmail = '" & passEmail & "'"
    '                            connect()

    '                            dr.Close()

    '                            If cmd.ExecuteNonQuery Then
    '                                SavedConfirmation.Show()
    '                            End If
    '                        Else
    '                            lblPassChecker.Visible = True
    '                            lblPassChecker.Text = "Password must contain at least 1 Uppercase, 1 Number, and 1 Special!"
    '                        End If
    '                    Else
    '                        lblPassChecker.Visible = True
    '                        lblPassChecker.Text = "Password must be at least 8 characters."
    '                    End If
    '                Else
    '                    lblPassChecker.Visible = True
    '                    lblPassChecker.Text = "Password does not match."
    '                End If
    '            Else
    '                lblPassChecker.Visible = True
    '                lblPassChecker.Text = "Current password is incorrect"
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    conn.Close()
    'End Sub

    Private Function fieldsChecker() As Boolean
        lblPassChecker.Location = New Point(207, 422)

        If txtNewPass.Text = Nothing Or txtConfirmNewPass.Text = Nothing Or txtOldPass.Text = Nothing Then
            lblPassChecker.Visible = True
            lblPassChecker.Text = "Password is invalid!"
            Return False
        ElseIf txtNewPass.TextLength < 8 Or txtConfirmNewPass.TextLength < 8 Then
            lblPassChecker.Visible = True
            lblPassChecker.Text = "Password should be more than 8 characters!"
            Return False
        ElseIf txtNewPass.Text <> txtConfirmNewPass.Text Then
            lblPassChecker.Visible = True
            lblPassChecker.Text = "Password does not match!"
            Return False
        ElseIf Not ValidatePassword(txtNewPass.Text) Then
            lblPassChecker.Visible = True
            lblPassChecker.Location = New Point(119, 422)
            lblPassChecker.Text = "Password must contain at least 1 Uppercase, 1 Number, and 1 Special!"
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub changePass()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userProfile WHERE uEmail = '" & passEmail & "'"
            connect()

            If dr.Read Then
                Dim pass As String = des.Decrypt(dr.GetString("uPass").ToString)

                If txtOldPass.Text.Equals(pass) Then
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If

                    sql = "UPDATE userProfile SET uPass = '" & des.Encrypt(txtNewPass.Text) & "' WHERE uEmail = '" & passEmail & "'"
                    connect()

                    dr.Close()

                    If cmd.ExecuteNonQuery Then
                        SavedConfirmation.Show()
                    End If
                Else
                    lblPassChecker.Visible = True
                    lblPassChecker.Text = "Current password is incorrect"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

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

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If fieldsChecker() Then
            changePass()
        End If
    End Sub

    Private Sub txtOldPass_TextChanged(sender As Object, e As EventArgs) Handles txtOldPass.TextChanged
        lblPassChecker.Visible = False
    End Sub

    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        lblPassChecker.Visible = False
    End Sub

    Private Sub txtConfirmNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmNewPass.TextChanged
        lblPassChecker.Visible = False
    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        txtOldPass.Text = ""
        txtNewPass.Text = ""
        txtConfirmNewPass.Text = ""
        lblPassChecker.Visible = False

        Dim obj As New forgotPassForm With {
            .Size = New Size(370, 400)
        }
        obj.emailReset.Text = passEmail
        obj.emailReset.Enabled = False
        obj.passedValue = True
        obj.Show()
    End Sub
End Class