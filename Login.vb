Imports System.ComponentModel
Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class Login
    Public Shared randomCode As String
    Public Shared toUser As String
    Public Shared sendUserName As String

    Private ReadOnly key() As Byte = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
    Private ReadOnly iv() As Byte = {10, 9, 8, 7, 6, 5, 4, 3}
    Dim des As New PassEnCDeC(key, iv)

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fadeIn()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        'If My.Settings.userRememberMe = True Then
        '    rememberMeLogin()

        '    'Dim obj As New Homepage
        '    'obj.Show()
        '    'Me.Hide()
        'End If
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub Guna2ImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles passwordShow.CheckedChanged
        If passwordShow.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub fadeIn()
        Me.Opacity = 0
        Dim tmr As New Timer With {
            .Interval = 2
        }
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Opacity += 0.1
                                 If Me.Opacity = 1 Then tmr.Stop()
                             End Sub
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        sendLogin()
    End Sub

    Public Function IsEncrypted(ByVal text As String) As Boolean
        If (String.IsNullOrEmpty(text)) Then Return False
        Return text.StartsWith("!=!enc!=!", StringComparison.InvariantCulture)
    End Function

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function

    Private Function emailChecker(ByVal email As String) As Boolean
        Dim emailExist As Boolean = False

        sql = "SELECT * FROM userProfile WHERE uEmail = '" & email & "'"
        connect()

        If dr.Read Then
            emailExist = True
        End If
        conn.Close()
        Return emailExist
    End Function

    Private Sub sendCode()
        If IsValidEmailFormat(signupEmail.Text) Then
            emailCheck()
        Else
            lblEmailChecker.Visible = True
            lblEmailChecker.Text = "Invalid email address!"
        End If
    End Sub

    Private Sub emailCheck()
        sql = "SELECT * FROM userProfile WHERE uEmail = '" & signupEmail.Text & "'"
        connect()

        If dr.Read Then
            Dim obj As New AlreadyExist With {
                .passEmail = signupEmail.Text,
                .passUsername = dr.GetValue(1)
            }
            obj.Show()
            Me.Hide()
        Else
            Dim from, pass, messageBody As String
            Dim rand As New Random()
            randomCode = (rand.Next(999999)).ToString()
            Dim message As New MailMessage()
            toUser = signupEmail.Text
            from = "trialkoito4@gmail.com"
            pass = "broxxedasqosbrvy"
            messageBody = "Your Verification Code is: " + randomCode
            message.To.Add(toUser)
            message.From = New MailAddress(from)
            message.Body = messageBody
            message.Subject = "Resetting Code"
            Dim smtp As New SmtpClient("smtp.gmail.com") With {
                .EnableSsl = True,
                .Port = 587
            }
            smtp.DeliveryMethod = smtp.DeliveryMethod.Network
            smtp.Credentials = New NetworkCredential(from, pass)
            Try
                smtp.Send(message)

                Dim obj1 As New CodeVerification
                obj1.ShowDialog()

                Dim obj As New Signup With {
                    .sentCode = randomCode,
                    .passEmail = toUser
                }
                obj.Show()
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        conn.Close()
    End Sub

    Private Sub rememberMeLogin()
        Dim email As String = My.Settings.userEmail
        Dim pass As String = My.Settings.userPassword

        Try
            sql = "SELECT * FROM userProfile WHERE uEmail = '" & email & "' AND uPass = '" & des.Decrypt(pass) & "'"
            connect()

            If dr.Read Then
                Dim obj As New Homepage
                obj.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub sendLogin()
        Try
            sql = "SELECT * FROM userProfile WHERE uEmail = '" & txtEmail.Text & "'"
            connect()

            If dr.Read Then
                Dim email As String = dr.GetString("uEmail").ToString
                Dim password As String = des.Decrypt(dr.GetString("uPass").ToString)

                'If IsEncrypted(dr.GetString("uPass").ToString) Then
                '    password = des.Decrypt(dr.GetString("uPass").ToString)
                'Else
                '    password = dr.GetString("uPass").ToString
                'End If

                If txtEmail.Text.Equals(email) And txtPassword.Text.Equals(password) Then
                    If chkRememberMe.Checked = True Then
                        My.Settings.userEmail = txtEmail.Text.ToString
                        My.Settings.userPassword = des.Encrypt(txtPassword.Text).ToString
                        My.Settings.userRememberMe = True
                        My.Settings.userUsername = dr.GetValue(1).ToString
                        My.Settings.Save()
                    Else
                        My.Settings.userEmail = ""
                        My.Settings.userPassword = ""
                        My.Settings.userRememberMe = False
                        My.Settings.userUsername = ""
                        My.Settings.Save()
                    End If

                    Dim obj As New Homepage With {
                        .emailPic = txtEmail.Text,
                        .userPic = dr.GetValue(1)
                    }
                    obj.Show()
                    Me.Hide()
                Else
                    txtPassword.Text = ""
                    lblChecker.Visible = True
                End If
            Else
                txtPassword.Text = ""
                lblChecker.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgPass.LinkClicked
        Dim obj As New forgotPassForm
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblSignup.Click
        txtEmail.Text = Nothing
        txtPassword.Text = Nothing
        signupPanel.Visible = True
        loginPanel.Visible = False
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        lblChecker.Visible = False

        lblEmail.Visible = True
        If txtEmail.Text = Nothing Then
            lblEmail.Visible = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        lblChecker.Visible = False

        lblPass.Visible = True
        If txtPassword.Text = Nothing Then
            lblPass.Visible = False
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            sendLogin()
        End If
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            sendLogin()
        End If
    End Sub

    Private Sub signupEmail_TextChanged(sender As Object, e As EventArgs) Handles signupEmail.TextChanged
        lblEmailChecker.Visible = False

        lblSmail.Visible = True
        If signupEmail.Text = Nothing Then
            lblSmail.Visible = False
        End If
    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles lblLogin.Click
        signupEmail.Text = Nothing
        signupPanel.Hide()
        loginPanel.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        sendCode()
    End Sub

    Private Sub Login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Opacity = 1
        Dim tmr As New Timer With {
            .Interval = 1
        }
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Opacity -= 0.1
                                 If Me.Opacity = 0 Then
                                     e.Cancel = False
                                     tmr.Stop()
                                     Me.Dispose()
                                 End If
                             End Sub
    End Sub

    Private Sub btnCloseProg_Click(sender As Object, e As EventArgs) Handles btnCloseProg.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class