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
            this.columnTld = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(65, 105);
            this.title.Margin = new System.Windows.Forms.Padding(4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(132, 22);
            this.title.TabIndex = 0;
            // 
            // savelog
            // 
            this.savelog.Location = new System.Drawing.Point(65, 459);
            this.savelog.Margin = new System.Windows.Forms.Padding(4);
            this.savelog.Name = "savelog";
            this.savelog.Size = new System.Drawing.Size(100, 28);
            this.savelog.TabIndex = 1;
            this.savelog.Text = "Создать";
            this.savelog.UseVisualStyleBackColor = true;
            this.savelog.Click += new System.EventHandler(this.savelog_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(65, 159);
            this.time.Margin = new System.Windows.Forms.Padding(4);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(132, 22);
            this.time.TabIndex = 2;
            // 
            // spon
            // 
            this.spon.Location = new System.Drawing.Point(65, 215);
            this.spon.Margin = new System.Windows.Forms.Padding(4);
            this.spon.Name = "spon";
            this.spon.Size = new System.Drawing.Size(132, 22);
            this.spon.TabIndex = 3;
            // 
            // descript
            // 
            this.descript.Location = new System.Drawing.Point(65, 268);
            this.descript.Margin = new System.Windows.Forms.Padding(4);
            this.descript.Name = "descript";
            this.descript.Size = new System.Drawing.Size(132, 22);
            this.descript.TabIndex = 4;
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(65, 320);
            this.link.Margin = new System.Windows.Forms.Padding(4);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(132, 22);
            this.link.TabIndex = 5;
            // 
            // direct
            // 
            this.direct.Location = new System.Drawing.Point(65, 380);
            this.direct.Margin = new System.Windows.Forms.Padding(4);
            this.direct.Name = "direct";
            this.direct.Size = new System.Drawing.Size(132, 22);
            this.direct.TabIndex = 6;
            this.direct.Text = " ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTld,
            this.columnTime});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(292, 15);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(266, 387);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnTld
            // 
            this.columnTld.Text = "tld";
            this.columnTld.Width = 100;
            // 
            // columnTime
            // 
            this.columnTime.Text = "time";
            this.columnTime.Width = 100;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(679, 15);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(266, 387);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "info";
            this.columnHeader1.Width = 500;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(311, 472);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(126, 43);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(638, 472);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(126, 43);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.direct);
            this.Controls.Add(this.link);
            this.Controls.Add(this.descript);
            this.Controls.Add(this.spon);
            this.Controls.Add(this.time);
            this.Controls.Add(this.savelog);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ColumnHeader columnTld;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
    }
}

