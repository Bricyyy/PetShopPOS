Imports System.ComponentModel

Public Class SavedConfirmation
    Public Property ItemAddedConfirmation As String

    Private TargetDT As DateTime
    Private stopWatch As TimeSpan = TimeSpan.FromSeconds(3)

    Private Const CS_DROPSHADOW As Integer = 131072

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub FadeInWindow()
        Me.Opacity = 0
        Dim tmr As New Timer With {
            .Interval = 2
        }
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Opacity += 0.1
                                 If Me.Opacity = 1 Then tmr.Stop()
                             End Sub
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub SavedConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrClose.Start()
        TargetDT = DateTime.Now.Add(stopWatch)
        FadeInWindow()

        If Not ItemAddedConfirmation = Nothing Then
            lblConfirmation.Text = ItemAddedConfirmation
        End If
    End Sub

    Private Sub SavedConfirmation_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ''e.Cancel = True
        ''Me.Opacity = 1
        ''Dim tmr As New Timer With {
        ''    .Interval = 1
        ''}
        ''tmr.Start()
        ''AddHandler tmr.Tick, Sub()
        ''                         Me.Opacity -= 0.1
        ''                         If Me.Opacity = 0 Then
        ''                             e.Cancel = False
        ''                             tmr.Stop()
        ''                             Me.Dispose()
        ''                         End If
        ''                     End Sub
    End Sub

    Private Sub tmrClose_Tick(sender As Object, e As EventArgs) Handles tmrClose.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 1 Then
            lblTime.Text = ts.ToString("ss")
        Else
            tmrClose.Stop()
            Me.Close()
        End If
    End Sub
End Class