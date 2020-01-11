using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Gestion_Commerciale.PL
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender,ItemClickEventArgs e)
        {
            frmClient fClient = new frmClient();
            fClient.ShowDialog();
        }
    }
}