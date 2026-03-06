<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextBoxForm
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
        Me.TxtBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'TxtBox
        '
        Me.TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBox.Location = New System.Drawing.Point(2, 2)
        Me.TxtBox.Name = "TxtBox"
        Me.TxtBox.Size = New System.Drawing.Size(699, 450)
        Me.TxtBox.TabIndex = 0
        Me.TxtBox.Text = ""
        '
        'TextBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 453)
        Me.Controls.Add(Me.TxtBox)
        Me.Name = "TextBoxForm"
        Me.Text = "TextBoxForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtBox As RichTextBox
End Class
