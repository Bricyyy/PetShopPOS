Imports System.Text
Imports MySql.Data.MySqlClient

Public Class HomePanel
    Dim userID As String
    Dim countPrice As String
    Dim price As Integer
    Dim total As Integer
    Dim flag As Boolean = False
    Dim orderNum As String

    Dim userName As String
    Dim phoneNum As String
    Dim houseNum As String
    Dim houseRegion As String
    Dim houseCode As String

    Private AllLeave As Boolean = True
    Private FoodsLeave As Boolean = True
    Private LeashLeave As Boolean = True
    Private ToiletriesLeave As Boolean = True
    Private MedicineLeave As Boolean = True
    Private CageLeave As Boolean = True
    Public Shared bTopLevel As Boolean

    Private WithEvents pic As New PictureBox
    Private WithEvents itemPnl As New Panel
    Private WithEvents btnCart As New Guna.UI2.WinForms.Guna2Button
    Private WithEvents lblItemName As New Label
    Private WithEvents lblItemPrice As New Label
    Private WithEvents lblItemQuan As New Label

    Private WithEvents cartPnl As New Panel
    Private WithEvents cartPic As New PictureBox
    Private WithEvents cartProdName As New Label
    Private WithEvents cartProdPrice As New Label
    Private WithEvents cartQuan As New Guna.UI2.WinForms.Guna2NumericUpDown
    Private WithEvents removeItem As New Guna.UI2.WinForms.Guna2Button
    Private WithEvents lblAmount As New Label
    Private WithEvents lblOriginal As New Label

    Private WithEvents tempPic As New PictureBox
    Private WithEvents tempPic1 As New PictureBox

    Private WithEvents pnlCheckoutItem As New Panel
    Private WithEvents checkoutPic As New PictureBox
    Private WithEvents checkoutIName As New Label
    Private WithEvents checkoutItemPrice As New Label
    Private WithEvents checkoutItemQuan As New Label
    Private WithEvents checkoutItemSubT As New Label

    Public Property passEmail As String
    Public Property passUsername As String

    Private Sub HomePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        If conn1.State = ConnectionState.Open Then
            conn1.Close()
        End If
        conn1.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        If conn2.State = ConnectionState.Open Then
            conn2.Close()
        End If
        conn2.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        Try
            sql = "SELECT * FROM userProfile WHERE uEmail = '" & passEmail & "'"
            connect()

            If dr.Read Then
                lblUsername.Text = dr.GetValue(1)
                userID = dr.GetValue(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        LoadItems("All")
        loadCart()
        getProfilePic()
        loadComboBox()

        btnAll.BorderColor = Color.FromArgb(255, 152, 19)
        btnAll.ForeColor = Color.FromArgb(255, 152, 19)
        AllLeave = False

        lblItems.Text = "All Items"

        showItemCount("All")
        countAmount()

        restrictionButton()
    End Sub

    Private Sub loadCartID()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userCart WHERE uID = '" & userID & "'"
            connect()

            While dr.Read
                lstCheckout.Items.Add(dr.GetString("cID").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub removeItems()
        For Each cartID As String In lstCheckout.Items
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Try
                sql = "DELETE FROM userCart WHERE cID = '" & cartID & "'"
                connect()

                dr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        Next
    End Sub

    Private Sub checkoutItem()
        Dim itemID As String
        Dim arrimage() As Byte
        Dim arrimage1() As Byte
        Dim itemName As String
        Dim itemPrice As String
        Dim itemQuan As String
        Dim itemSubT As String

        Dim orderTotal = (total + 50).ToString
        Dim payMethod As String = "Cash"
        Dim datentime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        Dim message As String = txtMessage.Text

        Dim origQuan As String
        Dim newQuan As Integer

        'Retrieving Default Address
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userAddress WHERE uID = '" & userID & "' AND isDefault = '" & "Yes" & "'"
            connect()

            If dr.Read Then
                userName = dr.GetString("userFName").ToString
                phoneNum = dr.GetString("userPNum").ToString
                houseNum = dr.GetString("userHouseNum").ToString
                houseRegion = dr.GetString("userRegion").ToString
                houseCode = dr.GetString("userPostal").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        'End of retrieving address

        'Start of generating order number
        Dim validchars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        Dim sb As New StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To 6
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb.Append(randomChar)
        Next i

        orderNum = sb.ToString()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM usersProdPurchased WHERE oNum = '" & orderNum & "'"
            connect()

            If dr.Read Then
                For i As Integer = 1 To 6
                    Dim idx As Integer = rand.Next(0, validchars.Length)
                    Dim randomChar As Char = validchars(idx)
                    sb.Append(randomChar)
                Next i

                orderNum = sb.ToString()
            Else
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        'End of generating order number

        'Start of retrieving items in cart
        For Each item As String In lstCheckout.Items
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Try
                sql = "SELECT * FROM userCart WHERE cID = '" & item & "'"
                connect()

                If dr.Read Then
                    If conn1.State = ConnectionState.Open Then
                        conn1.Close()
                    End If

                    Try
                        sql1 = "SELECT * FROM storeItems WHERE sID = '" & dr.GetString("sID").ToString & "' AND prodAvail <> 0"
                        connectAlt()

                        If dr1.Read Then
                            itemID = dr.GetString("sID").ToString

                            arrimage = dr.Item("prodPic")
                            Dim mstream As New System.IO.MemoryStream(arrimage)
                            tempPic1.Image = System.Drawing.Image.FromStream(mstream)

                            Dim originalImage = tempPic1.Image
                            Dim filesize As UInt32
                            Dim mstream1 As New System.IO.MemoryStream
                            originalImage.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
                            arrimage1 = mstream1.GetBuffer
                            filesize = mstream1.Length
                            mstream1.Close()

                            itemName = dr.GetString("prodName").ToString
                            itemPrice = dr.GetString("prodPrice").ToString
                            itemQuan = dr.GetString("prodQuan").ToString
                            itemSubT = dr.GetString("prodSubT").ToString

                            'Start of saving user Purchased Items
                            If conn.State = ConnectionState.Open Then
                                conn.Close()
                            End If

                            Try
                                sql = "INSERT INTO usersProdPurchased (uID, oNum, sID, prodPic, prodName, prodPrice, prodQuan, prodSubT) VALUES (@uID, @oNum, @sID, @prodPic, @prodName, @prodPrice, @prodQuan, @prodSubT)"
                                With cmd
                                    .Parameters.Clear()
                                    .Parameters.AddWithValue("@uID", userID)
                                    .Parameters.Add("@oNum", MySqlDbType.VarChar).Value = orderNum
                                    .Parameters.Add("@sID", MySqlDbType.VarChar).Value = itemID
                                    .Parameters.Add("@prodPic", MySqlDbType.Blob).Value = arrimage1
                                    .Parameters.Add("@prodName", MySqlDbType.VarChar).Value = itemName
                                    .Parameters.Add("@prodPrice", MySqlDbType.Int32).Value = itemPrice
                                    .Parameters.Add("@prodQuan", MySqlDbType.VarChar).Value = itemQuan
                                    .Parameters.Add("@prodSubT", MySqlDbType.VarChar).Value = itemSubT
                                End With
                                connect()

                                flag = True
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                            conn.Close()
                            'End of saving user Purchased Items
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    conn1.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        Next
        'End of retrieving items in cart

        'Start of saving user Order to History
        For Each item As String In lstCheckout.Items
            If conn1.State = ConnectionState.Open Then
                conn1.Close()
            End If

            Try
                sql1 = "SELECT * FROM userCart WHERE cID = '" & item & "'"
                connectAlt()

                If dr1.Read Then
                    If conn2.State = ConnectionState.Open Then
                        conn2.Close()
                    End If

                    Try
                        sql2 = "SELECT * FROM storeItems WHERE sID = '" & dr1.GetString("sID").ToString & "' AND prodAvail <> 0"
                        connectAgain()

                        If dr2.Read Then
                            If conn.State = ConnectionState.Open Then
                                conn.Close()
                            End If

                            Try
                                If txtMessage.Text = Nothing Then
                                    sql = "INSERT INTO usersOrderHistory (uID, oNum, userTotal, uPayType, orderDateTime, userFName, userPNum, userStreet, userRegion, userPostalCode) VALUES (@uID, @oNum, @userTotal, @uPayType, @orderDateTime, @userFName, @userPNum, @userStreet, @userRegion, @userPostalCode)"
                                    With cmd
                                        .Parameters.Clear()
                                        .Parameters.AddWithValue("@uID", userID)
                                        .Parameters.Add("@oNum", MySqlDbType.VarChar).Value = orderNum
                                        .Parameters.Add("@userTotal", MySqlDbType.VarChar).Value = orderTotal
                                        .Parameters.Add("@uPayType", MySqlDbType.VarChar).Value = payMethod
                                        .Parameters.Add("@orderDateTime", MySqlDbType.VarChar).Value = datentime
                                        .Parameters.Add("@userFName", MySqlDbType.VarChar).Value = userName
                                        .Parameters.Add("@userPNum", MySqlDbType.VarChar).Value = phoneNum
                                        .Parameters.Add("@userStreet", MySqlDbType.VarChar).Value = houseNum
                                        .Parameters.Add("@userRegion", MySqlDbType.VarChar).Value = houseRegion
                                        .Parameters.Add("@userPostalCode", MySqlDbType.VarChar).Value = houseCode
                                    End With
                                    connect()
                                Else
                                    sql = "INSERT INTO usersOrderHistory (uID, oNum, userTotal, uPayType, orderDateTime, userFName, userPNum, userStreet, userRegion, userPostalCode, userMessage) VALUES (@uID, @oNum, @userTotal, @uPayType, @orderDateTime, @userFName, @userPNum, @userStreet, @userRegion, @userPostalCode, @userMessage)"
                                    With cmd
                                        .Parameters.Clear()
                                        .Parameters.AddWithValue("@uID", userID)
                                        .Parameters.Add("@oNum", MySqlDbType.VarChar).Value = orderNum
                                        .Parameters.Add("@userTotal", MySqlDbType.VarChar).Value = orderTotal
                                        .Parameters.Add("@uPayType", MySqlDbType.VarChar).Value = payMethod
                                        .Parameters.Add("@orderDateTime", MySqlDbType.VarChar).Value = datentime
                                        .Parameters.Add("@userFName", MySqlDbType.VarChar).Value = userName
                                        .Parameters.Add("@userPNum", MySqlDbType.VarChar).Value = phoneNum
                                        .Parameters.Add("@userStreet", MySqlDbType.VarChar).Value = houseNum
                                        .Parameters.Add("@userRegion", MySqlDbType.VarChar).Value = houseRegion
                                        .Parameters.Add("@userPostalCode", MySqlDbType.VarChar).Value = houseCode
                                        .Parameters.Add("@userMessage", MySqlDbType.VarChar).Value = message
                                    End With
                                    connect()
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                            conn.Close()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    conn2.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn1.Close()
        Next
        'End of saving user Order to History

        'Getting the items to be checked out
        For Each item As String In lstCheckout.Items
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Try
                sql = "SELECT * FROM userCart WHERE cID = '" & item & "'"
                connect()

                If dr.Read Then
                    itemID = dr.GetString("sID").ToString
                    itemQuan = dr.GetString("prodQuan").ToString

                    'Getting and reducing the original amount of item
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If

                    Try
                        sql = "SELECT * FROM storeItems WHERE sID = '" & itemID & "' AND prodAvail <> 0"
                        connect()

                        If dr.Read Then
                            origQuan = dr.GetString("prodAvail").ToString

                            newQuan = CInt(origQuan) - CInt(itemQuan)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    conn.Close()
                    'End of getting and reducing the original amount of item

                    'Setting the new quantity of bought item
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If

                    Try
                        sql = "UPDATE storeItems SET prodAvail = '" & newQuan & "' WHERE sID = '" & itemID & "' AND prodAvail <> 0"
                        connect()

                        dr.Close()

                        If cmd.ExecuteNonQuery Then
                            conn.Close()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    conn.Close()
                    'End of setting the new quantity of bought item
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        Next
        'End of getting the items to be checked out
    End Sub

    Private Sub restrictionButton()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userCart WHERE uID = '" & userID & "'"
            connect()

            If dr.Read Then
                btnProceed.Enabled = True
                pnlCartCheck.Visible = False
            Else
                pnlCartCheck.Visible = True
                btnProceed.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub getAddress()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userAddress WHERE uID = '" & userID & "' AND isDefault = '" & "Yes" & "'"
            connect()

            If dr.Read Then
                lblAddName.Text = dr.GetString("userFName").ToString & " " & dr.GetString("userPNum").ToString
                lblAddPlace.Text = dr.GetString("userHouseNum").ToString & ", " & dr.GetString("userRegion").ToString & " " & dr.GetString("userPostal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub loadCheckout()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userCart WHERE uID = '" & userID & "'"
            connect()

            While dr.Read
                If conn1.State = ConnectionState.Open Then
                    conn1.Close()
                End If

                sql1 = "SELECT * FROM storeItems WHERE sID = '" & dr.GetString("sID").ToString & "' AND prodAvail <> 0"
                connectAlt()

                If dr1.Read Then
                    pnlCheckoutItem = New Panel With {
                        .Width = 820,
                        .Height = 73,
                        .BackColor = Color.White
                    }

                    Dim len As Long = dr.GetBytes(3, 0, Nothing, 0, 0)
                    Dim array(CInt(len)) As Byte
                    dr.GetBytes(3, 0, array, 0, CInt(len))
                    checkoutPic = New PictureBox With {
                        .Width = 55,
                        .Height = 55,
                        .BackgroundImageLayout = ImageLayout.Zoom,
                        .Location = New Point(21, 8)
                    }
                    Dim ms As New System.IO.MemoryStream(array)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    checkoutPic.BackgroundImage = bitmap

                    checkoutIName = New Label With {
                        .Text = dr.GetString("prodName").ToString,
                        .Font = New Font("Segoe UI", 12, FontStyle.Regular),
                        .Width = 276,
                        .Height = 21,
                        .ForeColor = Color.Black,
                        .BackColor = Color.Transparent,
                        .Location = New Point(95, 24)
                    }

                    checkoutItemPrice = New Label With {
                        .Text = "₱" & dr.GetString("prodPrice").ToString,
                        .Font = New Font("Segoe UI", 12, FontStyle.Regular),
                        .Width = 69,
                        .Height = 21,
                        .ForeColor = Color.Black,
                        .BackColor = Color.Transparent,
                        .Location = New Point(400, 24),
                        .TextAlign = ContentAlignment.MiddleCenter
                    }

                    checkoutItemQuan = New Label With {
                        .Text = dr.GetString("prodQuan").ToString,
                        .Font = New Font("Segoe UI", 12, FontStyle.Regular),
                        .Width = 56,
                        .Height = 21,
                        .ForeColor = Color.Black,
                        .BackColor = Color.Transparent,
                        .Location = New Point(525, 24),
                        .TextAlign = ContentAlignment.MiddleCenter
                    }

                    checkoutItemSubT = New Label With {
                        .Text = "₱" & dr.GetString("prodSubT").ToString,
                        .Font = New Font("Segoe UI", 12, FontStyle.Regular),
                        .Width = 91,
                        .Height = 21,
                        .ForeColor = Color.Black,
                        .BackColor = Color.Transparent,
                        .Location = New Point(724, 24),
                        .TextAlign = ContentAlignment.MiddleCenter
                    }

                    pnlCheckoutItem.Controls.Add(checkoutPic)
                    pnlCheckoutItem.Controls.Add(checkoutIName)
                    pnlCheckoutItem.Controls.Add(checkoutItemPrice)
                    pnlCheckoutItem.Controls.Add(checkoutItemQuan)
                    pnlCheckoutItem.Controls.Add(checkoutItemSubT)
                    flpCheckoutCart.Controls.Add(pnlCheckoutItem)

                    checkoutLstBox.Items.Add(CInt(dr.GetString("prodSubT").ToString))
                End If
                conn1.Close()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub countCheckout()
        For Each price As String In checkoutLstBox.Items
            total += CInt(price)
        Next
        lblItemTotal.Text = "₱" & total
        lblMerch.Text = "₱" & total
        lblGrandTotal.Text = "₱" & total + 50
    End Sub

    Private Sub countAmount()
        For Each amount As String In lstPrices.Items
            price += CInt(amount)
        Next
        lblSubT.Text = "₱" & price
        lblTotal.Text = "₱" & price + 50
    End Sub

    Private Sub countCart()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT COUNT(*) FROM userCart WHERE uID = '" & userID & "'"
            connect()

            If dr.Read Then
                lblCartCount.Text = "Order Total (" & dr.GetValue(0) & " Item/s):"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub loadCart()
        lstPrices.Items.Clear()

        Dim itemQuantity As String

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userCart"
            connect()

            While dr.Read
                If conn1.State = ConnectionState.Open Then
                    conn1.Close()
                End If

                Try
                    sql1 = "SELECT * FROM storeItems WHERE sID = '" & dr.GetString("sID").ToString & "'"
                    connectAlt()

                    If Not dr1.Read Then
                        If conn2.State = ConnectionState.Open Then
                            conn2.Close()
                        End If

                        Try
                            sql2 = "DELETE FROM userCart WHERE cID = '" & dr.GetString("cID").ToString & "'"
                            connectAgain()

                            dr2.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        conn2.Close()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn1.Close()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "DELETE FROM userCart WHERE sID IN (SELECT (sID) FROM storeItems WHERE prodAvail = 0)"
            connect()

            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userCart WHERE uID = '" & userID & "' AND cID IN (SELECT (cID) FROM userCart WHERE uID = '" & userID & "')"
            connect()

            While dr.Read
                If conn2.State = ConnectionState.Open Then
                    conn2.Close()
                End If

                sql2 = "SELECT * FROM storeItems WHERE sID = '" & dr.GetString("sID").ToString & "' AND prodAvail <> 0"
                connectAgain()

                If dr2.Read Then
                    cartPnl = New Panel With {
                    .Width = 200,
                    .Height = 91,
                    .BackColor = Color.White
                    }

                    Dim len As Long = dr.GetBytes(3, 0, Nothing, 0, 0)
                    Dim array(CInt(len)) As Byte
                    dr.GetBytes(3, 0, array, 0, CInt(len))
                    cartPic = New PictureBox With {
                        .Width = 52,
                        .Height = 85,
                        .BackgroundImageLayout = ImageLayout.Zoom,
                        .Location = New Point(7, 3)
                    }
                    Dim ms As New System.IO.MemoryStream(array)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    cartPic.BackgroundImage = bitmap

                    cartProdName = New Label With {
                        .Text = dr.GetString("prodName").ToString,
                        .Font = New Font("Proxima Nova Rg", 10, FontStyle.Regular),
                        .Width = 115,
                        .Height = 35,
                        .ForeColor = Color.Black,
                        .BackColor = Color.Transparent,
                        .Location = New Point(61, 8)
                    }
                    cartProdName.SendToBack()

                    lblOriginal = New Label With {
                        .Text = "₱" & dr.GetString("prodPrice").ToString,
                        .Font = New Font("Proxima Nova Rg", 9, FontStyle.Regular),
                        .Width = 35,
                        .Height = 18,
                        .ForeColor = Color.Black,
                        .BackColor = Color.Transparent,
                        .Location = New Point(110, 55)
                    }

                    If dr.IsDBNull(7) Then
                        countPrice = dr.GetString("prodPrice").ToString
                        cartProdPrice = New Label With {
                            .Text = "₱" & countPrice,
                            .Font = New Font("Proxima Nova Lt", 11, FontStyle.Bold),
                            .Width = 64,
                            .Height = 18,
                            .TextAlign = ContentAlignment.MiddleRight,
                            .ForeColor = Color.Black,
                            .Location = New Point(140, 59),
                            .Tag = dr.GetString("sID")
                        }
                    Else
                        countPrice = dr.GetString("prodSubT").ToString
                        cartProdPrice = New Label With {
                            .Text = "₱" & countPrice,
                            .Font = New Font("Proxima Nova Lt", 11, FontStyle.Bold),
                            .Width = 64,
                            .Height = 18,
                            .TextAlign = ContentAlignment.MiddleRight,
                            .ForeColor = Color.Black,
                            .Location = New Point(140, 59),
                            .Tag = dr.GetString("sID")
                        }
                    End If

                    If conn1.State = ConnectionState.Open Then
                        conn1.Close()
                    End If

                    sql1 = "SELECT * FROM storeItems WHERE sID = '" & dr.GetString("sID").ToString & "'"
                    connectAlt()

                    If dr1.Read Then
                        itemQuantity = dr1.GetString("prodAvail").ToString

                        If dr.IsDBNull(6) Then
                            cartQuan = New Guna.UI2.WinForms.Guna2NumericUpDown With {
                                .Value = 1,
                                .Font = New Font("Proxima Nova Rg", 9, FontStyle.Regular),
                                .UseTransparentBackground = True,
                                .Width = 45,
                                .Height = 29,
                                .UpDownButtonFillColor = Color.White,
                                .Location = New Point(64, 48),
                                .Tag = dr.GetString("sID")
                            }
                            cartQuan.Minimum = 1
                            cartQuan.Maximum = CInt(itemQuantity)
                        Else
                            cartQuan = New Guna.UI2.WinForms.Guna2NumericUpDown With {
                                .Value = Convert.ToInt32(Convert.ToDecimal(dr.GetString("prodQuan"))),
                                .Font = New Font("Proxima Nova Rg", 9, FontStyle.Regular),
                                .UseTransparentBackground = True,
                                .Width = 45,
                                .Height = 29,
                                .UpDownButtonFillColor = Color.White,
                                .Location = New Point(64, 48),
                                .Tag = dr.GetString("sID")
                            }
                            cartQuan.Minimum = 1
                            cartQuan.Maximum = CInt(itemQuantity)
                        End If
                    End If
                    conn1.Close()

                    removeItem = New Guna.UI2.WinForms.Guna2Button With {
                        .Width = 10,
                        .Height = 10,
                        .Animated = True,
                        .UseTransparentBackground = True,
                        .FillColor = Color.Transparent,
                        .Location = New Point(190, 11),
                        .BackgroundImage = My.Resources.xIcon3,
                        .BackgroundImageLayout = ImageLayout.Zoom,
                        .Cursor = Cursors.Hand,
                        .Tag = dr.GetString("cID")
                    }
                    removeItem.BringToFront()

                    lblAmount = New Label With {
                        .Text = "Total",
                        .Font = New Font("Proxima Nova Rg", 10, FontStyle.Regular),
                        .Width = 36,
                        .Height = 16,
                        .ForeColor = Color.Black,
                        .BackColor = Color.Transparent,
                        .Location = New Point(167, 43)
                    }

                    cartPnl.Controls.Add(cartPic)
                    cartPnl.Controls.Add(cartProdName)
                    cartPnl.Controls.Add(lblOriginal)
                    cartPnl.Controls.Add(cartProdPrice)
                    cartPnl.Controls.Add(cartQuan)
                    cartPnl.Controls.Add(removeItem)
                    cartPnl.Controls.Add(lblAmount)
                    flpCart.Controls.Add(cartPnl)

                    lstPrices.Items.Add(countPrice)

                    AddHandler cartQuan.ValueChanged, AddressOf cartQuan_ValueChanged
                    AddHandler removeItem.Click, AddressOf removeItem_Click
                End If
                conn2.Close()
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub removeItem_Click(sender As Object, e As EventArgs)
        price = 0

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "DELETE FROM userCart WHERE cID = '" & sender.tag.ToString & "'"
            connect()

            dr.Close()

            flpCart.Controls.Clear()
            loadCart()
            countAmount()
            restrictionButton()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub cartQuan_ValueChanged(sender As Object, e As EventArgs)
        price = 0

        Dim productID = sender.tag.ToString

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Try
            sql = "SELECT * FROM storeItems WHERE sID = '" & productID & "'"
            connect()

            If dr.Read Then
                Dim subtotal = dr.GetString("prodPrice")
                Dim quantity As Integer = sender.Value
                Dim total As Integer
                total = subtotal * quantity

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                sql = "SELECT * FROM userCart WHERE uID = '" & userID & "' AND sID = '" & productID & "'"
                connect()

                If dr.Read Then
                    Dim cartID = dr.GetString("cID").ToString

                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If

                    sql = "UPDATE userCart SET prodQuan = '" & sender.Value.ToString & "', prodSubT = '" & total & "' WHERE cID = '" & cartID & "'"
                    connect()

                    dr.Close()

                    If cmd.ExecuteNonQuery Then
                        flpCart.Controls.Clear()
                        loadCart()
                        countAmount()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub loadComboBox()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userAddress WHERE uID = '" & userID & "' AND isDefault = '" & "Yes" & "'"
            connect()

            If dr.Read Then
                cmbAddress.Items.Insert(0, dr.GetString("userHouseNum") & " " & dr.GetString("userRegion"))
            End If
            conn.Close()

            sql = "SELECT * FROM userAddress WHERE uID = '" & userID & "' AND isDefault = '" & "No" & "'"
            connect()

            While dr.Read
                cmbAddress.Items.Add(dr.GetString("userHouseNum") & " " & dr.GetString("userRegion"))
            End While

            cmbAddress.StartIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub LoadItems(ByVal itemType As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            If Not txtSearch.Text = Nothing Then
                sql = "SELECT * FROM storeItems WHERE prodName LIKE '%" & itemType & "%' ORDER BY prodAvail DESC"
                connect()
            Else
                If itemType.Equals("All") Then
                    sql = "SELECT * FROM storeItems ORDER BY prodAvail DESC"
                    connect()
                Else
                    sql = "SELECT * FROM storeItems WHERE prodCat = '" & itemType & "' ORDER BY prodAvail DESC"
                    connect()
                End If
            End If

            While dr.Read
                Dim prodQuantity As Integer = CInt(dr.GetString("prodAvail").ToString)

                Dim len As Long = dr.GetBytes(1, 0, Nothing, 0, 0)
                Dim array(CInt(len)) As Byte
                dr.GetBytes(1, 0, array, 0, CInt(len))

                itemPnl = New Panel With {
                    .Width = 275,
                    .Height = 230,
                    .BackColor = Color.White
                }
                roundCorners(itemPnl)

                pic = New PictureBox With {
                    .Width = 137,
                    .Height = 131,
                    .BackgroundImageLayout = ImageLayout.Zoom,
                    .Anchor = System.Windows.Forms.AnchorStyles.Left,
                    .Location = New Point(14, 14)
                }
                Dim ms As New System.IO.MemoryStream(array)
                Dim bitmap As New System.Drawing.Bitmap(ms)
                pic.BackgroundImage = bitmap

                btnCart = New Guna.UI2.WinForms.Guna2Button With {
                    .Width = 195,
                    .Height = 48,
                    .FillColor = Color.FromArgb(255, 152, 19),
                    .BorderRadius = 6,
                    .Location = New Point(44, 156),
                    .Font = New Font("Proxima Nova Lt", 12, FontStyle.Bold),
                    .Cursor = Cursors.Hand,
                    .Animated = True,
                    .Tag = dr.Item("sID").ToString
                }
                If prodQuantity = 0 Then
                    btnCart.Text = "Item Unavailable"
                    btnCart.Enabled = False
                Else
                    btnCart.Text = "Add to Cart"
                    btnCart.Enabled = True
                End If

                lblItemName = New Label With {
                    .Text = dr.GetString("prodName").ToString,
                    .Width = 104,
                    .Height = 62,
                    .ForeColor = Color.Black,
                    .Location = New Point(150, 10),
                    .Font = New Font("Proxima Nova Lt", 12, FontStyle.Bold)
                }

                lblItemPrice = New Label With {
                    .Text = "₱" & dr.GetString("prodPrice").ToString,
                    .Width = 134,
                    .Height = 21,
                    .ForeColor = Color.Black,
                    .Location = New Point(150, 100),
                    .Font = New Font("Proxima Nova Lt", 12, FontStyle.Bold)
                }

                If prodQuantity >= 1 And prodQuantity <= 10 Then
                    lblItemQuan = New Label With {
                        .Text = "(" & dr.GetString("prodAvail").ToString & " item/s left)",
                        .Width = 134,
                        .Height = 21,
                        .ForeColor = Color.Black,
                        .Location = New Point(150, 80),
                        .Font = New Font("Proxima Nova Lt", 10, FontStyle.Bold),
                        .Visible = True
                    }
                Else
                    lblItemQuan = New Label With {
                        .Text = "",
                        .Width = 134,
                        .Height = 21,
                        .ForeColor = Color.Black,
                        .Location = New Point(150, 80),
                        .Font = New Font("Proxima Nova Lt", 10, FontStyle.Bold),
                        .Visible = False
                    }
                End If

                itemPnl.Controls.Add(lblItemPrice)
                itemPnl.Controls.Add(lblItemQuan)
                itemPnl.Controls.Add(lblItemName)
                itemPnl.Controls.Add(pic)
                itemPnl.Controls.Add(btnCart)
                flpOrder.Controls.Add(itemPnl)

                AddHandler btnCart.Click, AddressOf btnCart_Click
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM storeItems WHERE sID = '" & sender.tag.ToString & "'"
            connect()

            If dr.Read Then
                Dim itemID = dr.GetString("sID")
                Dim arrimage() As Byte
                arrimage = dr.Item("prodPic")
                Dim mstream As New System.IO.MemoryStream(arrimage)
                tempPic.Image = System.Drawing.Image.FromStream(mstream)

                Dim originalImage = tempPic.Image
                Dim filesize As UInt32
                Dim mstream1 As New System.IO.MemoryStream
                originalImage.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrimage1() As Byte = mstream1.GetBuffer
                filesize = mstream1.Length
                mstream1.Close()

                Dim itemName = dr.GetString("prodName").ToString
                Dim itemPrice = dr.GetString("prodPrice").ToString
                Dim itemCount As String = "1"
                Dim itemAvailability As Integer = CInt(dr.GetString("prodAvail").ToString)

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                Try
                    sql = "SELECT * FROM userCart WHERE sID = '" & itemID & "' AND uID = '" & userID & "'"
                    connect()

                    If dr.Read Then
                        Dim quantity As String
                        Dim changeQuan As Integer
                        If dr.IsDBNull(6) Then
                            quantity = "1"
                            changeQuan = 1 + CInt(quantity)
                        Else
                            quantity = dr.GetString("prodQuan").ToString
                            changeQuan = 1 + CInt(quantity)
                        End If

                        Dim quanSubT As String
                        Dim totalSubT As Integer
                        If dr.IsDBNull(7) Then
                            quanSubT = itemPrice
                            totalSubT = CInt(quanSubT) + CInt(itemPrice)
                        Else
                            quanSubT = dr.GetString("prodSubT").ToString
                            totalSubT = CInt(quanSubT) + CInt(itemPrice)
                        End If

                        If conn2.State = ConnectionState.Open Then
                            conn2.Close()
                        End If

                        Try
                            sql2 = "SELECT * FROM userCart WHERE sID = '" & itemID & "' AND uID = '" & userID & "'"
                            connectAgain()

                            If dr2.Read Then
                                Dim itemInCartQuan As Integer = CInt(dr.GetString("prodQuan").ToString)

                                If Not itemAvailability.Equals(itemInCartQuan) Then
                                    If conn1.State = ConnectionState.Open Then
                                        conn1.Close()
                                    End If

                                    sql1 = "SELECT * FROM storeItems WHERE sID = '" & itemID & "'"
                                    connectAlt()

                                    If dr1.Read Then
                                        If conn.State = ConnectionState.Open Then
                                            conn.Close()
                                        End If

                                        Try
                                            sql = "UPDATE userCart SET prodQuan = '" & changeQuan.ToString & "', prodSubT = '" & totalSubT & "' WHERE uID = '" & userID & "' AND sID = '" & itemID & "'"
                                            connect()

                                            dr.Close()

                                            If cmd.ExecuteNonQuery Then
                                                price = 0
                                                flpCart.Controls.Clear()
                                                loadCart()
                                                countAmount()
                                                restrictionButton()
                                            End If
                                        Catch ex As Exception
                                            MsgBox(ex.Message)
                                        End Try
                                        conn.Close()
                                    End If
                                    conn1.Close()
                                Else
                                    conn2.Close()
                                End If
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        conn2.Close()
                    Else
                        If conn.State = ConnectionState.Open Then
                            conn.Close()
                        End If

                        Try
                            sql = "INSERT INTO userCart (uID, sID, prodPic, prodName, prodPrice, prodQuan, prodSubT) VALUES (@uID, @sID, @prodPic, @prodName, @prodPrice, @prodQuan, @prodSubT)"
                            With cmd
                                .Parameters.Clear()
                                .Parameters.Add("@uID", MySqlDbType.VarChar).Value = userID
                                .Parameters.Add("@sID", MySqlDbType.VarChar).Value = itemID
                                .Parameters.Add("@prodPic", MySqlDbType.Blob).Value = arrimage1
                                .Parameters.Add("@prodName", MySqlDbType.VarChar).Value = itemName
                                .Parameters.Add("@prodPrice", MySqlDbType.VarChar).Value = itemPrice
                                .Parameters.Add("@prodQuan", MySqlDbType.VarChar).Value = itemCount
                                .Parameters.Add("@prodSubT", MySqlDbType.VarChar).Value = itemPrice
                            End With
                            connect()

                            price = 0
                            flpCart.Controls.Clear()
                            loadCart()
                            countAmount()
                            restrictionButton()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        conn.Close()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub showItemCount(ByVal prodType As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        If prodType.Equals("All") Then
            Try
                sql = "SELECT COUNT(*) FROM storeItems"
                connect()

                If dr.Read Then
                    lblItemCount.Text = dr.GetValue(0) & " " & prodType & " Result"
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf Not txtSearch.Text = Nothing Then
            Try
                sql = "SELECT COUNT(*) FROM storeItems WHERE prodName LIKE '%" & prodType & "%'"
                connect()

                If dr.Read Then
                    lblItemCount.Text = dr.GetValue(0) & " Search Result"
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                sql = "SELECT COUNT(*) FROM storeItems WHERE prodCat = '" & prodType & "'"
                connect()

                If dr.Read Then
                    lblItemCount.Text = dr.GetValue(0) & " " & prodType & " Result"
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
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

    Private Sub roundCorners(pnl As Panel)
        Dim g As New Drawing2D.GraphicsPath
        g.StartFigure()

        'Top Left Corner
        g.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        g.AddLine(20, 0, pnl.Width - 20, 0)

        'Top Right Corner
        g.AddArc(New Rectangle(pnl.Width - 20, 0, 20, 20), -90, 90)
        g.AddLine(pnl.Width, 20, pnl.Width, pnl.Height - 20)

        'Bottom Right Corner
        g.AddArc(New Rectangle(pnl.Width - 20, pnl.Height - 20, 20, 20), 0, 90)
        g.AddLine(pnl.Width - 20, pnl.Height, 20, pnl.Width)

        'Bottom Left Corner
        g.AddArc(New Rectangle(0, pnl.Height - 20, 20, 20), 90, 90)
        g.CloseFigure()

        pnl.Region = New Region(g)
    End Sub

    Private Sub Guna2Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnAll.MouseEnter
        btnAll.BorderColor = Color.FromArgb(255, 152, 19)
        btnAll.ForeColor = Color.FromArgb(255, 152, 19)
    End Sub

    Private Sub btnFoods_MouseEnter(sender As Object, e As EventArgs) Handles btnFoods.MouseEnter
        btnFoods.BorderColor = Color.FromArgb(255, 152, 19)
        btnFoods.ForeColor = Color.FromArgb(255, 152, 19)
    End Sub

    Private Sub btnAll_MouseLeave(sender As Object, e As EventArgs) Handles btnAll.MouseLeave
        If AllLeave Then
            btnAll.BorderColor = Color.LightGray
            btnAll.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnFoods_MouseLeave(sender As Object, e As EventArgs) Handles btnFoods.MouseLeave
        If FoodsLeave Then
            btnFoods.BorderColor = Color.LightGray
            btnFoods.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnLeash_MouseEnter(sender As Object, e As EventArgs) Handles btnLeash.MouseEnter
        btnLeash.BorderColor = Color.FromArgb(255, 152, 19)
        btnLeash.ForeColor = Color.FromArgb(255, 152, 19)
    End Sub

    Private Sub btnLeash_MouseLeave(sender As Object, e As EventArgs) Handles btnLeash.MouseLeave
        If LeashLeave Then
            btnLeash.BorderColor = Color.LightGray
            btnLeash.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnToiletries_MouseEnter(sender As Object, e As EventArgs) Handles btnToiletries.MouseEnter
        btnToiletries.BorderColor = Color.FromArgb(255, 152, 19)
        btnToiletries.ForeColor = Color.FromArgb(255, 152, 19)
    End Sub

    Private Sub btnToiletries_MouseLeave(sender As Object, e As EventArgs) Handles btnToiletries.MouseLeave
        If ToiletriesLeave Then
            btnToiletries.BorderColor = Color.LightGray
            btnToiletries.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnMedicine_MouseEnter(sender As Object, e As EventArgs) Handles btnMedicine.MouseEnter
        btnMedicine.BorderColor = Color.FromArgb(255, 152, 19)
        btnMedicine.ForeColor = Color.FromArgb(255, 152, 19)
    End Sub

    Private Sub btnMedicine_MouseLeave(sender As Object, e As EventArgs) Handles btnMedicine.MouseLeave
        If MedicineLeave Then
            btnMedicine.BorderColor = Color.LightGray
            btnMedicine.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnCage_MouseEnter(sender As Object, e As EventArgs) Handles btnCage.MouseEnter
        btnCage.BorderColor = Color.FromArgb(255, 152, 19)
        btnCage.ForeColor = Color.FromArgb(255, 152, 19)
    End Sub

    Private Sub btnCage_MouseLeave(sender As Object, e As EventArgs) Handles btnCage.MouseLeave
        If CageLeave Then
            btnCage.BorderColor = Color.LightGray
            btnCage.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        AllLeave = False

        FoodsLeave = True
        LeashLeave = True
        ToiletriesLeave = True
        MedicineLeave = True
        CageLeave = True

        btnFoods.BorderColor = Color.LightGray
        btnFoods.ForeColor = Color.Black
        btnLeash.BorderColor = Color.LightGray
        btnLeash.ForeColor = Color.Black
        btnToiletries.BorderColor = Color.LightGray
        btnToiletries.ForeColor = Color.Black
        btnMedicine.BorderColor = Color.LightGray
        btnMedicine.ForeColor = Color.Black
        btnCage.BorderColor = Color.LightGray
        btnCage.ForeColor = Color.Black

        btnAll.BorderColor = Color.FromArgb(255, 152, 19)
        btnAll.ForeColor = Color.FromArgb(255, 152, 19)

        txtSearch.Text = Nothing
        showItemCount("All")
        flpOrder.Controls.Clear()
        LoadItems("All")

        lblItems.Text = "All Items"
    End Sub

    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        txtSearch.Text = Nothing
        showItemCount("Foods")
        flpOrder.Controls.Clear()
        LoadItems("Foods")

        lblItems.Text = "Food Items"

        If lblItems.Text = "Food Items" Then
            FoodsLeave = False

            AllLeave = True
            LeashLeave = True
            ToiletriesLeave = True
            MedicineLeave = True
            CageLeave = True

            btnAll.BorderColor = Color.LightGray
            btnAll.ForeColor = Color.Black
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
        End If
    End Sub

    Private Sub btnLeash_Click(sender As Object, e As EventArgs) Handles btnLeash.Click
        txtSearch.Text = Nothing

        showItemCount("Leash")
        flpOrder.Controls.Clear()
        LoadItems("Leash")

        lblItems.Text = "Leash Items"

        If lblItems.Text = "Leash Items" Then
            LeashLeave = False

            AllLeave = True
            FoodsLeave = True
            ToiletriesLeave = True
            MedicineLeave = True
            CageLeave = True

            btnAll.BorderColor = Color.LightGray
            btnAll.ForeColor = Color.Black
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
        txtSearch.Text = Nothing

        showItemCount("Toiletries")
        flpOrder.Controls.Clear()
        LoadItems("Toiletries")

        lblItems.Text = "Toiletries Items"

        If lblItems.Text = "Toiletries Items" Then
            ToiletriesLeave = False

            AllLeave = True
            FoodsLeave = True
            LeashLeave = True
            MedicineLeave = True
            CageLeave = True

            btnAll.BorderColor = Color.LightGray
            btnAll.ForeColor = Color.Black
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
        txtSearch.Text = Nothing

        showItemCount("Medicines")
        flpOrder.Controls.Clear()
        LoadItems("Medicines")

        lblItems.Text = "Medicine Items"

        If lblItems.Text = "Medicine Items" Then
            MedicineLeave = False

            AllLeave = True
            FoodsLeave = True
            LeashLeave = True
            ToiletriesLeave = True
            CageLeave = True

            btnAll.BorderColor = Color.LightGray
            btnAll.ForeColor = Color.Black
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
        txtSearch.Text = Nothing

        showItemCount("Cage")
        flpOrder.Controls.Clear()
        LoadItems("Cage")

        lblItems.Text = "Cage Items"

        If lblItems.Text = "Cage Items" Then
            CageLeave = False

            AllLeave = True
            FoodsLeave = True
            LeashLeave = True
            ToiletriesLeave = True
            MedicineLeave = True

            btnAll.BorderColor = Color.LightGray
            btnAll.ForeColor = Color.Black
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        btnAll.BorderColor = Color.FromArgb(255, 152, 19)
        btnAll.ForeColor = Color.FromArgb(255, 152, 19)

        AllLeave = False

        FoodsLeave = True
        LeashLeave = True
        ToiletriesLeave = True
        MedicineLeave = True
        CageLeave = True

        btnFoods.BorderColor = Color.LightGray
        btnFoods.ForeColor = Color.Black
        btnLeash.BorderColor = Color.LightGray
        btnLeash.ForeColor = Color.Black
        btnToiletries.BorderColor = Color.LightGray
        btnToiletries.ForeColor = Color.Black
        btnMedicine.BorderColor = Color.LightGray
        btnMedicine.ForeColor = Color.Black
        btnCage.BorderColor = Color.LightGray
        btnCage.ForeColor = Color.Black

        flpOrder.Controls.Clear()
        LoadItems(txtSearch.Text)
        showItemCount(txtSearch.Text)
        lblItems.Text = "Found Items"

        If txtSearch.Text = Nothing Then
            LoadItems("All")
            showItemCount("All")
            lblItems.Text = "All Items"
        End If
    End Sub

    Private Sub lstPrices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrices.SelectedIndexChanged
        lstPrices.Items.Clear()
        price = 0
        countAmount()
    End Sub

    Public Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If cmbAddress.Items.Count = 0 Then
            Dim obj As New AddressNotice
            If obj.ShowDialog = DialogResult.OK Then
                obj.Close()
                Dim obj1 As New AddressPopUp With {
                    .userID = userID
                }
                If obj1.ShowDialog = DialogResult.OK Then
                    obj1.Close()
                    pnlCheckout.Visible = True
                    loadCheckout()
                    countCart()
                    countCheckout()
                    getAddress()
                End If
            End If
        Else
            pnlCheckout.Visible = True
            loadCheckout()
            countCart()
            countCheckout()
            getAddress()
            loadCartID()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlCheckout.Visible = False
        flpCheckoutCart.Controls.Clear()
        checkoutLstBox.Items.Clear()
        total = 0
        lstCheckout.Items.Clear()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim checkoutCheker As Boolean = False

        For Each item As String In lstCheckout.Items
            If conn1.State = ConnectionState.Open Then
                conn1.Close()
            End If

            Try
                sql1 = "SELECT * FROM storeItems WHERE prodAvail = 0 AND sID IN (SELECT (sID) FROM userCart WHERE cID = '" & item & "')"
                connectAlt()

                If dr1.Read Then
                    checkoutCheker = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn1.Close()
        Next

        If checkoutCheker = False Then
            checkoutItem()
        Else
            Dim obj As New ItemCheckoutConfirmation
            If obj.ShowDialog = DialogResult.OK Then
                flpCart.Controls.Clear()
                loadCart()

                removeItems()
                lstCheckout.Items.Clear()
                flpCheckoutCart.Controls.Clear()
                checkoutLstBox.Items.Clear()

                pnlCheckout.Visible = False
                flpOrder.Controls.Clear()
                LoadItems("All")

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                Try
                    sql = "SELECT * FROM userCart WHERE uID = '" & userID & "'"
                    connect()

                    While dr.Read
                        lstCheckout.Items.Add(dr.GetString("cID").ToString)
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
            End If
        End If

        If flag = True Then
            Dim obj As New OrderConfirmation With {
                .ordernumber = orderNum
            }
            If obj.ShowDialog = DialogResult.OK Then
                flpCart.Controls.Clear()
                pnlCartCheck.Visible = True
                btnProceed.Enabled = False
                lblSubT.Text = "₱0"
                lblTotal.Text = "₱50"
                total = 0
                removeItems()
                pnlCheckout.Visible = False
                flag = False
                lstCheckout.Items.Clear()
                flpCheckoutCart.Controls.Clear()
                checkoutLstBox.Items.Clear()
                flpOrder.Controls.Clear()
                LoadItems("All")
            End If
        End If
    End Sub
End Class
