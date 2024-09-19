Imports System.Net
Imports System.Net.Mail

Public Class Signup
    Private TargetDT As DateTime
    Private tDateTime As DateTime
    Private CountDownFrom As TimeSpan = TimeSpan.FromSeconds(60)
    Private stopWatch As TimeSpan = TimeSpan.FromSeconds(7)

    Dim randCode As String
    Dim toUser As String

    Private ReadOnly key() As Byte = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
    Private ReadOnly iv() As Byte = {10, 9, 8, 7, 6, 5, 4, 3}
    Dim des As New PassEnCDeC(key, iv)

    Public Property sentCode As String
    Public Property passEmail As String

    Private Sub insertData()
        Try
            sql = "INSERT INTO userProfile (uName, uNCount, uEmail, uPass) VALUES ('" & txtUsername.Text & "', '" & "0" & "' , '" & passEmail & "','" & des.Encrypt(txtPass.Text) & "')"
            connect()
            conn.Close()

            arrow2.Image = My.Resources.arrowcolored
            picCheck.Image = My.Resources.checkcolored
            lblDone.ForeColor = Color.FromArgb(190, 65, 109)
            pnlCreate.Visible = False
            pnlDone.Visible = True
            timerRedirect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Private Function usernameCheck(ByVal uname As String) As Boolean
        Dim usernameExist As Boolean = False

        Try
            sql = "SELECT * FROM userProfile WHERE uName = '" & txtUsername.Text & "'"
            connect()

            If dr.Read Then
                lblError.Visible = True
                lblError.Text = "Username already exist!"
                usernameExist = True
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return usernameExist
    End Function

    Private Sub sendCode()
        Dim from, pass, messageBody As String
        Dim rand As New Random()
        randCode = (rand.Next(999999)).ToString()
        Dim message As New MailMessage()
        toUser = passEmail
        from = "trialkoito4@gmail.com"
        pass = "broxxedasqosbrvy"
        messageBody = "Your Verification Code is: " + randCode
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

            sentCode = randCode
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub timerStarter()
        tmrResend.Start()
        tmrResend.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)
    End Sub

    Private Sub timerRedirect()
        tmrRedirect.Start()
        tmrRedirect.Interval = 100
        tDateTime = DateTime.Now.Add(stopWatch)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim obj As New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        txtCode.MaxLength = 6
        lblEmail.Text = passEmail
        lblDEmail.Text = passEmail
        timerStarter()
    End Sub

    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If txtCode.Text.Equals(sentCode) Then
            arrow1.Image = My.Resources.arrowcolored
            pic2.Image = My.Resources.colored
            lblCreate.ForeColor = Color.FromArgb(190, 65, 109)

            pnlVerify.Visible = False
            pnlCreate.Visible = True
        Else
            lblCodeError.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrResend.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 1 Then
            lblTimer.Text = "Please wait " & ts.ToString("ss") & " seconds to resend."
        Else
            tmrResend.Stop()
            lblTimer.Visible = False
            lblQuestion.Visible = True
            lblResend.Visible = True
        End If
    End Sub

    Private Sub lblResend_Click(sender As Object, e As EventArgs) Handles lblResend.Click
        sendCode()
        timerStarter()
        lblTimer.Visible = True
        lblQuestion.Visible = False
        lblResend.Visible = False
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        lblError.Visible = False

        lblUsername.Visible = True
        If txtUsername.Text = Nothing Then
            lblUsername.Visible = False
        End If
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        lblError.Visible = False

        lblPass.Visible = True
        If txtPass.Text = Nothing Then
            lblPass.Visible = False
        End If
    End Sub

    Private Sub txtCPass_TextChanged(sender As Object, e As EventArgs) Handles txtCPass.TextChanged
        lblError.Visible = False

        lblCPass.Visible = True
        If txtCPass.Text = Nothing Then
            lblCPass.Visible = False
        End If
    End Sub

    Private Sub showPass_CheckedChanged(sender As Object, e As EventArgs) Handles showPass.CheckedChanged
        If showPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub showCPass_CheckedChanged(sender As Object, e As EventArgs) Handles showCPass.CheckedChanged
        If showCPass.Checked = True Then
            txtCPass.UseSystemPasswordChar = False
        Else
            txtCPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        lblCodeError.Visible = False

        If txtCode.TextLength = 6 Then
            btnVerify.Enabled = True
        Else
            btnVerify.Enabled = False
        End If
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        lblError.Location = New Point(86, 254)

        If txtUsername.Text = Nothing Or txtPass.Text = Nothing Or txtCPass.Text = Nothing Then
            lblError.Visible = True
            lblError.Text = "Please fill out the form!"
        ElseIf txtUsername.Text.Contains(" ") Then
            lblError.Visible = True
            lblError.Text = "Username should not contain spaces!"
        ElseIf txtPass.TextLength < 8 Then
            lblError.Visible = True
            lblError.Text = "Password should be at least 8 characters long!"
        Else
            If txtPass.Text.Equals(txtCPass.Text) Then
                If Not usernameCheck(txtUsername.Text) Then
                    If ValidatePassword(txtPass.Text) Then
                        insertData()
                    Else
                        lblError.Visible = True
                        lblError.Location = New Point(15, 254)
                        lblError.Text = "Password must contain at least 1 Uppercase, 1 Number, and 1 Special!"
                    End If
                End If
            Else
                lblError.Visible = True
                lblError.Text = "Password does not match!"
            End If
        End If
    End Sub

    Private Sub tmrRedirect_Tick(sender As Object, e As EventArgs) Handles tmrRedirect.Tick
        Dim ts As TimeSpan = tDateTime.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 1 Then
            lblRedirect.Text = "You will be redirected to Login in " & ts.ToString("ss") & " seconds."
        Else
            tmrRedirect.Stop()
            Dim obj As New Login
            obj.signupPanel.Visible = False
            obj.loginPanel.Visible = True
            obj.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim obj As New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        pnlCreate.Visible = False
        pnlVerify.Visible = True
        txtCode.Text = ""

        pic2.Image = My.Resources.circle2
        arrow1.Image = My.Resources.arrowgray
        lblCreate.ForeColor = SystemColors.ActiveBorder
        timerStarter()
    End Sub
End Class