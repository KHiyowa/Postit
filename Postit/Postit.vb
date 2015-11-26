﻿Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class PostitFm

    Inherits Form

    Private mouseX As Integer   ' マウスの横位置(x座標)
    Private mouseY As Integer   ' マウスの縦位置(y座標)
    Public AskBeforeClose As Boolean = False ' 閉じる前に確認するか

    Private Sub ContentRtb_KeyDown(sender As Object, e As KeyEventArgs) Handles ContentRtb.KeyDown
        Dim Ask As Integer

        ' <判定> 押されたキーがエスケープキーの場合
        If e.KeyCode = Keys.Escape Then
            If AskBeforeClose = False Then
                ' アプリケーションを終了
                Me.Close()
            Else
                Ask = MsgBox("この付箋を閉じますか?", vbYesNo + vbQuestion, "Postit")
                If Ask = vbYes Then Me.Close()
            End If
        End If
    End Sub

    Private Sub ContentRtb_MouseDown(sender As Object, e As MouseEventArgs) Handles ContentRtb.MouseDown
        ' <判定> 押されたキーがマウスの左ボタン?
        If e.Button = MouseButtons.Left Then
            Me.mouseX = e.X
            Me.mouseY = e.Y
        End If
    End Sub
    Private Sub ContentRtb_MouseMove(sender As Object, e As MouseEventArgs) Handles ContentRtb.MouseMove
        ' <判定> 押されたキーがマウスの左ボタン?
        If e.Button = MouseButtons.Left Then
            Me.Left += e.X - mouseX
            Me.Top += e.Y - mouseY
        End If
    End Sub
    Private Sub ContentRtb_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ContentRtb.MouseDoubleClick
        ' 設定画面関連
        ' 設定画面をモードレスで呼出
        ConfigFm.Show()
        ' 最前面表示の状態を設定画面に反映
        ConfigFm.TopMostCb.Checked = Me.TopMost
        ' 閉じる前に確認の状態を設定画面に反映
        ConfigFm.LockCb.Checked = AskBeforeClose
        ' 透明度の状態を設定画面に反映
        ConfigFm.OpacityTb.Value = Me.Opacity * 100
        ' 縦の長さの状態を設定画面に反映
        ConfigFm.HeightTb.Value = Me.Size.Height
    End Sub

End Class
