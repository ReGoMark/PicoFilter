'Imports System.Diagnostics

'Public Class Form9
'    Private WithEvents Timer1 As New Timer()

'    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ListView1.View = View.Details
'        ListView1.Columns.Clear()
'        ListView1.Columns.Add("窗口名", 100)
'        ListView1.Columns.Add("窗口状态", 100)

'        Timer1.Interval = 1000
'        Timer1.Start()
'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        ' 记录当前选中的窗口名
'        Dim selectedNames As New List(Of String)
'        For Each item As ListViewItem In ListView1.SelectedItems
'            selectedNames.Add(item.Text)
'        Next

'        ListView1.Items.Clear()

'        Dim forms As Form() = {Form1, Form2, Form3, Form4, Form5, Form6, Form7, Form8, Me}
'        For Each frm As Form In forms
'            If frm.Visible Then
'                Dim name As String = frm.Name
'                Dim state As String = GetWindowState(frm)
'                Dim item As New ListViewItem({name, state})
'                ListView1.Items.Add(item)
'                If selectedNames.Contains(name) Then
'                    item.Selected = True
'                End If
'            End If
'        Next
'    End Sub

'    Private Function GetWindowState(frm As Form) As String
'        Select Case frm.WindowState
'            Case FormWindowState.Maximized
'                Return "最大化"
'            Case FormWindowState.Minimized
'                Return "最小化"
'            Case Else
'                Return "常规"
'        End Select
'    End Function
'End Class
