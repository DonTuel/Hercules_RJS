using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hercules_RJS
{
    public partial class RJSPreview : Form
    {
        RJSMain rJS;

        public RJSPreview()
        {
            InitializeComponent();
        }

        public twEditControls.EditBox EditBox
        { get { return ebControl; } }

        public Boolean ViewShowLineNumbers
        {
            get
            {
                return mnuViewShowLineNumbers.Checked;
            }
            set
            {
                mnuViewShowLineNumbers.Checked = value;
            }
        }

        private void mnuEditShowLineNumbers_Click(object sender, EventArgs e)
        {
            mnuViewShowLineNumbers.Checked = !mnuViewShowLineNumbers.Checked;
            EditBox.LineNumberPanelVisible = mnuViewShowLineNumbers.Checked;
            EditBox.Refresh();
        }

        private void btnPreviewSubmit_Click(object sender, EventArgs e)
        {
            rJS.SubmitJCL(EditBox.Lines);
        }

        private void btnPreviewClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RJSPreview_Load(object sender, EventArgs e)
        {
            rJS = (RJSMain)Owner;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
