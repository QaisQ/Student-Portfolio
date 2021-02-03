namespace WindowsFormsApp2
{
    partial class UserControl11
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userControl131 = new WindowsFormsApp2.UserControl13();
            this.userControl121 = new WindowsFormsApp2.UserControl12();
            this.userControl141 = new WindowsFormsApp2.UserControl14();
            this.blank1 = new WindowsFormsApp1.Blank();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Aldhabi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(600, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "التعليم";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Aldhabi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(355, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 48);
            this.button2.TabIndex = 0;
            this.button2.Text = "الهوايات";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Aldhabi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(110, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 48);
            this.button3.TabIndex = 0;
            this.button3.Text = "أمور أخرى";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userControl131
            // 
            this.userControl131.Location = new System.Drawing.Point(-3, 145);
            this.userControl131.Name = "userControl131";
            this.userControl131.Size = new System.Drawing.Size(883, 723);
            this.userControl131.TabIndex = 2;
            // 
            // userControl121
            // 
            this.userControl121.Location = new System.Drawing.Point(0, 142);
            this.userControl121.Name = "userControl121";
            this.userControl121.Size = new System.Drawing.Size(883, 723);
            this.userControl121.TabIndex = 1;
            // 
            // userControl141
            // 
            this.userControl141.Location = new System.Drawing.Point(-3, 142);
            this.userControl141.Name = "userControl141";
            this.userControl141.Size = new System.Drawing.Size(883, 723);
            this.userControl141.TabIndex = 3;
            // 
            // blank1
            // 
            this.blank1.Location = new System.Drawing.Point(0, 142);
            this.blank1.Name = "blank1";
            this.blank1.Size = new System.Drawing.Size(883, 868);
            this.blank1.TabIndex = 4;
            // 
            // UserControl11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.blank1);
            this.Controls.Add(this.userControl141);
            this.Controls.Add(this.userControl131);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl121);
            this.Name = "UserControl11";
            this.Size = new System.Drawing.Size(883, 868);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private UserControl12 userControl121;
        private UserControl13 userControl131;
        private UserControl14 userControl141;
        private WindowsFormsApp1.Blank blank1;
    }
}
