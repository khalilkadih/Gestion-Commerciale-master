using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Gestion_Commerciale.PL
{
    public partial class frmClient : DevExpress.XtraEditors.XtraForm
    {
        BL.Client client = new BL.Client();
        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender,EventArgs e)
        {
            dgvClient.DataSource = client.SelectDataClient();
        }
    }
}