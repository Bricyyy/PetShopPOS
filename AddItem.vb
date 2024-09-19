Imports MySql.Data.MySqlClient

Public Class AddItem
    Dim flag As Integer = 0

    Public Property passItemCategory As String
    Public Property checker As Boolean = False
    Public Property itemID As String

    ReadOnly opf As New OpenFileDialog With {
        .Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
    }

    Private Const CS_DROPSHADOW As Integer = 131072

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub ManageItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        If checker = True Then
            setFields()
            lblItems.Text = "Edit Product"
        End If
    End Sub

    Private Function isProductExist(ByVal item As String) As Boolean
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            If checker = True Then
                sql = "SELECT * FROM storeItems WHERE prodName = '" & item & "' AND sID <> '" & itemID & "'"
                connect()
            Else
                sql = "SELECT * FROM storeItems WHERE prodName = '" & item & "'"
                connect()
            End If

            If dr.Read Then
                lblChecker.Visible = True
                lblChecker.Text = "An item with this name already exist!"

                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        Return False
    End Function

    Private Sub setFields()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM storeItems WHERE sID = '" & itemID & "'"
            connect()

            If dr.Read Then
                Dim arrimage() As Byte = dr.Item("prodPic")
                Dim mstream As New System.IO.MemoryStream(arrimage)
                itemPicture.Image = System.Drawing.Image.FromStream(mstream)

                txtItemName.Text = dr.GetString("prodName").ToString
                txtItemPrice.Text = dr.GetString("prodPrice").ToString
                txtItemQuantity.Text = dr.GetString("prodAvail").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub updateItem()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            Dim arrimage1() As Byte
            Dim originalImage = itemPicture.Image
            Dim mstream1 As New System.IO.MemoryStream
            originalImage.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage1 = mstream1.GetBuffer
            mstream1.Close()

            Dim itemCat As String = passItemCategory
            Dim itemName As String = txtItemName.Text
            Dim itemPrice As String = txtItemPrice.Text
            Dim itemCount As String = txtItemQuantity.Text

            sql = "UPDATE storeItems SET prodPic = @prodPic, prodName = @prodName, prodPrice = @prodPrice, prodAvail = @prodAvail WHERE sID = '" & itemID & "'"
            With cmd
                .Parameters.Clear()
                .Parameters.Add("@prodPic", MySqlDbType.Blob).Value = arrimage1
                .Parameters.Add("@prodCat", MySqlDbType.VarChar).Value = itemCat
                .Parameters.Add("@prodName", MySqlDbType.VarChar).Value = itemName
                .Parameters.Add("@prodPrice", MySqlDbType.VarChar).Value = itemPrice
                .Parameters.Add("@prodAvail", MySqlDbType.VarChar).Value = itemCount
            End With
            connect()

            dr.Close()

            If cmd.ExecuteNonQuery Then
                Me.Close()
                Dim obj1 As New SavedConfirmation
                obj1.ItemAddedConfirmation = "Item Updated Succesfully!"
                obj1.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub insertNewItem()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            Dim arrimage1() As Byte
            Dim originalImage = itemPicture.Image
            Dim mstream1 As New System.IO.MemoryStream
            originalImage.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage1 = mstream1.GetBuffer
            mstream1.Close()

            Dim itemCat As String = passItemCategory
            Dim itemName As String = txtItemName.Text
            Dim itemPrice As String = txtItemPrice.Text
            Dim itemCount As String = txtItemQuantity.Text

            sql = "INSERT INTO storeItems (prodPic, prodCat, prodName, prodPrice, prodAvail) VALUES (@prodPic, @prodCat, @prodName, @prodPrice, @prodAvail)"
            With cmd
                .Parameters.Clear()
                .Parameters.Add("@prodPic", MySqlDbType.Blob).Value = arrimage1
                .Parameters.Add("@prodCat", MySqlDbType.VarChar).Value = itemCat
                .Parameters.Add("@prodName", MySqlDbType.VarChar).Value = itemName
                .Parameters.Add("@prodPrice", MySqlDbType.VarChar).Value = itemPrice
                .Parameters.Add("@prodAvail", MySqlDbType.VarChar).Value = itemCount
            End With
            connect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub setItemPic()
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            flag = 1
            Dim originalImage = Image.FromFile(opf.FileName)
            itemPicture.Image = originalImage
        End If
    End Sub

    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If checker = True Then
            flag = 1
        End If

        If txtItemName.Text = Nothing Or txtItemPrice.Text = Nothing Or txtItemQuantity.Text = Nothing Or flag = 0 Then
            lblChecker.Visible = True
        Else
            If Not isProductExist(txtItemName.Text) Then
                If checker = False Then
                    insertNewItem()
                    flag = 0
                Else
                    updateItem()
                    checker = False
                End If
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Private Sub setPic_Click(sender As Object, e As EventArgs) Handles itemPicture.Click
        setItemPic()
        lblChecker.Visible = False
    End Sub

    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged
        lblChecker.Visible = False
    End Sub

    Private Sub txtItemPrice_TextChanged(sender As Object, e As EventArgs) Handles txtItemPrice.TextChanged
        lblChecker.Visible = False
    End Sub

    Private Sub txtItemQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtItemQuantity.TextChanged
        lblChecker.Visible = False
    End Sub

    Private Sub txtItemPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub txtItemQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemQuantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
End Class