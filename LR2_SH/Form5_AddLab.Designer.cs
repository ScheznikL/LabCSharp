namespace LR3_SH
{
    partial class Form5_AddLab
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
            this.label6 = new System.Windows.Forms.Label();
            this.BtNextToAud = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtAddToHalls = new System.Windows.Forms.Button();
            this.mTBid = new System.Windows.Forms.MaskedTextBox();
            this.nUpDNumOfComp = new System.Windows.Forms.NumericUpDown();
            this.nUpDNumOfSeats = new System.Windows.Forms.NumericUpDown();
            this.mTbWifiS = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Number of seats";
            // 
            // BtNextToAud
            // 
            this.BtNextToAud.Location = new System.Drawing.Point(233, 176);
            this.BtNextToAud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtNextToAud.Name = "BtNextToAud";
            this.BtNextToAud.Size = new System.Drawing.Size(145, 39);
            this.BtNextToAud.TabIndex = 29;
            this.BtNextToAud.Text = "Next";
            this.BtNextToAud.UseVisualStyleBackColor = true;
            this.BtNextToAud.Click += new System.EventHandler(this.BtNextToAud_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Number of Computers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Wi-fi Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // BtAddToHalls
            // 
            this.BtAddToHalls.Location = new System.Drawing.Point(6, 176);
            this.BtAddToHalls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtAddToHalls.Name = "BtAddToHalls";
            this.BtAddToHalls.Size = new System.Drawing.Size(145, 39);
            this.BtAddToHalls.TabIndex = 32;
            this.BtAddToHalls.Text = "Add More";
            this.BtAddToHalls.UseVisualStyleBackColor = true;
            this.BtAddToHalls.Click += new System.EventHandler(this.BtAddToHalls_Click);
            // 
            // mTBid
            // 
            this.mTBid.Location = new System.Drawing.Point(277, 27);
            this.mTBid.Mask = "000";
            this.mTBid.Name = "mTBid";
            this.mTBid.ReadOnly = true;
            this.mTBid.Size = new System.Drawing.Size(100, 23);
            this.mTBid.TabIndex = 33;
            // 
            // nUpDNumOfComp
            // 
            this.nUpDNumOfComp.Location = new System.Drawing.Point(258, 119);
            this.nUpDNumOfComp.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nUpDNumOfComp.Name = "nUpDNumOfComp";
            this.nUpDNumOfComp.Size = new System.Drawing.Size(120, 23);
            this.nUpDNumOfComp.TabIndex = 34;
            // 
            // nUpDNumOfSeats
            // 
            this.nUpDNumOfSeats.Location = new System.Drawing.Point(258, 60);
            this.nUpDNumOfSeats.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nUpDNumOfSeats.Name = "nUpDNumOfSeats";
            this.nUpDNumOfSeats.Size = new System.Drawing.Size(120, 23);
            this.nUpDNumOfSeats.TabIndex = 35;
            // 
            // mTbWifiS
            // 
            this.mTbWifiS.Location = new System.Drawing.Point(258, 90);
            this.mTbWifiS.Mask = "000.00Mbit";
            this.mTbWifiS.Name = "mTbWifiS";
            this.mTbWifiS.Size = new System.Drawing.Size(118, 23);
            this.mTbWifiS.TabIndex = 36;
            // 
            // Form5_AddLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 228);
            this.Controls.Add(this.mTbWifiS);
            this.Controls.Add(this.nUpDNumOfSeats);
            this.Controls.Add(this.nUpDNumOfComp);
            this.Controls.Add(this.mTBid);
            this.Controls.Add(this.BtAddToHalls);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtNextToAud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form5_AddLab";
            this.ShowIcon = false;
            this.Text = "New Laboratory";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtNextToAud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtAddToHalls;
        private System.Windows.Forms.MaskedTextBox mTBid;
        private System.Windows.Forms.NumericUpDown nUpDNumOfComp;
        private System.Windows.Forms.NumericUpDown nUpDNumOfSeats;
        private System.Windows.Forms.MaskedTextBox mTbWifiS;
    }
}