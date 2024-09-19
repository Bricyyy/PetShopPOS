Public Class Settings
    Public Shared toEmail As String
    Public Shared ToUserName As String

    Public Property passEmail As String
    Public Property passUsername As String

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toEmail = passEmail
        ToUserName = passUsername

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        lblUsername.Text = passUsername
        getProfilePic()

        btnAccount.Image = My.Resources.iconPersonColored
        btnAccount.ForeColor = Color.FromArgb(255, 152, 19)
        btnAccount.FillColor = Color.FromArgb(255, 240, 220)

        Dim obj1 As New MyAccount With {
            .passEmail = toEmail,
            .passUsername = ToUserName,
            .TopLevel = False
        }
        pnlSettingsMain.Controls.Add(obj1)
        obj1.Dock = DockStyle.Fill
        obj1.Show()
    End Sub

    Public Sub getProfilePic()
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

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        pnlSettingsMain.Controls.Clear()
        Dim obj1 As New MyAccount With {
            .passEmail = toEmail,
            .passUsername = ToUserName,
            .TopLevel = False
        }
        pnlSettingsMain.Controls.Add(obj1)
        obj1.Dock = DockStyle.Fill
        obj1.Show()

        btnAccount.Image = My.Resources.iconPersonColored
        btnAccount.ForeColor = Color.FromArgb(255, 152, 19)
        btnAccount.FillColor = Color.FromArgb(255, 240, 220)

        btnAddress.Image = My.Resources.addressIconBlack
        btnAddress.ForeColor = Color.Black
        btnAddress.FillColor = Color.White
        btnSecurity.Image = My.Resources.securityIconBlack
        btnSecurity.ForeColor = Color.Black
        btnSecurity.FillColor = Color.White
    End Sub

    Private Sub btnAddress_Click(sender As Object, e As EventArgs) Handles btnAddress.Click
        pnlSettingsMain.Controls.Clear()
        Dim obj1 As New MyAddress With {
            .passEmail = toEmail,
            .passUsername = ToUserName,
            .TopLevel = False
        }
        pnlSettingsMain.Controls.Add(obj1)
        obj1.Dock = DockStyle.Fill
        obj1.Show()

        btnAddress.Image = My.Resources.addressIconColored
        btnAddress.ForeColor = Color.FromArgb(255, 152, 19)
        btnAddress.FillColor = Color.FromArgb(255, 240, 220)

        btnAccount.Image = My.Resources.personIconBlack
        btnAccount.ForeColor = Color.Black
        btnAccount.FillColor = Color.White
        btnSecurity.Image = My.Resources.securityIconBlack
        btnSecurity.ForeColor = Color.Black
        btnSecurity.FillColor = Color.White
    End Sub

    Private Sub btnSecurity_Click(sender As Object, e As EventArgs) Handles btnSecurity.Click
        pnlSettingsMain.Controls.Clear()
        Dim obj1 As New ChangePassword With {
            .passEmail = toEmail,
            .passUsername = ToUserName,
            .TopLevel = False
        }
        pnlSettingsMain.Controls.Add(obj1)
        obj1.Dock = DockStyle.Fill
        obj1.Show()

        btnSecurity.Image = My.Resources.securityIconColored
        btnSecurity.ForeColor = Color.FromArgb(255, 152, 19)
        btnSecurity.FillColor = Color.FromArgb(255, 240, 220)

        btnAccount.Image = My.Resources.personIconBlack
        btnAccount.ForeColor = Color.Black
        btnAccount.FillColor = Color.White
        btnAddress.Image = My.Resources.addressIconBlack
        btnAddress.ForeColor = Color.Black
        btnAddress.FillColor = Color.White
    End Sub
End Class