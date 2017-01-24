namespace employee
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
			this.label_name = new System.Windows.Forms.Label();
			this.label_tel = new System.Windows.Forms.Label();
			this.label_add = new System.Windows.Forms.Label();
			this.label_mail = new System.Windows.Forms.Label();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.textBox_mail = new System.Windows.Forms.TextBox();
			this.button_prev = new System.Windows.Forms.Button();
			this.button_next = new System.Windows.Forms.Button();
			this.button_insert = new System.Windows.Forms.Button();
			this.button_del = new System.Windows.Forms.Button();
			this.button_search = new System.Windows.Forms.Button();
			this.listBox_mobile = new System.Windows.Forms.ListBox();
			this.listBox_street = new System.Windows.Forms.ListBox();
			this.listBox_home = new System.Windows.Forms.ListBox();
			this.listBox_no = new System.Windows.Forms.ListBox();
			this.listBox_region = new System.Windows.Forms.ListBox();
			this.listBox_city = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox_counry = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_name
			// 
			this.label_name.AutoSize = true;
			this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_name.Location = new System.Drawing.Point(12, 9);
			this.label_name.Name = "label_name";
			this.label_name.Size = new System.Drawing.Size(45, 17);
			this.label_name.TabIndex = 0;
			this.label_name.Text = "Name";
			// 
			// label_tel
			// 
			this.label_tel.AutoSize = true;
			this.label_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_tel.Location = new System.Drawing.Point(12, 53);
			this.label_tel.Name = "label_tel";
			this.label_tel.Size = new System.Drawing.Size(76, 17);
			this.label_tel.TabIndex = 1;
			this.label_tel.Text = "Telephone";
			// 
			// label_add
			// 
			this.label_add.AutoSize = true;
			this.label_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_add.Location = new System.Drawing.Point(12, 146);
			this.label_add.Name = "label_add";
			this.label_add.Size = new System.Drawing.Size(60, 17);
			this.label_add.TabIndex = 2;
			this.label_add.Text = "Address";
			// 
			// label_mail
			// 
			this.label_mail.AutoSize = true;
			this.label_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_mail.Location = new System.Drawing.Point(12, 215);
			this.label_mail.Name = "label_mail";
			this.label_mail.Size = new System.Drawing.Size(47, 17);
			this.label_mail.TabIndex = 3;
			this.label_mail.Text = "E-mail";
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(103, 12);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(181, 20);
			this.textBox_name.TabIndex = 4;
			// 
			// textBox_mail
			// 
			this.textBox_mail.Location = new System.Drawing.Point(103, 212);
			this.textBox_mail.Name = "textBox_mail";
			this.textBox_mail.Size = new System.Drawing.Size(181, 20);
			this.textBox_mail.TabIndex = 7;
			// 
			// button_prev
			// 
			this.button_prev.Location = new System.Drawing.Point(15, 251);
			this.button_prev.Name = "button_prev";
			this.button_prev.Size = new System.Drawing.Size(102, 23);
			this.button_prev.TabIndex = 8;
			this.button_prev.Text = "previous";
			this.button_prev.UseVisualStyleBackColor = true;
			this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
			// 
			// button_next
			// 
			this.button_next.Location = new System.Drawing.Point(192, 251);
			this.button_next.Name = "button_next";
			this.button_next.Size = new System.Drawing.Size(110, 23);
			this.button_next.TabIndex = 9;
			this.button_next.Text = "next";
			this.button_next.UseVisualStyleBackColor = true;
			this.button_next.Click += new System.EventHandler(this.button_next_Click);
			// 
			// button_insert
			// 
			this.button_insert.Location = new System.Drawing.Point(390, 251);
			this.button_insert.Name = "button_insert";
			this.button_insert.Size = new System.Drawing.Size(97, 23);
			this.button_insert.TabIndex = 10;
			this.button_insert.Text = "insert";
			this.button_insert.UseVisualStyleBackColor = true;
			// 
			// button_del
			// 
			this.button_del.Location = new System.Drawing.Point(78, 310);
			this.button_del.Name = "button_del";
			this.button_del.Size = new System.Drawing.Size(115, 23);
			this.button_del.TabIndex = 11;
			this.button_del.Text = "delete";
			this.button_del.UseVisualStyleBackColor = true;
			this.button_del.Click += new System.EventHandler(this.button_del_Click);
			// 
			// button_search
			// 
			this.button_search.Location = new System.Drawing.Point(300, 310);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(108, 23);
			this.button_search.TabIndex = 12;
			this.button_search.Text = "search";
			this.button_search.UseVisualStyleBackColor = true;
			// 
			// listBox_mobile
			// 
			this.listBox_mobile.FormattingEnabled = true;
			this.listBox_mobile.Location = new System.Drawing.Point(103, 38);
			this.listBox_mobile.Name = "listBox_mobile";
			this.listBox_mobile.Size = new System.Drawing.Size(129, 43);
			this.listBox_mobile.TabIndex = 13;
			// 
			// listBox_street
			// 
			this.listBox_street.FormattingEnabled = true;
			this.listBox_street.HorizontalScrollbar = true;
			this.listBox_street.Location = new System.Drawing.Point(113, 122);
			this.listBox_street.Name = "listBox_street";
			this.listBox_street.Size = new System.Drawing.Size(67, 56);
			this.listBox_street.TabIndex = 14;
			// 
			// listBox_home
			// 
			this.listBox_home.FormattingEnabled = true;
			this.listBox_home.Location = new System.Drawing.Point(238, 38);
			this.listBox_home.Name = "listBox_home";
			this.listBox_home.Size = new System.Drawing.Size(129, 43);
			this.listBox_home.TabIndex = 15;
			// 
			// listBox_no
			// 
			this.listBox_no.FormattingEnabled = true;
			this.listBox_no.HorizontalScrollbar = true;
			this.listBox_no.Location = new System.Drawing.Point(186, 122);
			this.listBox_no.Name = "listBox_no";
			this.listBox_no.Size = new System.Drawing.Size(67, 56);
			this.listBox_no.TabIndex = 16;
			// 
			// listBox_region
			// 
			this.listBox_region.FormattingEnabled = true;
			this.listBox_region.HorizontalScrollbar = true;
			this.listBox_region.Location = new System.Drawing.Point(259, 122);
			this.listBox_region.Name = "listBox_region";
			this.listBox_region.Size = new System.Drawing.Size(67, 56);
			this.listBox_region.TabIndex = 17;
			// 
			// listBox_city
			// 
			this.listBox_city.FormattingEnabled = true;
			this.listBox_city.HorizontalScrollbar = true;
			this.listBox_city.Location = new System.Drawing.Point(332, 122);
			this.listBox_city.Name = "listBox_city";
			this.listBox_city.Size = new System.Drawing.Size(67, 56);
			this.listBox_city.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(131, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "street";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(186, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "buliding_No";
			// 
			// listBox_counry
			// 
			this.listBox_counry.FormattingEnabled = true;
			this.listBox_counry.HorizontalScrollbar = true;
			this.listBox_counry.Location = new System.Drawing.Point(405, 122);
			this.listBox_counry.Name = "listBox_counry";
			this.listBox_counry.Size = new System.Drawing.Size(67, 56);
			this.listBox_counry.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(276, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "region";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(353, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 23;
			this.label4.Text = "city";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(420, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 13);
			this.label5.TabIndex = 24;
			this.label5.Text = "country";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 345);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBox_counry);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox_city);
			this.Controls.Add(this.listBox_region);
			this.Controls.Add(this.listBox_no);
			this.Controls.Add(this.listBox_home);
			this.Controls.Add(this.listBox_street);
			this.Controls.Add(this.listBox_mobile);
			this.Controls.Add(this.button_search);
			this.Controls.Add(this.button_del);
			this.Controls.Add(this.button_insert);
			this.Controls.Add(this.button_next);
			this.Controls.Add(this.button_prev);
			this.Controls.Add(this.textBox_mail);
			this.Controls.Add(this.textBox_name);
			this.Controls.Add(this.label_mail);
			this.Controls.Add(this.label_add);
			this.Controls.Add(this.label_tel);
			this.Controls.Add(this.label_name);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ListBox listBox_mobile;
        private System.Windows.Forms.ListBox listBox_street;
		private System.Windows.Forms.ListBox listBox_home;
		private System.Windows.Forms.ListBox listBox_no;
		private System.Windows.Forms.ListBox listBox_region;
		private System.Windows.Forms.ListBox listBox_city;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox_counry;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

