<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PostitFm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContentRtb = New System.Windows.Forms.RichTextBox()
        Me.NotifyTimerTm = New System.Windows.Forms.Timer(Me.components)
        Me.TrayNotifyNi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'ContentRtb
        '
        Me.ContentRtb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ContentRtb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentRtb.Location = New System.Drawing.Point(0, 0)
        Me.ContentRtb.Name = "ContentRtb"
        Me.ContentRtb.Size = New System.Drawing.Size(250, 200)
        Me.ContentRtb.TabIndex = 0
        Me.ContentRtb.Text = ""
        '
        'TrayNotifyNi
        '
        Me.TrayNotifyNi.Text = "お知らせ"
        '
        'PostitFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 200)
        Me.Controls.Add(Me.ContentRtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PostitFm"
        Me.Opacity = 0.8R
        Me.Text = "付箋"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContentRtb As RichTextBox
    Friend WithEvents NotifyTimerTm As Timer
    Friend WithEvents TrayNotifyNi As NotifyIcon
End Class
