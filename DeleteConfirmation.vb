Public Class DeleteConfirmation
    Public Property passAddress As String
    Public Property passConfirmation As String

    Private Const CS_DROPSHADOW As Integer = 131072

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub DeleteConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost;user id=root;port=3306;password=0102bryan;database=accountdb"

        If Not passConfirmation = Nothing Then
            lblConfirmation.Text = passConfirmation
        Else
            Dim obj As New Homepage
            obj.Hide()
        End If
    End Sub
End Class