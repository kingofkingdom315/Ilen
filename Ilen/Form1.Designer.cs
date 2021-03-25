namespace Ilen
{
    partial class MainForm
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
            this.all_mat_list = new System.Windows.Forms.ListBox();
            this.mat_off_btn = new System.Windows.Forms.Button();
            this.prod_mat_btn = new System.Windows.Forms.Button();
            this.add_off_mat_btn = new System.Windows.Forms.Button();
            this.add_prod_mat_btn = new System.Windows.Forms.Button();
            this.add_mat_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // all_mat_list
            // 
            this.all_mat_list.FormattingEnabled = true;
            this.all_mat_list.Location = new System.Drawing.Point(12, 12);
            this.all_mat_list.Name = "all_mat_list";
            this.all_mat_list.Size = new System.Drawing.Size(296, 225);
            this.all_mat_list.TabIndex = 0;
            // 
            // mat_off_btn
            // 
            this.mat_off_btn.Location = new System.Drawing.Point(12, 243);
            this.mat_off_btn.Name = "mat_off_btn";
            this.mat_off_btn.Size = new System.Drawing.Size(145, 40);
            this.mat_off_btn.TabIndex = 1;
            this.mat_off_btn.Text = "Списаные \r\nматериалы";
            this.mat_off_btn.UseVisualStyleBackColor = true;
            this.mat_off_btn.Click += new System.EventHandler(this.mat_off_btn_Click);
            // 
            // prod_mat_btn
            // 
            this.prod_mat_btn.Location = new System.Drawing.Point(163, 243);
            this.prod_mat_btn.Name = "prod_mat_btn";
            this.prod_mat_btn.Size = new System.Drawing.Size(145, 40);
            this.prod_mat_btn.TabIndex = 2;
            this.prod_mat_btn.Text = "Материалы на \r\nпроизводстве";
            this.prod_mat_btn.UseVisualStyleBackColor = true;
            this.prod_mat_btn.Click += new System.EventHandler(this.prod_mat_btn_Click);
            // 
            // add_off_mat_btn
            // 
            this.add_off_mat_btn.Location = new System.Drawing.Point(314, 12);
            this.add_off_mat_btn.Name = "add_off_mat_btn";
            this.add_off_mat_btn.Size = new System.Drawing.Size(127, 23);
            this.add_off_mat_btn.TabIndex = 3;
            this.add_off_mat_btn.Text = "Списать материал";
            this.add_off_mat_btn.UseVisualStyleBackColor = true;
            this.add_off_mat_btn.Click += new System.EventHandler(this.add_off_mat_btn_Click);
            // 
            // add_prod_mat_btn
            // 
            this.add_prod_mat_btn.Location = new System.Drawing.Point(314, 41);
            this.add_prod_mat_btn.Name = "add_prod_mat_btn";
            this.add_prod_mat_btn.Size = new System.Drawing.Size(127, 36);
            this.add_prod_mat_btn.TabIndex = 4;
            this.add_prod_mat_btn.Text = "Отправить материал \r\nна производство";
            this.add_prod_mat_btn.UseVisualStyleBackColor = true;
            this.add_prod_mat_btn.Click += new System.EventHandler(this.add_prod_mat_btn_Click);
            // 
            // add_mat_btn
            // 
            this.add_mat_btn.Location = new System.Drawing.Point(314, 83);
            this.add_mat_btn.Name = "add_mat_btn";
            this.add_mat_btn.Size = new System.Drawing.Size(127, 23);
            this.add_mat_btn.TabIndex = 5;
            this.add_mat_btn.Text = "Добавить материал";
            this.add_mat_btn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 287);
            this.Controls.Add(this.add_mat_btn);
            this.Controls.Add(this.add_prod_mat_btn);
            this.Controls.Add(this.add_off_mat_btn);
            this.Controls.Add(this.prod_mat_btn);
            this.Controls.Add(this.mat_off_btn);
            this.Controls.Add(this.all_mat_list);
            this.Name = "MainForm";
            this.Text = "Склад";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox all_mat_list;
        private System.Windows.Forms.Button mat_off_btn;
        private System.Windows.Forms.Button prod_mat_btn;
        private System.Windows.Forms.Button add_off_mat_btn;
        private System.Windows.Forms.Button add_prod_mat_btn;
        private System.Windows.Forms.Button add_mat_btn;
    }
}

