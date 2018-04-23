Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports System.Windows.Input
Imports System.Collections.Generic

Namespace DxSample
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			InitDXTabControlItems(dXTabControl1)
			InitAdditionItem(dXTabControl1)
		End Sub

		Private Sub InitDXTabControlItems(ByVal dXTabControl As DXTabControl)
			For i As Integer = 0 To 14
				dXTabControl.Items.Add("Page")
			Next i
		End Sub

		Private Sub InitAdditionItem(ByVal dXTabControl As DXTabControl)
			Dim item As New DXTabItem()
			item.Header = "+"
			AddHandler item.PreviewMouseDown, AddressOf AddItem_PreviewMouseDown
			item.ToolTip = "Open a new tab"
			dXTabControl.Items.Add(item)
		End Sub

		Private Sub AddItem_PreviewMouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			dXTabControl1.Items.Insert(dXTabControl1.Items.Count-1,"New Page")
			dXTabControl1.SelectedTabItem = dXTabControl1.GetTabItem(dXTabControl1.Items.Count - 2)
			e.Handled = True
		End Sub
	End Class
End Namespace
