<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoForm
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
        Me.GrpInfo = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'GrpInfo
        '
        Me.GrpInfo.Location = New System.Drawing.Point(12, 12)
        Me.GrpInfo.Name = "GrpInfo"
        Me.GrpInfo.Size = New System.Drawing.Size(254, 379)
        Me.GrpInfo.TabIndex = 0
        Me.GrpInfo.TabStop = False
        Me.GrpInfo.Text = "信息"
        '
        'InfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 403)
        Me.Controls.Add(Me.GrpInfo)
        Me.Name = "InfoForm"
        Me.Text = "InfoForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpInfo As GroupBox
End Class
