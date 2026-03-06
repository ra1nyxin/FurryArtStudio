<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintForm
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
        Me.cbPrinter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtPrintCount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPaper = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPrinterSetup = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.txtBottom = New System.Windows.Forms.TextBox()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.txtRight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbVertical = New System.Windows.Forms.RadioButton()
        Me.rbHorizonal = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cbPrinter
        '
        Me.cbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPrinter.FormattingEnabled = True
        Me.cbPrinter.Location = New System.Drawing.Point(70, 6)
        Me.cbPrinter.Name = "cbPrinter"
        Me.cbPrinter.Size = New System.Drawing.Size(400, 23)
        Me.cbPrinter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "打印机:"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(246, 143)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(109, 49)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "打印(&P)"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(361, 143)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 49)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "取消(&C)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtPrintCount
        '
        Me.txtPrintCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrintCount.Location = New System.Drawing.Point(70, 39)
        Me.txtPrintCount.MaxLength = 2
        Me.txtPrintCount.Name = "txtPrintCount"
        Me.txtPrintCount.Size = New System.Drawing.Size(86, 25)
        Me.txtPrintCount.TabIndex = 2
        Me.txtPrintCount.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "份数:"
        '
        'cbPaper
        '
        Me.cbPaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaper.FormattingEnabled = True
        Me.cbPaper.Location = New System.Drawing.Point(226, 41)
        Me.cbPaper.Name = "cbPaper"
        Me.cbPaper.Size = New System.Drawing.Size(244, 23)
        Me.cbPaper.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "纸张:"
        '
        'btnPrinterSetup
        '
        Me.btnPrinterSetup.Location = New System.Drawing.Point(15, 143)
        Me.btnPrinterSetup.Name = "btnPrinterSetup"
        Me.btnPrinterSetup.Size = New System.Drawing.Size(141, 49)
        Me.btnPrinterSetup.TabIndex = 10
        Me.btnPrinterSetup.Text = "打印机管理(&M)"
        Me.btnPrinterSetup.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "布局:"
        '
        'txtTop
        '
        Me.txtTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTop.Location = New System.Drawing.Point(70, 73)
        Me.txtTop.MaxLength = 5
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(86, 25)
        Me.txtTop.TabIndex = 6
        Me.txtTop.Text = "25"
        '
        'txtBottom
        '
        Me.txtBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBottom.Location = New System.Drawing.Point(226, 73)
        Me.txtBottom.MaxLength = 5
        Me.txtBottom.Name = "txtBottom"
        Me.txtBottom.Size = New System.Drawing.Size(86, 25)
        Me.txtBottom.TabIndex = 7
        Me.txtBottom.Text = "25"
        '
        'txtLeft
        '
        Me.txtLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeft.Location = New System.Drawing.Point(70, 106)
        Me.txtLeft.MaxLength = 5
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(86, 25)
        Me.txtLeft.TabIndex = 8
        Me.txtLeft.Text = "25"
        '
        'txtRight
        '
        Me.txtRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRight.Location = New System.Drawing.Point(226, 106)
        Me.txtRight.MaxLength = 5
        Me.txtRight.Name = "txtRight"
        Me.txtRight.Size = New System.Drawing.Size(86, 25)
        Me.txtRight.TabIndex = 9
        Me.txtRight.Text = "25"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "上边距:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "左边距:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "下边距:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(164, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "右边距:"
        '
        'rbVertical
        '
        Me.rbVertical.AutoSize = True
        Me.rbVertical.Location = New System.Drawing.Point(396, 74)
        Me.rbVertical.Name = "rbVertical"
        Me.rbVertical.Size = New System.Drawing.Size(58, 19)
        Me.rbVertical.TabIndex = 4
        Me.rbVertical.Text = "纵向"
        Me.rbVertical.UseVisualStyleBackColor = True
        '
        'rbHorizonal
        '
        Me.rbHorizonal.AutoSize = True
        Me.rbHorizonal.Checked = True
        Me.rbHorizonal.Location = New System.Drawing.Point(396, 107)
        Me.rbHorizonal.Name = "rbHorizonal"
        Me.rbHorizonal.Size = New System.Drawing.Size(58, 19)
        Me.rbHorizonal.TabIndex = 5
        Me.rbHorizonal.TabStop = True
        Me.rbHorizonal.Text = "横向"
        Me.rbHorizonal.UseVisualStyleBackColor = True
        '
        'PrintForm
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(482, 203)
        Me.Controls.Add(Me.rbHorizonal)
        Me.Controls.Add(Me.rbVertical)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRight)
        Me.Controls.Add(Me.txtLeft)
        Me.Controls.Add(Me.txtBottom)
        Me.Controls.Add(Me.txtTop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPrinterSetup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbPaper)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrintCount)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPrinter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "打印"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPrinter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtPrintCount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbPaper As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPrinterSetup As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTop As TextBox
    Friend WithEvents txtBottom As TextBox
    Friend WithEvents txtLeft As TextBox
    Friend WithEvents txtRight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rbVertical As RadioButton
    Friend WithEvents rbHorizonal As RadioButton
End Class
