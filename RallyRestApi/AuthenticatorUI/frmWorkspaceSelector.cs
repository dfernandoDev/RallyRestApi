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
    public partial class frmWorkspaceSelector : Form
    {
        private int selectedWorkspaceID;

        public int SelectedWorkspaceID
        {
            get { return selectedWorkspaceID; }
            set { selectedWorkspaceID = value; }
        }

        private Workspaces.QueryResult workspaces;

        public Workspaces.QueryResult Workspaces
        {
            get { return workspaces; }
            set { workspaces = value; }
        }

        private int selectedProjectID;

        public int SelectedProjectID
        {
            get { return selectedProjectID; }
            set { selectedProjectID = value; }
        }


        private Projects.QueryResult projects;

        public Projects.QueryResult Projects
        {
            get { return projects; }
            set { projects = value; }
        }


        public frmWorkspaceSelector()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            selectedWorkspaceID = comboBoxWorkspace.SelectedIndex;
            selectedProjectID = comboBoxProject.SelectedIndex;
            DialogResult = DialogResult.OK;
        }

        private void frmWorkspaceSelector_Load(object sender, EventArgs e)
        {
            foreach (Workspaces.Result w in workspaces.Results)
            {
                comboBoxWorkspace.Items.Add(w.Name);
            }

            comboBoxWorkspace.SelectedIndex = SelectedWorkspaceID;

            foreach (RallyRestApi.Projects.Result p in projects.Results)
            {
                comboBoxProject.Items.Add(p.Name);
            }
            comboBoxProject.SelectedIndex = selectedProjectID;
        }
    }
}
