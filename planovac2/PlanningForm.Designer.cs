namespace planovac2
{
    partial class PlanningForm
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvResponsibilities = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tmrTIme = new System.Windows.Forms.Timer(this.components);
            this.chkAlertOn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsibilities)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(415, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnPlanning_Click);
            // 
            // dgvResponsibilities
            // 
            this.dgvResponsibilities.AllowUserToAddRows = false;
            this.dgvResponsibilities.AllowUserToDeleteRows = false;
            this.dgvResponsibilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsibilities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkAlertOn,
            this.txtType,
            this.txtName,
            this.txtDescription,
            this.btnEdit,
            this.btnRemove});
            this.dgvResponsibilities.Location = new System.Drawing.Point(12, 12);
            this.dgvResponsibilities.Name = "dgvResponsibilities";
            this.dgvResponsibilities.ReadOnly = true;
            this.dgvResponsibilities.Size = new System.Drawing.Size(518, 364);
            this.dgvResponsibilities.TabIndex = 3;
            this.dgvResponsibilities.TabStop = false;
            this.dgvResponsibilities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsibilities_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(12, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(22, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tmrTIme
            // 
            this.tmrTIme.Enabled = true;
            this.tmrTIme.Interval = 1000;
            // 
            // chkAlertOn
            // 
            this.chkAlertOn.FalseValue = "0";
            this.chkAlertOn.HeaderText = "Alert";
            this.chkAlertOn.Name = "chkAlertOn";
            this.chkAlertOn.ReadOnly = true;
            this.chkAlertOn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chkAlertOn.TrueValue = "1";
            this.chkAlertOn.Width = 35;
            // 
            // txtType
            // 
            this.txtType.HeaderText = "Type";
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtName
            // 
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtDescription
            // 
            this.txtDescription.HeaderText = "Description";
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            this.btnEdit.Width = 70;
            // 
            // btnRemove
            // 
            this.btnRemove.HeaderText = "";
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ReadOnly = true;
            this.btnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseColumnTextForButtonValue = true;
            this.btnRemove.Width = 70;
            // 
            // PlanningForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(542, 416);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvResponsibilities);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(548, 422);
            this.Name = "PlanningForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsibilities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvResponsibilities;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer tmrTIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkAlertOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescription;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnRemove;
    }
}