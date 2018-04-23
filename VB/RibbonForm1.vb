Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UserDesigner

Namespace RepEUDRibbonMerging
	Partial Public Class RibbonForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Private designerForm As XRDesignRibbonFormEx

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub RibbonForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.IsMdiContainer = True
			Me.clientPanel.Visible = False

			designerForm = New XRDesignRibbonFormEx()
			designerForm.DesignPanel.ExecCommand(ReportCommand.NewReport)
			designerForm.MdiParent = Me
			designerForm.Show()
		End Sub

		Private Sub ribbon_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbon.SelectedPageChanged
			If ribbon.SelectedPage.Text = "Print Preview" Then
				designerForm.DesignPanel.ExecCommand(ReportCommand.ShowPreviewTab)
			ElseIf ribbon.SelectedPage.Text = "Report Designer" Then
				designerForm.DesignPanel.ExecCommand(ReportCommand.ShowDesignerTab)
			ElseIf ribbon.SelectedPage.Text = "HTML Preview" Then
				designerForm.DesignPanel.ExecCommand(ReportCommand.ShowHTMLViewTab)
			End If

			designerForm.RibbonControl.SelectedPage = designerForm.RibbonControl.Pages(ribbon.SelectedPage.Text)
		End Sub
	End Class
End Namespace