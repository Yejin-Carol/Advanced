

namespace iPhone_repairshop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTitle = new Sunny.UI.UISymbolLabel();
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.custAdd = new Sunny.UI.UISymbolButton();
            this.repairView = new Sunny.UI.UISymbolButton();
            this.adminMode = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.Color.MintCream;
            this.mainTitle.Location = new System.Drawing.Point(2, 0);
            this.mainTitle.Margin = new System.Windows.Forms.Padding(4);
            this.mainTitle.MinimumSize = new System.Drawing.Size(1, 2);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(417, 57);
            this.mainTitle.Style = Sunny.UI.UIStyle.Custom;
            this.mainTitle.Symbol = 57355;
            this.mainTitle.SymbolColor = System.Drawing.Color.GhostWhite;
            this.mainTitle.SymbolSize = 36;
            this.mainTitle.TabIndex = 9;
            this.mainTitle.Text = "iPhone Repair App v1.0";
            // 
            // mainPic
            // 
            this.mainPic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPic.Image = ((System.Drawing.Image)(resources.GetObject("mainPic.Image")));
            this.mainPic.Location = new System.Drawing.Point(0, 203);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(1000, 445);
            this.mainPic.TabIndex = 10;
            this.mainPic.TabStop = false;
            // 
            // custAdd
            // 
            this.custAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAdd.Location = new System.Drawing.Point(25, 73);
            this.custAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAdd.Name = "custAdd";
            this.custAdd.Size = new System.Drawing.Size(235, 59);
            this.custAdd.Symbol = 62004;
            this.custAdd.TabIndex = 11;
            this.custAdd.Text = "Add Customer";
            this.custAdd.Click += new System.EventHandler(this.custAdd_Click);
            // 
            // repairView
            // 
            this.repairView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repairView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.repairView.Location = new System.Drawing.Point(297, 73);
            this.repairView.MinimumSize = new System.Drawing.Size(1, 1);
            this.repairView.Name = "repairView";
            this.repairView.Size = new System.Drawing.Size(235, 59);
            this.repairView.Symbol = 57398;
            this.repairView.TabIndex = 12;
            this.repairView.Text = "Repair Detail";
            this.repairView.Click += new System.EventHandler(this.repairView_Click);
            // 
            // adminMode
            // 
            this.adminMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminMode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.adminMode.Location = new System.Drawing.Point(568, 73);
            this.adminMode.MinimumSize = new System.Drawing.Size(1, 1);
            this.adminMode.Name = "adminMode";
            this.adminMode.Size = new System.Drawing.Size(235, 59);
            this.adminMode.Symbol = 61680;
            this.adminMode.TabIndex = 13;
            this.adminMode.Text = "Admin Mode";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 648);
            this.Controls.Add(this.adminMode);
            this.Controls.Add(this.repairView);
            this.Controls.Add(this.custAdd);
            this.Controls.Add(this.mainPic);
            this.Controls.Add(this.mainTitle);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel mainTitle;
        private System.Windows.Forms.PictureBox mainPic;
        private Sunny.UI.UISymbolButton custAdd;
        private Sunny.UI.UISymbolButton repairView;
        private Sunny.UI.UISymbolButton adminMode;
    }
}

