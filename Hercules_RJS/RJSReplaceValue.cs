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
    public partial class RJSReplaceValue : Form
    {
        public RJSReplaceValue()
        {
            InitializeComponent();
        }

        public String SourceValue
        { get { return txtSourceText.Text; } set { txtSourceText.Text = value; } }

        public String ReplaceValue
        { get { return txtReplaceValue.Text; } set { txtReplaceValue.Text = value; } }
    }
}
