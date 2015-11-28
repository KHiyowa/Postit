Public Class ConfigFm

    Private Sub ConfigFm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ウインドウを開いたとき、リマインダに現在時刻を代入
        If PostitFm.NotifyTimerTm.Enabled = False Then SetCurrentTime()
    End Sub

    Private Sub ChangeColorBtn_Click(sender As Object, e As EventArgs)
        ' 設定中の付箋の色を変える。
        ' 色設定画面の呼出
        ChooseColorCd.ShowDialog()
        ' 色を適用
        PostitFm.ContentRtb.BackColor = ChooseColorCd.Color
    End Sub

    Private Sub ChangeFontBtn_Click(sender As Object, e As EventArgs)
        ' 設定中の付箋のフォントを変える。
        ' フォント設定画面の呼出
        ChooseFontFd.ShowDialog()
        ' フォントを適用
        PostitFm.ContentRtb.Font = ChooseFontFd.Font
    End Sub

    Private Sub TopMost_CheckedChanged(sender As Object, e As EventArgs)
        ' 設定中の付箋の最前面表示を切り替える
        PostitFm.TopMost = TopMostCb.Checked
    End Sub

    Private Sub LockCb_CheckedChanged(sender As Object, e As EventArgs)
        ' 設定中の付箋を閉じる前に確認
        PostitFm.AskBeforeClose = LockCb.Checked
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        ' 設定画面を閉じる
        Me.Close()
    End Sub

    Private Sub OpacityTb_Scroll(sender As Object, e As EventArgs)
        ' 設定中の付箋の透明度を変更する。
        PostitFm.Opacity = OpacityTb.Value / 100
    End Sub

    Private Sub HeightTb_Scroll(sender As Object, e As EventArgs)
        ' 設定中の付箋の縦の長さを変更する。
        PostitFm.Height = HeightTb.Value
    End Sub

    Private Sub TimerTb_CheckedChanged(sender As Object, e As EventArgs) Handles TimerTb.CheckedChanged
        Dim WillSetDateTime As DateTime = NotifyTimeDtp.Value

        ' 通知の有効/無効を切り替える
        If TimerTb.Checked = True Then
            If WillSetDateTime.CompareTo(DateTime.Now) < 0 Then
                WillSetDateTime = WillSetDateTime.AddDays(1.0)
            End If
            PostitFm.SetNotify(WillSetDateTime.Subtract(DateTime.Now))
            TimerTb.Text = "通知は有効です"
        Else
            PostitFm.CancelNotify()
            TimerTb.Text = "通知を有効にする"

        End If
    End Sub

    Private Sub NowBtn_Click(sender As Object, e As EventArgs) Handles NowBtn.Click
        ' 時刻欄に現在時刻を入力
        SetCurrentTime()
    End Sub

    Private Sub Plus10minBtn_Click(sender As Object, e As EventArgs) Handles Plus10minBtn.Click
        Dim Time As DateTime
        Dim Hour As Integer
        Dim Minute As Integer

        ' 表示中の時刻に10分を足して入力
        Time = NotifyTimeDtp.Text
        Hour = Time.Hour
        Minute = Time.Minute

        Minute += 10

        Hour = (Hour + (Minute \ 60)) Mod 24
        Minute = Minute Mod 60

        SetTime(Hour, Minute)

    End Sub

    Private Sub Plus1hBtn_Click(sender As Object, e As EventArgs) Handles Plus1hBtn.Click
        Dim Time As DateTime
        Dim Hour As Integer

        ' 表示中の時刻に1時間足して代入
        Time = NotifyTimeDtp.Text
        Hour = Time.Hour

        Hour = (Hour + 1) Mod 24

        SetTime(Hour, Time.Minute)

    End Sub

    Private Sub ToggleAMPMBtn_Click(sender As Object, e As EventArgs) Handles ToggleAMPMBtn.Click
        Dim Time As DateTime
        Dim Hour As Integer

        ' 表示中の時刻に12時間足して代入
        ' ここで継承が使えるとかっこいいかもしれない
        Time = NotifyTimeDtp.Text
        Hour = Time.Hour

        Hour = (Hour + 12) Mod 24

        SetTime(Hour, Time.Minute)
    End Sub

    Private Sub SetTime(Hour As Integer, Minute As Integer)
        ' 時と分を入力。秒は00とする。
        NotifyTimeDtp.Text = DateTime.Parse(Hour.ToString + ":" +
                                    Minute.ToString + ":" + "00")
    End Sub

    Private Sub SetCurrentTime()
        ' 現在時刻を取得して秒数を00にしてから代入
        Dim Time As DateTime = DateTime.Now
        Dim Hour As Integer = Time.Hour
        Dim Minute As Integer = Time.Minute

        SetTime(Hour, Minute)

    End Sub

End Class