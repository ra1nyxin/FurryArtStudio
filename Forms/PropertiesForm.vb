' Furry Art Studio - 本地稿件管理工具
' Copyright 2026 xionglongztz
'
' Licensed under the Apache License, Version 2.0 (the "License");
' you may not use this file except in compliance with the License.
' You may obtain a copy of the License at
'
'     http://www.apache.org/licenses/LICENSE-2.0
'
' Unless required by applicable law or agreed to in writing, software
' distributed under the License is distributed on an "AS IS" BASIS,
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
' See the License for the specific language governing permissions and
' limitations under the License.
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class PropertiesForm
    Implements IThemeChangeable, ILocalizable
#Region "窗体"
    Private Sub PropertiesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MnuHandle = GetSystemMenu(Handle, False) '获取菜单句柄
        RemoveMenu(MnuHandle, SC_RESTORE, MF_BYCOMMAND) '去除还原菜单
        RemoveMenu(MnuHandle, SC_MAXIMIZE, MF_BYCOMMAND) '去除最大化菜单
        RemoveMenu(MnuHandle, SC_SIZE, MF_BYCOMMAND) '去除大小菜单
        RemoveMenu(MnuHandle, SC_MINIMIZE, MF_BYCOMMAND) '去除最小化菜单
        SystemThemeChange()
        InitSettings()
    End Sub
    Private Sub SystemThemeChange() Implements IThemeChangeable.SystemThemeChange
        '颜色常量
        Dim bgColor As Color
        Dim frColor As Color
        '获取控件集合
        Dim controlList As List(Of Control) = GetAllControls(Me)
        '判断颜色
        If IsDarkMode() Then
            bgColor = BgColorDark
            frColor = FrColorDark
            Icon = CreateRoundedRectangleIcon(True, My.Resources.Icons.MenuSettingsDark)
        Else
            bgColor = BgColorLight
            frColor = FrColorLight
            Icon = CreateRoundedRectangleIcon(False, My.Resources.Icons.MenuSettingsLight)
        End If
        For Each control In controlList
            control.ForeColor = frColor
            control.BackColor = bgColor
        Next
        ForeColor = frColor
        BackColor = bgColor
        'WinAPI
        DwmSetWindowAttribute(Handle, DwmWindowAttribute.UseImmersiveDarkMode, IsDarkMode(), Marshal.SizeOf(Of Integer))
        SetPreferredAppMode(If(IsDarkMode(), PreferredAppMode.AllowDark, PreferredAppMode.ForceLight))
        FlushMenuThemes()
    End Sub
    Private Sub InitSettings()
        If ChkShowThemeColor.Checked = False Then
            ChkShowInChild.Enabled = False
            BtnThemeColor.Enabled = False
        Else
            ChkShowInChild.Enabled = True
            BtnThemeColor.Enabled = True
        End If
        CboLang.Items.Clear() '删除所有选项
        CboLang.Items.Add("简体中文")
        CboLang.Items.Add("繁體中文")
        CboLang.Items.Add("English")
        CboLang.SelectedIndex() = 0
    End Sub
    Private Sub LanguageChange() Implements ILocalizable.LanguageChange

    End Sub
#End Region

#Region "外观"
    Private Sub RadLight_CheckedChanged(sender As Object, e As EventArgs) Handles RadLight.CheckedChanged
        AppTheme = Appearance.Light
        UpdateFormTheme()
    End Sub
    Private Sub RadDark_CheckedChanged(sender As Object, e As EventArgs) Handles RadDark.CheckedChanged
        AppTheme = Appearance.Dark
        UpdateFormTheme()
    End Sub
    Private Sub RadSystem_CheckedChanged(sender As Object, e As EventArgs) Handles RadSystem.CheckedChanged
        AppTheme = Appearance.System
        UpdateFormTheme()
    End Sub
    Private Sub ChkShowThemeColor_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowThemeColor.CheckedChanged
        If ChkShowThemeColor.Checked = False Then
            ChkShowInChild.Enabled = False
            BtnThemeColor.Enabled = False
        Else
            ChkShowInChild.Enabled = True
            BtnThemeColor.Enabled = True
        End If
    End Sub
    Private Sub ChkShowInChild_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowInChild.CheckedChanged

    End Sub
    Private Sub BtnThemeColor_Click(sender As Object, e As EventArgs) Handles BtnThemeColor.Click

    End Sub
    Private Sub CboLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboLang.SelectedIndexChanged
        Select Case CboLang.SelectedIndex
            Case 0
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("zh-Hans")
            Case 1
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("zh-Hant")
            Case 2
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        End Select
        UpdateFormLang() '更新语言
    End Sub
#End Region

End Class