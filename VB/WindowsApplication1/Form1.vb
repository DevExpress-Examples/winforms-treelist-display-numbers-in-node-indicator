Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Function CreateTable() As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			tbl.Columns.Add("ParentID", GetType(Integer))
			For i As Integer = 0 To 9
				For j As Integer = 0 To 4
					tbl.Rows.Add(New Object() { String.Format("Name{0}", 10*i+j), 10*i+j + 1, 3 - 10*i+j, DateTime.Now.AddDays(10*i+j), 10*i+j })
				Next j
			Next i
			Return tbl
		End Function


		Public Sub New()
			InitializeComponent()
			treeList1.DataSource = CreateTable()
		End Sub

		Private Sub treeList1_CustomDrawNodeIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs) Handles treeList1.CustomDrawNodeIndicator
			Dim tree As TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
			Dim args As IndicatorObjectInfoArgs = TryCast(e.ObjectArgs, IndicatorObjectInfoArgs)
			args.DisplayText = (tree.GetVisibleIndexByNode(e.Node) + 1).ToString()
			e.ImageIndex = -1
		End Sub
	End Class
End Namespace