using System.Windows.Forms;
namespace planovac2
{
    partial class MainForm
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
            this.btnPlanning = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlanning
            // 
            this.btnPlanning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlanning.Location = new System.Drawing.Point(3, 3);
            this.btnPlanning.Name = "btnPlanning";
            this.btnPlanning.Size = new System.Drawing.Size(121, 22);
            this.btnPlanning.TabIndex = 1;
            this.btnPlanning.Text = "Planning";
            this.btnPlanning.UseVisualStyleBackColor = true;
            this.btnPlanning.Click += new System.EventHandler(this.btnPlanning_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuit.Location = new System.Drawing.Point(130, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(121, 22);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.MinimumSize = new System.Drawing.Size(254, 104);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(254, 104);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.TextChanged += new System.EventHandler(this.lblTime_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(254, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Wednesday, 30. September, 2017";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.btnPlanning, 0, 0);
            this.tlpButtons.Controls.Add(this.btnQuit, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButtons.Location = new System.Drawing.Point(0, 76);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Size = new System.Drawing.Size(254, 28);
            this.tlpButtons.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(254, 104);
            this.ControlBox = false;
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - ClientSize.Width) - 20, (Screen.PrimaryScreen.WorkingArea.Height - ClientSize.Height) - 20); //might not work (designer)  
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 110);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlanning;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
    }
}

