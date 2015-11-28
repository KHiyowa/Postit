<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigFm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ChooseColorCd = New System.Windows.Forms.ColorDialog()
        Me.ChooseFontFd = New System.Windows.Forms.FontDialog()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.ConfigTc = New System.Windows.Forms.TabControl()
        Me.GeneralTp = New System.Windows.Forms.TabPage()
        Me.LockCb = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HeightTb = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Opacity100Lb = New System.Windows.Forms.Label()
        Me.Opacity60Lb = New System.Windows.Forms.Label()
        Me.OpacityLb = New System.Windows.Forms.Label()
        Me.OpacityTb = New System.Windows.Forms.TrackBar()
        Me.TopMostCb = New System.Windows.Forms.CheckBox()
        Me.ChangeFontBtn = New System.Windows.Forms.Button()
        Me.ChangeColorBtn = New System.Windows.Forms.Button()
        Me.ReminderTp = New System.Windows.Forms.TabPage()
        Me.ToggleAMPMBtn = New System.Windows.Forms.Button()
        Me.NowBtn = New System.Windows.Forms.Button()
        Me.Plus1hBtn = New System.Windows.Forms.Button()
        Me.Plus10minBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifyTimeDtp = New System.Windows.Forms.DateTimePicker()
        Me.TimerTb = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ConfigTc.SuspendLayout()
        Me.GeneralTp.SuspendLayout()
        CType(Me.HeightTb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpacityTb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReminderTp.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(135, 237)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(98, 23)
        Me.CloseBtn.TabIndex = 2
        Me.CloseBtn.Text = "設定を閉じる"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'ConfigTc
        '
        Me.ConfigTc.Controls.Add(Me.GeneralTp)
        Me.ConfigTc.Controls.Add(Me.ReminderTp)
        Me.ConfigTc.Location = New System.Drawing.Point(12, 12)
        Me.ConfigTc.Name = "ConfigTc"
        Me.ConfigTc.SelectedIndex = 0
        Me.ConfigTc.Size = New System.Drawing.Size(225, 219)
        Me.ConfigTc.TabIndex = 13
        '
        'GeneralTp
        '
        Me.GeneralTp.BackColor = System.Drawing.SystemColors.Control
        Me.GeneralTp.Controls.Add(Me.LockCb)
        Me.GeneralTp.Controls.Add(Me.Label6)
        Me.GeneralTp.Controls.Add(Me.Label5)
        Me.GeneralTp.Controls.Add(Me.HeightTb)
        Me.GeneralTp.Controls.Add(Me.Label4)
        Me.GeneralTp.Controls.Add(Me.Opacity100Lb)
        Me.GeneralTp.Controls.Add(Me.Opacity60Lb)
        Me.GeneralTp.Controls.Add(Me.OpacityLb)
        Me.GeneralTp.Controls.Add(Me.OpacityTb)
        Me.GeneralTp.Controls.Add(Me.TopMostCb)
        Me.GeneralTp.Controls.Add(Me.ChangeFontBtn)
        Me.GeneralTp.Controls.Add(Me.ChangeColorBtn)
        Me.GeneralTp.Location = New System.Drawing.Point(4, 22)
        Me.GeneralTp.Name = "GeneralTp"
        Me.GeneralTp.Padding = New System.Windows.Forms.Padding(3)
        Me.GeneralTp.Size = New System.Drawing.Size(217, 193)
        Me.GeneralTp.TabIndex = 0
        Me.GeneralTp.Text = "一般"
        '
        'LockCb
        '
        Me.LockCb.AutoSize = True
        Me.LockCb.Location = New System.Drawing.Point(6, 171)
        Me.LockCb.Name = "LockCb"
        Me.LockCb.Size = New System.Drawing.Size(169, 16)
        Me.LockCb.TabIndex = 24
        Me.LockCb.Text = "この付箋を閉じる前に確認する"
        Me.LockCb.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(170, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 12)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "長い"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 12)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "短い"
        '
        'HeightTb
        '
        Me.HeightTb.LargeChange = 50
        Me.HeightTb.Location = New System.Drawing.Point(33, 98)
        Me.HeightTb.Maximum = 500
        Me.HeightTb.Minimum = 100
        Me.HeightTb.Name = "HeightTb"
        Me.HeightTb.Size = New System.Drawing.Size(141, 45)
        Me.HeightTb.SmallChange = 10
        Me.HeightTb.TabIndex = 21
        Me.HeightTb.TickFrequency = 50
        Me.HeightTb.Value = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "縦の長さ"
        '
        'Opacity100Lb
        '
        Me.Opacity100Lb.AutoSize = True
        Me.Opacity100Lb.Location = New System.Drawing.Point(170, 57)
        Me.Opacity100Lb.Name = "Opacity100Lb"
        Me.Opacity100Lb.Size = New System.Drawing.Size(41, 12)
        Me.Opacity100Lb.TabIndex = 19
        Me.Opacity100Lb.Text = "不透明"
        '
        'Opacity60Lb
        '
        Me.Opacity60Lb.AutoSize = True
        Me.Opacity60Lb.Location = New System.Drawing.Point(4, 57)
        Me.Opacity60Lb.Name = "Opacity60Lb"
        Me.Opacity60Lb.Size = New System.Drawing.Size(23, 12)
        Me.Opacity60Lb.TabIndex = 18
        Me.Opacity60Lb.Text = "60%"
        '
        'OpacityLb
        '
        Me.OpacityLb.AutoSize = True
        Me.OpacityLb.Location = New System.Drawing.Point(4, 32)
        Me.OpacityLb.Name = "OpacityLb"
        Me.OpacityLb.Size = New System.Drawing.Size(41, 12)
        Me.OpacityLb.TabIndex = 17
        Me.OpacityLb.Text = "透明度"
        '
        'OpacityTb
        '
        Me.OpacityTb.Location = New System.Drawing.Point(33, 47)
        Me.OpacityTb.Maximum = 100
        Me.OpacityTb.Minimum = 60
        Me.OpacityTb.Name = "OpacityTb"
        Me.OpacityTb.Size = New System.Drawing.Size(141, 45)
        Me.OpacityTb.TabIndex = 16
        Me.OpacityTb.TickFrequency = 5
        Me.OpacityTb.Value = 60
        '
        'TopMostCb
        '
        Me.TopMostCb.AutoSize = True
        Me.TopMostCb.Checked = True
        Me.TopMostCb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TopMostCb.Location = New System.Drawing.Point(6, 149)
        Me.TopMostCb.Name = "TopMostCb"
        Me.TopMostCb.Size = New System.Drawing.Size(144, 16)
        Me.TopMostCb.TabIndex = 15
        Me.TopMostCb.Text = "この付箋を最前面に表示"
        Me.TopMostCb.UseVisualStyleBackColor = True
        '
        'ChangeFontBtn
        '
        Me.ChangeFontBtn.Location = New System.Drawing.Point(109, 6)
        Me.ChangeFontBtn.Name = "ChangeFontBtn"
        Me.ChangeFontBtn.Size = New System.Drawing.Size(100, 23)
        Me.ChangeFontBtn.TabIndex = 14
        Me.ChangeFontBtn.Text = "フォントを変更"
        Me.ChangeFontBtn.UseVisualStyleBackColor = True
        '
        'ChangeColorBtn
        '
        Me.ChangeColorBtn.Location = New System.Drawing.Point(6, 6)
        Me.ChangeColorBtn.Name = "ChangeColorBtn"
        Me.ChangeColorBtn.Size = New System.Drawing.Size(97, 23)
        Me.ChangeColorBtn.TabIndex = 13
        Me.ChangeColorBtn.Text = "背景色を変更"
        Me.ChangeColorBtn.UseVisualStyleBackColor = True
        '
        'ReminderTp
        '
        Me.ReminderTp.BackColor = System.Drawing.SystemColors.Control
        Me.ReminderTp.Controls.Add(Me.ToggleAMPMBtn)
        Me.ReminderTp.Controls.Add(Me.NowBtn)
        Me.ReminderTp.Controls.Add(Me.Plus1hBtn)
        Me.ReminderTp.Controls.Add(Me.Plus10minBtn)
        Me.ReminderTp.Controls.Add(Me.Label1)
        Me.ReminderTp.Controls.Add(Me.NotifyTimeDtp)
        Me.ReminderTp.Controls.Add(Me.TimerTb)
        Me.ReminderTp.Controls.Add(Me.Label7)
        Me.ReminderTp.Location = New System.Drawing.Point(4, 22)
        Me.ReminderTp.Name = "ReminderTp"
        Me.ReminderTp.Padding = New System.Windows.Forms.Padding(3)
        Me.ReminderTp.Size = New System.Drawing.Size(217, 193)
        Me.ReminderTp.TabIndex = 1
        Me.ReminderTp.Text = "リマインダ"
        '
        'ToggleAMPMBtn
        '
        Me.ToggleAMPMBtn.Location = New System.Drawing.Point(105, 86)
        Me.ToggleAMPMBtn.Name = "ToggleAMPMBtn"
        Me.ToggleAMPMBtn.Size = New System.Drawing.Size(75, 23)
        Me.ToggleAMPMBtn.TabIndex = 7
        Me.ToggleAMPMBtn.Text = "12時間反転"
        Me.ToggleAMPMBtn.UseVisualStyleBackColor = True
        '
        'NowBtn
        '
        Me.NowBtn.Location = New System.Drawing.Point(31, 86)
        Me.NowBtn.Name = "NowBtn"
        Me.NowBtn.Size = New System.Drawing.Size(75, 23)
        Me.NowBtn.TabIndex = 6
        Me.NowBtn.Text = "現在時刻"
        Me.NowBtn.UseVisualStyleBackColor = True
        '
        'Plus1hBtn
        '
        Me.Plus1hBtn.Location = New System.Drawing.Point(105, 115)
        Me.Plus1hBtn.Name = "Plus1hBtn"
        Me.Plus1hBtn.Size = New System.Drawing.Size(75, 23)
        Me.Plus1hBtn.TabIndex = 5
        Me.Plus1hBtn.Text = "+1時間"
        Me.Plus1hBtn.UseVisualStyleBackColor = True
        '
        'Plus10minBtn
        '
        Me.Plus10minBtn.Location = New System.Drawing.Point(31, 115)
        Me.Plus10minBtn.Name = "Plus10minBtn"
        Me.Plus10minBtn.Size = New System.Drawing.Size(75, 23)
        Me.Plus10minBtn.TabIndex = 4
        Me.Plus10minBtn.Text = "+10分"
        Me.Plus10minBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "通知時刻"
        '
        'NotifyTimeDtp
        '
        Me.NotifyTimeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.NotifyTimeDtp.Location = New System.Drawing.Point(105, 49)
        Me.NotifyTimeDtp.Name = "NotifyTimeDtp"
        Me.NotifyTimeDtp.ShowUpDown = True
        Me.NotifyTimeDtp.Size = New System.Drawing.Size(76, 19)
        Me.NotifyTimeDtp.TabIndex = 2
        Me.NotifyTimeDtp.Value = New Date(2015, 11, 27, 2, 54, 51, 0)
        '
        'TimerTb
        '
        Me.TimerTb.Appearance = System.Windows.Forms.Appearance.Button
        Me.TimerTb.Location = New System.Drawing.Point(61, 164)
        Me.TimerTb.Name = "TimerTb"
        Me.TimerTb.Size = New System.Drawing.Size(98, 23)
        Me.TimerTb.TabIndex = 1
        Me.TimerTb.Text = "通知を有効にする"
        Me.TimerTb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TimerTb.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 30)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "指定時刻になるとメッセージボックスでお知らせします"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConfigFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.ConfigTc)
        Me.Controls.Add(Me.CloseBtn)
        Me.Name = "ConfigFm"
        Me.ShowInTaskbar = False
        Me.Text = "設定"
        Me.TopMost = True
        Me.ConfigTc.ResumeLayout(False)
        Me.GeneralTp.ResumeLayout(False)
        Me.GeneralTp.PerformLayout()
        CType(Me.HeightTb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpacityTb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReminderTp.ResumeLayout(False)
        Me.ReminderTp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChooseColorCd As ColorDialog
    Friend WithEvents ChooseFontFd As FontDialog
    Friend WithEvents CloseBtn As Button
    Friend WithEvents ConfigTc As TabControl
    Friend WithEvents GeneralTp As TabPage
    Friend WithEvents LockCb As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents HeightTb As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Opacity100Lb As Label
    Friend WithEvents Opacity60Lb As Label
    Friend WithEvents OpacityLb As Label
    Friend WithEvents OpacityTb As TrackBar
    Friend WithEvents TopMostCb As CheckBox
    Friend WithEvents ChangeFontBtn As Button
    Friend WithEvents ChangeColorBtn As Button
    Friend WithEvents ReminderTp As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NotifyTimeDtp As DateTimePicker
    Friend WithEvents TimerTb As CheckBox
    Friend WithEvents Plus1hBtn As Button
    Friend WithEvents Plus10minBtn As Button
    Friend WithEvents ToggleAMPMBtn As Button
    Friend WithEvents NowBtn As Button
End Class
