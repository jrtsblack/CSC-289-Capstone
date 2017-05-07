namespace Invoice.Forms
{
    partial class AdminNewInvoiceCheck
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
            this.btnoccupantInvoice = new System.Windows.Forms.Button();
            this.btnofficeWorkerInvoice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to view the New Invoice Form for an Occupant or Office Worker?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnoccupantInvoice
            // 
            this.btnoccupantInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoccupantInvoice.Location = new System.Drawing.Point(119, 9);
            this.btnoccupantInvoice.Name = "btnoccupantInvoice";
            this.btnoccupantInvoice.Size = new System.Drawing.Size(98, 37);
            this.btnoccupantInvoice.TabIndex = 1;
            this.btnoccupantInvoice.Text = "Occupant New Work Order";
            this.btnoccupantInvoice.UseVisualStyleBackColor = true;
            this.btnoccupantInvoice.Click += new System.EventHandler(this.btnoccupantInvoice_Click);
            // 
            // btnofficeWorkerInvoice
            // 
            this.btnofficeWorkerInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnofficeWorkerInvoice.Location = new System.Drawing.Point(223, 9);
            this.btnofficeWorkerInvoice.Name = "btnofficeWorkerInvoice";
            this.btnofficeWorkerInvoice.Size = new System.Drawing.Size(98, 37);
            this.btnofficeWorkerInvoice.TabIndex = 2;
            this.btnofficeWorkerInvoice.Text = "Office Worker New Work Order";
            this.btnofficeWorkerInvoice.UseVisualStyleBackColor = true;
            this.btnofficeWorkerInvoice.Click += new System.EventHandler(this.btnofficeWorkerInvoice_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnofficeWorkerInvoice);
            this.panel1.Controls.Add(this.btnoccupantInvoice);
            this.panel1.Location = new System.Drawing.Point(-3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 49);
            this.panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(327, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminNewInvoiceCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 99);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminNewInvoiceCheck";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminNewInvoiceCheck";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminNewInvoiceCheck_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnoccupantInvoice;
        private System.Windows.Forms.Button btnofficeWorkerInvoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
    }
}