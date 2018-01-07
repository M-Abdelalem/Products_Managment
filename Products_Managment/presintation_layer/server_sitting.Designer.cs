namespace Products_Managment.presintation_layer
{
    partial class server_sitting
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
            this.servername = new System.Windows.Forms.TextBox();
            this.databasename = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.خروج = new System.Windows.Forms.Button();
            this.sql = new System.Windows.Forms.RadioButton();
            this.sql_authontication = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // servername
            // 
            this.servername.Location = new System.Drawing.Point(179, 31);
            this.servername.Name = "servername";
            this.servername.Size = new System.Drawing.Size(163, 20);
            this.servername.TabIndex = 0;
            // 
            // databasename
            // 
            this.databasename.Location = new System.Drawing.Point(179, 80);
            this.databasename.Name = "databasename";
            this.databasename.Size = new System.Drawing.Size(163, 20);
            this.databasename.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(179, 182);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(163, 20);
            this.name.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(179, 222);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(163, 20);
            this.password.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // خروج
            // 
            this.خروج.Location = new System.Drawing.Point(267, 292);
            this.خروج.Name = "خروج";
            this.خروج.Size = new System.Drawing.Size(75, 23);
            this.خروج.TabIndex = 5;
            this.خروج.Text = "خروج";
            this.خروج.UseVisualStyleBackColor = true;
            this.خروج.Click += new System.EventHandler(this.button2_Click);
            // 
            // sql
            // 
            this.sql.AutoSize = true;
            this.sql.Checked = true;
            this.sql.Location = new System.Drawing.Point(304, 136);
            this.sql.Name = "sql";
            this.sql.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sql.Size = new System.Drawing.Size(38, 17);
            this.sql.TabIndex = 6;
            this.sql.TabStop = true;
            this.sql.Text = "sql";
            this.sql.UseVisualStyleBackColor = true;
            this.sql.CheckedChanged += new System.EventHandler(this.sql_CheckedChanged);
            // 
            // sql_authontication
            // 
            this.sql_authontication.AutoSize = true;
            this.sql_authontication.Location = new System.Drawing.Point(231, 159);
            this.sql_authontication.Name = "sql_authontication";
            this.sql_authontication.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sql_authontication.Size = new System.Drawing.Size(111, 17);
            this.sql_authontication.TabIndex = 7;
            this.sql_authontication.Text = "sql_authontication";
            this.sql_authontication.UseVisualStyleBackColor = true;
            this.sql_authontication.CheckedChanged += new System.EventHandler(this.sql_authontication_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم السيرفر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "اسم قاعدة البيانات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "نوع الاتصال";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "الاسم";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "الرقم السري";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(179, 107);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(163, 20);
            this.user_name.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "موقع قاعدة البيانات";
            // 
            // server_sitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 362);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sql_authontication);
            this.Controls.Add(this.sql);
            this.Controls.Add(this.خروج);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.databasename);
            this.Controls.Add(this.servername);
            this.Name = "server_sitting";
            this.Text = "server_sitting";
            this.Load += new System.EventHandler(this.server_sitting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox servername;
        private System.Windows.Forms.TextBox databasename;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button خروج;
        private System.Windows.Forms.RadioButton sql;
        private System.Windows.Forms.RadioButton sql_authontication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label6;
    }
}