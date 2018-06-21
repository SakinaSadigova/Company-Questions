namespace Answer_3
{
    partial class Form1
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
            this.checkBoxList = new System.Windows.Forms.CheckedListBox();
            this.defineBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxList
            // 
            this.checkBoxList.CheckOnClick = true;
            this.checkBoxList.FormattingEnabled = true;
            this.checkBoxList.Items.AddRange(new object[] {
            "Halsızlıq ",
            "Kitab oxumağa həvəssizlik",
            "Boğazda qıcıqlanma ",
            "Öskürək",
            "Yuxusuzluq"});
            this.checkBoxList.Location = new System.Drawing.Point(12, 12);
            this.checkBoxList.Name = "checkBoxList";
            this.checkBoxList.Size = new System.Drawing.Size(237, 109);
            this.checkBoxList.TabIndex = 0;
            // 
            // defineBtn
            // 
            this.defineBtn.Location = new System.Drawing.Point(174, 127);
            this.defineBtn.Name = "defineBtn";
            this.defineBtn.Size = new System.Drawing.Size(75, 23);
            this.defineBtn.TabIndex = 1;
            this.defineBtn.Text = "Teyin et";
            this.defineBtn.UseVisualStyleBackColor = true;
            this.defineBtn.Click += new System.EventHandler(this.defineBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.defineBtn);
            this.Controls.Add(this.checkBoxList);
            this.Name = "Form1";
            this.Text = "Symptoms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkBoxList;
        private System.Windows.Forms.Button defineBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

