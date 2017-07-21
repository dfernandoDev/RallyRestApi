using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RallyRestApi.Iteration
{
    public partial class Iterations : Form
    {
        private Result selIteration;

        public Result SelectedIteration
        {
            get { return selIteration; }
            set { selIteration = value; }
        }


        private Iteration.QueryResult  allIteration;

        public Iteration.QueryResult  IterationList
        {
            get { return allIteration; }
            set { allIteration = value; }
        }

        public Iterations()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.selIteration = (Result) comboBoxIterations.SelectedItem;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Iterations_Load(object sender, EventArgs e)
        {
            comboBoxIterations.DisplayMember = "Name";
            comboBoxIterations.ValueMember  = "Name";
            comboBoxIterations.DataSource = this.IterationList.Results;

            label1.Text += " [" + this.IterationList.TotalResultCount +" Total Iterations]";
        }
    }
}
