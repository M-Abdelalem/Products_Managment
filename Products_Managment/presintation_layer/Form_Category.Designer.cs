namespace Products_Managment.presintation_layer
{
    partial class Form_Category
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.past = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.category_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.print_item_category = new System.Windows.Forms.Button();
            this.print_category = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.past);
            this.groupBox1.Controls.Add(this.next);
            this.groupBox1.Controls.Add(this.last);
            this.groupBox1.Controls.Add(this.first);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.category_name);
            this.groupBox1.Location = new System.Drawing.Point(390, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(390, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // past
            // 
            this.past.Location = new System.Drawing.Point(122, 55);
            this.past.Name = "past";
            this.past.Size = new System.Drawing.Size(75, 23);
            this.past.TabIndex = 5;
            this.past.Text = ">>";
            this.past.UseVisualStyleBackColor = true;
            this.past.Click += new System.EventHandler(this.past_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(226, 55);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 4;
            this.next.Text = "<<";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(41, 55);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(75, 23);
            this.last.TabIndex = 3;
            this.last.Text = ">>||";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(307, 55);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(75, 23);
            this.first.TabIndex = 2;
            this.first.Text = "||<<";
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الصنف";
            // 
            // category_name
            // 
            this.category_name.Location = new System.Drawing.Point(51, 19);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(187, 20);
            this.category_name.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exit);
            this.groupBox2.Controls.Add(this.print_item_category);
            this.groupBox2.Controls.Add(this.print_category);
            this.groupBox2.Controls.Add(this.update);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(768, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(239, 83);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 8;
            this.exit.Text = "خروج";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // print_item_category
            // 
            this.print_item_category.Location = new System.Drawing.Point(86, 31);
            this.print_item_category.Name = "print_item_category";
            this.print_item_category.Size = new System.Drawing.Size(153, 23);
            this.print_item_category.TabIndex = 5;
            this.print_item_category.Text = "طباعة الصنف الحالي";
            this.print_item_category.UseVisualStyleBackColor = true;
            this.print_item_category.Click += new System.EventHandler(this.button10_Click);
            // 
            // print_category
            // 
            this.print_category.Location = new System.Drawing.Point(378, 83);
            this.print_category.Name = "print_category";
            this.print_category.Size = new System.Drawing.Size(151, 23);
            this.print_category.TabIndex = 4;
            this.print_category.Text = "طباعة كل الاصناف";
            this.print_category.UseVisualStyleBackColor = true;
            this.print_category.Click += new System.EventHandler(this.print_category_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(262, 31);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 3;
            this.update.Text = "تعديل";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(365, 31);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(466, 31);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "اضافة";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(547, 31);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "جديد";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(27, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(357, 205);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لائحة الاصناف";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(314, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Form_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 365);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Category";
            this.Text = "Form_Category";
            this.Load += new System.EventHandler(this.Form_Category_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox category_name;
        private System.Windows.Forms.Button past;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.Button first;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button print_item_category;
        private System.Windows.Forms.Button print_category;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit;
    }
}