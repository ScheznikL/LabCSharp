namespace LR3_SH
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtAdd = new System.Windows.Forms.Button();
            this.BtOpenFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(90, 23);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(114, 57);
            this.BtAdd.TabIndex = 19;
            this.BtAdd.Text = "Add University";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // BtOpenFromFile
            // 
            this.BtOpenFromFile.Location = new System.Drawing.Point(90, 106);
            this.BtOpenFromFile.Name = "BtOpenFromFile";
            this.BtOpenFromFile.Size = new System.Drawing.Size(114, 57);
            this.BtOpenFromFile.TabIndex = 20;
            this.BtOpenFromFile.Text = "Open from file";
            this.BtOpenFromFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 187);
            this.Controls.Add(this.BtOpenFromFile);
            this.Controls.Add(this.BtAdd);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Welcome Page";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Button BtOpenFromFile;
    }
}

