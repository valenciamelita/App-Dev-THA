namespace week_4_takehome
{
    partial class secondwindowform
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
            this.label_background = new System.Windows.Forms.Label();
            this.radio_lightbrown = new System.Windows.Forms.RadioButton();
            this.radio_gray = new System.Windows.Forms.RadioButton();
            this.radio_lightblue = new System.Windows.Forms.RadioButton();
            this.radio_violet = new System.Windows.Forms.RadioButton();
            this.radio_green = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_textcolor = new System.Windows.Forms.Label();
            this.radio_black = new System.Windows.Forms.RadioButton();
            this.radio_white = new System.Windows.Forms.RadioButton();
            this.radio_pink = new System.Windows.Forms.RadioButton();
            this.checkbox_agree = new System.Windows.Forms.CheckBox();
            this.checkbox_true2 = new System.Windows.Forms.CheckBox();
            this.button_magic = new System.Windows.Forms.Button();
            this.label_output = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_background
            // 
            this.label_background.AutoSize = true;
            this.label_background.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_background.Location = new System.Drawing.Point(6, 14);
            this.label_background.Name = "label_background";
            this.label_background.Size = new System.Drawing.Size(425, 28);
            this.label_background.TabIndex = 0;
            this.label_background.Text = "Pick your favorite background color :";
            // 
            // radio_lightbrown
            // 
            this.radio_lightbrown.AutoSize = true;
            this.radio_lightbrown.Location = new System.Drawing.Point(11, 60);
            this.radio_lightbrown.Name = "radio_lightbrown";
            this.radio_lightbrown.Size = new System.Drawing.Size(118, 24);
            this.radio_lightbrown.TabIndex = 1;
            this.radio_lightbrown.TabStop = true;
            this.radio_lightbrown.Text = "Light Brown";
            this.radio_lightbrown.UseVisualStyleBackColor = true;
            this.radio_lightbrown.CheckedChanged += new System.EventHandler(this.radio_lightbrown_CheckedChanged);
            // 
            // radio_gray
            // 
            this.radio_gray.AutoSize = true;
            this.radio_gray.Location = new System.Drawing.Point(11, 90);
            this.radio_gray.Name = "radio_gray";
            this.radio_gray.Size = new System.Drawing.Size(68, 24);
            this.radio_gray.TabIndex = 2;
            this.radio_gray.TabStop = true;
            this.radio_gray.Text = "Gray";
            this.radio_gray.UseVisualStyleBackColor = true;
            // 
            // radio_lightblue
            // 
            this.radio_lightblue.AutoSize = true;
            this.radio_lightblue.Location = new System.Drawing.Point(11, 120);
            this.radio_lightblue.Name = "radio_lightblue";
            this.radio_lightblue.Size = new System.Drawing.Size(105, 24);
            this.radio_lightblue.TabIndex = 3;
            this.radio_lightblue.TabStop = true;
            this.radio_lightblue.Text = "Light Blue";
            this.radio_lightblue.UseVisualStyleBackColor = true;
            // 
            // radio_violet
            // 
            this.radio_violet.AutoSize = true;
            this.radio_violet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radio_violet.Location = new System.Drawing.Point(11, 150);
            this.radio_violet.Name = "radio_violet";
            this.radio_violet.Size = new System.Drawing.Size(74, 24);
            this.radio_violet.TabIndex = 4;
            this.radio_violet.TabStop = true;
            this.radio_violet.Text = "Violet";
            this.radio_violet.UseVisualStyleBackColor = true;
            // 
            // radio_green
            // 
            this.radio_green.AutoSize = true;
            this.radio_green.Location = new System.Drawing.Point(11, 180);
            this.radio_green.Name = "radio_green";
            this.radio_green.Size = new System.Drawing.Size(79, 24);
            this.radio_green.TabIndex = 5;
            this.radio_green.TabStop = true;
            this.radio_green.Text = "Green";
            this.radio_green.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_green);
            this.panel1.Controls.Add(this.radio_violet);
            this.panel1.Controls.Add(this.radio_lightblue);
            this.panel1.Controls.Add(this.radio_gray);
            this.panel1.Controls.Add(this.radio_lightbrown);
            this.panel1.Controls.Add(this.label_background);
            this.panel1.Location = new System.Drawing.Point(6, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 216);
            this.panel1.TabIndex = 6;
            // 
            // label_textcolor
            // 
            this.label_textcolor.AutoSize = true;
            this.label_textcolor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_textcolor.Location = new System.Drawing.Point(12, 229);
            this.label_textcolor.Name = "label_textcolor";
            this.label_textcolor.Size = new System.Drawing.Size(186, 28);
            this.label_textcolor.TabIndex = 6;
            this.label_textcolor.Text = "Pick text color :";
            // 
            // radio_black
            // 
            this.radio_black.AutoSize = true;
            this.radio_black.Location = new System.Drawing.Point(17, 260);
            this.radio_black.Name = "radio_black";
            this.radio_black.Size = new System.Drawing.Size(73, 24);
            this.radio_black.TabIndex = 7;
            this.radio_black.TabStop = true;
            this.radio_black.Text = "Black";
            this.radio_black.UseVisualStyleBackColor = true;
            // 
            // radio_white
            // 
            this.radio_white.AutoSize = true;
            this.radio_white.Location = new System.Drawing.Point(17, 290);
            this.radio_white.Name = "radio_white";
            this.radio_white.Size = new System.Drawing.Size(75, 24);
            this.radio_white.TabIndex = 8;
            this.radio_white.TabStop = true;
            this.radio_white.Text = "White";
            this.radio_white.UseVisualStyleBackColor = true;
            // 
            // radio_pink
            // 
            this.radio_pink.AutoSize = true;
            this.radio_pink.Location = new System.Drawing.Point(17, 320);
            this.radio_pink.Name = "radio_pink";
            this.radio_pink.Size = new System.Drawing.Size(64, 24);
            this.radio_pink.TabIndex = 9;
            this.radio_pink.TabStop = true;
            this.radio_pink.Text = "Pink";
            this.radio_pink.UseVisualStyleBackColor = true;
            // 
            // checkbox_agree
            // 
            this.checkbox_agree.AutoSize = true;
            this.checkbox_agree.Location = new System.Drawing.Point(157, 332);
            this.checkbox_agree.Name = "checkbox_agree";
            this.checkbox_agree.Size = new System.Drawing.Size(283, 24);
            this.checkbox_agree.TabIndex = 10;
            this.checkbox_agree.Text = "I agree to the Terms of Agreement.";
            this.checkbox_agree.UseVisualStyleBackColor = true;
            this.checkbox_agree.CheckedChanged += new System.EventHandler(this.checkbox_agree_CheckedChanged);
            // 
            // checkbox_true2
            // 
            this.checkbox_true2.AutoSize = true;
            this.checkbox_true2.Location = new System.Drawing.Point(157, 362);
            this.checkbox_true2.Name = "checkbox_true2";
            this.checkbox_true2.Size = new System.Drawing.Size(280, 24);
            this.checkbox_true2.TabIndex = 11;
            this.checkbox_true2.Text = "All the choice I pick above are true.";
            this.checkbox_true2.UseVisualStyleBackColor = true;
            this.checkbox_true2.CheckedChanged += new System.EventHandler(this.checkbox_true2_CheckedChanged);
            // 
            // button_magic
            // 
            this.button_magic.Location = new System.Drawing.Point(230, 392);
            this.button_magic.Name = "button_magic";
            this.button_magic.Size = new System.Drawing.Size(88, 31);
            this.button_magic.TabIndex = 12;
            this.button_magic.Text = "MAGIC";
            this.button_magic.UseVisualStyleBackColor = true;
            this.button_magic.Click += new System.EventHandler(this.button_magic_Click);
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output.Location = new System.Drawing.Point(64, 426);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(497, 28);
            this.label_output.TabIndex = 13;
            this.label_output.Text = "Hi, my name is _ and my favorite artist is _";
            // 
            // secondwindowform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.button_magic);
            this.Controls.Add(this.checkbox_true2);
            this.Controls.Add(this.checkbox_agree);
            this.Controls.Add(this.radio_pink);
            this.Controls.Add(this.radio_white);
            this.Controls.Add(this.radio_black);
            this.Controls.Add(this.label_textcolor);
            this.Controls.Add(this.panel1);
            this.Name = "secondwindowform";
            this.Text = "Form2";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_background;
        private System.Windows.Forms.RadioButton radio_lightbrown;
        private System.Windows.Forms.RadioButton radio_gray;
        private System.Windows.Forms.RadioButton radio_lightblue;
        private System.Windows.Forms.RadioButton radio_violet;
        private System.Windows.Forms.RadioButton radio_green;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_textcolor;
        private System.Windows.Forms.RadioButton radio_black;
        private System.Windows.Forms.RadioButton radio_white;
        private System.Windows.Forms.RadioButton radio_pink;
        private System.Windows.Forms.CheckBox checkbox_agree;
        private System.Windows.Forms.CheckBox checkbox_true2;
        private System.Windows.Forms.Button button_magic;
        public System.Windows.Forms.Label label_output;
    }
}