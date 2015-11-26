Public Class ConfigFm
    Private Sub ChangeColorBtn_Click(sender As Object, e As EventArgs) Handles ChangeColorBtn.Click
        ' 設定中の付箋の色を変える。
        ' 色設定画面の呼出
        ChooseColorCd.ShowDialog()
        ' 色を適用
        PostitFm.ContentRtb.BackColor = ChooseColorCd.Color
    End Sub

    Private Sub ChangeFontBtn_Click(sender As Object, e As EventArgs) Handles ChangeFontBtn.Click
        ' 設定中の付箋のフォントを変える。
        ' フォント設定画面の呼出
        ChooseFontFd.ShowDialog()
        ' フォントを適用
        PostitFm.ContentRtb.Font = ChooseFontFd.Font
    End Sub

    Private Sub TopMost_CheckedChanged(sender As Object, e As EventArgs) Handles TopMostCb.CheckedChanged
        ' 設定中の付箋の最前面表示を切り替える
        PostitFm.TopMost = TopMostCb.Checked
    End Sub

    Private Sub LockCb_CheckedChanged(sender As Object, e As EventArgs) Handles LockCb.CheckedChanged
        ' 設定中の付箋を閉じる前に確認
        PostitFm.AskBeforeClose = LockCb.Checked
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        ' 設定画面を閉じる
        Me.Close()
    End Sub

    Private Sub OpacityTb_Scroll(sender As Object, e As EventArgs) Handles OpacityTb.Scroll
        ' 設定中の付箋の透明度を変更する。
        PostitFm.Opacity = OpacityTb.Value / 100
    End Sub

    Private Sub HeightTb_Scroll(sender As Object, e As EventArgs) Handles HeightTb.Scroll
        ' 設定中の付箋の縦の長さを変更する。
        PostitFm.Height = HeightTb.Value
    End Sub

End Class