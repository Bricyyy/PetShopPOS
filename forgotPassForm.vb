Imports System.Net
Imports System.Net.Mail

Public Class forgotPassForm
    Dim randomCode As String
    Public Property passedValue As Boolean = False

    Public Shared toUser As String

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim obj As New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub createNewAcc_Click(sender As Object, e As EventArgs) Handles createNewAcc.Click
        Dim obj As New Login
        obj.signupPanel.Visible = True
        obj.loginPanel.Visible = False
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles emailReset.TextChanged
        txtError.Visible = False

        txtError.Visible = False
        If emailReset.Text = Nothing Then
            btnSend.Enabled = False
        Else
            btnSend.Enabled = True
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        sendCode()
    End Sub

    Private Sub sendCode()
        If IsValidEmailFormat(emailReset.Text) Then
            emailCheck()
        Else
            txtError.Visible = True
            txtError.Text = "Please enter a valid email address!"
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        verifyCode()
    End Sub

    Private Sub verifyCode()
        If passedValue = True Then
            If (txtCode.Text.Equals(randomCode)) Then
                Dim obj As New ResetPass With {
                    .passEmail = emailReset.Text,
                    .passValue = passedValue
                }
                obj.btnLogin.Text = "Done"
                obj.Show()
                Me.Hide()
            Else
                txtCodeCheck.Visible = True
                txtCodeCheck.Text = "Invalid Code!"
            End If
        Else
            If (txtCode.Text.Equals(randomCode)) Then
                Dim obj As New ResetPass With {
                    .passEmail = emailReset.Text
                }
                obj.Show()
                Me.Hide()
            Else
                txtCodeCheck.Visible = True
                txtCodeCheck.Text = "Invalid Code!"
            End If
        End If
    End Sub

    Public Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function

    Private Sub emailCheck()
        sql = "SELECT * FROM userProfile WHERE uEmail = '" & emailReset.Text & "'"
        connect()

        If dr.Read Then
            Dim from, pass, messageBody As String
            Dim rand As New Random()
            randomCode = (rand.Next(999999)).ToString()
            Dim message As New MailMessage()
            toUser = emailReset.Text
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

                sendPanel.Hide()
                verifyPanel.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            txtError.Visible = True
            txtError.Text = "Email is not found!"
        End If
        conn.Close()
    End Sub

    Private Sub forgotPassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"
        txtCode.MaxLength = 6
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        txtCodeCheck.Visible = False

        If txtCode.Text = Nothing Then
            btnVerify.Enabled = False
        Else
            btnVerify.Enabled = True
        End If
    End Sub

    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub emailReset_KeyDown(sender As Object, e As KeyEventArgs) Handles emailReset.KeyDown
        If e.KeyCode = Keys.Enter Then
            sendCode()
        End If
    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            verifyCode()
        End If
    End Sub
End Class