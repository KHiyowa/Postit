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
        Me.ChangeColorBtn = New System.Windows.Forms.Button()
        Me.ChangeFontBtn = New System.Windows.Forms.Button()
        Me.ChooseColorCd = New System.Windows.Forms.ColorDialog()
        Me.ChooseFontFd = New System.Windows.Forms.FontDialog()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.TopMostCb = New System.Windows.Forms.CheckBox()
        Me.OpacityTb = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HeightTb = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LockCb = New System.Windows.Forms.CheckBox()
        CType(Me.OpacityTb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightTb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChangeColorBtn
        '
        Me.ChangeColorBtn.Location = New System.Drawing.Point(12, 12)
        Me.ChangeColorBtn.Name = "ChangeColorBtn"
        Me.ChangeColorBtn.Size = New System.Drawing.Size(97, 23)
        Me.ChangeColorBtn.TabIndex = 0
        Me.ChangeColorBtn.Text = "背景色を変更"
        Me.ChangeColorBtn.UseVisualStyleBackColor = True
        '
        'ChangeFontBtn
        '
        Me.ChangeFontBtn.Location = New System.Drawing.Point(115, 12)
        Me.ChangeFontBtn.Name = "ChangeFontBtn"
        Me.ChangeFontBtn.Size = New System.Drawing.Size(100, 23)
        Me.ChangeFontBtn.TabIndex = 1
        Me.ChangeFontBtn.Text = "フォントを変更"
        Me.ChangeFontBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(115, 199)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(98, 23)
        Me.CloseBtn.TabIndex = 2
        Me.CloseBtn.Text = "設定を閉じる"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'TopMostCb
        '
        Me.TopMostCb.AutoSize = True
        Me.TopMostCb.Checked = True
        Me.TopMostCb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TopMostCb.Location = New System.Drawing.Point(12, 155)
        Me.TopMostCb.Name = "TopMostCb"
        Me.TopMostCb.Size = New System.Drawing.Size(144, 16)
        Me.TopMostCb.TabIndex = 3
        Me.TopMostCb.Text = "この付箋を最前面に表示"
        Me.TopMostCb.UseVisualStyleBackColor = True
        '
        'OpacityTb
        '
        Me.OpacityTb.Location = New System.Drawing.Point(39, 53)
        Me.OpacityTb.Maximum = 100
        Me.OpacityTb.Minimum = 60
        Me.OpacityTb.Name = "OpacityTb"
        Me.OpacityTb.Size = New System.Drawing.Size(141, 45)
        Me.OpacityTb.TabIndex = 4
        Me.OpacityTb.TickFrequency = 5
        Me.OpacityTb.Value = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "透明度"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "60%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "100%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "縦の長さ"
        '
        'HeightTb
        '
        Me.HeightTb.LargeChange = 50
        Me.HeightTb.Location = New System.Drawing.Point(39, 104)
        Me.HeightTb.Maximum = 500
        Me.HeightTb.Minimum = 100
        Me.HeightTb.Name = "HeightTb"
        Me.HeightTb.Size = New System.Drawing.Size(141, 45)
        Me.HeightTb.SmallChange = 10
        Me.HeightTb.TabIndex = 9
        Me.HeightTb.TickFrequency = 50
        Me.HeightTb.Value = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "短い"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(186, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "長い"
        '
        'LockCb
        '
        Me.LockCb.AutoSize = True
        Me.LockCb.Location = New System.Drawing.Point(11, 177)
        Me.LockCb.Name = "LockCb"
        Me.LockCb.Size = New System.Drawing.Size(169, 16)
        Me.LockCb.TabIndex = 12
        Me.LockCb.Text = "この付箋を閉じる前に確認する"
        Me.LockCb.UseVisualStyleBackColor = True
        '
        'ConfigFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.LockCb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HeightTb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OpacityTb)
        Me.Controls.Add(Me.TopMostCb)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.ChangeFontBtn)
        Me.Controls.Add(Me.ChangeColorBtn)
        Me.Name = "ConfigFm"
        Me.ShowInTaskbar = False
        Me.Text = "設定"
        Me.TopMost = True
        CType(Me.OpacityTb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightTb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChangeColorBtn As Button
    Friend WithEvents ChangeFontBtn As Button
    Friend WithEvents ChooseColorCd As ColorDialog
    Friend WithEvents ChooseFontFd As FontDialog
    Friend WithEvents CloseBtn As Button
    Friend WithEvents TopMostCb As CheckBox
    Friend WithEvents OpacityTb As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HeightTb As TrackBar
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LockCb As CheckBox
End Class
