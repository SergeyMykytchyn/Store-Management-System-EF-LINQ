﻿namespace FashionHousesProject
{
    partial class ShowMeClothInShops
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
            this.dataGridView_CLSH = new System.Windows.Forms.DataGridView();
            this.btn_DEL_CL_FROM_SH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CLSH)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_CLSH
            // 
            this.dataGridView_CLSH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CLSH.Location = new System.Drawing.Point(12, 61);
            this.dataGridView_CLSH.Name = "dataGridView_CLSH";
            this.dataGridView_CLSH.ReadOnly = true;
            this.dataGridView_CLSH.RowTemplate.Height = 24;
            this.dataGridView_CLSH.Size = new System.Drawing.Size(747, 286);
            this.dataGridView_CLSH.TabIndex = 0;
            // 
            // btn_DEL_CL_FROM_SH
            // 
            this.btn_DEL_CL_FROM_SH.Location = new System.Drawing.Point(12, 376);
            this.btn_DEL_CL_FROM_SH.Name = "btn_DEL_CL_FROM_SH";
            this.btn_DEL_CL_FROM_SH.Size = new System.Drawing.Size(140, 62);
            this.btn_DEL_CL_FROM_SH.TabIndex = 1;
            this.btn_DEL_CL_FROM_SH.Text = "Видалити Одяг з магазину";
            this.btn_DEL_CL_FROM_SH.UseVisualStyleBackColor = true;
            this.btn_DEL_CL_FROM_SH.Click += new System.EventHandler(this.btn_DEL_CL_FROM_SH_Click);
            // 
            // ShowMeClothInShops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DEL_CL_FROM_SH);
            this.Controls.Add(this.dataGridView_CLSH);
            this.Name = "ShowMeClothInShops";
            this.Text = "Одяг у магазинах";
            this.Load += new System.EventHandler(this.ShowMeClothInShops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CLSH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_CLSH;
        private System.Windows.Forms.Button btn_DEL_CL_FROM_SH;
    }
}