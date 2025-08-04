'Imports System.Windows.Forms

'Public Class Form9
'    Private WithEvents timer As New Timer()

'    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' 设置定时器，每秒刷新一次
'        timer.Interval = 1000
'        timer.Start()
'        EnableListViewDoubleBuffering() ' 启用双缓冲
'        UpdateWindowStatus()
'    End Sub

'    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
'        UpdateWindowStatus()
'    End Sub

'    Private Sub EnableListViewDoubleBuffering()
'        Dim prop = GetType(Control).GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
'        If prop IsNot Nothing Then
'            prop.SetValue(ListView1, True, Nothing)
'        End If
'    End Sub

'    Private Sub UpdateWindowStatus()
'        ' 记录当前选中的窗口名
'        Dim selectedName As String = Nothing
'        If ListView1.SelectedItems.Count > 0 Then
'            selectedName = ListView1.SelectedItems(0).Text
'        End If

'        ListView1.BeginUpdate()
'        ListView1.Items.Clear()
'        Dim toSelect As ListViewItem = Nothing
'        For i As Integer = 1 To 9
'            Dim formName As String = "Form" & i.ToString()
'            Dim frm As Form = GetOpenFormByName(formName)
'            If frm IsNot Nothing AndAlso frm IsNot Me Then
'                Dim state As String = ""
'                Select Case frm.WindowState
'                    Case FormWindowState.Maximized
'                        state = "最大化"
'                    Case FormWindowState.Minimized
'                        state = "最小化"
'                    Case FormWindowState.Normal
'                        state = "常规"
'                End Select
'                Dim topMost As String = If(frm.TopMost, "置顶", "未置顶")
'                Dim item As New ListViewItem(formName)
'                item.SubItems.Add(state)
'                item.SubItems.Add(topMost)
'                ListView1.Items.Add(item)
'                ' 刷新后恢复选中项
'                If selectedName IsNot Nothing AndAlso formName = selectedName Then
'                    toSelect = item
'                End If
'            End If
'        Next
'        If toSelect IsNot Nothing Then
'            toSelect.Selected = True
'            toSelect.Focused = True
'            ListView1.EnsureVisible(toSelect.Index)
'        End If
'        ListView1.EndUpdate()
'    End Sub

'    Private Function GetOpenFormByName(name As String) As Form
'        For Each frm As Form In Application.OpenForms
'            If frm.Name = name Then
'                Return frm
'            End If
'        Next
'        Return Nothing
'    End Function

'    ' 确保窗体上有一个多行TextBox，命名为TextBox1
'End Class
