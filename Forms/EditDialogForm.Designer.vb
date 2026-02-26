<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditDialogForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtboxTitle = New System.Windows.Forms.TextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtboxAuthor = New System.Windows.Forms.TextBox()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.PreviewPicturebox = New System.Windows.Forms.PictureBox()
        Me.BtnModify = New System.Windows.Forms.Button()
        Me.LblUUID = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TxtboxCharacters = New System.Windows.Forms.TextBox()
        Me.LblCharacters = New System.Windows.Forms.Label()
        Me.TxtboxTags = New System.Windows.Forms.TextBox()
        Me.LblTags = New System.Windows.Forms.Label()
        Me.LblImportTime = New System.Windows.Forms.Label()
        Me.LblUpdateTime = New System.Windows.Forms.Label()
        Me.LblCreateTime = New System.Windows.Forms.Label()
        Me.TxtboxCreateTime = New System.Windows.Forms.TextBox()
        Me.TxtboxNotes = New System.Windows.Forms.TextBox()
        Me.LblNotes = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LstBox = New System.Windows.Forms.ListBox()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnSetPreview = New System.Windows.Forms.Button()
        Me.SelectPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PreviewPicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtboxTitle
        '
        Me.TxtboxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtboxTitle.Location = New System.Drawing.Point(285, 12)
        Me.TxtboxTitle.Name = "TxtboxTitle"
        Me.TxtboxTitle.Size = New System.Drawing.Size(249, 25)
        Me.TxtboxTitle.TabIndex = 1
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(219, 15)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(45, 15)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "标题:"
        '
        'TxtboxAuthor
        '
        Me.TxtboxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtboxAuthor.Location = New System.Drawing.Point(285, 45)
        Me.TxtboxAuthor.Name = "TxtboxAuthor"
        Me.TxtboxAuthor.Size = New System.Drawing.Size(249, 25)
        Me.TxtboxAuthor.TabIndex = 2
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Location = New System.Drawing.Point(219, 48)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(45, 15)
        Me.LblAuthor.TabIndex = 3
        Me.LblAuthor.Text = "作者:"
        '
        'PreviewPicturebox
        '
        Me.PreviewPicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PreviewPicturebox.Location = New System.Drawing.Point(12, 12)
        Me.PreviewPicturebox.Name = "PreviewPicturebox"
        Me.PreviewPicturebox.Size = New System.Drawing.Size(200, 200)
        Me.PreviewPicturebox.TabIndex = 5
        Me.PreviewPicturebox.TabStop = False
        '
        'BtnModify
        '
        Me.BtnModify.Location = New System.Drawing.Point(310, 383)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(109, 49)
        Me.BtnModify.TabIndex = 11
        Me.BtnModify.Text = "保存(&S)"
        Me.BtnModify.UseVisualStyleBackColor = True
        '
        'LblUUID
        '
        Me.LblUUID.AutoSize = True
        Me.LblUUID.Location = New System.Drawing.Point(12, 400)
        Me.LblUUID.Name = "LblUUID"
        Me.LblUUID.Size = New System.Drawing.Size(15, 15)
        Me.LblUUID.TabIndex = 7
        Me.LblUUID.Text = " "
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(425, 383)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(109, 49)
        Me.BtnCancel.TabIndex = 12
        Me.BtnCancel.Text = "取消(&C)"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'TxtboxCharacters
        '
        Me.TxtboxCharacters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtboxCharacters.Location = New System.Drawing.Point(285, 78)
        Me.TxtboxCharacters.Name = "TxtboxCharacters"
        Me.TxtboxCharacters.Size = New System.Drawing.Size(249, 25)
        Me.TxtboxCharacters.TabIndex = 3
        '
        'LblCharacters
        '
        Me.LblCharacters.AutoSize = True
        Me.LblCharacters.Location = New System.Drawing.Point(219, 81)
        Me.LblCharacters.Name = "LblCharacters"
        Me.LblCharacters.Size = New System.Drawing.Size(45, 15)
        Me.LblCharacters.TabIndex = 10
        Me.LblCharacters.Text = "角色:"
        '
        'TxtboxTags
        '
        Me.TxtboxTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtboxTags.Location = New System.Drawing.Point(285, 111)
        Me.TxtboxTags.Name = "TxtboxTags"
        Me.TxtboxTags.Size = New System.Drawing.Size(249, 25)
        Me.TxtboxTags.TabIndex = 4
        '
        'LblTags
        '
        Me.LblTags.AutoSize = True
        Me.LblTags.Location = New System.Drawing.Point(219, 114)
        Me.LblTags.Name = "LblTags"
        Me.LblTags.Size = New System.Drawing.Size(45, 15)
        Me.LblTags.TabIndex = 12
        Me.LblTags.Text = "标签:"
        '
        'LblImportTime
        '
        Me.LblImportTime.AutoSize = True
        Me.LblImportTime.Location = New System.Drawing.Point(273, 246)
        Me.LblImportTime.Name = "LblImportTime"
        Me.LblImportTime.Size = New System.Drawing.Size(83, 15)
        Me.LblImportTime.TabIndex = 13
        Me.LblImportTime.Text = "导入时间: "
        '
        'LblUpdateTime
        '
        Me.LblUpdateTime.AutoSize = True
        Me.LblUpdateTime.Location = New System.Drawing.Point(11, 246)
        Me.LblUpdateTime.Name = "LblUpdateTime"
        Me.LblUpdateTime.Size = New System.Drawing.Size(83, 15)
        Me.LblUpdateTime.TabIndex = 14
        Me.LblUpdateTime.Text = "更新时间: "
        '
        'LblCreateTime
        '
        Me.LblCreateTime.AutoSize = True
        Me.LblCreateTime.Location = New System.Drawing.Point(11, 221)
        Me.LblCreateTime.Name = "LblCreateTime"
        Me.LblCreateTime.Size = New System.Drawing.Size(75, 15)
        Me.LblCreateTime.TabIndex = 15
        Me.LblCreateTime.Text = "创作时间:"
        '
        'TxtboxCreateTime
        '
        Me.TxtboxCreateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtboxCreateTime.Location = New System.Drawing.Point(103, 218)
        Me.TxtboxCreateTime.Name = "TxtboxCreateTime"
        Me.TxtboxCreateTime.Size = New System.Drawing.Size(184, 25)
        Me.TxtboxCreateTime.TabIndex = 6
        '
        'TxtboxNotes
        '
        Me.TxtboxNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtboxNotes.Location = New System.Drawing.Point(285, 144)
        Me.TxtboxNotes.Multiline = True
        Me.TxtboxNotes.Name = "TxtboxNotes"
        Me.TxtboxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtboxNotes.Size = New System.Drawing.Size(249, 68)
        Me.TxtboxNotes.TabIndex = 5
        '
        'LblNotes
        '
        Me.LblNotes.AutoSize = True
        Me.LblNotes.Location = New System.Drawing.Point(219, 147)
        Me.LblNotes.Name = "LblNotes"
        Me.LblNotes.Size = New System.Drawing.Size(45, 15)
        Me.LblNotes.TabIndex = 18
        Me.LblNotes.Text = "备注:"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(12, 270)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(129, 37)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "添加(&A)..."
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'LstBox
        '
        Me.LstBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstBox.FormattingEnabled = True
        Me.LstBox.ItemHeight = 15
        Me.LstBox.Location = New System.Drawing.Point(141, 270)
        Me.LstBox.Name = "LstBox"
        Me.LstBox.Size = New System.Drawing.Size(278, 107)
        Me.LstBox.TabIndex = 10
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(12, 304)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(129, 37)
        Me.BtnDel.TabIndex = 8
        Me.BtnDel.Text = "删除(&D)..."
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnSetPreview
        '
        Me.BtnSetPreview.Location = New System.Drawing.Point(12, 338)
        Me.BtnSetPreview.Name = "BtnSetPreview"
        Me.BtnSetPreview.Size = New System.Drawing.Size(129, 37)
        Me.BtnSetPreview.TabIndex = 9
        Me.BtnSetPreview.Text = "设为封面(&P)"
        Me.BtnSetPreview.UseVisualStyleBackColor = True
        '
        'SelectPictureBox
        '
        Me.SelectPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SelectPictureBox.Location = New System.Drawing.Point(424, 270)
        Me.SelectPictureBox.Name = "SelectPictureBox"
        Me.SelectPictureBox.Size = New System.Drawing.Size(110, 110)
        Me.SelectPictureBox.TabIndex = 22
        Me.SelectPictureBox.TabStop = False
        '
        'EditDialogForm
        '
        Me.AcceptButton = Me.BtnModify
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(542, 443)
        Me.Controls.Add(Me.SelectPictureBox)
        Me.Controls.Add(Me.BtnSetPreview)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.LstBox)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.LblNotes)
        Me.Controls.Add(Me.TxtboxNotes)
        Me.Controls.Add(Me.TxtboxCreateTime)
        Me.Controls.Add(Me.LblCreateTime)
        Me.Controls.Add(Me.LblUpdateTime)
        Me.Controls.Add(Me.LblImportTime)
        Me.Controls.Add(Me.LblTags)
        Me.Controls.Add(Me.TxtboxTags)
        Me.Controls.Add(Me.LblCharacters)
        Me.Controls.Add(Me.TxtboxCharacters)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblUUID)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.PreviewPicturebox)
        Me.Controls.Add(Me.LblAuthor)
        Me.Controls.Add(Me.TxtboxAuthor)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.TxtboxTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditDialogForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EditDialogForm"
        CType(Me.PreviewPicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtboxTitle As TextBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtboxAuthor As TextBox
    Friend WithEvents LblAuthor As Label
    Friend WithEvents PreviewPicturebox As PictureBox
    Friend WithEvents BtnModify As Button
    Friend WithEvents LblUUID As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents TxtboxCharacters As TextBox
    Friend WithEvents LblCharacters As Label
    Friend WithEvents TxtboxTags As TextBox
    Friend WithEvents LblTags As Label
    Friend WithEvents LblImportTime As Label
    Friend WithEvents LblUpdateTime As Label
    Friend WithEvents LblCreateTime As Label
    Friend WithEvents TxtboxCreateTime As TextBox
    Friend WithEvents TxtboxNotes As TextBox
    Friend WithEvents LblNotes As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents LstBox As ListBox
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnSetPreview As Button
    Friend WithEvents SelectPictureBox As PictureBox
End Class
