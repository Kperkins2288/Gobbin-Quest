namespace Gobbin_Quest
{
    partial class Form_Menu
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
            this.label_title = new System.Windows.Forms.Label();
            this.button_Creat_Char = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_Score = new System.Windows.Forms.Button();
            this.button_Credits = new System.Windows.Forms.Button();
            this.button_Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Power Green Small", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(60, 50);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(366, 72);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Gobbin Quest";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Creat_Char
            // 
            this.button_Creat_Char.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Creat_Char.Location = new System.Drawing.Point(72, 300);
            this.button_Creat_Char.Name = "button_Creat_Char";
            this.button_Creat_Char.Size = new System.Drawing.Size(150, 50);
            this.button_Creat_Char.TabIndex = 1;
            this.button_Creat_Char.Text = "Create Character";
            this.button_Creat_Char.UseVisualStyleBackColor = true;
            this.button_Creat_Char.Click += new System.EventHandler(this.button_Creat_Char_Click);
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.Location = new System.Drawing.Point(276, 300);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(150, 50);
            this.button_load.TabIndex = 2;
            this.button_load.Text = "Load Game";
            this.button_load.UseVisualStyleBackColor = true;
            // 
            // button_Score
            // 
            this.button_Score.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Score.Location = new System.Drawing.Point(72, 400);
            this.button_Score.Name = "button_Score";
            this.button_Score.Size = new System.Drawing.Size(150, 50);
            this.button_Score.TabIndex = 3;
            this.button_Score.Text = "High Score";
            this.button_Score.UseVisualStyleBackColor = true;
            // 
            // button_Credits
            // 
            this.button_Credits.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Credits.Location = new System.Drawing.Point(276, 400);
            this.button_Credits.Name = "button_Credits";
            this.button_Credits.Size = new System.Drawing.Size(150, 50);
            this.button_Credits.TabIndex = 4;
            this.button_Credits.Text = "Credits";
            this.button_Credits.UseVisualStyleBackColor = true;
            // 
            // button_Options
            // 
            this.button_Options.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Options.Location = new System.Drawing.Point(170, 500);
            this.button_Options.Name = "button_Options";
            this.button_Options.Size = new System.Drawing.Size(150, 50);
            this.button_Options.TabIndex = 5;
            this.button_Options.Text = "Options";
            this.button_Options.UseVisualStyleBackColor = true;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.button_Options);
            this.Controls.Add(this.button_Credits);
            this.Controls.Add(this.button_Score);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_Creat_Char);
            this.Controls.Add(this.label_title);
            this.Name = "Form_Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_Creat_Char;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_Score;
        private System.Windows.Forms.Button button_Credits;
        private System.Windows.Forms.Button button_Options;
    }
}

