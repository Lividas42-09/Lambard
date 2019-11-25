namespace Практика
{
    partial class Form2
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
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.ServerNameBox = new System.Windows.Forms.TextBox();
            this.DbNameBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.UserPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(209, 204);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(153, 48);
            this.ConnectionButton.TabIndex = 0;
            this.ConnectionButton.Text = "Подключиться";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // ServerNameBox
            // 
            this.ServerNameBox.Location = new System.Drawing.Point(157, 44);
            this.ServerNameBox.Name = "ServerNameBox";
            this.ServerNameBox.Size = new System.Drawing.Size(255, 20);
            this.ServerNameBox.TabIndex = 1;
            this.ServerNameBox.TextChanged += new System.EventHandler(this.ServerNameBox_TextChanged);
            // 
            // DbNameBox
            // 
            this.DbNameBox.Location = new System.Drawing.Point(157, 80);
            this.DbNameBox.Name = "DbNameBox";
            this.DbNameBox.Size = new System.Drawing.Size(255, 20);
            this.DbNameBox.TabIndex = 2;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(157, 115);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(255, 20);
            this.UserNameBox.TabIndex = 3;
            // 
            // UserPasswordBox
            // 
            this.UserPasswordBox.Location = new System.Drawing.Point(157, 150);
            this.UserPasswordBox.Name = "UserPasswordBox";
            this.UserPasswordBox.Size = new System.Drawing.Size(255, 20);
            this.UserPasswordBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название Сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название БД";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль пользователя";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 285);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserPasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.DbNameBox);
            this.Controls.Add(this.ServerNameBox);
            this.Controls.Add(this.ConnectionButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.TextBox ServerNameBox;
        private System.Windows.Forms.TextBox DbNameBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox UserPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}