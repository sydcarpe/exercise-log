namespace exercise_log
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
            this.button1 = new System.Windows.Forms.Button();
            this.exerciseName = new System.Windows.Forms.TextBox();
            this.hintname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.notesText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metValue = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.caloriesBPM = new System.Windows.Forms.TextBox();
            this.muscleGroups = new System.Windows.Forms.CheckedListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "View user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exerciseName
            // 
            this.exerciseName.Location = new System.Drawing.Point(368, 12);
            this.exerciseName.Name = "exerciseName";
            this.exerciseName.Size = new System.Drawing.Size(407, 31);
            this.exerciseName.TabIndex = 1;
            this.exerciseName.TextChanged += new System.EventHandler(this.exerciseName_TextChanged);
            // 
            // hintname
            // 
            this.hintname.Location = new System.Drawing.Point(141, 12);
            this.hintname.Name = "hintname";
            this.hintname.ReadOnly = true;
            this.hintname.Size = new System.Drawing.Size(221, 31);
            this.hintname.TabIndex = 2;
            this.hintname.Text = "Weight exercise name";
            this.hintname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(65, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "notes";
            // 
            // notesText
            // 
            this.notesText.Location = new System.Drawing.Point(368, 66);
            this.notesText.Name = "notesText";
            this.notesText.Size = new System.Drawing.Size(407, 31);
            this.notesText.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(119, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "MET Value";
            // 
            // metValue
            // 
            this.metValue.Location = new System.Drawing.Point(368, 125);
            this.metValue.Name = "metValue";
            this.metValue.Size = new System.Drawing.Size(407, 31);
            this.metValue.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(267, 31);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "calories burned per minute";
            // 
            // caloriesBPM
            // 
            this.caloriesBPM.Location = new System.Drawing.Point(368, 186);
            this.caloriesBPM.Name = "caloriesBPM";
            this.caloriesBPM.Size = new System.Drawing.Size(407, 31);
            this.caloriesBPM.TabIndex = 8;
            // 
            // muscleGroups
            // 
            this.muscleGroups.FormattingEnabled = true;
            this.muscleGroups.Location = new System.Drawing.Point(368, 251);
            this.muscleGroups.Name = "muscleGroups";
            this.muscleGroups.Size = new System.Drawing.Size(407, 172);
            this.muscleGroups.TabIndex = 9;
            this.muscleGroups.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(226, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(136, 31);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "muscle group";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(12, 358);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(153, 80);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "create new workout";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.muscleGroups);
            this.Controls.Add(this.caloriesBPM);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.metValue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.notesText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.hintname);
            this.Controls.Add(this.exerciseName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox exerciseName;
        private System.Windows.Forms.TextBox hintname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox notesText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox metValue;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox caloriesBPM;
        private System.Windows.Forms.CheckedListBox muscleGroups;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button submitBtn;
    }
}

