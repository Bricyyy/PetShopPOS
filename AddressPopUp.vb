Public Class AddressPopUp

    Public Property userID As String

    Private Const CS_DROPSHADOW As Integer = 131072

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtFullName.Text = Nothing Or txtPhoneNum.Text = Nothing Or txtRegion.Text = Nothing Or txtPostalCode.Text = Nothing Or txtStreet.Text = Nothing Then
            lblChecker.Visible = True
        ElseIf txtPhoneNum.Text.Length < 11 Then
            lblChecker.Text = "Phone number should be 11 characters!"
            lblChecker.Visible = True
        Else
            insertAddress()
        End If
    End Sub

    Private Sub AddressPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"
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
            Dim hset As String = "Yes"

            If type = "Home" Or type = "Work" Then
                sql = "INSERT INTO userAddress (uID, userFName, userPNum, userRegion, userPostal, userHouseNum, userLabel, isDefault) VALUES ('" & userID & "','" & fullname & "','" & phonenum & "','" & region & "','" & postal & "','" & street & "','" & type & "','" & hset & "')"
                connect()
            Else
                sql = "INSERT INTO userAddress (uID, userFName, userPNum, userRegion, userPostal, userHouseNum, isDefault) VALUES ('" & userID & "','" & fullname & "','" & phonenum & "','" & region & "','" & postal & "','" & street & "','" & hset & "')"
                connect()
            End If

            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
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

    Private Sub txtPhoneNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNum.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub txtPostalCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPostalCode.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
End Class