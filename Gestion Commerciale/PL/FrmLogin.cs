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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        BL.Utilisateur utilisateur = new BL.Utilisateur();
        DataTable dt = new DataTable();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender,EventArgs e)
        {
            bool ok;
            utilisateur.Login(txtUtilisateur.Text,txtPWD.Text, out ok);
            MessageBox.Show(ok.ToString());
        }
    }
}