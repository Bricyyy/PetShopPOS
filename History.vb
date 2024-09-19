Public Class History
    Dim userID As String
    Dim flag As Boolean = False

    Private WithEvents pnlItemOrders As New Panel
    Private WithEvents lblOrderNum As New Label
    Private WithEvents lblOrderPlaced As New Label
    Private WithEvents lblAddress As New Label
    Private WithEvents lblTotalTitle As New Label
    Private WithEvents lblPrice As New Label
    Private WithEvents line1 As New PictureBox
    Private WithEvents line2 As New PictureBox
    Private WithEvents flpProducts As New FlowLayoutPanel

    Private WithEvents pnlProductItem As New Panel
    Private WithEvents itemPic As New PictureBox
    Private WithEvents itemName As New Label
    Private WithEvents itemQuan As New Label
    Private WithEvents itemPrice As New Label

    Private WithEvents pnlItemOverview As Panel
    Private WithEvents ItemOverviewPic As New PictureBox
    Private WithEvents lblItemNameOV As New Label
    Private WithEvents lblItemQuanOV As New Label
    Private WithEvents lblItemPriceOV As New Label

    Public Property passEmail As String

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        Try
            sql = "SELECT * FROM userProfile WHERE uEmail = '" & passEmail & "'"
            connect()

            If dr.Read Then
                userID = dr.GetValue(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        getOrderNumber()
        getItemCount()
        flpProducts.Controls.Clear()
        loadHistory("Temp")
    End Sub

    Private Sub getOrderNumber()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            If Not txtSearchHistory.Text = Nothing Then
                sql = "SELECT * FROM usersOrderHistory WHERE uID = '" & userID & "' AND oNum LIKE '%" & txtSearchHistory.Text & "%'"
                connect()
            Else
                sql = "SELECT * FROM usersOrderHistory WHERE uID = '" & userID & "' ORDER BY oID DESC"
                connect()
            End If

            While dr.Read
                listOrderNum.Items.Add(dr.GetString("oNum").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub getItemCount()
        For Each orderNumber As String In listOrderNum.Items
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Try
                sql = "SELECT COUNT(*) FROM usersProdPurchased WHERE oNum = '" & orderNumber & "'"
                connect()

                If dr.Read Then
                    listItemCount.Items.Add(dr.GetValue(0).ToString)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        Next
    End Sub

    Private Sub loadHistory(ByVal search As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            If Not txtSearchHistory.Text = Nothing Then
                sql = "SELECT * FROM usersOrderHistory WHERE uID = '" & userID & "' AND oNum LIKE '%" & txtSearchHistory.Text & "%'"
                connect()
            Else
                sql = "SELECT * FROM usersOrderHistory WHERE uID = '" & userID & "' ORDER BY oID DESC"
                connect()
            End If

            While dr.Read
                pnlItemOrders = New Panel With {
                    .Width = 855,
                    .Height = 238,
                    .BackColor = Color.White
                }
                roundCorners(pnlItemOrders)

                lblOrderNum = New Label With {
                    .Text = "Order #" & dr.GetString("oNum").ToString,
                    .Width = 180,
                    .Height = 20,
                    .ForeColor = Color.Black,
                    .Location = New Point(16, 10),
                    .Font = New Font("Proxima Nova Lt", 12, FontStyle.Bold),
                    .TextAlign = ContentAlignment.MiddleLeft
                }

                lblOrderPlaced = New Label With {
                    .Text = "Order Placed: " & dr.GetString("orderDateTime").ToString,
                    .Width = 239,
                    .Height = 16,
                    .ForeColor = SystemColors.ControlDarkDark,
                    .Location = New Point(593, 14),
                    .Font = New Font("Proxima Nova Rg", 10, FontStyle.Regular),
                    .TextAlign = ContentAlignment.MiddleRight
                 }

                lblAddress = New Label With {
                    .Text = "Deliver to: " & dr.GetString("userFName").ToString & " " & dr.GetString("userPNum").ToString & " " & dr.GetString("userStreet").ToString & " " & dr.GetString("userRegion").ToString & " " & dr.GetString("userPostalCode").ToString,
                    .Width = 632,
                    .Height = 16,
                    .ForeColor = SystemColors.ControlDarkDark,
                    .Location = New Point(17, 198),
                    .Font = New Font("Proxima Nova Rg", 10, FontStyle.Regular),
                    .TextAlign = ContentAlignment.MiddleLeft
                 }

                lblTotalTitle = New Label With {
                    .Text = "Order Total: ",
                    .Width = 90,
                    .Height = 21,
                    .ForeColor = Color.Black,
                    .Location = New Point(655, 196),
                    .Font = New Font("Proxima Nova Rg", 12, FontStyle.Regular),
                    .TextAlign = ContentAlignment.MiddleCenter
                }

                lblPrice = New Label With {
                    .Text = "₱" & dr.GetString("userTotal").ToString,
                    .Width = 88,
                    .Height = 27,
                    .ForeColor = Color.FromArgb(255, 152, 19),
                    .Location = New Point(744, 189),
                    .Font = New Font("Proxima Nova Rg", 18, FontStyle.Regular),
                    .TextAlign = ContentAlignment.MiddleRight
                }

                line1 = New PictureBox With {
                    .BackgroundImage = My.Resources.line,
                    .Width = 1087,
                    .Height = 32,
                    .Location = New Point(-107, 23),
                    .BackgroundImageLayout = ImageLayout.Stretch
                }

                line2 = New PictureBox With {
                    .BackgroundImage = My.Resources.line,
                    .Width = 1087,
                    .Height = 32,
                    .Location = New Point(-108, 157),
                    .BackgroundImageLayout = ImageLayout.Stretch,
                    .Anchor = AnchorStyles.Bottom
                }

                flpProducts = New FlowLayoutPanel With {
                    .Width = 812,
                    .Height = 100,
                    .BackColor = Color.White,
                    .Location = New Point(20, 55),
                    .AutoScroll = True,
                    .Visible = True,
                    .Tag = dr.GetString("oNum").ToString
                }

                pnlItemOrders.Controls.Add(lblOrderNum)
                pnlItemOrders.Controls.Add(lblOrderPlaced)
                pnlItemOrders.Controls.Add(lblAddress)
                pnlItemOrders.Controls.Add(lblTotalTitle)
                pnlItemOrders.Controls.Add(lblPrice)
                pnlItemOrders.Controls.Add(line1)
                pnlItemOrders.Controls.Add(line2)
                pnlItemOrders.Controls.Add(flpProducts)
                flpHistory.Controls.Add(pnlItemOrders)

                AddHandler flpProducts.Click, AddressOf flpProducts_Click
                AddHandler flpProducts.Paint, AddressOf flpProducts_Paint
                AddHandler flpProducts.VisibleChanged, AddressOf flpProducts_VisibleChanged
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub flpProducts_Paint(sender As Object, e As EventArgs)
        flag = False
    End Sub

    Private Sub flpProducts_VisibleChanged(sender As Object, e As EventArgs)
        flag = True
        If flag = True Then
            flpProducts_Click(sender, New System.EventArgs)
        Else
            flag = False
        End If
    End Sub

    Private Sub flpProducts_Click(sender As Object, e As EventArgs)
        sender.visible = True

        If flag = True Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Try
                sql = "SELECT * FROM usersProdPurchased WHERE uID = '" & userID & "' AND oNum = '" & sender.tag.ToString & "'"
                connect()

                While dr.Read
                    pnlProductItem = New Panel With {
                        .Width = 774,
                        .Height = 93,
                        .BackColor = Color.White,
                        .Tag = dr.GetString("oNum").ToString,
                        .Cursor = Cursors.Hand
                    }

                    Dim len As Long = dr.GetBytes(4, 0, Nothing, 0, 0)
                    Dim array(CInt(len)) As Byte
                    dr.GetBytes(4, 0, array, 0, CInt(len))
                    itemPic = New PictureBox With {
                        .Width = 78,
                        .Height = 78,
                        .BackgroundImageLayout = ImageLayout.Zoom,
                        .Location = New Point(8, 7)
                    }
                    Dim ms As New System.IO.MemoryStream(array)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    itemPic.BackgroundImage = bitmap

                    itemName = New Label With {
                        .Text = dr.GetString("prodName").ToString,
                        .Width = 275,
                        .Height = 20,
                        .ForeColor = Color.Black,
                        .Location = New Point(91, 23),
                        .Font = New Font("Proxima Nova Rg", 12, FontStyle.Regular),
                        .TextAlign = ContentAlignment.MiddleLeft
                    }

                    itemQuan = New Label With {
                        .Text = "x" & dr.GetString("prodQuan").ToString,
                        .Width = 56,
                        .Height = 21,
                        .ForeColor = Color.Black,
                        .Location = New Point(91, 44),
                        .Font = New Font("Proxima Nova Rg", 12, FontStyle.Regular),
                        .TextAlign = ContentAlignment.MiddleLeft
                    }

                    itemPrice = New Label With {
                        .Text = "₱" & dr.GetString("prodPrice").ToString,
                        .Width = 91,
                        .Height = 21,
                        .ForeColor = Color.Black,
                        .Location = New Point(660, 35),
                        .Font = New Font("Proxima Nova Rg", 12, FontStyle.Regular),
                        .TextAlign = ContentAlignment.MiddleRight
                    }

                    pnlProductItem.Controls.Add(itemPic)
                    pnlProductItem.Controls.Add(itemName)
                    pnlProductItem.Controls.Add(itemQuan)
                    pnlProductItem.Controls.Add(itemPrice)
                    sender.Controls.Add(pnlProductItem)

                    AddHandler pnlProductItem.Click, AddressOf pnlProductItem_Click
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If

        flag = False
    End Sub

    Private Sub loadProducts(orderNumber As String)
        lblONum.Text = "Order #" & orderNumber

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM usersOrderHistory WHERE uID = '" & userID & "' AND oNum = '" & orderNumber & "'"
            connect()

            If dr.Read Then
                lblAddName.Text = dr.GetString("userFName").ToString
                lblAddPhone.Text = dr.GetString("userPNum").ToString
                lblAddFull.Text = dr.GetString("userStreet").ToString & " " & dr.GetString("userRegion").ToString & " " & dr.GetString("userPostalCode").ToString

                If dr.IsDBNull(11) Then
                    lblMessage.Text = "(No message left for the seller)"
                Else
                    lblMessage.Text = dr.GetString("userMessage").ToString
                End If

                Dim subtotal = CInt(dr.GetString("userTotal").ToString) - 50
                lblOSubT.Text = "₱" & subtotal.ToString
                lblOTotal.Text = "₱" & dr.GetString("userTotal").ToString

                If dr.GetString("uPayType").ToString.Equals("Cash") Then
                    lblPayType.Text = "Cash on Delivery"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM usersProdPurchased WHERE uID = '" & userID & "' AND oNum = '" & orderNumber & "'"
            connect()

            While dr.Read
                pnlItemOverview = New Panel With {
                    .Width = 855,
                    .Height = 100,
                    .BackColor = Color.WhiteSmoke
                }

                Dim len As Long = dr.GetBytes(4, 0, Nothing, 0, 0)
                Dim array(CInt(len)) As Byte
                dr.GetBytes(4, 0, array, 0, CInt(len))
                ItemOverviewPic = New PictureBox With {
                    .Width = 89,
                    .Height = 89,
                    .BackgroundImageLayout = ImageLayout.Zoom,
                    .Location = New Point(20, 12)
                }
                Dim ms As New System.IO.MemoryStream(array)
                Dim bitmap As New System.Drawing.Bitmap(ms)
                ItemOverviewPic.BackgroundImage = bitmap

                lblItemNameOV = New Label With {
                    .Text = dr.GetString("prodName").ToString,
                    .Width = 300,
                    .Height = 23,
                    .ForeColor = Color.Black,
                    .Location = New Point(122, 34),
                    .Font = New Font("Proxima Nova Rg", 12, FontStyle.Regular),
                    .TextAlign = ContentAlignment.MiddleLeft
                }

                lblItemQuanOV = New Label With {
                    .Text = "x" & dr.GetString("prodQuan").ToString,
                    .Width = 124,
                    .Height = 23,
                    .ForeColor = Color.Black,
                    .Location = New Point(122, 57),
                    .Font = New Font("Proxima Nova Rg", 12, FontStyle.Regular),
                    .TextAlign = ContentAlignment.MiddleLeft
                }

                lblItemPriceOV = New Label With {
                    .Text = "₱" & dr.GetString("prodPrice").ToString,
                    .Width = 160,
                    .Height = 16,
                    .ForeColor = Color.Black,
                    .Location = New Point(655, 48),
                    .Font = New Font("Proxima Nova Rg", 12, FontStyle.Regular),
                    .TextAlign = ContentAlignment.MiddleRight
                }

                pnlItemOverview.Controls.Add(ItemOverviewPic)
                pnlItemOverview.Controls.Add(lblItemNameOV)
                pnlItemOverview.Controls.Add(lblItemQuanOV)
                pnlItemOverview.Controls.Add(lblItemPriceOV)
                flpOrderOverview.Controls.Add(pnlItemOverview)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub pnlProductItem_Click(sender As Object, e As EventArgs)
        pnlOrders.Visible = True
        loadProducts(sender.tag.ToString)
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlOrders.Visible = False
        flpOrderOverview.Controls.Clear()
    End Sub

    Private Sub txtSearchHistory_TextChanged(sender As Object, e As EventArgs) Handles txtSearchHistory.TextChanged
        getOrderNumber()
        getItemCount()
        flpProducts.Controls.Clear()
        flpHistory.Controls.Clear()
        loadHistory(txtSearchHistory.Text)

        If txtSearchHistory.Text = Nothing Then
            getOrderNumber()
            getItemCount()
            flpProducts.Controls.Clear()
            flpHistory.Controls.Clear()
            loadHistory("Temp")
        End If
    End Sub
End Class