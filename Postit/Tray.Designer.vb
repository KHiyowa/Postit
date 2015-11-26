<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrayFm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrayFm))
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.NewBtn = New System.Windows.Forms.Button()
        Me.Tasktray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.HideBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'QuitBtn
        '
        Me.QuitBtn.Location = New System.Drawing.Point(12, 41)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(260, 23)
        Me.QuitBtn.TabIndex = 0
        Me.QuitBtn.Text = "アプリケーションの終了"
        Me.QuitBtn.UseVisualStyleBackColor = True
        '
        'NewBtn
        '
        Me.NewBtn.Location = New System.Drawing.Point(12, 12)
        Me.NewBtn.Name = "NewBtn"
        Me.NewBtn.Size = New System.Drawing.Size(260, 23)
        Me.NewBtn.TabIndex = 1
        Me.NewBtn.Text = "新しい付箋をつくる"
        Me.NewBtn.UseVisualStyleBackColor = True
        '
        'Tasktray
        '
        Me.Tasktray.Icon = CType(resources.GetObject("Tasktray.Icon"), System.Drawing.Icon)
        Me.Tasktray.Text = "Postit"
        Me.Tasktray.Visible = True
        '
        'HideBtn
        '
        Me.HideBtn.Location = New System.Drawing.Point(12, 89)
        Me.HideBtn.Name = "HideBtn"
        Me.HideBtn.Size = New System.Drawing.Size(260, 23)
        Me.HideBtn.TabIndex = 2
        Me.HideBtn.Text = "通知領域に最小化"
        Me.HideBtn.UseVisualStyleBackColor = True
        '
        'TrayFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 124)
        Me.ControlBox = False
        Me.Controls.Add(Me.HideBtn)
        Me.Controls.Add(Me.NewBtn)
        Me.Controls.Add(Me.QuitBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TrayFm"
        Me.ShowInTaskbar = False
        Me.Text = "Postit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QuitBtn As Button
    Friend WithEvents NewBtn As Button
    Friend WithEvents Tasktray As NotifyIcon
    Friend WithEvents HideBtn As Button
End Class
