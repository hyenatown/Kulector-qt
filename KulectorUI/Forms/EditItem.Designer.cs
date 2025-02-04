﻿namespace KulectorUI.Forms
{
    partial class EditItem
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
            this.Icon = KulectorUI.Properties.Resources.MainIcon;

            this.TLPRight = new System.Windows.Forms.TableLayoutPanel();
            this.TLPBottomRight = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSaveItem = new System.Windows.Forms.Button();
            this.BtnCancelEditing = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RtbItemDesc = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TLPMaster = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnImageChange = new System.Windows.Forms.Button();
            this.NudItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.LblItemQuantity = new System.Windows.Forms.Label();
            this.TbItemName = new System.Windows.Forms.TextBox();
            this.LblItemName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TLPRight.SuspendLayout();
            this.TLPBottomRight.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TLPMaster.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudItemQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPRight
            // 
            this.TLPRight.ColumnCount = 1;
            this.TLPRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPRight.Controls.Add(this.TLPBottomRight, 0, 1);
            this.TLPRight.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TLPRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPRight.Location = new System.Drawing.Point(483, 3);
            this.TLPRight.Name = "TLPRight";
            this.TLPRight.RowCount = 2;
            this.TLPRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TLPRight.Size = new System.Drawing.Size(317, 467);
            this.TLPRight.TabIndex = 0;
            // 
            // TLPBottomRight
            // 
            this.TLPBottomRight.ColumnCount = 2;
            this.TLPBottomRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBottomRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBottomRight.Controls.Add(this.BtnSaveItem, 1, 0);
            this.TLPBottomRight.Controls.Add(this.BtnCancelEditing, 0, 0);
            this.TLPBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPBottomRight.Location = new System.Drawing.Point(3, 410);
            this.TLPBottomRight.Name = "TLPBottomRight";
            this.TLPBottomRight.RowCount = 1;
            this.TLPBottomRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPBottomRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPBottomRight.Size = new System.Drawing.Size(311, 54);
            this.TLPBottomRight.TabIndex = 0;
            // 
            // BtnSaveItem
            // 
            this.BtnSaveItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSaveItem.Location = new System.Drawing.Point(158, 3);
            this.BtnSaveItem.Name = "BtnSaveItem";
            this.BtnSaveItem.Size = new System.Drawing.Size(150, 48);
            this.BtnSaveItem.TabIndex = 0;
            this.BtnSaveItem.Text = "Save Item";
            this.BtnSaveItem.UseVisualStyleBackColor = true;
            this.BtnSaveItem.Click += new System.EventHandler(this.BtnSaveItem_Click);
            // 
            // BtnCancelEditing
            // 
            this.BtnCancelEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelEditing.Location = new System.Drawing.Point(3, 3);
            this.BtnCancelEditing.Name = "BtnCancelEditing";
            this.BtnCancelEditing.Size = new System.Drawing.Size(149, 48);
            this.BtnCancelEditing.TabIndex = 1;
            this.BtnCancelEditing.Text = "Cancel";
            this.BtnCancelEditing.UseVisualStyleBackColor = true;
            this.BtnCancelEditing.Click += new System.EventHandler(this.BtnCancelEditing_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RtbItemDesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.81546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.18454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 401);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // RtbItemDesc
            // 
            this.RtbItemDesc.Location = new System.Drawing.Point(3, 299);
            this.RtbItemDesc.Name = "RtbItemDesc";
            this.RtbItemDesc.Size = new System.Drawing.Size(305, 99);
            this.RtbItemDesc.TabIndex = 1;
            this.RtbItemDesc.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TLPMaster
            // 
            this.TLPMaster.ColumnCount = 2;
            this.TLPMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.89651F));
            this.TLPMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.10349F));
            this.TLPMaster.Controls.Add(this.TLPRight, 1, 0);
            this.TLPMaster.Controls.Add(this.panel1, 0, 0);
            this.TLPMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMaster.Location = new System.Drawing.Point(0, 0);
            this.TLPMaster.Name = "TLPMaster";
            this.TLPMaster.RowCount = 1;
            this.TLPMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMaster.Size = new System.Drawing.Size(803, 473);
            this.TLPMaster.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnImageChange);
            this.panel1.Controls.Add(this.NudItemQuantity);
            this.panel1.Controls.Add(this.LblItemQuantity);
            this.panel1.Controls.Add(this.TbItemName);
            this.panel1.Controls.Add(this.LblItemName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 467);
            this.panel1.TabIndex = 1;
            // 
            // BtnImageChange
            // 
            this.BtnImageChange.Location = new System.Drawing.Point(9, 410);
            this.BtnImageChange.Name = "BtnImageChange";
            this.BtnImageChange.Size = new System.Drawing.Size(200, 48);
            this.BtnImageChange.TabIndex = 5;
            this.BtnImageChange.Text = "Change Image";
            this.BtnImageChange.UseVisualStyleBackColor = true;
            this.BtnImageChange.Click += new System.EventHandler(this.BtnImageChange_Click);
            // 
            // NudItemQuantity
            // 
            this.NudItemQuantity.Location = new System.Drawing.Point(117, 46);
            this.NudItemQuantity.Name = "NudItemQuantity";
            this.NudItemQuantity.Size = new System.Drawing.Size(354, 27);
            this.NudItemQuantity.TabIndex = 3;
            // 
            // LblItemQuantity
            // 
            this.LblItemQuantity.AutoSize = true;
            this.LblItemQuantity.Location = new System.Drawing.Point(9, 48);
            this.LblItemQuantity.Name = "LblItemQuantity";
            this.LblItemQuantity.Size = new System.Drawing.Size(102, 20);
            this.LblItemQuantity.TabIndex = 2;
            this.LblItemQuantity.Text = "Item Quantity:";
            this.LblItemQuantity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TbItemName
            // 
            this.TbItemName.Location = new System.Drawing.Point(101, 12);
            this.TbItemName.Name = "TbItemName";
            this.TbItemName.Size = new System.Drawing.Size(370, 27);
            this.TbItemName.TabIndex = 1;
            // 
            // LblItemName
            // 
            this.LblItemName.AutoSize = true;
            this.LblItemName.Location = new System.Drawing.Point(9, 15);
            this.LblItemName.Name = "LblItemName";
            this.LblItemName.Size = new System.Drawing.Size(86, 20);
            this.LblItemName.TabIndex = 0;
            this.LblItemName.Text = "Item Name:";
            this.LblItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 473);
            this.Controls.Add(this.TLPMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditItem";
            this.Text = "Kulector - Item Editor";
            this.TLPRight.ResumeLayout(false);
            this.TLPBottomRight.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TLPMaster.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudItemQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPRight;
        private TableLayoutPanel TLPBottomRight;
        private Button BtnSaveItem;
        private Button BtnCancelEditing;
        private RichTextBox RtbItemDesc;
        private TableLayoutPanel TLPMaster;
        private Panel panel1;
        private TextBox TbItemName;
        private Label LblItemName;
        private NumericUpDown NudItemQuantity;
        private Label LblItemQuantity;
        private PictureBox pictureBox1;
        private Button BtnImageChange;
        private TableLayoutPanel tableLayoutPanel1;
        private OpenFileDialog openFileDialog1;
    }
}
