
namespace EmployeeTrackingCrud_2022
{
    partial class FrmListDepartment
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
            this.dataGridViewOfDepartment = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNew = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfDepartment)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOfDepartment
            // 
            this.dataGridViewOfDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOfDepartment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOfDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewOfDepartment.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOfDepartment.Name = "dataGridViewOfDepartment";
            this.dataGridViewOfDepartment.Size = new System.Drawing.Size(468, 243);
            this.dataGridViewOfDepartment.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BtnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 100);
            this.panel1.TabIndex = 1;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(12, 22);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(105, 55);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(345, 22);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(105, 55);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmListDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewOfDepartment);
            this.Name = "FrmListDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operation Of Department";
            this.Load += new System.EventHandler(this.FrmListDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfDepartment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOfDepartment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnNew;
    }
}