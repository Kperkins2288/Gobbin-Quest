namespace Gobbin_Quest
{
    partial class Form_Create_Character
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
            this.label_Name = new System.Windows.Forms.Label();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.label_Gender = new System.Windows.Forms.Label();
            this.groupBox_Gender = new System.Windows.Forms.GroupBox();
            this.radioButton_Gobblyn = new System.Windows.Forms.RadioButton();
            this.radioButton_Gobbina = new System.Windows.Forms.RadioButton();
            this.radioButton_Gobbo = new System.Windows.Forms.RadioButton();
            this.label_Class = new System.Windows.Forms.Label();
            this.comboBox_Class = new System.Windows.Forms.ComboBox();
            this.button_Save_Char = new System.Windows.Forms.Button();
            this.groupBox_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(23, 26);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(36, 18);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // text_Name
            // 
            this.text_Name.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Name.Location = new System.Drawing.Point(76, 19);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(189, 25);
            this.text_Name.TabIndex = 1;
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.Location = new System.Drawing.Point(23, 70);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(50, 18);
            this.label_Gender.TabIndex = 2;
            this.label_Gender.Text = "Gender";
            // 
            // groupBox_Gender
            // 
            this.groupBox_Gender.Controls.Add(this.radioButton_Gobblyn);
            this.groupBox_Gender.Controls.Add(this.radioButton_Gobbina);
            this.groupBox_Gender.Controls.Add(this.radioButton_Gobbo);
            this.groupBox_Gender.Location = new System.Drawing.Point(76, 73);
            this.groupBox_Gender.Name = "groupBox_Gender";
            this.groupBox_Gender.Size = new System.Drawing.Size(189, 104);
            this.groupBox_Gender.TabIndex = 3;
            this.groupBox_Gender.TabStop = false;
            this.groupBox_Gender.UseCompatibleTextRendering = true;
            // 
            // radioButton_Gobblyn
            // 
            this.radioButton_Gobblyn.AutoSize = true;
            this.radioButton_Gobblyn.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Gobblyn.Location = new System.Drawing.Point(7, 68);
            this.radioButton_Gobblyn.Name = "radioButton_Gobblyn";
            this.radioButton_Gobblyn.Size = new System.Drawing.Size(74, 22);
            this.radioButton_Gobblyn.TabIndex = 2;
            this.radioButton_Gobblyn.TabStop = true;
            this.radioButton_Gobblyn.Text = "Gobblyn";
            this.radioButton_Gobblyn.UseVisualStyleBackColor = true;
            // 
            // radioButton_Gobbina
            // 
            this.radioButton_Gobbina.AutoSize = true;
            this.radioButton_Gobbina.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Gobbina.Location = new System.Drawing.Point(7, 44);
            this.radioButton_Gobbina.Name = "radioButton_Gobbina";
            this.radioButton_Gobbina.Size = new System.Drawing.Size(72, 22);
            this.radioButton_Gobbina.TabIndex = 1;
            this.radioButton_Gobbina.TabStop = true;
            this.radioButton_Gobbina.Text = "Gobbina";
            this.radioButton_Gobbina.UseVisualStyleBackColor = true;
            // 
            // radioButton_Gobbo
            // 
            this.radioButton_Gobbo.AutoSize = true;
            this.radioButton_Gobbo.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Gobbo.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Gobbo.Name = "radioButton_Gobbo";
            this.radioButton_Gobbo.Size = new System.Drawing.Size(61, 22);
            this.radioButton_Gobbo.TabIndex = 0;
            this.radioButton_Gobbo.TabStop = true;
            this.radioButton_Gobbo.Text = "Gobbo";
            this.radioButton_Gobbo.UseVisualStyleBackColor = true;
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Class.Location = new System.Drawing.Point(23, 213);
            this.label_Class.Name = "label_Class";
            this.label_Class.Size = new System.Drawing.Size(42, 18);
            this.label_Class.TabIndex = 4;
            this.label_Class.Text = "Class";
            // 
            // comboBox_Class
            // 
            this.comboBox_Class.Font = new System.Drawing.Font("Power Green Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Class.FormattingEnabled = true;
            this.comboBox_Class.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Thief",
            "Novice"});
            this.comboBox_Class.Location = new System.Drawing.Point(76, 210);
            this.comboBox_Class.Name = "comboBox_Class";
            this.comboBox_Class.Size = new System.Drawing.Size(189, 26);
            this.comboBox_Class.TabIndex = 5;
            // 
            // button_Save_Char
            // 
            this.button_Save_Char.Font = new System.Drawing.Font("Power Green Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save_Char.Location = new System.Drawing.Point(76, 265);
            this.button_Save_Char.Name = "button_Save_Char";
            this.button_Save_Char.Size = new System.Drawing.Size(189, 50);
            this.button_Save_Char.TabIndex = 6;
            this.button_Save_Char.Text = "Save Character";
            this.button_Save_Char.UseVisualStyleBackColor = true;
            this.button_Save_Char.Click += new System.EventHandler(this.button_Save_Char_Click);
            // 
            // Form_Create_Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.button_Save_Char);
            this.Controls.Add(this.comboBox_Class);
            this.Controls.Add(this.label_Class);
            this.Controls.Add(this.groupBox_Gender);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.label_Name);
            this.Name = "Form_Create_Character";
            this.Text = "Create Your Character";
            this.groupBox_Gender.ResumeLayout(false);
            this.groupBox_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.GroupBox groupBox_Gender;
        private System.Windows.Forms.RadioButton radioButton_Gobblyn;
        private System.Windows.Forms.RadioButton radioButton_Gobbina;
        private System.Windows.Forms.RadioButton radioButton_Gobbo;
        private System.Windows.Forms.Label label_Class;
        private System.Windows.Forms.ComboBox comboBox_Class;
        private System.Windows.Forms.Button button_Save_Char;
    }
}