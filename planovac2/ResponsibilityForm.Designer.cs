namespace planovac2
{
    partial class ResponsibilityForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.tblInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nudAlert = new System.Windows.Forms.NumericUpDown();
            this.lblAlertTimes = new System.Windows.Forms.Label();
            this.tblAlert = new System.Windows.Forms.TableLayoutPanel();
            this.txtAlert1 = new System.Windows.Forms.TextBox();
            this.txtAlert5 = new System.Windows.Forms.TextBox();
            this.txtAlert4 = new System.Windows.Forms.TextBox();
            this.txtAlert3 = new System.Windows.Forms.TextBox();
            this.txtAlert2 = new System.Windows.Forms.TextBox();
            this.lblAlert1 = new System.Windows.Forms.Label();
            this.lblAlert2 = new System.Windows.Forms.Label();
            this.lblAlert3 = new System.Windows.Forms.Label();
            this.lblAlert4 = new System.Windows.Forms.Label();
            this.lblAlert5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            this.tblInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlert)).BeginInit();
            this.tblAlert.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(276, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 22);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(12, 9);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(135, 13);
            this.lblCreate.TabIndex = 0;
            this.lblCreate.Text = "Create a new responsibility:";
            // 
            // lblAlert
            // 
            this.lblAlert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlert.Location = new System.Drawing.Point(4, 82);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(68, 26);
            this.lblAlert.TabIndex = 0;
            this.lblAlert.Text = "Alerts:";
            this.lblAlert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblInfo
            // 
            this.tblInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblInfo.ColumnCount = 2;
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.15873F));
            this.tblInfo.Controls.Add(this.txtName, 1, 1);
            this.tblInfo.Controls.Add(this.lblType, 0, 0);
            this.tblInfo.Controls.Add(this.lblName, 0, 1);
            this.tblInfo.Controls.Add(this.cmbType, 1, 0);
            this.tblInfo.Controls.Add(this.lblDescription, 0, 2);
            this.tblInfo.Controls.Add(this.txtDescription, 1, 2);
            this.tblInfo.Controls.Add(this.lblAlert, 0, 3);
            this.tblInfo.Controls.Add(this.nudAlert, 1, 3);
            this.tblInfo.Location = new System.Drawing.Point(12, 25);
            this.tblInfo.Name = "tblInfo";
            this.tblInfo.RowCount = 4;
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblInfo.Size = new System.Drawing.Size(379, 109);
            this.tblInfo.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(79, 31);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Location = new System.Drawing.Point(4, 1);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(68, 26);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(4, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbType
            // 
            this.cmbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Location = new System.Drawing.Point(79, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(296, 21);
            this.cmbType.TabIndex = 0;
            this.cmbType.Tag = "";
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(4, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(68, 26);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(79, 58);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(296, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // nudAlert
            // 
            this.nudAlert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAlert.Location = new System.Drawing.Point(79, 85);
            this.nudAlert.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAlert.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAlert.Name = "nudAlert";
            this.nudAlert.Size = new System.Drawing.Size(296, 20);
            this.nudAlert.TabIndex = 6;
            this.nudAlert.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAlert.ValueChanged += new System.EventHandler(this.nudAlert_ValueChanged);
            // 
            // lblAlertTimes
            // 
            this.lblAlertTimes.AutoSize = true;
            this.lblAlertTimes.Location = new System.Drawing.Point(12, 137);
            this.lblAlertTimes.Name = "lblAlertTimes";
            this.lblAlertTimes.Size = new System.Drawing.Size(58, 13);
            this.lblAlertTimes.TabIndex = 0;
            this.lblAlertTimes.Text = "Alert times:";
            // 
            // tblAlert
            // 
            this.tblAlert.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblAlert.ColumnCount = 2;
            this.tblAlert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.28571F));
            this.tblAlert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.71429F));
            this.tblAlert.Controls.Add(this.txtAlert1, 1, 0);
            this.tblAlert.Controls.Add(this.txtAlert5, 1, 4);
            this.tblAlert.Controls.Add(this.txtAlert4, 1, 3);
            this.tblAlert.Controls.Add(this.txtAlert3, 1, 2);
            this.tblAlert.Controls.Add(this.txtAlert2, 1, 1);
            this.tblAlert.Controls.Add(this.lblAlert1, 0, 0);
            this.tblAlert.Controls.Add(this.lblAlert2, 0, 1);
            this.tblAlert.Controls.Add(this.lblAlert3, 0, 2);
            this.tblAlert.Controls.Add(this.lblAlert4, 0, 3);
            this.tblAlert.Controls.Add(this.lblAlert5, 0, 4);
            this.tblAlert.Location = new System.Drawing.Point(12, 153);
            this.tblAlert.Name = "tblAlert";
            this.tblAlert.RowCount = 5;
            this.tblAlert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblAlert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblAlert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblAlert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblAlert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblAlert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblAlert.Size = new System.Drawing.Size(141, 136);
            this.tblAlert.TabIndex = 1;
            // 
            // txtAlert1
            // 
            this.txtAlert1.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAlert1.Location = new System.Drawing.Point(79, 4);
            this.txtAlert1.Name = "txtAlert1";
            this.txtAlert1.Size = new System.Drawing.Size(57, 20);
            this.txtAlert1.TabIndex = 0;
            this.txtAlert1.Text = "00:00";
            this.txtAlert1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlert5
            // 
            this.txtAlert5.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAlert5.Enabled = false;
            this.txtAlert5.Location = new System.Drawing.Point(79, 112);
            this.txtAlert5.Name = "txtAlert5";
            this.txtAlert5.Size = new System.Drawing.Size(57, 20);
            this.txtAlert5.TabIndex = 4;
            this.txtAlert5.Text = "00:00";
            this.txtAlert5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlert4
            // 
            this.txtAlert4.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAlert4.Enabled = false;
            this.txtAlert4.Location = new System.Drawing.Point(79, 85);
            this.txtAlert4.Name = "txtAlert4";
            this.txtAlert4.Size = new System.Drawing.Size(57, 20);
            this.txtAlert4.TabIndex = 3;
            this.txtAlert4.Text = "00:00";
            this.txtAlert4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlert3
            // 
            this.txtAlert3.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAlert3.Enabled = false;
            this.txtAlert3.Location = new System.Drawing.Point(79, 58);
            this.txtAlert3.Name = "txtAlert3";
            this.txtAlert3.Size = new System.Drawing.Size(57, 20);
            this.txtAlert3.TabIndex = 2;
            this.txtAlert3.Text = "00:00";
            this.txtAlert3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlert2
            // 
            this.txtAlert2.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAlert2.Enabled = false;
            this.txtAlert2.Location = new System.Drawing.Point(79, 31);
            this.txtAlert2.Name = "txtAlert2";
            this.txtAlert2.Size = new System.Drawing.Size(57, 20);
            this.txtAlert2.TabIndex = 1;
            this.txtAlert2.Text = "00:00";
            this.txtAlert2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAlert1
            // 
            this.lblAlert1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlert1.Location = new System.Drawing.Point(4, 1);
            this.lblAlert1.Name = "lblAlert1";
            this.lblAlert1.Size = new System.Drawing.Size(68, 26);
            this.lblAlert1.TabIndex = 0;
            this.lblAlert1.Text = "Alert #1:";
            this.lblAlert1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlert2
            // 
            this.lblAlert2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlert2.Enabled = false;
            this.lblAlert2.Location = new System.Drawing.Point(4, 28);
            this.lblAlert2.Name = "lblAlert2";
            this.lblAlert2.Size = new System.Drawing.Size(68, 26);
            this.lblAlert2.TabIndex = 0;
            this.lblAlert2.Text = "Alert #2:";
            this.lblAlert2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlert3
            // 
            this.lblAlert3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlert3.Enabled = false;
            this.lblAlert3.Location = new System.Drawing.Point(4, 55);
            this.lblAlert3.Name = "lblAlert3";
            this.lblAlert3.Size = new System.Drawing.Size(68, 26);
            this.lblAlert3.TabIndex = 0;
            this.lblAlert3.Text = "Alert #3:";
            this.lblAlert3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlert4
            // 
            this.lblAlert4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlert4.Enabled = false;
            this.lblAlert4.Location = new System.Drawing.Point(4, 82);
            this.lblAlert4.Name = "lblAlert4";
            this.lblAlert4.Size = new System.Drawing.Size(68, 26);
            this.lblAlert4.TabIndex = 0;
            this.lblAlert4.Text = "Alert #4:";
            this.lblAlert4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlert5
            // 
            this.lblAlert5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlert5.Enabled = false;
            this.lblAlert5.Location = new System.Drawing.Point(4, 109);
            this.lblAlert5.Name = "lblAlert5";
            this.lblAlert5.Size = new System.Drawing.Size(68, 26);
            this.lblAlert5.TabIndex = 0;
            this.lblAlert5.Text = "Alert #5:";
            this.lblAlert5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreate.Location = new System.Drawing.Point(12, 295);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 22);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormat.Location = new System.Drawing.Point(161, 153);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(230, 136);
            this.lblFormat.TabIndex = 0;
            this.lblFormat.Text = "Format:\r\n\r\nName, Description: arbitrary text\r\n[0-50 characters]\r\nAlerts: number [" +
    "1-5]\r\nAlert #1-5: time [hh:mm] \r\nhh = hours [00-23] mm = minutes [00-59]\r\n";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResponsibilityForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(403, 329);
            this.ControlBox = false;
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tblAlert);
            this.Controls.Add(this.lblAlertTimes);
            this.Controls.Add(this.tblInfo);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(409, 335);
            this.Name = "ResponsibilityForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tblInfo.ResumeLayout(false);
            this.tblInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlert)).EndInit();
            this.tblAlert.ResumeLayout(false);
            this.tblAlert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.TableLayoutPanel tblInfo;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.NumericUpDown nudAlert;
        private System.Windows.Forms.Label lblAlertTimes;
        private System.Windows.Forms.TableLayoutPanel tblAlert;
        private System.Windows.Forms.TextBox txtAlert1;
        private System.Windows.Forms.TextBox txtAlert5;
        private System.Windows.Forms.TextBox txtAlert4;
        private System.Windows.Forms.TextBox txtAlert3;
        private System.Windows.Forms.TextBox txtAlert2;
        private System.Windows.Forms.Label lblAlert1;
        private System.Windows.Forms.Label lblAlert2;
        private System.Windows.Forms.Label lblAlert3;
        private System.Windows.Forms.Label lblAlert4;
        private System.Windows.Forms.Label lblAlert5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblFormat;
    }
}