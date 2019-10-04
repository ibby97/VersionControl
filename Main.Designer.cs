namespace Assessment2Q5
{
    partial class frmMain
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
            this.lstOrginalOrder = new System.Windows.Forms.ListBox();
            this.lstComparer = new System.Windows.Forms.ListBox();
            this.lblOriginalOrder = new System.Windows.Forms.Label();
            this.lblSorted = new System.Windows.Forms.Label();
            this.lstReverseComparer = new System.Windows.Forms.ListBox();
            this.lblReverseComparer = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOrginalOrder
            // 
            this.lstOrginalOrder.FormattingEnabled = true;
            this.lstOrginalOrder.Location = new System.Drawing.Point(12, 70);
            this.lstOrginalOrder.Name = "lstOrginalOrder";
            this.lstOrginalOrder.Size = new System.Drawing.Size(120, 238);
            this.lstOrginalOrder.TabIndex = 0;
            // 
            // lstComparer
            // 
            this.lstComparer.FormattingEnabled = true;
            this.lstComparer.Location = new System.Drawing.Point(212, 70);
            this.lstComparer.Name = "lstComparer";
            this.lstComparer.Size = new System.Drawing.Size(120, 238);
            this.lstComparer.TabIndex = 1;
            // 
            // lblOriginalOrder
            // 
            this.lblOriginalOrder.AutoSize = true;
            this.lblOriginalOrder.Location = new System.Drawing.Point(12, 27);
            this.lblOriginalOrder.Name = "lblOriginalOrder";
            this.lblOriginalOrder.Size = new System.Drawing.Size(104, 26);
            this.lblOriginalOrder.TabIndex = 3;
            this.lblOriginalOrder.Text = "The original order of \r\nelements in the array\r\n";
            // 
            // lblSorted
            // 
            this.lblSorted.Location = new System.Drawing.Point(209, 27);
            this.lblSorted.Name = "lblSorted";
            this.lblSorted.Size = new System.Drawing.Size(140, 40);
            this.lblSorted.TabIndex = 4;
            this.lblSorted.Text = "After sorting elements 1-3 by using the default comparer";
            // 
            // lstReverseComparer
            // 
            this.lstReverseComparer.FormattingEnabled = true;
            this.lstReverseComparer.Location = new System.Drawing.Point(424, 70);
            this.lstReverseComparer.Name = "lstReverseComparer";
            this.lstReverseComparer.Size = new System.Drawing.Size(120, 238);
            this.lstReverseComparer.TabIndex = 5;
            // 
            // lblReverseComparer
            // 
            this.lblReverseComparer.AutoSize = true;
            this.lblReverseComparer.Location = new System.Drawing.Point(422, 28);
            this.lblReverseComparer.Name = "lblReverseComparer";
            this.lblReverseComparer.Size = new System.Drawing.Size(185, 26);
            this.lblReverseComparer.TabIndex = 6;
            this.lblReverseComparer.Text = " After sorting the entire array using \r\nthe reverse case-insensitive comparer";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(578, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblReverseComparer);
            this.Controls.Add(this.lstReverseComparer);
            this.Controls.Add(this.lblSorted);
            this.Controls.Add(this.lblOriginalOrder);
            this.Controls.Add(this.lstComparer);
            this.Controls.Add(this.lstOrginalOrder);
            this.Name = "frmMain";
            this.Text = "Using Comparator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrginalOrder;
        private System.Windows.Forms.ListBox lstComparer;
        private System.Windows.Forms.Label lblOriginalOrder;
        private System.Windows.Forms.Label lblSorted;
        private System.Windows.Forms.ListBox lstReverseComparer;
        private System.Windows.Forms.Label lblReverseComparer;
        private System.Windows.Forms.Button btnExit;
    }
}

