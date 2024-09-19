Imports MySql.Data.MySqlClient

Public Class MyAddress
    Dim userID As String
    Dim address As String
    Dim editAddressID As String

    Public Property passEmail As String
    Public Property passUsername As String

    Private WithEvents addressPnl As New Panel
    Private WithEvents dialogfn As New Label
    Private WithEvents dialogph As New Label
    Private WithEvents dialogad As New Label
    Private WithEvents lblFName As New Label
    Private WithEvents lblPNum As New Label
    Private WithEvents lblAdd As New Label
    Private WithEvents picLine As New Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents editlbl As New Label
    Private WithEvents deletelbl As New Label
    Private WithEvents btnSet As New Guna.UI2.WinForms.Guna2Button
    Private WithEvents defaultlbl As New Label

    Private Sub MyAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        txtPhoneNum.MaxLength = 11

        loadAddress()

        If Not flpAddress.Controls.Contains(addressPnl) Then
            lblIndicator.Visible = True
        Else
            lblIndicator.Visible = False
        End If
    End Sub

    Public Sub loadAddress()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userProfile WHERE uEmail = '" & passEmail & "'"
            connect()

            If dr.Read Then
                userID = dr.GetString("uID").ToString

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                sql = "SELECT * FROM userAddress WHERE uID = '" & userID & "'"
                connect()

                While dr.Read
                    addressPnl = New Panel With {
                        .Width = 455,
                        .Height = 140,
                        .BackColor = Color.White
                    }

                    dialogfn = New Label With {
                        .Text = "Full Name",
                        .Width = 73,
                        .Height = 18,
                        .ForeColor = SystemColors.ControlDarkDark,
                        .Location = New Point(27, 31),
                        .Font = New Font("Proxima Nova Lt", 11, FontStyle.Regular)
                    }

                    dialogph = New Label With {
                        .Text = "Phone",
                        .Width = 53,
                        .Height = 18,
                        .ForeColor = SystemColors.ControlDarkDark,
                        .Location = New Point(50, 61),
                        .Font = New Font("Proxima Nova Lt", 11, FontStyle.Regular)
                    }

                    dialogad = New Label With {
                        .Text = "Address",
                        .Width = 65,
                        .Height = 18,
                        .ForeColor = SystemColors.ControlDarkDark,
                        .Location = New Point(37, 91),
                        .Font = New Font("Proxima Nova Lt", 11, FontStyle.Regular)
                    }

                    lblFName = New Label With {
                        .Text = dr.GetString("userFName").ToString,
                        .Width = 221,
                        .Height = 20,
                        .ForeColor = Color.Black,
                        .Location = New Point(121, 30),
                        .Font = New Font("Proxima Nova Lt", 12, FontStyle.Bold)
                    }

                    lblPNum = New Label With {
                        .Text = dr.GetString("userPNum").ToString,
                        .Width = 200,
                        .Height = 18,
                        .ForeColor = Color.Black,
                        .Location = New Point(122, 61),
                        .Font = New Font("Proxima Nova Rg", 11, FontStyle.Regular)
                    }

                    Dim userFullAddress As String
                    Dim houseNumber = dr.GetString("userHouseNum").ToString
                    Dim houseRegion = dr.GetString("userRegion").ToString
                    Dim housePostal = dr.GetString("userPostal").ToString
                    userFullAddress = houseNumber & " " & houseRegion & " " & housePostal
                    lblAdd = New Label With {
                        .Text = userFullAddress,
                        .Width = 221,
                        .Height = 36,
                        .ForeColor = Color.Black,
                        .Location = New Point(122, 91),
                        .Font = New Font("Proxima Nova Rg", 11, FontStyle.Regular)
                    }
                    lblAdd.SendToBack()

                    picLine = New Guna.UI2.WinForms.Guna2PictureBox With {
                        .Image = My.Resources.line,
                        .Width = 540,
                        .Height = 20,
                        .Location = New Point(-32, 129),
                        .BackColor = Color.Transparent,
                        .SizeMode = PictureBoxSizeMode.StretchImage,
                        .TabIndex = 57,
                        .TabStop = False,
                        .UseTransparentBackground = True
                    }

                    editlbl = New Label With {
                        .Text = "Edit",
                        .Width = 35,
                        .Height = 16,
                        .ForeColor = Color.Black,
                        .Location = New Point(409, 34),
                        .Font = New Font("Proxima Nova Rg", 10, FontStyle.Underline),
                        .Cursor = Cursors.Hand,
                        .Tag = dr.Item("aID").ToString
                    }

                    deletelbl = New Label With {
                        .Text = "Delete",
                        .AutoSize = True,
                        .Size = New System.Drawing.Size(45, 16),
                        .ForeColor = Color.Black,
                        .TabIndex = 59,
                        .Location = New System.Drawing.Point(348, 34),
                        .Font = New Font("Proxima Nova Rg", 10, FontStyle.Underline),
                        .Cursor = Cursors.Hand,
                        .Tag = dr.Item("aID").ToString
                    }

                    btnSet = New Guna.UI2.WinForms.Guna2Button With {
                        .Text = "Set as Default",
                        .Width = 80,
                        .Height = 32,
                        .ForeColor = Color.Black,
                        .Location = New Point(360, 77),
                        .Font = New Font("Proxima Nova Rg", 8, FontStyle.Regular),
                        .Cursor = Cursors.Hand,
                        .FillColor = Color.Transparent,
                        .BorderColor = Color.LightGray,
                        .BorderThickness = 1,
                        .Animated = True,
                        .Tag = dr.Item("aID").ToString
                    }
                    btnSet.BringToFront()

                    defaultlbl = New Label With {
                        .Text = "Default",
                        .AutoSize = True,
                        .BackColor = Color.FromArgb(0, 191, 165),
                        .Font = New Font("Proxima Nova Lt", 10, FontStyle.Bold),
                        .ForeColor = Color.White,
                        .Location = New Point(385, 89)
                    }
                    defaultlbl.BringToFront()

                    addressPnl.Controls.Add(dialogfn)
                    addressPnl.Controls.Add(dialogph)
                    addressPnl.Controls.Add(dialogad)
                    addressPnl.Controls.Add(lblFName)
                    addressPnl.Controls.Add(lblPNum)
                    addressPnl.Controls.Add(lblAdd)
                    addressPnl.Controls.Add(picLine)
                    addressPnl.Controls.Add(editlbl)
                    addressPnl.Controls.Add(deletelbl)
                    addressPnl.Controls.Add(defaultlbl)
                    addressPnl.Controls.Add(btnSet)

                    Dim defaultType = dr.GetString("isDefault").ToString
                    If defaultType.Equals("Yes") Then
                        btnSet.Visible = False
                        deletelbl.Visible = False
                        defaultlbl.Visible = True
                    Else
                        btnSet.Enabled = True
                        deletelbl.Visible = True
                        defaultlbl.Visible = False
                    End If

                    flpAddress.Controls.Add(addressPnl)

                    AddHandler btnSet.Click, AddressOf btnSet_Click
                    AddHandler deletelbl.Click, AddressOf deletelbl_Click
                    AddHandler editlbl.Click, AddressOf editlbl_Click
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub insertAddress()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            Dim fullname = txtFullName.Text
            Dim phonenum = txtPhoneNum.Text
            Dim region = txtRegion.Text
            Dim postal = txtPostalCode.Text
            Dim street = txtStreet.Text
            Dim type As String
            If btnHome.ForeColor = Color.FromArgb(255, 152, 19) Then
                type = "Home"
            ElseIf btnWork.ForeColor = Color.FromArgb(255, 152, 19) Then
                type = "Work"
            Else
                type = Nothing
            End If
            Dim hset As String
            If chkDefault.Checked = True Then
                hset = "Yes"
            Else
                hset = "No"
            End If

            If type = "Home" Or type = "Work" Then
                sql = "INSERT INTO userAddress (uID, userFName, userPNum, userRegion, userPostal, userHouseNum, userLabel, isDefault) VALUES ('" & userID & "','" & fullname & "','" & phonenum & "','" & region & "','" & postal & "','" & street & "','" & type & "','" & hset & "')"
                connect()
            Else
                sql = "INSERT INTO userAddress (uID, userFName, userPNum, userRegion, userPostal, userHouseNum, isDefault) VALUES ('" & userID & "','" & fullname & "','" & phonenum & "','" & region & "','" & postal & "','" & street & "','" & hset & "')"
                connect()
            End If

            dr.Close()
            getLastId()

            If chkDefault.Checked = True Then
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                sql = "UPDATE userAddress SET isDefault = '" & "No" & "' WHERE  uID = '" & userID & "' AND  aID <> '" & address & "'"
                connect()

                dr.Close()

                If cmd.ExecuteNonQuery Then
                    flpAddress.Controls.Clear()
                    loadAddress()
                End If
            Else
                flpAddress.Controls.Clear()
                loadAddress()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub getLastId()
        sql = "SELECT aID FROM userAddress WHERE aID = (SELECT max(aID) FROM userAddress)"
        Dim cmd1 As New MySqlCommand(sql, conn)
        dr = cmd1.ExecuteReader
        dr.Read()
        address = dr("aID")
        conn.Close()
    End Sub

    Private Sub updateAddress()
        Dim houselabel As String
        If btnHome.ForeColor = Color.FromArgb(255, 152, 19) Then
            houselabel = "Home"
        ElseIf btnWork.ForeColor = Color.FromArgb(255, 152, 19) Then
            houselabel = "Work"
        Else
            houselabel = Nothing
        End If

        Dim hset As String
        If chkDefault.Checked = True Then
            hset = "Yes"
        Else
            hset = "No"
        End If

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            If houselabel = "Home" Or houselabel = "Work" Then
                sql = "UPDATE userAddress SET userFName = '" & txtFullName.Text & "', userPNum = '" & txtPhoneNum.Text & "', userRegion = '" & txtRegion.Text & "', userPostal = '" & txtPostalCode.Text & "', userHouseNum = '" & txtStreet.Text & "', userLabel = '" & houselabel & "', isDefault = '" & hset & "' WHERE aID = '" & editAddressID & "'"
                connect()
            Else
                sql = "UPDATE userAddress SET userFName = '" & txtFullName.Text & "', userPNum = '" & txtPhoneNum.Text & "', userRegion = '" & txtRegion.Text & "', userPostal = '" & txtPostalCode.Text & "', userHouseNum = '" & txtStreet.Text & "', userLabel = NULL, isDefault = '" & hset & "' WHERE aID = '" & editAddressID & "'"
                connect()
            End If

            dr.Close()

            If cmd.ExecuteNonQuery Then
                If chkDefault.Checked = True Then
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If

                    sql = "UPDATE userAddress SET isDefault = '" & "No" & "' WHERE  uID = '" & userID & "' AND  aID <> '" & editAddressID & "'"
                    connect()

                    dr.Close()

                    If cmd.ExecuteNonQuery Then
                        flpAddress.Controls.Clear()
                        loadAddress()
                    End If
                Else
                    flpAddress.Controls.Clear()
                    loadAddress()
                End If
            End If

            flpAddress.Controls.Clear()
            loadAddress()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub editlbl_Click(sender As Object, e As EventArgs)
        addressPnl.Visible = False
        pnlNewAddress.Visible = True

        btnSubmit.Visible = False
        btnSave.Visible = True
        lblTitle.Text = "Edit Address"

        editAddressID = sender.tag.ToString

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "SELECT * FROM userAddress WHERE aID = '" & editAddressID & "'"
            connect()

            If dr.Read Then
                txtFullName.Text = dr.GetString("userFName")
                txtPhoneNum.Text = dr.GetString("userPNum")
                txtRegion.Text = dr.GetString("userRegion")
                txtPostalCode.Text = dr.GetString("userPostal")
                txtStreet.Text = dr.GetString("userHouseNum")

                If dr.IsDBNull(7) Then
                    btnHome.ForeColor = Color.Black
                    btnHome.BorderColor = Color.FromArgb(213, 218, 223)
                    btnWork.ForeColor = Color.Black
                    btnWork.BorderColor = Color.FromArgb(213, 218, 223)
                Else
                    Dim houseLabel = dr.GetString("userLabel")
                    If houseLabel = "Home" Then
                        btnHome.ForeColor = Color.FromArgb(255, 152, 19)
                        btnHome.BorderColor = Color.FromArgb(255, 152, 19)

                        btnWork.ForeColor = Color.Black
                        btnWork.BorderColor = Color.FromArgb(213, 218, 223)
                    ElseIf houseLabel = "Work" Then
                        btnWork.ForeColor = Color.FromArgb(255, 152, 19)
                        btnWork.BorderColor = Color.FromArgb(255, 152, 19)

                        btnHome.ForeColor = Color.Black
                        btnHome.BorderColor = Color.FromArgb(213, 218, 223)
                    End If
                End If

                Dim houseDefault = dr.GetString("isDefault")
                If houseDefault = "Yes" Then
                    chkDefault.Checked = True
                    chkDefault.Enabled = False
                ElseIf houseDefault = "No" Then
                    chkDefault.Checked = False
                    chkDefault.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub deletelbl_Click(sender As Object, e As EventArgs)
        Dim addressID As String
        addressID = sender.tag.ToString

        If DeleteConfirmation.ShowDialog = DialogResult.OK Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Try
                sql = "DELETE FROM userAddress WHERE aID = '" & addressID & "'"
                connect()

                dr.Close()

                flpAddress.Controls.Clear()
                loadAddress()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs)
        Dim addressID As String
        addressID = sender.tag.ToString

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            sql = "UPDATE userAddress SET isDefault = '" & "Yes" & "' WHERE aID = '" & addressID & "' AND uID = '" & userID & "'"
            connect()

            dr.Close()

            If cmd.ExecuteNonQuery Then
                btnSet.Visible = False
                deletelbl.Visible = False
                defaultlbl.Visible = True

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                sql = "UPDATE userAddress SET isDefault = '" & "No" & "' WHERE uID = '" & userID & "' AND aID <> '" & addressID & "'"
                connect()

                dr.Close()

                If cmd.ExecuteNonQuery Then
                    btnSet.Enabled = True
                    deletelbl.Visible = True
                    defaultlbl.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

        flpAddress.Controls.Clear()
        loadAddress()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addressPnl.Visible = False
        lblIndicator.Visible = False
        pnlNewAddress.Visible = True

        btnSave.Visible = False
        btnSubmit.Visible = True
        lblTitle.Text = "New Address"

        lblChecker.Visible = False

        clearFields()

        If Not flpAddress.Controls.Contains(addressPnl) Then
            chkDefault.Checked = True
            chkDefault.Enabled = False
        Else
            chkDefault.Checked = False
            chkDefault.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        addressPnl.Visible = True
        pnlNewAddress.Visible = False

        If Not flpAddress.Controls.Contains(addressPnl) Then
            lblIndicator.Visible = True
        Else
            lblIndicator.Visible = False
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        If btnHome.ForeColor = Color.FromArgb(255, 152, 19) Then
            btnHome.ForeColor = Color.Black
            btnHome.BorderColor = Color.FromArgb(213, 218, 223)
        Else
            btnHome.ForeColor = Color.FromArgb(255, 152, 19)
            btnHome.BorderColor = Color.FromArgb(255, 152, 19)

            btnWork.ForeColor = Color.Black
            btnWork.BorderColor = Color.FromArgb(213, 218, 223)
        End If
    End Sub

    Private Sub btnWork_Click(sender As Object, e As EventArgs) Handles btnWork.Click
        If btnWork.ForeColor = Color.FromArgb(255, 152, 19) Then
            btnWork.ForeColor = Color.Black
            btnWork.BorderColor = Color.FromArgb(213, 218, 223)
        Else
            btnWork.ForeColor = Color.FromArgb(255, 152, 19)
            btnWork.BorderColor = Color.FromArgb(255, 152, 19)

            btnHome.ForeColor = Color.Black
            btnHome.BorderColor = Color.FromArgb(213, 218, 223)
        End If
    End Sub

    Private Sub clearFields()
        txtFullName.Text = Nothing
        txtPhoneNum.Text = Nothing
        txtRegion.Text = Nothing
        txtPostalCode.Text = Nothing
        txtStreet.Text = Nothing
        btnHome.ForeColor = Color.Black
        btnHome.BorderColor = Color.FromArgb(213, 218, 223)
        btnWork.ForeColor = Color.Black
        btnWork.BorderColor = Color.FromArgb(213, 218, 223)
        chkDefault.Checked = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtFullName.Text = Nothing Or txtPhoneNum.Text = Nothing Or txtRegion.Text = Nothing Or txtPostalCode.Text = Nothing Or txtStreet.Text = Nothing Then
            lblChecker.Visible = True
        ElseIf txtPhoneNum.Text.Length < 11 Then
            lblChecker.Text = "Phone number should be 11 characters!"
            lblChecker.Visible = True
        Else
            insertAddress()
            clearFields()
            pnlNewAddress.Visible = False
            addressPnl.Visible = True
        End If

        flpAddress.Controls.Clear()
        loadAddress()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFullName.Text = Nothing Or txtPhoneNum.Text = Nothing Or txtRegion.Text = Nothing Or txtPostalCode.Text = Nothing Or txtStreet.Text = Nothing Then
            lblChecker.Visible = True
        ElseIf txtPhoneNum.Text.Length < 11 Then
            lblChecker.Text = "Phone number should be 11 characters!"
            lblChecker.Visible = True
        Else
            updateAddress()
            clearFields()
            pnlNewAddress.Visible = False
            addressPnl.Visible = True
        End If
    End Sub

    Private Sub txtPhoneNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNum.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub txtPostalCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPostalCode.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        lblChecker.Visible = False
    End Sub

    Private Sub txtPhoneNum_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNum.TextChanged
        lblChecker.Visible = False
    End Sub

    Private Sub txtRegion_TextChanged(sender As Object, e As EventArgs) Handles txtRegion.TextChanged
        lblChecker.Visible = False
    End Sub

    Private Sub txtPostalCode_TextChanged(sender As Object, e As EventArgs) Handles txtPostalCode.TextChanged
        lblChecker.Visible = False
    End Sub

    Private Sub txtStreet_TextChanged(sender As Object, e As EventArgs) Handles txtStreet.TextChanged
        lblChecker.Visible = False
    End Sub
End Class