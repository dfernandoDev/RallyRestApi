using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RallyRestApi.AuthenticatorUI
{
    public partial class frmSettings : Form
    {
        private string url;

        public string WebUrl
        {
            get { return url; }
            set { url = value; }
        }

        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Rally_SSO_URL = txtURL.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtURL.Text = WebUrl;
        }

    }
}
