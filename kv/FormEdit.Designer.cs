
namespace kv
{
    partial class FormEdit
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.directEdit = new System.Windows.Forms.TextBox();
            this.linkEdit = new System.Windows.Forms.TextBox();
            this.descriptEdit = new System.Windows.Forms.TextBox();
            this.sponEdit = new System.Windows.Forms.TextBox();
            this.timeEdit = new System.Windows.Forms.TextBox();
            this.titleEdit = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(586, 404);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(232, 43);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // directEdit
            // 
            this.directEdit.Location = new System.Drawing.Point(81, 351);
            this.directEdit.Margin = new System.Windows.Forms.Padding(4);
            this.directEdit.Name = "directEdit";
            this.directEdit.Size = new System.Drawing.Size(238, 22);
            this.directEdit.TabIndex = 16;
            this.directEdit.Text = " ";
            // 
            // linkEdit
            // 
            this.linkEdit.Location = new System.Drawing.Point(81, 291);
            this.linkEdit.Margin = new System.Windows.Forms.Padding(4);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(238, 22);
            this.linkEdit.TabIndex = 15;
            // 
            // descriptEdit
            // 
            this.descriptEdit.Location = new System.Drawing.Point(81, 239);
            this.descriptEdit.Margin = new System.Windows.Forms.Padding(4);
            this.descriptEdit.Name = "descriptEdit";
            this.descriptEdit.Size = new System.Drawing.Size(238, 22);
            this.descriptEdit.TabIndex = 14;
            // 
            // sponEdit
            // 
            this.sponEdit.Location = new System.Drawing.Point(81, 186);
            this.sponEdit.Margin = new System.Windows.Forms.Padding(4);
            this.sponEdit.Name = "sponEdit";
            this.sponEdit.Size = new System.Drawing.Size(238, 22);
            this.sponEdit.TabIndex = 13;
            // 
            // timeEdit
            // 
            this.timeEdit.Location = new System.Drawing.Point(81, 130);
            this.timeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.timeEdit.Name = "timeEdit";
            this.timeEdit.Size = new System.Drawing.Size(238, 22);
            this.timeEdit.TabIndex = 12;
            // 
            // titleEdit
            // 
            this.titleEdit.Location = new System.Drawing.Point(81, 76);
            this.titleEdit.Margin = new System.Windows.Forms.Padding(4);
            this.titleEdit.Name = "titleEdit";
            this.titleEdit.Size = new System.Drawing.Size(238, 22);
            this.titleEdit.TabIndex = 11;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(81, 413);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(238, 41);
            this.buttonChange.TabIndex = 18;
            this.buttonChange.Text = "Сохранить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 483);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.directEdit);
            this.Controls.Add(this.linkEdit);
            this.Controls.Add(this.descriptEdit);
            this.Controls.Add(this.sponEdit);
            this.Controls.Add(this.timeEdit);
            this.Controls.Add(this.titleEdit);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox directEdit;
        private System.Windows.Forms.TextBox linkEdit;
        private System.Windows.Forms.TextBox descriptEdit;
        private System.Windows.Forms.TextBox sponEdit;
        private System.Windows.Forms.TextBox timeEdit;
        private System.Windows.Forms.TextBox titleEdit;
        private System.Windows.Forms.Button buttonChange;
    }
}