﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceOCR
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "Choose Invoice Images";
            fileDialog.Filter = "All Files|*.*";

            string file = "";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = fileDialog.FileName;
            }
            else
            {
                return;
            }

            ibInvoice.Image = Bitmap.FromFile(file);
            //ibInvoice.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close and dispose form
            this.Close();
            this.Dispose();
        }

        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            AddTemplateForm atf = new AddTemplateForm();
            atf.ShowDialog(this);
        }
    }
}
