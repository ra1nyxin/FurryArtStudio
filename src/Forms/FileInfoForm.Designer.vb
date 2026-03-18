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
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.MsInfo = New System.Windows.Forms.TabPage()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblNotes = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.LblUpdate = New System.Windows.Forms.Label()
        Me.LblImport = New System.Windows.Forms.Label()
        Me.LblCreate = New System.Windows.Forms.Label()
        Me.LblTags = New System.Windows.Forms.Label()
        Me.LblRoles = New System.Windows.Forms.Label()
        Me.LblUUID = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.FileInfo = New System.Windows.Forms.TabPage()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.BtnCopyPath = New System.Windows.Forms.Button()
        Me.BtnHash = New System.Windows.Forms.Button()
        Me.BtnProp = New System.Windows.Forms.Button()
        Me.LblSize = New System.Windows.Forms.Label()
        Me.LblType = New System.Windows.Forms.Label()
        Me.LblRes = New System.Windows.Forms.Label()
        Me.LnkPath = New System.Windows.Forms.LinkLabel()
        Me.ColorInfo = New System.Windows.Forms.TabPage()
        Me.MainTabControl.SuspendLayout()
        Me.MsInfo.SuspendLayout()
        Me.FileInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.MsInfo)
        Me.MainTabControl.Controls.Add(Me.FileInfo)
        Me.MainTabControl.Controls.Add(Me.ColorInfo)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(582, 403)
        Me.MainTabControl.TabIndex = 0
        '
        'MsInfo
        '
        Me.MsInfo.Controls.Add(Me.BtnClose)
        Me.MsInfo.Controls.Add(Me.LblNotes)
        Me.MsInfo.Controls.Add(Me.BtnEdit)
        Me.MsInfo.Controls.Add(Me.LblUpdate)
        Me.MsInfo.Controls.Add(Me.LblImport)
        Me.MsInfo.Controls.Add(Me.LblCreate)
        Me.MsInfo.Controls.Add(Me.LblTags)
        Me.MsInfo.Controls.Add(Me.LblRoles)
        Me.MsInfo.Controls.Add(Me.LblUUID)
        Me.MsInfo.Controls.Add(Me.LblAuthor)
        Me.MsInfo.Controls.Add(Me.LblTitle)
        Me.MsInfo.Location = New System.Drawing.Point(4, 25)
        Me.MsInfo.Name = "MsInfo"
        Me.MsInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.MsInfo.Size = New System.Drawing.Size(574, 374)
        Me.MsInfo.TabIndex = 0
        Me.MsInfo.Text = "稿件"
        Me.MsInfo.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(446, 326)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(120, 40)
        Me.BtnClose.TabIndex = 10
        Me.BtnClose.Text = "关闭(&C)"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblNotes
        '
        Me.LblNotes.Location = New System.Drawing.Point(8, 237)
        Me.LblNotes.Name = "LblNotes"
        Me.LblNotes.Size = New System.Drawing.Size(558, 77)
        Me.LblNotes.TabIndex = 9
        Me.LblNotes.Text = "备注: "
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(8, 326)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(120, 40)
        Me.BtnEdit.TabIndex = 8
        Me.BtnEdit.Text = "编辑(&E)"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'LblUpdate
        '
        Me.LblUpdate.Location = New System.Drawing.Point(8, 209)
        Me.LblUpdate.Name = "LblUpdate"
        Me.LblUpdate.Size = New System.Drawing.Size(558, 23)
        Me.LblUpdate.TabIndex = 7
        Me.LblUpdate.Text = "更新时间: "
        Me.LblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImport
        '
        Me.LblImport.Location = New System.Drawing.Point(8, 181)
        Me.LblImport.Name = "LblImport"
        Me.LblImport.Size = New System.Drawing.Size(558, 23)
        Me.LblImport.TabIndex = 6
        Me.LblImport.Text = "入库时间: "
        Me.LblImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCreate
        '
        Me.LblCreate.Location = New System.Drawing.Point(8, 153)
        Me.LblCreate.Name = "LblCreate"
        Me.LblCreate.Size = New System.Drawing.Size(558, 23)
        Me.LblCreate.TabIndex = 5
        Me.LblCreate.Text = "创作时间: "
        Me.LblCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTags
        '
        Me.LblTags.Location = New System.Drawing.Point(8, 125)
        Me.LblTags.Name = "LblTags"
        Me.LblTags.Size = New System.Drawing.Size(558, 23)
        Me.LblTags.TabIndex = 4
        Me.LblTags.Text = "标签: "
        Me.LblTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRoles
        '
        Me.LblRoles.Location = New System.Drawing.Point(8, 97)
        Me.LblRoles.Name = "LblRoles"
        Me.LblRoles.Size = New System.Drawing.Size(558, 23)
        Me.LblRoles.TabIndex = 3
        Me.LblRoles.Text = "角色: "
        Me.LblRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUUID
        '
        Me.LblUUID.Location = New System.Drawing.Point(8, 69)
        Me.LblUUID.Name = "LblUUID"
        Me.LblUUID.Size = New System.Drawing.Size(558, 23)
        Me.LblUUID.TabIndex = 2
        Me.LblUUID.Text = "UUID: "
        Me.LblUUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAuthor
        '
        Me.LblAuthor.Location = New System.Drawing.Point(8, 41)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(558, 23)
        Me.LblAuthor.TabIndex = 1
        Me.LblAuthor.Text = "作者: "
        Me.LblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTitle
        '
        Me.LblTitle.Location = New System.Drawing.Point(8, 13)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(558, 23)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "标题: "
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FileInfo
        '
        Me.FileInfo.Controls.Add(Me.LnkPath)
        Me.FileInfo.Controls.Add(Me.LblTime)
        Me.FileInfo.Controls.Add(Me.BtnOpen)
        Me.FileInfo.Controls.Add(Me.BtnCopyPath)
        Me.FileInfo.Controls.Add(Me.BtnHash)
        Me.FileInfo.Controls.Add(Me.BtnProp)
        Me.FileInfo.Controls.Add(Me.LblSize)
        Me.FileInfo.Controls.Add(Me.LblType)
        Me.FileInfo.Controls.Add(Me.LblRes)
        Me.FileInfo.Location = New System.Drawing.Point(4, 25)
        Me.FileInfo.Name = "FileInfo"
        Me.FileInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.FileInfo.Size = New System.Drawing.Size(574, 374)
        Me.FileInfo.TabIndex = 1
        Me.FileInfo.Text = "文件"
        Me.FileInfo.UseVisualStyleBackColor = True
        '
        'LblTime
        '
        Me.LblTime.Location = New System.Drawing.Point(8, 125)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(558, 23)
        Me.LblTime.TabIndex = 25
        Me.LblTime.Text = "创建时间: 修改时间: "
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(446, 52)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(120, 40)
        Me.BtnOpen.TabIndex = 24
        Me.BtnOpen.Text = "打开(&O)"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'BtnCopyPath
        '
        Me.BtnCopyPath.Location = New System.Drawing.Point(446, 6)
        Me.BtnCopyPath.Name = "BtnCopyPath"
        Me.BtnCopyPath.Size = New System.Drawing.Size(120, 40)
        Me.BtnCopyPath.TabIndex = 23
        Me.BtnCopyPath.Text = "复制路径(&C)"
        Me.BtnCopyPath.UseVisualStyleBackColor = True
        '
        'BtnHash
        '
        Me.BtnHash.Location = New System.Drawing.Point(446, 326)
        Me.BtnHash.Name = "BtnHash"
        Me.BtnHash.Size = New System.Drawing.Size(120, 40)
        Me.BtnHash.TabIndex = 21
        Me.BtnHash.Text = "哈希(&H)..."
        Me.BtnHash.UseVisualStyleBackColor = True
        '
        'BtnProp
        '
        Me.BtnProp.Location = New System.Drawing.Point(8, 326)
        Me.BtnProp.Name = "BtnProp"
        Me.BtnProp.Size = New System.Drawing.Size(120, 40)
        Me.BtnProp.TabIndex = 19
        Me.BtnProp.Text = "属性(&R)"
        Me.BtnProp.UseVisualStyleBackColor = True
        '
        'LblSize
        '
        Me.LblSize.Location = New System.Drawing.Point(8, 97)
        Me.LblSize.Name = "LblSize"
        Me.LblSize.Size = New System.Drawing.Size(558, 23)
        Me.LblSize.TabIndex = 14
        Me.LblSize.Text = "文件大小: "
        Me.LblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblType
        '
        Me.LblType.Location = New System.Drawing.Point(8, 69)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(432, 23)
        Me.LblType.TabIndex = 13
        Me.LblType.Text = "文件类型: "
        Me.LblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRes
        '
        Me.LblRes.Location = New System.Drawing.Point(8, 41)
        Me.LblRes.Name = "LblRes"
        Me.LblRes.Size = New System.Drawing.Size(432, 23)
        Me.LblRes.TabIndex = 12
        Me.LblRes.Text = "分辨率: 位深:"
        Me.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LnkPath
        '
        Me.LnkPath.Location = New System.Drawing.Point(8, 13)
        Me.LnkPath.Name = "LnkPath"
        Me.LnkPath.Size = New System.Drawing.Size(432, 23)
        Me.LnkPath.TabIndex = 27
        Me.LnkPath.TabStop = True
        Me.LnkPath.Text = "路径"
        Me.LnkPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ColorInfo
        '
        Me.ColorInfo.Location = New System.Drawing.Point(4, 25)
        Me.ColorInfo.Name = "ColorInfo"
        Me.ColorInfo.Size = New System.Drawing.Size(574, 374)
        Me.ColorInfo.TabIndex = 2
        Me.ColorInfo.Text = "颜色"
        Me.ColorInfo.UseVisualStyleBackColor = True
        '
        'InfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 403)
        Me.Controls.Add(Me.MainTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InfoForm"
        Me.Text = "属性"
        Me.MainTabControl.ResumeLayout(False)
        Me.MsInfo.ResumeLayout(False)
        Me.FileInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents MsInfo As TabPage
    Friend WithEvents FileInfo As TabPage
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblAuthor As Label
    Friend WithEvents LblRoles As Label
    Friend WithEvents LblUUID As Label
    Friend WithEvents LblUpdate As Label
    Friend WithEvents LblImport As Label
    Friend WithEvents LblCreate As Label
    Friend WithEvents LblTags As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents LblNotes As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnHash As Button
    Friend WithEvents BtnProp As Button
    Friend WithEvents LblSize As Label
    Friend WithEvents LblType As Label
    Friend WithEvents LblRes As Label
    Friend WithEvents BtnCopyPath As Button
    Friend WithEvents BtnOpen As Button
    Friend WithEvents LblTime As Label
    Friend WithEvents LnkPath As LinkLabel
    Friend WithEvents ColorInfo As TabPage
End Class
