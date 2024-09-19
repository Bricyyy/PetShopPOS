Public Class AlreadyExist

    Public Property passEmail As String
    Public Property passUsername As String

    Private Sub showPicture()
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

    Private Sub AlreadyExist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        lblEmail.Text = passEmail
        lblUname.Text = passUsername

        showPicture()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim obj As New Login
        obj.signupPanel.Visible = True
        obj.loginPanel.Visible = False
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim obj As New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblReset_Click(sender As Object, e As EventArgs) Handles lblReset.Click
        Dim obj As New forgotPassForm
        obj.emailReset.Text = passEmail
        obj.emailReset.Enabled = False
        obj.Show()
        Me.Hide()
    End Sub
End Class