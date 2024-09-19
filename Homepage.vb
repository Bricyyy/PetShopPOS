Imports System.ComponentModel

Public Class Homepage
    Private _useHomeEventLeave As Boolean = True
    Private _useHistoryEventLeave As Boolean = True
    Private _useMessageEventLeave As Boolean = True
    Private _useSettingsEventLeave As Boolean = True
    Private _useManageEventLeavee As Boolean = True

    Public Shared toEmail As String
    Public Shared ToUserName As String

    Public Property emailPic As String
    Public Property userPic As String

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub fadeIn()
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

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fadeIn()

        toEmail = emailPic
        ToUserName = userPic

        Login.Hide()

        btnHome.BorderThickness = 2
        btnHome.ForeColor = Color.FromArgb(255, 152, 19)
        btnHome.Image = My.Resources.homeIconColored
        _useHomeEventLeave = False

        Dim obj As New Login
        If obj.chkRememberMe.Checked Then
            My.Settings.userRememberMe = True
        End If

        If My.Settings.userRememberMe = True Then
            lblUserInfo.Text = String.Concat("email: ", My.Settings.userEmail, " password: ", My.Settings.userPassword, " username: ", My.Settings.userUsername, " remember me: ", My.Settings.userRememberMe)
            toEmail = My.Settings.userEmail
            ToUserName = My.Settings.userUsername
        End If

        Dim obj1 As New HomePanel With {
            .passEmail = toEmail,
            .passUsername = ToUserName,
            .TopLevel = False
        }
        pnlMain.Controls.Add(obj1)
        obj1.Dock = DockStyle.Fill
        obj1.Show()
    End Sub

    Sub switchPanel(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        pnlMain.Controls.Add(panel)
        panel.Dock = DockStyle.Fill
        panel.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Settings.userRememberMe = False
        My.Settings.userEmail = ""
        My.Settings.userPassword = ""
        My.Settings.userUsername = ""
        My.Settings.Save()
        Dim obj As New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_MouseEnter(sender As Object, e As EventArgs) Handles btnLogout.MouseEnter
        btnLogout.BorderThickness = 2
        btnLogout.ForeColor = Color.FromArgb(255, 152, 19)
        btnLogout.Image = My.Resources.logoutIconColored
    End Sub

    Private Sub btnLogout_MouseLeave(sender As Object, e As EventArgs) Handles btnLogout.MouseLeave
        btnLogout.BorderThickness = 0
        btnLogout.ForeColor = Color.Black
        btnLogout.Image = My.Resources.logoutIconBlack
    End Sub

    'Private Sub btnHome_MouseEnter(sender As Object, e As EventArgs) Handles btnHome.MouseEnter
    '    btnHome.BorderThickness = 2
    '    btnHome.ForeColor = Color.FromArgb(255, 152, 19)
    '    btnHome.Image = My.Resources.homeIconColored
    'End Sub

    'Private Sub btnHome_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave
    '    If _useHomeEventLeave Then
    '        btnHome.BorderThickness = 0
    '        btnHome.ForeColor = Color.Black
    '        btnHome.Image = My.Resources.homeIconBlack
    '    End If
    'End Sub

    'Private Sub btnHistory_MouseEnter(sender As Object, e As EventArgs) Handles btnHistory.MouseEnter
    '    btnHistory.BorderThickness = 2
    '    btnHistory.ForeColor = Color.FromArgb(255, 152, 19)
    '    btnHistory.Image = My.Resources.historyIconColored
    'End Sub

    'Private Sub btnHistory_MouseLeave(sender As Object, e As EventArgs) Handles btnHistory.MouseLeave
    '    If _useHistoryEventLeave Then
    '        btnHistory.BorderThickness = 0
    '        btnHistory.ForeColor = Color.Black
    '        btnHistory.Image = My.Resources.historyIconBlack
    '    End If
    'End Sub

    'Private Sub btnMessage_MouseEnter(sender As Object, e As EventArgs) Handles btnMessage.MouseEnter
    '    btnMessage.BorderThickness = 2
    '    btnMessage.ForeColor = Color.FromArgb(255, 152, 19)
    '    btnMessage.Image = My.Resources.messageIconColored
    'End Sub

    'Private Sub btnMessage_MouseLeave(sender As Object, e As EventArgs) Handles btnMessage.MouseLeave
    '    If _useMessageEventLeave Then
    '        btnMessage.BorderThickness = 0
    '        btnMessage.ForeColor = Color.Black
    '        btnMessage.Image = My.Resources.messageIconBlack
    '    End If
    'End Sub

    'Private Sub btnSettings_MouseEnter(sender As Object, e As EventArgs) Handles btnSettings.MouseEnter
    '    btnSettings.BorderThickness = 2
    '    btnSettings.ForeColor = Color.FromArgb(255, 152, 19)
    '    btnSettings.Image = My.Resources.settingsIconColored
    'End Sub

    'Private Sub btnSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
    '    If _useSettingsEventLeave Then
    '        btnSettings.BorderThickness = 0
    '        btnSettings.ForeColor = Color.Black
    '        btnSettings.Image = My.Resources.settingsIconBlack
    '    End If
    'End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        _useHomeEventLeave = False

        _useHistoryEventLeave = True
        _useMessageEventLeave = True
        _useSettingsEventLeave = True
        _useManageEventLeavee = True

        btnHistory.BorderThickness = 0
        btnHistory.ForeColor = Color.Black
        btnHistory.Image = My.Resources.historyIconBlack
        btnMessage.BorderThickness = 0
        btnMessage.ForeColor = Color.Black
        btnMessage.Image = My.Resources.messageIconBlack
        btnSettings.BorderThickness = 0
        btnSettings.ForeColor = Color.Black
        btnSettings.Image = My.Resources.settingsIconBlack
        btnManage.BorderThickness = 0
        btnManage.ForeColor = Color.Black
        btnManage.Image = My.Resources.ManageItemIconBlack

        btnHome.BorderThickness = 2
        btnHome.ForeColor = Color.FromArgb(255, 152, 19)
        btnHome.Image = My.Resources.homeIconColored

        pnlMain.Controls.Clear()
        Dim obj1 As New HomePanel With {
            .passEmail = toEmail,
            .passUsername = userPic,
            .TopLevel = False
        }
        pnlMain.Controls.Add(obj1)
        obj1.Dock = DockStyle.Fill
        obj1.Show()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        _useHistoryEventLeave = False

        _useHomeEventLeave = True
        _useMessageEventLeave = True
        _useSettingsEventLeave = True
        _useManageEventLeavee = True

        btnHome.BorderThickness = 0
        btnHome.ForeColor = Color.Black
        btnHome.Image = My.Resources.homeIconBlack
        btnMessage.BorderThickness = 0
        btnMessage.ForeColor = Color.Black
        btnMessage.Image = My.Resources.messageIconBlack
        btnSettings.BorderThickness = 0
        btnSettings.ForeColor = Color.Black
        btnSettings.Image = My.Resources.settingsIconBlack
        btnManage.BorderThickness = 0
        btnManage.ForeColor = Color.Black
        btnManage.Image = My.Resources.ManageItemIconBlack

        btnHistory.BorderThickness = 2
        btnHistory.ForeColor = Color.FromArgb(255, 152, 19)
        btnHistory.Image = My.Resources.historyIconColored

        pnlMain.Controls.Clear()
        Dim obj1 As New History With {
            .passEmail = toEmail,
            .TopLevel = False
        }
        pnlMain.Controls.Add(obj1)
        obj1.Dock = DockStyle.Fill
        obj1.Show()
    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        _useMessageEventLeave = False

        _useHomeEventLeave = True
        _useHistoryEventLeave = True
        _useSettingsEventLeave = True
        _useManageEventLeavee = True

        btnHome.BorderThickness = 0
        btnHome.ForeColor = Color.Black
        btnHome.Image = My.Resources.homeIconBlack
        btnHistory.BorderThickness = 0
        btnHistory.ForeColor = Color.Black
        btnHistory.Image = My.Resources.historyIconBlack
        btnSettings.BorderThickness = 0
        btnSettings.ForeColor = Color.Black
        btnSettings.Image = My.Resources.settingsIconBlack
        btnManage.BorderThickness = 0
        btnManage.ForeColor = Color.Black
        btnManage.Image = My.Resources.ManageItemIconBlack

        btnMessage.BorderThickness = 2
        btnMessage.ForeColor = Color.FromArgb(255, 152, 19)
        btnMessage.Image = My.Resources.messageIconColored
    End Sub

    Public Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        _useSettingsEventLeave = False

        _useHomeEventLeave = True
        _useHistoryEventLeave = True
        _useMessageEventLeave = True
        _useManageEventLeavee = True

        btnHome.BorderThickness = 0
        btnHome.ForeColor = Color.Black
        btnHome.Image = My.Resources.homeIconBlack
        btnHistory.BorderThickness = 0
        btnHistory.ForeColor = Color.Black
        btnHistory.Image = My.Resources.historyIconBlack
        btnMessage.BorderThickness = 0
        btnMessage.ForeColor = Color.Black
        btnMessage.Image = My.Resources.messageIconBlack
        btnManage.BorderThickness = 0
        btnManage.ForeColor = Color.Black
        btnManage.Image = My.Resources.ManageItemIconBlack

        btnSettings.BorderThickness = 2
        btnSettings.ForeColor = Color.FromArgb(255, 152, 19)
        btnSettings.Image = My.Resources.settingsIconColored

        pnlMain.Controls.Clear()
        Dim obj1 As New Settings With {
            .passEmail = toEmail,
            .passUsername = userPic,
            .TopLevel = False
        }
        pnlMain.Controls.Add(obj1)
        obj1.Dock = DockStyle.Fill
        obj1.Show()

    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        _useManageEventLeavee = False

        _useHomeEventLeave = True
        _useHistoryEventLeave = True
        _useMessageEventLeave = True
        _useSettingsEventLeave = True

        btnHome.BorderThickness = 0
        btnHome.ForeColor = Color.Black
        btnHome.Image = My.Resources.homeIconBlack
        btnHistory.BorderThickness = 0
        btnHistory.ForeColor = Color.Black
        btnHistory.Image = My.Resources.historyIconBlack
        btnMessage.BorderThickness = 0
        btnMessage.ForeColor = Color.Black
        btnMessage.Image = My.Resources.messageIconBlack
        btnSettings.BorderThickness = 0
        btnSettings.ForeColor = Color.Black
        btnSettings.Image = My.Resources.settingsIconBlack

        btnManage.BorderThickness = 2
        btnManage.ForeColor = Color.FromArgb(255, 152, 19)
        btnManage.Image = My.Resources.ManageItemIconColored

        pnlMain.Controls.Clear()
        Dim obj1 As New ProductsManagement With {
            .TopLevel = False
        }
        pnlMain.Controls.Add(obj1)
        obj1.Dock = DockStyle.Fill
        obj1.Show()
    End Sub

    Private Sub Homepage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Opacity = 1
        Dim tmr As New Timer With {
            .Interval = 1
        }
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Opacity -= 0.1
                                 If Me.Opacity = 0 Then
                                     e.Cancel = False
                                     tmr.Stop()
                                     Me.Dispose()
                                 End If
                             End Sub
    End Sub

    Private Sub btnCloseProg_Click(sender As Object, e As EventArgs) Handles btnCloseProg.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class