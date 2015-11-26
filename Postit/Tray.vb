Imports System
Imports System.Threading

Public Class TrayFm

    Private Sub NewBtn_Click(sender As Object, e As EventArgs) Handles NewBtn.Click
        ' スレッドの宣言
        Dim thread As New Thread(New ThreadStart(AddressOf PostitThread))

        ' 新しいスレッドを生成し、付箋を表示する
        thread.Start()
    End Sub

    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        Dim Ask As Integer

        ' アプリケーションの終了
        Ask = MsgBox("アプリケーションを終了しますか?", vbYesNo + vbQuestion, "Postit")
        If Ask = vbYes Then Application.Exit()
    End Sub

    Private Sub HideBtn_Click(sender As Object, e As EventArgs) Handles HideBtn.Click
        ' 最小化
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Tasktray_Click(sender As Object, e As EventArgs) Handles Tasktray.Click
        ' タスクトレイアイコンをクリックすると標準表示
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Shared Sub PostitThread()
        ' 付箋をモーダルで表示
        PostitFm.ShowDialog()
    End Sub

End Class