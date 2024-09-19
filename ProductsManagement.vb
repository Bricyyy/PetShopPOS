Public Class ProductsManagement
    Private FoodsLeave As Boolean = True
    Private LeashLeave As Boolean = True
    Private ToiletriesLeave As Boolean = True
    Private MedicineLeave As Boolean = True
    Private CageLeave As Boolean = True

    Private WithEvents pnlItems As New Panel
    Private WithEvents picItem As New PictureBox
    Private WithEvents lblItem As New Label
    Private WithEvents lblPriceAvail As New Label
    Private WithEvents btnEdit As New Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnRemove As New PictureBox
    Private WithEvents picNoStock As New Guna.UI2.WinForms.Guna2PictureBox

    Private Sub ProductsManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        btnFoods.BorderColor = Color.FromArgb(255, 152, 19)
        btnFoods.ForeColor = Color.FromArgb(255, 152, 19)
        FoodsLeave = False

        flpManage.Controls.Clear()
        loadProducts("Foods")
        showItemCount("Foods")
        lblItems.Text = "Foods Category"
    End Sub

    Private Sub loadProducts(ByVal itemType As String)
        flpManage.Controls.Add(btnAddNew)

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM storeItems WHERE prodCat = '" & itemType & "' ORDER BY prodAvail ASC"
            connect()

            While dr.Read
                pnlItems = New Panel With {
                    .Width = 201,
                    .Height = 281,
                    .BackColor = Color.White,
                    .BorderStyle = BorderStyle.FixedSingle
                }

                picNoStock.BringToFront()
                picNoStock = New Guna.UI2.WinForms.Guna2PictureBox With {
                    .Width = 122,
                    .Height = 120,
                    .Location = New Point(43, 19),
                    .Image = My.Resources.outofstock,
                    .UseTransparentBackground = True,
                    .SizeMode = PictureBoxSizeMode.Normal
                }
                If CInt(dr.GetString("prodAvail").ToString) = 0 Then
                    picNoStock.Visible = True
                Else
                    picNoStock.Visible = False
                End If

                Dim len As Long = dr.GetBytes(1, 0, Nothing, 0, 0)
                Dim array(CInt(len)) As Byte
                dr.GetBytes(1, 0, array, 0, CInt(len))
                picItem = New PictureBox With {
                    .Width = 106,
                    .Height = 106,
                    .BackgroundImageLayout = ImageLayout.Zoom,
                    .Location = New Point(45, 18)
                }
                Dim ms As New System.IO.MemoryStream(array)
                Dim bitmap As New System.Drawing.Bitmap(ms)
                picItem.BackgroundImage = bitmap

                lblItem = New Label With {
                    .Text = dr.GetString("prodName").ToString,
                    .Font = New Font("Proxima Nova Rg", 11, FontStyle.Regular),
                    .Width = 133,
                    .Height = 41,
                    .ForeColor = Color.Black,
                    .BackColor = Color.Transparent,
                    .TextAlign = ContentAlignment.TopCenter,
                    .Location = New Point(32, 137)
                }

                lblPriceAvail = New Label With {
                    .Text = "₱" & dr.GetString("prodPrice").ToString & " • " & dr.GetString("prodAvail").ToString & " Available",
                    .Font = New Font("Proxima Nova Rg", 11, FontStyle.Regular),
                    .Width = 193,
                    .Height = 21,
                    .ForeColor = SystemColors.ControlDarkDark,
                    .BackColor = Color.Transparent,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Location = New Point(3, 190)
                }

                btnEdit = New Guna.UI2.WinForms.Guna2Button With {
                    .Text = "Edit Item",
                    .Font = New Font("Proxima Nova Rg", 12, FontStyle.Bold),
                    .Width = 201,
                    .Height = 53,
                    .Animated = True,
                    .UseTransparentBackground = True,
                    .FillColor = Color.PeachPuff,
                    .ForeColor = Color.FromArgb(255, 152, 19),
                    .Location = New Point(-1, 227),
                    .Image = My.Resources.EditItemIconColored,
                    .Cursor = Cursors.Hand,
                    .ImageSize = New Size(23, 23),
                    .Tag = dr.GetString("sID").ToString
                }

                btnRemove = New PictureBox With {
                    .Width = 25,
                    .Height = 30,
                    .Location = New Point(170, 5),
                    .BackgroundImage = My.Resources.trashIconBlack,
                    .BackgroundImageLayout = ImageLayout.Zoom,
                    .Cursor = Cursors.Hand,
                    .Tag = dr.GetString("sID").ToString
                }

                pnlItems.Controls.Add(picItem)
                pnlItems.Controls.Add(lblItem)
                pnlItems.Controls.Add(lblPriceAvail)
                pnlItems.Controls.Add(btnEdit)
                pnlItems.Controls.Add(btnRemove)
                pnlItems.Controls.Add(picNoStock)
                flpManage.Controls.Add(pnlItems)

                AddHandler btnEdit.Click, AddressOf btnEdit_Click
                AddHandler btnRemove.Click, AddressOf btnRemove_Click
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub showItemCount(ByVal prodType As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT COUNT(*) FROM storeItems WHERE prodCat = '" & prodType & "'"
            connect()

            If dr.Read Then
                lblItemCount.Text = dr.GetValue(0) & " Items"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub deleteItem(ByVal itemID As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "DELETE FROM storeItems WHERE sID = '" & itemID & "'"
            connect()

            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs)
        Dim obj As New DeleteConfirmation With {
            .passConfirmation = "Delete Item?"
        }
        If obj.ShowDialog = DialogResult.OK Then
            deleteItem(sender.tag.ToString)
            flpManage.Controls.Clear()
            loadAll()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        Dim obj As New AddItem With {
            .checker = True,
            .itemID = sender.tag.ToString
        }
        obj.ShowDialog()
        loadAll()
    End Sub

    Private Sub loadAll()
        flpManage.Controls.Clear()
        If btnFoods.BorderColor = Color.FromArgb(255, 152, 19) Then
            loadProducts("Foods")
            showItemCount("Foods")
        ElseIf btnLeash.BorderColor = Color.FromArgb(255, 152, 19) Then
            loadProducts("Leash")
            showItemCount("Leash")
        ElseIf btnToiletries.BorderColor = Color.FromArgb(255, 152, 19) Then
            loadProducts("Toiletries")
            showItemCount("Toiletries")
        ElseIf btnMedicine.BorderColor = Color.FromArgb(255, 152, 19) Then
            loadProducts("Medicines")
            showItemCount("Medicines")
        Else
            loadProducts("Cage")
            showItemCount("Cage")
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim obj As New AddItem
        If btnFoods.BorderColor = Color.FromArgb(255, 152, 19) Then
            obj.passItemCategory = "Foods"
        ElseIf btnLeash.BorderColor = Color.FromArgb(255, 152, 19) Then
            obj.passItemCategory = "Leash"
        ElseIf btnToiletries.BorderColor = Color.FromArgb(255, 152, 19) Then
            obj.passItemCategory = "Toiletries"
        ElseIf btnMedicine.BorderColor = Color.FromArgb(255, 152, 19) Then
            obj.passItemCategory = "Medicines"
        Else
            obj.passItemCategory = "Cage"
        End If
        If obj.ShowDialog = DialogResult.OK Then
            loadAll()
            Dim obj1 As New SavedConfirmation With {
                .ItemAddedConfirmation = "Item Added Succesfully!"
            }
            obj1.ShowDialog()
        End If
    End Sub

    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        showItemCount("Foods")
        flpManage.Controls.Clear()
        loadProducts("Foods")

        lblItems.Text = "Foods Category"

        FoodsLeave = False

        LeashLeave = True
        ToiletriesLeave = True
        MedicineLeave = True
        CageLeave = True

        btnLeash.BorderColor = Color.LightGray
        btnLeash.ForeColor = Color.Black
        btnToiletries.BorderColor = Color.LightGray
        btnToiletries.ForeColor = Color.Black
        btnMedicine.BorderColor = Color.LightGray
        btnMedicine.ForeColor = Color.Black
        btnCage.BorderColor = Color.LightGray
        btnCage.ForeColor = Color.Black

        btnFoods.BorderColor = Color.FromArgb(255, 152, 19)
        btnFoods.ForeColor = Color.FromArgb(255, 152, 19)
    End Sub

    Private Sub btnLeash_Click(sender As Object, e As EventArgs) Handles btnLeash.Click
        showItemCount("Leash")
        flpManage.Controls.Clear()
        loadProducts("Leash")

        lblItems.Text = "Leash Category"

        If lblItems.Text = "Leash Category" Then
            LeashLeave = False

            FoodsLeave = True
            ToiletriesLeave = True
            MedicineLeave = True
            CageLeave = True

            btnFoods.BorderColor = Color.LightGray
            btnFoods.ForeColor = Color.Black
            btnToiletries.BorderColor = Color.LightGray
            btnToiletries.ForeColor = Color.Black
            btnMedicine.BorderColor = Color.LightGray
            btnMedicine.ForeColor = Color.Black
            btnCage.BorderColor = Color.LightGray
            btnCage.ForeColor = Color.Black

            btnLeash.BorderColor = Color.FromArgb(255, 152, 19)
            btnLeash.ForeColor = Color.FromArgb(255, 152, 19)
        End If
    End Sub

    Private Sub btnToiletries_Click(sender As Object, e As EventArgs) Handles btnToiletries.Click
        showItemCount("Toiletries")
        flpManage.Controls.Clear()
        loadProducts("Toiletries")

        lblItems.Text = "Toiletries Category"

        If lblItems.Text = "Toiletries Category" Then
            ToiletriesLeave = False

            FoodsLeave = True
            LeashLeave = True
            MedicineLeave = True
            CageLeave = True

            btnFoods.BorderColor = Color.LightGray
            btnFoods.ForeColor = Color.Black
            btnLeash.BorderColor = Color.LightGray
            btnLeash.ForeColor = Color.Black
            btnMedicine.BorderColor = Color.LightGray
            btnMedicine.ForeColor = Color.Black
            btnCage.BorderColor = Color.LightGray
            btnCage.ForeColor = Color.Black

            btnToiletries.BorderColor = Color.FromArgb(255, 152, 19)
            btnToiletries.ForeColor = Color.FromArgb(255, 152, 19)
        End If
    End Sub

    Private Sub btnMedicine_Click(sender As Object, e As EventArgs) Handles btnMedicine.Click
        showItemCount("Medicines")
        flpManage.Controls.Clear()
        loadProducts("Medicines")

        lblItems.Text = "Medicine Category"

        If lblItems.Text = "Medicine Category" Then
            MedicineLeave = False

            FoodsLeave = True
            LeashLeave = True
            ToiletriesLeave = True
            CageLeave = True

            btnFoods.BorderColor = Color.LightGray
            btnFoods.ForeColor = Color.Black
            btnLeash.BorderColor = Color.LightGray
            btnLeash.ForeColor = Color.Black
            btnToiletries.BorderColor = Color.LightGray
            btnToiletries.ForeColor = Color.Black
            btnCage.BorderColor = Color.LightGray
            btnCage.ForeColor = Color.Black

            btnMedicine.BorderColor = Color.FromArgb(255, 152, 19)
            btnMedicine.ForeColor = Color.FromArgb(255, 152, 19)
        End If
    End Sub

    Private Sub btnCage_Click(sender As Object, e As EventArgs) Handles btnCage.Click
        showItemCount("Cage")
        flpManage.Controls.Clear()
        loadProducts("Cage")

        lblItems.Text = "Cage Category"

        If lblItems.Text = "Cage Category" Then
            CageLeave = False

            FoodsLeave = True
            LeashLeave = True
            ToiletriesLeave = True
            MedicineLeave = True

            btnFoods.BorderColor = Color.LightGray
            btnFoods.ForeColor = Color.Black
            btnLeash.BorderColor = Color.LightGray
            btnLeash.ForeColor = Color.Black
            btnToiletries.BorderColor = Color.LightGray
            btnToiletries.ForeColor = Color.Black
            btnMedicine.BorderColor = Color.LightGray
            btnMedicine.ForeColor = Color.Black

            btnCage.BorderColor = Color.FromArgb(255, 152, 19)
            btnCage.ForeColor = Color.FromArgb(255, 152, 19)
        End If
    End Sub
End Class