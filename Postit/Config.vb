Public Class ConfigFm
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
        If TimerTb.Checked = True Then
            TimerTb.Text = "通知は有効です"
        Else
            TimerTb.Text = "通知を有効にする"
        End If
    End Sub

    Private Sub Plus10minBtn_Click(sender As Object, e As EventArgs) Handles Plus10minBtn.Click
        Dim Time As DateTime
        Dim Hour As Integer
        Dim Minute As Integer

        Time = NotifyTimeDtp.Text
        Hour = Time.Hour
        Minute = Time.Minute

        Minute += 10

        Hour = (Hour + (Minute \ 60)) Mod 24
        Minute = Minute Mod 60

        SetTime(Hour, Minute, Time.Second)

    End Sub

    Private Sub Plus1hBtn_Click(sender As Object, e As EventArgs) Handles Plus1hBtn.Click
        Dim Time As DateTime
        Dim Hour As Integer

        Time = NotifyTimeDtp.Text
        Hour = Time.Hour

        Hour = (Hour + 1) Mod 24

        SetTime(Hour, Time.Minute, Time.Second)

    End Sub

    Private Sub SetTime(Hour As Integer, Minute As Integer, Second As Integer)
        NotifyTimeDtp.Text = DateTime.Parse(Hour.ToString + ":" +
                                    Minute.ToString + ":" + Second.ToString)
    End Sub

    Private Sub SetCurrentTime()

    End Sub

End Class