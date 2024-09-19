Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class MyAccount
    Dim b1 As String
    Dim a As String
    Dim b As String
    Dim c As String
    Dim setUname As String
    Dim index1 As Integer
    Dim index3 As Integer
    Dim flag As Integer

    Public Property passEmail As String
    Public Property passUsername As String

    ReadOnly opf As New OpenFileDialog With {
        .Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
    }

    Private Sub MyAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        If My.Settings.userRememberMe = True Then
            passEmail = My.Settings.userEmail
            passUsername = My.Settings.userUsername
        End If

        getProfilePic()
        setCredentials()
        userNameChangeChecker()

        Dim outputEmail As Char
        outputEmail = passEmail.Substring(0, 1)
        Dim outputEmail1 As Char
        outputEmail1 = passEmail.Substring(1, 1)
        Dim count As Integer
        count = passEmail.Length

        Dim split = passEmail.Split("@"c)
        If (split.Count = 2) Then
            b1 = split(1).ToString
        End If

        If count > 18 Then
            lblEmail.Text = outputEmail & outputEmail1 & "***********@" & b1
        Else
            lblEmail.Text = outputEmail & outputEmail1 & "******@" & b1
        End If

        txtPhoneNum.MaxLength = 11
    End Sub

    Private Sub userNameChangeChecker()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "Select * FROM userProfile WHERE uEmail = '" & passEmail & "'"
            connect()

            If dr.Read Then
                Dim count As String
                count = dr.GetInt32(2).ToString
                If count = "0" Then
                    txtUsername.Enabled = True
                Else
                    txtUsername.Enabled = False
                    lblUNInfo.Text = "You already changed your username once."
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub setCredentials()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userProfile WHERE uEmail = '" & passEmail & "'"
            connect()

            If dr.Read Then
                setUname = dr.GetString("uName")
                txtUsername.Text = setUname
                txtFullName.Text = dr.GetString("userName")
                txtPhoneNum.Text = dr.GetString("userPhone")
                If Not dr.IsDBNull(8) Then
                    If dr.GetString("userGend").Equals("Male") Then
                        btnMale.Checked = True
                    ElseIf dr.GetString("userGend").Equals("Female") Then
                        btnFemale.Checked = True
                    ElseIf dr.GetString("userGend").Equals("Other") Then
                        btnOther.Checked = True
                    Else
                        btnMale.Checked = False
                        btnFemale.Checked = False
                        btnOther.Checked = False
                    End If
                Else
                    btnMale.Checked = False
                    btnFemale.Checked = False
                    btnOther.Checked = False
                End If
                If Not dr.IsDBNull(9) Then
                    lblDate.Text = dr.GetDateTime("userBday")
                    Dim split = lblDate.Text.Split("/"c)
                    If (split.Count = 3) Then
                        a = split(0)
                        b = split(1)
                        c = split(2)
                    End If
                    index1 = cmbYear.FindString(c)
                    cmbYear.SelectedIndex = index1
                    cmbMonth.SelectedIndex = a - 1
                    index3 = cmbDate.FindString(b)
                    cmbDate.SelectedIndex = index3
                End If
            End If
        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()

        btnSave.Visible = False
        btnDiscard.Visible = False
    End Sub

    Private Sub saveCredentials()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userProfile WHERE uEmail = '" & passEmail & "'"
            connect()

            If dr.Read Then
                Dim uname = dr.GetString("uName")

                If dr.GetInt32(2) = "0" Then
                    If unameChecker(txtUsername.Text) Then
                        lblUsernameChecker.Visible = True
                        btnSave.Enabled = True
                        btnDiscard.Enabled = True
                    Else
                        If Not txtUsername.Text.Equals(uname) Then
                            If conn.State = ConnectionState.Open Then
                                conn.Close()
                            End If

                            sql = "UPDATE userProfile SET uName = '" & txtUsername.Text & "', uNCount = '" & "1" & "' WHERE uEmail = '" & passEmail & "'"
                            connect()

                            dr.Close()

                            If cmd.ExecuteNonQuery Then
                                If lblUsernameChecker.Visible = False Then
                                    SavedConfirmation.ShowDialog()
                                End If
                            End If
                        End If
                    End If
                End If

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                Dim gender As String
                If btnMale.Checked = True Then
                    gender = "Male"
                ElseIf btnFemale.Checked = True Then
                    gender = "Female"
                Else
                    gender = "Other"
                End If

                Dim bday As String
                Dim a = cmbYear.Text
                Dim b = cmbMonth.SelectedIndex + 1
                Dim c = cmbDate.Text
                bday = a & "-" & b & "-" & c

                sql = "UPDATE userProfile SET userName = '" & txtFullName.Text & "', userPhone = '" & txtPhoneNum.Text & "', userGend = '" & gender & "', userBday = '" & bday & "' WHERE uEmail = '" & passEmail & "'"
                connect()

                dr.Close()

                If cmd.ExecuteNonQuery Then
                    If Not flag = 1 Then
                        If lblUsernameChecker.Visible = False Then
                            SavedConfirmation.ShowDialog()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Function unameChecker(ByVal userName) As Boolean
        Dim usernameExist As Boolean = False

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Try
            sql = "SELECT * FROM userProfile WHERE uName = '" & userName & "'"
            connect()

            If dr.Read Then
                Dim email = dr.GetString("uEmail")
                If Not email.Equals(passEmail) Then
                    usernameExist = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Return usernameExist
    End Function

    Private Sub getProfilePic()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Dim arrimage() As Byte

        Try
            sql = "SELECT userPic FROM userProfile WHERE uEmail = '" & passEmail & "'"
            connect()

            If dr.Read Then
                arrimage = dr.Item("userPic")
                Dim mstream As New System.IO.MemoryStream(arrimage)
                setPicture.CustomImages.Image = System.Drawing.Image.FromStream(mstream)

                Dim originalImage = setPicture.CustomImages.Image
                Dim croppedImage As New Bitmap(originalImage.Width, originalImage.Height)

                Using g = Graphics.FromImage(croppedImage)
                    Dim path As New GraphicsPath

                    path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height)

                    Dim reg As New Region(path)

                    g.Clip = reg
                    g.DrawImage(originalImage, Point.Empty)
                End Using

                setPicture.CustomImages.Image = croppedImage
            ElseIf dr.IsDBNull(5) Then
                conn.Close()
            End If
        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub setProfilePic()
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            flag = 1
            Dim originalImage = Image.FromFile(opf.FileName)
            Dim croppedImage As New Bitmap(originalImage.Width, originalImage.Height)

            Using g = Graphics.FromImage(croppedImage)
                Dim path As New GraphicsPath

                path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height)

                Dim reg As New Region(path)

                g.Clip = reg
                g.DrawImage(originalImage, Point.Empty)
            End Using

            setPicture.CustomImages.Image = croppedImage

            btnSave.Visible = True
            btnDiscard.Visible = True
        End If
    End Sub

    Private Sub saveProfilePic()
        If flag = 1 Then
            Dim originalImage = Image.FromFile(opf.FileName)

            Dim filesize As UInt32

            Dim mstream As New System.IO.MemoryStream
            originalImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrimage() As Byte = mstream.GetBuffer
            filesize = mstream.Length
            mstream.Close()

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Try
                sql = "UPDATE userProfile SET userPic = @pic WHERE uEmail = @email"
                With cmd
                    .Parameters.Clear()
                    .Parameters.Add("@pic", MySqlDbType.Blob).Value = arrimage
                    .Parameters.Add("@email", MySqlDbType.VarChar).Value = passEmail
                End With
                connect()
                'SavedConfirmation.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()

            flag = 0
        End If
    End Sub

    Private Sub setPicture_Click(sender As Object, e As EventArgs) Handles setPicture.Click
        setProfilePic()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim obj As New Settings
        obj.getProfilePic()

        saveProfilePic()
        If txtUsername.Text.Contains(" ") Then
            lblUsernameChecker.Visible = True
            lblUsernameChecker.Text = "Username should not contain spaces"
        Else
            saveCredentials()
        End If
        userNameChangeChecker()

        If lblUsernameChecker.Visible = True Then
            btnSave.Visible = True
            btnDiscard.Visible = True
        Else
            btnSave.Visible = False
            btnDiscard.Visible = False
        End If
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        getProfilePic()

        btnDiscard.Visible = False
        btnSave.Visible = False

        setCredentials()
    End Sub

    Private Sub btnSelectPic_Click(sender As Object, e As EventArgs) Handles btnSelectPic.Click
        setProfilePic()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        btnSave.Visible = True
        btnDiscard.Visible = True

        lblUsernameChecker.Visible = False
    End Sub

    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        btnSave.Visible = True
        btnDiscard.Visible = True
    End Sub

    Private Sub txtPhoneNum_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNum.TextChanged
        btnSave.Visible = True
        btnDiscard.Visible = True
    End Sub

    Private Sub btnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles btnFemale.CheckedChanged
        If Not btnFemale.Checked = True Then
            btnSave.Visible = True
            btnDiscard.Visible = True
        ElseIf btnMale.Checked = False And btnOther.Checked = False Then
            btnSave.Visible = True
            btnDiscard.Visible = True
        End If
    End Sub

    Private Sub btnMale_CheckedChanged(sender As Object, e As EventArgs) Handles btnMale.CheckedChanged
        If Not btnMale.Checked = True Then
            btnSave.Visible = True
            btnDiscard.Visible = True
        ElseIf btnFemale.Checked = False And btnOther.Checked = False Then
            btnSave.Visible = True
            btnDiscard.Visible = True
        End If
    End Sub

    Private Sub btnOther_CheckedChanged(sender As Object, e As EventArgs) Handles btnOther.CheckedChanged
        If Not btnOther.Checked = True Then
            btnSave.Visible = True
            btnDiscard.Visible = True
        ElseIf btnMale.Checked = False And btnFemale.Checked = False Then
            btnSave.Visible = True
            btnDiscard.Visible = True
        End If
    End Sub

    Private Sub cmbDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDate.SelectedIndexChanged
        If Not cmbDate.SelectedIndex = index3 Then
            btnSave.Visible = True
            btnDiscard.Visible = True
        End If
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        If Not cmbMonth.SelectedIndex = a - 1 Then
            btnSave.Visible = True
            btnDiscard.Visible = True
        End If
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        If Not cmbYear.SelectedIndex = index1 Then
            btnSave.Visible = True
            btnDiscard.Visible = True
        End If
    End Sub

    Private Sub txtPhoneNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNum.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
End Class