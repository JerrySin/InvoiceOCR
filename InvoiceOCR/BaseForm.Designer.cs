namespace InvoiceOCR
{
    partial class BaseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblChooseTemplate = new System.Windows.Forms.Label();
            this.cbChooseTemplate = new System.Windows.Forms.ComboBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ibInvoice = new Cyotek.Windows.Forms.ImageBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChooseTemplate);
            this.groupBox1.Controls.Add(this.cbChooseTemplate);
            this.groupBox1.Controls.Add(this.btnLoadImage);
            this.groupBox1.Location = new System.Drawing.Point(13, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 750);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Input ";
            // 
            // lblChooseTemplate
            // 
            this.lblChooseTemplate.AutoSize = true;
            this.lblChooseTemplate.Location = new System.Drawing.Point(29, 194);
            this.lblChooseTemplate.Name = "lblChooseTemplate";
            this.lblChooseTemplate.Size = new System.Drawing.Size(231, 25);
            this.lblChooseTemplate.TabIndex = 3;
            this.lblChooseTemplate.Text = "Choose a template (&T):";
            this.lblChooseTemplate.Click += new System.EventHandler(this.lblChooseTemplate_Click);
            // 
            // cbChooseTemplate
            // 
            this.cbChooseTemplate.FormattingEnabled = true;
            this.cbChooseTemplate.Location = new System.Drawing.Point(34, 239);
            this.cbChooseTemplate.Name = "cbChooseTemplate";
            this.cbChooseTemplate.Size = new System.Drawing.Size(250, 33);
            this.cbChooseTemplate.TabIndex = 2;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(34, 76);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(250, 62);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Load Image (&I)";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ibInvoice);
            this.groupBox2.Location = new System.Drawing.Point(431, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 750);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Preview ";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(961, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 750);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Result ";
            // 
            // ibInvoice
            // 
            this.ibInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ibInvoice.Location = new System.Drawing.Point(6, 30);
            this.ibInvoice.Name = "ibInvoice";
            this.ibInvoice.Size = new System.Drawing.Size(500, 714);
            this.ibInvoice.TabIndex = 0;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 801);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaseForm";
            this.Text = "Invoice OCR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblChooseTemplate;
        private System.Windows.Forms.ComboBox cbChooseTemplate;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Cyotek.Windows.Forms.ImageBox ibInvoice;
    }
}

