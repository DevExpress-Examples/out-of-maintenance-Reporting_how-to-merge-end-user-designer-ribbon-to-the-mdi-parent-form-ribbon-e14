<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128601909/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1479)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [RibbonForm1.cs](./CS/RibbonForm1.cs) (VB: [RibbonForm1.vb](./VB/RibbonForm1.vb))
<!-- default file list end -->
# How to merge End-User Designer Ribbon to the MDI parent form Ribbon


<p>Currently, <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument3451">Ribbon Merging</a> feature is not supported by the XtraReports End-User Designer. We understand the importance of this problem. A corresponding suggestion is registered in our Support Center at: <a href="https://www.devexpress.com/Support/Center/p/B91377">End-User Designer - Ribbon - Add the capability to use the designer when its form is set as an MDI child of the main form, and the ribbons of these forms are merged</a>.<br />
However, there is a workaround to this problem. Due to the numerous requests of our customers concerning this problem (i. e. <a href="https://www.devexpress.com/Support/Center/p/Q207191">How to refresh enability of controls on PrintPreviewRibbonPage after preview is generated?</a>, <a href="https://www.devexpress.com/Support/Center/p/Q145589">Merge report ribbon menu</a> and so on) we decided to publish this workaround in our example, so that everyone who encountered the same issue will be able to solve it with help of this workaround.</p><p>To force enabling of BarItems in the pages of the merged Ribbon, it is necessary to manually update the designerForm.RibbonControl.SelectedPage property value and call the XRDesignRibbonFormEx.DesignPanel.ExecCommand() method with the corresponding ReportCommand.Show*Tab parameter. This should be done in the RibbonControl.SelectedPageChanged event handler.</p>

<br/>


