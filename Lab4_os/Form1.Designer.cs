namespace Lab4_os
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
            this.PlusButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.MultButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.SignLabel = new System.Windows.Forms.Label();
            this.FirstValTextBox = new System.Windows.Forms.TextBox();
            this.SecondValTextBox = new System.Windows.Forms.TextBox();
            this.EqSignLabel = new System.Windows.Forms.Label();
            this.ResLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.Location = new System.Drawing.Point(51, 228);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(122, 42);
            this.PlusButton.TabIndex = 0;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubButton.Location = new System.Drawing.Point(222, 228);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(113, 42);
            this.SubButton.TabIndex = 1;
            this.SubButton.Text = "-";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // MultButton
            // 
            this.MultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultButton.Location = new System.Drawing.Point(386, 228);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(109, 42);
            this.MultButton.TabIndex = 2;
            this.MultButton.Text = "*";
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivButton.Location = new System.Drawing.Point(538, 228);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(126, 42);
            this.DivButton.TabIndex = 3;
            this.DivButton.Text = "/";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignLabel.Location = new System.Drawing.Point(245, 116);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(0, 32);
            this.SignLabel.TabIndex = 4;
            this.SignLabel.Click += new System.EventHandler(this.SignLabel_Click);
            // 
            // FirstValTextBox
            // 
            this.FirstValTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstValTextBox.Location = new System.Drawing.Point(129, 116);
            this.FirstValTextBox.Name = "FirstValTextBox";
            this.FirstValTextBox.Size = new System.Drawing.Size(90, 39);
            this.FirstValTextBox.TabIndex = 5;
            this.FirstValTextBox.TextChanged += new System.EventHandler(this.FirstValTextBox_TextChanged);
            // 
            // SecondValTextBox
            // 
            this.SecondValTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondValTextBox.Location = new System.Drawing.Point(338, 115);
            this.SecondValTextBox.Name = "SecondValTextBox";
            this.SecondValTextBox.Size = new System.Drawing.Size(100, 39);
            this.SecondValTextBox.TabIndex = 6;
            this.SecondValTextBox.TextChanged += new System.EventHandler(this.SecondValTextBox_TextChanged);
            // 
            // EqSignLabel
            // 
            this.EqSignLabel.AutoSize = true;
            this.EqSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqSignLabel.Location = new System.Drawing.Point(505, 115);
            this.EqSignLabel.Name = "EqSignLabel";
            this.EqSignLabel.Size = new System.Drawing.Size(30, 32);
            this.EqSignLabel.TabIndex = 8;
            this.EqSignLabel.Text = "=";
            this.EqSignLabel.Click += new System.EventHandler(this.EqSignLabel_Click);
            // 
            // ResLabel
            // 
            this.ResLabel.AutoSize = true;
            this.ResLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResLabel.Location = new System.Drawing.Point(622, 116);
            this.ResLabel.Name = "ResLabel";
            this.ResLabel.Size = new System.Drawing.Size(0, 32);
            this.ResLabel.TabIndex = 9;
            this.ResLabel.Click += new System.EventHandler(this.ResLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.ResLabel);
            this.Controls.Add(this.EqSignLabel);
            this.Controls.Add(this.SecondValTextBox);
            this.Controls.Add(this.FirstValTextBox);
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.MultButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.PlusButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button MultButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Label SignLabel;
        private System.Windows.Forms.TextBox FirstValTextBox;
        private System.Windows.Forms.TextBox SecondValTextBox;
        private System.Windows.Forms.Label EqSignLabel;
        private System.Windows.Forms.Label ResLabel;
    }
}

