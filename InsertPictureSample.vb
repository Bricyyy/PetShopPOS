Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class InsertPictureSample
    ReadOnly opf As New OpenFileDialog With {
        .Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
    }

    Private Sub InsertPictureSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"
    End Sub

    Private Sub setPicture_MouseEnter(sender As Object, e As EventArgs) Handles setPicture.MouseEnter
        setPicture.Text = "Set Picture"
    End Sub

    Private Sub setPicture_MouseLeave(sender As Object, e As EventArgs) Handles setPicture.MouseLeave
        setPicture.Text = ""
    End Sub

    Private Sub setPicture_Click(sender As Object, e As EventArgs) Handles setPicture.Click

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
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
        End If

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        Dim originalImage = Image.FromFile(opf.FileName)

        Dim filesize As UInt32

        Dim mstream As New System.IO.MemoryStream
        originalImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrimage() As Byte = mstream.GetBuffer
        filesize = mstream.Length
        mstream.Close()

        Try
            sql = "UPDATE userProfile SET userPic = @pic WHERE uEmail = @email"
            With cmd
                .Parameters.Add("@pic", MySqlDbType.Blob).Value = arrimage
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text
            End With
            connect()
            MessageBox.Show("Image Inserted")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class