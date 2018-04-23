using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UserDesigner;

namespace RepEUDRibbonMerging {
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm {

        private XRDesignRibbonFormEx designerForm;
        
        public RibbonForm1() {
            InitializeComponent();
        }

        private void RibbonForm1_Load(object sender, EventArgs e) {
            this.IsMdiContainer = true;
            this.clientPanel.Visible = false;

            designerForm = new XRDesignRibbonFormEx();
            designerForm.DesignPanel.ExecCommand(ReportCommand.NewReport);
            designerForm.MdiParent = this;
            designerForm.Show();
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e) {
            if(ribbon.SelectedPage.Text == "Print Preview") {
                designerForm.DesignPanel.ExecCommand(ReportCommand.ShowPreviewTab);
            }
            else if(ribbon.SelectedPage.Text == "Report Designer") {
                designerForm.DesignPanel.ExecCommand(ReportCommand.ShowDesignerTab);
            }
            else if(ribbon.SelectedPage.Text == "HTML Preview") {
                designerForm.DesignPanel.ExecCommand(ReportCommand.ShowHTMLViewTab);
            }

            designerForm.RibbonControl.SelectedPage = designerForm.RibbonControl.Pages[ribbon.SelectedPage.Text];
        }
    }
}