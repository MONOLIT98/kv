namespace kv
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
            this.title = new System.Windows.Forms.TextBox();
            this.savelog = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.TextBox();
            this.spon = new System.Windows.Forms.TextBox();
            this.descript = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.TextBox();
            this.direct = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(49, 85);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 0;
            this.title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // savelog
            // 
            this.savelog.Location = new System.Drawing.Point(49, 373);
            this.savelog.Name = "savelog";
            this.savelog.Size = new System.Drawing.Size(75, 23);
            this.savelog.TabIndex = 1;
            this.savelog.Text = "Создать";
            this.savelog.UseVisualStyleBackColor = true;
            this.savelog.Click += new System.EventHandler(this.savelog_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(49, 129);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 20);
            this.time.TabIndex = 2;
            // 
            // spon
            // 
            this.spon.Location = new System.Drawing.Point(49, 175);
            this.spon.Name = "spon";
            this.spon.Size = new System.Drawing.Size(100, 20);
            this.spon.TabIndex = 3;
            // 
            // descript
            // 
            this.descript.Location = new System.Drawing.Point(49, 218);
            this.descript.Name = "descript";
            this.descript.Size = new System.Drawing.Size(100, 20);
            this.descript.TabIndex = 4;
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(49, 260);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(100, 20);
            this.link.TabIndex = 5;
            // 
            // direct
            // 
            this.direct.Location = new System.Drawing.Point(49, 309);
            this.direct.Name = "direct";
            this.direct.Size = new System.Drawing.Size(100, 20);
            this.direct.TabIndex = 6;
            this.direct.Text = " ";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(219, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(209, 426);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.direct);
            this.Controls.Add(this.link);
            this.Controls.Add(this.descript);
            this.Controls.Add(this.spon);
            this.Controls.Add(this.time);
            this.Controls.Add(this.savelog);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button savelog;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox spon;
        private System.Windows.Forms.TextBox descript;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.TextBox direct;
        private System.Windows.Forms.ListView listView1;
    }
}

