namespace week_4_takehome
{
    partial class mainwindowform
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
            this.button_next = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label_artist = new System.Windows.Forms.Label();
            this.textbox_artist = new System.Windows.Forms.TextBox();
            this.checkbox_true = new System.Windows.Forms.CheckBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(551, 366);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(159, 32);
            this.button_next.TabIndex = 0;
            this.button_next.Text = "Open Next Form";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(96, 95);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(78, 28);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(344, 95);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(212, 26);
            this.textbox_name.TabIndex = 2;
            // 
            // label_artist
            // 
            this.label_artist.AutoSize = true;
            this.label_artist.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_artist.Location = new System.Drawing.Point(96, 141);
            this.label_artist.Name = "label_artist";
            this.label_artist.Size = new System.Drawing.Size(221, 28);
            this.label_artist.TabIndex = 3;
            this.label_artist.Text = "My Favorite Artist";
            // 
            // textbox_artist
            // 
            this.textbox_artist.Location = new System.Drawing.Point(344, 141);
            this.textbox_artist.Name = "textbox_artist";
            this.textbox_artist.Size = new System.Drawing.Size(212, 26);
            this.textbox_artist.TabIndex = 4;
            // 
            // checkbox_true
            // 
            this.checkbox_true.AutoSize = true;
            this.checkbox_true.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_true.Location = new System.Drawing.Point(208, 192);
            this.checkbox_true.Name = "checkbox_true";
            this.checkbox_true.Size = new System.Drawing.Size(304, 24);
            this.checkbox_true.TabIndex = 5;
            this.checkbox_true.Text = "All of the content I put above is true!";
            this.checkbox_true.UseVisualStyleBackColor = true;
            this.checkbox_true.Click += new System.EventHandler(this.checkbox_true_Click);
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(292, 235);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(102, 37);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // mainwindowform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.checkbox_true);
            this.Controls.Add(this.textbox_artist);
            this.Controls.Add(this.label_artist);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_next);
            this.Name = "mainwindowform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label_artist;
        private System.Windows.Forms.TextBox textbox_artist;
        private System.Windows.Forms.CheckBox checkbox_true;
        private System.Windows.Forms.Button button_submit;
    }
}

