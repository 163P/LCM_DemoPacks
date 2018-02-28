<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LibraryVersionLabel = New System.Windows.Forms.Label()
        Me.LibraryLabel = New System.Windows.Forms.Label()
        Me.BaseOtoVersionLabel = New System.Windows.Forms.Label()
        Me.UpdaterVersionLabel = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "确认"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(367, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "基础音库版本："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "基础音库原音设定集版本："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "音库目录："
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 161)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(542, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(104, 17)
        Me.ToolStripStatusLabel1.Text = "正在等待确认目录"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(83, 17)
        Me.ToolStripStatusLabel2.Text = "音库名：Lime"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "附属于LCM程序链 版本："
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(455, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "更新"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LibraryVersionLabel
        '
        Me.LibraryVersionLabel.AutoSize = True
        Me.LibraryVersionLabel.Location = New System.Drawing.Point(167, 45)
        Me.LibraryVersionLabel.Name = "LibraryVersionLabel"
        Me.LibraryVersionLabel.Size = New System.Drawing.Size(35, 12)
        Me.LibraryVersionLabel.TabIndex = 9
        Me.LibraryVersionLabel.Text = "0.1.1"
        '
        'LibraryLabel
        '
        Me.LibraryLabel.AutoSize = True
        Me.LibraryLabel.Location = New System.Drawing.Point(167, 74)
        Me.LibraryLabel.Name = "LibraryLabel"
        Me.LibraryLabel.Size = New System.Drawing.Size(41, 12)
        Me.LibraryLabel.TabIndex = 10
        Me.LibraryLabel.Text = "未检测"
        '
        'BaseOtoVersionLabel
        '
        Me.BaseOtoVersionLabel.AutoSize = True
        Me.BaseOtoVersionLabel.Location = New System.Drawing.Point(167, 103)
        Me.BaseOtoVersionLabel.Name = "BaseOtoVersionLabel"
        Me.BaseOtoVersionLabel.Size = New System.Drawing.Size(41, 12)
        Me.BaseOtoVersionLabel.TabIndex = 11
        Me.BaseOtoVersionLabel.Text = "未检测"
        '
        'UpdaterVersionLabel
        '
        Me.UpdaterVersionLabel.AutoSize = True
        Me.UpdaterVersionLabel.Location = New System.Drawing.Point(501, 137)
        Me.UpdaterVersionLabel.Name = "UpdaterVersionLabel"
        Me.UpdaterVersionLabel.Size = New System.Drawing.Size(29, 12)
        Me.UpdaterVersionLabel.TabIndex = 12
        Me.UpdaterVersionLabel.Text = "2684"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(455, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "更新"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(455, 98)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "更新"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 12)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "附加音库原音设定集版本："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 183)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.UpdaterVersionLabel)
        Me.Controls.Add(Me.BaseOtoVersionLabel)
        Me.Controls.Add(Me.LibraryLabel)
        Me.Controls.Add(Me.LibraryVersionLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "LcmUpdater"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents LibraryVersionLabel As Label
    Friend WithEvents LibraryLabel As Label
    Friend WithEvents BaseOtoVersionLabel As Label
    Friend WithEvents UpdaterVersionLabel As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
End Class
