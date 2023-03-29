namespace LR3_SH
{
    partial class Form6_AddAud
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
            this.BtSubbmitUn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChBProj = new System.Windows.Forms.CheckBox();
            this.nUpDNumOfBoards = new System.Windows.Forms.NumericUpDown();
            this.chBWiFi = new System.Windows.Forms.CheckBox();
            this.AddAudtoList = new System.Windows.Forms.Button();
            this.mTBid = new System.Windows.Forms.MaskedTextBox();
            this.nUpDNumOfSeats = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfBoards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Number of seats";
            // 
            // BtSubbmitUn
            // 
            this.BtSubbmitUn.Location = new System.Drawing.Point(259, 208);
            this.BtSubbmitUn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtSubbmitUn.Name = "BtSubbmitUn";
            this.BtSubbmitUn.Size = new System.Drawing.Size(169, 40);
            this.BtSubbmitUn.TabIndex = 38;
            this.BtSubbmitUn.Text = "End";
            this.BtSubbmitUn.UseVisualStyleBackColor = true;
            this.BtSubbmitUn.Click += new System.EventHandler(this.BtSubbmitUn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Number of interactive boards";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            // 
            // ChBProj
            // 
            this.ChBProj.AutoSize = true;
            this.ChBProj.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChBProj.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChBProj.Location = new System.Drawing.Point(342, 138);
            this.ChBProj.Name = "ChBProj";
            this.ChBProj.Size = new System.Drawing.Size(85, 22);
            this.ChBProj.TabIndex = 41;
            this.ChBProj.Text = "Projector";
            this.ChBProj.UseVisualStyleBackColor = true;
            // 
            // nUpDNumOfBoards
            // 
            this.nUpDNumOfBoards.Location = new System.Drawing.Point(308, 95);
            this.nUpDNumOfBoards.Name = "nUpDNumOfBoards";
            this.nUpDNumOfBoards.Size = new System.Drawing.Size(120, 23);
            this.nUpDNumOfBoards.TabIndex = 42;
            // 
            // chBWiFi
            // 
            this.chBWiFi.AutoSize = true;
            this.chBWiFi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chBWiFi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBWiFi.Location = new System.Drawing.Point(369, 166);
            this.chBWiFi.Name = "chBWiFi";
            this.chBWiFi.Size = new System.Drawing.Size(58, 22);
            this.chBWiFi.TabIndex = 45;
            this.chBWiFi.Text = "Wi-Fi";
            this.chBWiFi.UseVisualStyleBackColor = true;
            // 
            // AddAudtoList
            // 
            this.AddAudtoList.Location = new System.Drawing.Point(12, 208);
            this.AddAudtoList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddAudtoList.Name = "AddAudtoList";
            this.AddAudtoList.Size = new System.Drawing.Size(169, 40);
            this.AddAudtoList.TabIndex = 46;
            this.AddAudtoList.Text = "Add more";
            this.AddAudtoList.UseVisualStyleBackColor = true;
            this.AddAudtoList.Click += new System.EventHandler(this.AddAudtoList_Click);
            // 
            // mTBid
            // 
            this.mTBid.Location = new System.Drawing.Point(327, 23);
            this.mTBid.Mask = "000";
            this.mTBid.Name = "mTBid";
            this.mTBid.ReadOnly = true;
            this.mTBid.Size = new System.Drawing.Size(100, 23);
            this.mTBid.TabIndex = 47;
            // 
            // nUpDNumOfSeats
            // 
            this.nUpDNumOfSeats.Location = new System.Drawing.Point(308, 55);
            this.nUpDNumOfSeats.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUpDNumOfSeats.Name = "nUpDNumOfSeats";
            this.nUpDNumOfSeats.Size = new System.Drawing.Size(120, 23);
            this.nUpDNumOfSeats.TabIndex = 48;
            // 
            // Form6_AddAud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 256);
            this.Controls.Add(this.nUpDNumOfSeats);
            this.Controls.Add(this.mTBid);
            this.Controls.Add(this.AddAudtoList);
            this.Controls.Add(this.chBWiFi);
            this.Controls.Add(this.nUpDNumOfBoards);
            this.Controls.Add(this.ChBProj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtSubbmitUn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form6_AddAud";
            this.Text = "New Auditory";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfBoards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtSubbmitUn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChBProj;
        private System.Windows.Forms.NumericUpDown nUpDNumOfBoards;
        private System.Windows.Forms.CheckBox chBWiFi;
        private System.Windows.Forms.Button AddAudtoList;
        private System.Windows.Forms.MaskedTextBox mTBid;
        private System.Windows.Forms.NumericUpDown nUpDNumOfSeats;
    }
}