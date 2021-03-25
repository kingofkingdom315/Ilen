namespace Ilen
{
    partial class OffMat
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
            this.all_off_mat_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // all_off_mat_list
            // 
            this.all_off_mat_list.FormattingEnabled = true;
            this.all_off_mat_list.Location = new System.Drawing.Point(12, 12);
            this.all_off_mat_list.Name = "all_off_mat_list";
            this.all_off_mat_list.Size = new System.Drawing.Size(260, 186);
            this.all_off_mat_list.TabIndex = 0;
            // 
            // OffMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.all_off_mat_list);
            this.Name = "OffMat";
            this.Text = "OffMat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox all_off_mat_list;
    }
}