namespace LR3_SH
{
    partial class Form2_AddUn
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
            this.BtAddUnData = new System.Windows.Forms.Button();
            this.WhoorWhat = new System.Windows.Forms.Label();
            this.TbUnName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nUpDNumOfFacult = new System.Windows.Forms.NumericUpDown();
            this.nUpDNumOfStud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfFacult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfStud)).BeginInit();
            this.SuspendLayout();
            // 
            // BtAddUnData
            // 
            this.BtAddUnData.Location = new System.Drawing.Point(406, 290);
            this.BtAddUnData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtAddUnData.Name = "BtAddUnData";
            this.BtAddUnData.Size = new System.Drawing.Size(129, 32);
            this.BtAddUnData.TabIndex = 0;
            this.BtAddUnData.Text = "Next";
            this.BtAddUnData.UseVisualStyleBackColor = true;
            this.BtAddUnData.Click += new System.EventHandler(this.BtAddUnData_Click);
            // 
            // WhoorWhat
            // 
            this.WhoorWhat.AutoSize = true;
            this.WhoorWhat.Location = new System.Drawing.Point(29, 12);
            this.WhoorWhat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WhoorWhat.Name = "WhoorWhat";
            this.WhoorWhat.Size = new System.Drawing.Size(13, 18);
            this.WhoorWhat.TabIndex = 1;
            this.WhoorWhat.Text = " ";
            // 
            // TbUnName
            // 
            this.TbUnName.Location = new System.Drawing.Point(145, 89);
            this.TbUnName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbUnName.MaxLength = 5;
            this.TbUnName.Name = "TbUnName";
            this.TbUnName.Size = new System.Drawing.Size(390, 26);
            this.TbUnName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter required data below:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "University name:";
            // 
            // BtBack
            // 
            this.BtBack.Location = new System.Drawing.Point(12, 291);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(129, 32);
            this.BtBack.TabIndex = 5;
            this.BtBack.Text = "Back";
            this.BtBack.UseVisualStyleBackColor = true;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of faculties:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of students:";
            // 
            // nUpDNumOfFacult
            // 
            this.nUpDNumOfFacult.Location = new System.Drawing.Point(415, 142);
            this.nUpDNumOfFacult.Name = "nUpDNumOfFacult";
            this.nUpDNumOfFacult.Size = new System.Drawing.Size(120, 26);
            this.nUpDNumOfFacult.TabIndex = 10;
            // 
            // nUpDNumOfStud
            // 
            this.nUpDNumOfStud.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUpDNumOfStud.Location = new System.Drawing.Point(415, 184);
            this.nUpDNumOfStud.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nUpDNumOfStud.Name = "nUpDNumOfStud";
            this.nUpDNumOfStud.Size = new System.Drawing.Size(120, 26);
            this.nUpDNumOfStud.TabIndex = 11;
            // 
            // Form2_AddUn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 335);
            this.Controls.Add(this.nUpDNumOfStud);
            this.Controls.Add(this.nUpDNumOfFacult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbUnName);
            this.Controls.Add(this.WhoorWhat);
            this.Controls.Add(this.BtAddUnData);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2_AddUn";
            this.ShowIcon = false;
            this.Text = "New Unversity";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfFacult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfStud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtAddUnData;
        public System.Windows.Forms.Label WhoorWhat;
        public System.Windows.Forms.TextBox TbUnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown nUpDNumOfFacult;
        public System.Windows.Forms.NumericUpDown nUpDNumOfStud;
    }
}