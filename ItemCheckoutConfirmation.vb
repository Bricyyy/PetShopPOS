Public Class ItemCheckoutConfirmation

    Private Const CS_DROPSHADOW As Integer = 131072

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams

        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get

    End Property

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class