namespace RallyRestApi.AuthenticatorUI
{
    partial class frmWorkspaceSelector
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
            if (disposing && (components != null))
            {
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWorkspace = new System.Windows.Forms.ComboBox();
            this.Project = new System.Windows.Forms.Label();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Workspace";
            // 
            // comboBoxWorkspace
            // 
            this.comboBoxWorkspace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkspace.FormattingEnabled = true;
            this.comboBoxWorkspace.Location = new System.Drawing.Point(130, 29);
            this.comboBoxWorkspace.Name = "comboBoxWorkspace";
            this.comboBoxWorkspace.Size = new System.Drawing.Size(406, 24);
            this.comboBoxWorkspace.TabIndex = 1;
            // 
            // Project
            // 
            this.Project.AutoSize = true;
            this.Project.Location = new System.Drawing.Point(21, 85);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(52, 17);
            this.Project.TabIndex = 2;
            this.Project.Text = "Project";
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(130, 82);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(406, 24);
            this.comboBoxProject.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(365, 131);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 30);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // frmWorkspaceSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 177);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.Project);
            this.Controls.Add(this.comboBoxWorkspace);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWorkspaceSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Workspace and Project";
            this.Load += new System.EventHandler(this.frmWorkspaceSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWorkspace;
        private System.Windows.Forms.Label Project;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;
    }
}