namespace Gestion_Commerciale.PL
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUtilisateur = new DevExpress.XtraEditors.TextEdit();
            this.txtPWD = new DevExpress.XtraEditors.TextEdit();
            this.btnConnexion = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilisateur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPWD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(117, 27);
            this.txtUtilisateur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(229, 24);
            this.txtUtilisateur.TabIndex = 2;
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(117, 56);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Properties.UseSystemPasswordChar = true;
            this.txtPWD.Size = new System.Drawing.Size(229, 24);
            this.txtPWD.TabIndex = 3;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(256, 87);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(91, 30);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 29);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Utilisateur";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 58);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mot de passe";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 151);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtUtilisateur);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilisateur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPWD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUtilisateur;
        private DevExpress.XtraEditors.TextEdit txtPWD;
        private DevExpress.XtraEditors.SimpleButton btnConnexion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}