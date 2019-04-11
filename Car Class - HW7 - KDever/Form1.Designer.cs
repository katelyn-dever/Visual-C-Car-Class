namespace Car_Class___HW7___KDever
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
            this.makeLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.accelerateButton = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.currentSpeedLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.newCarButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.currentMakeLabel = new System.Windows.Forms.Label();
            this.currentYearLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.Location = new System.Drawing.Point(17, 35);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(54, 20);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(182, 35);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(48, 20);
            this.yearLabel.TabIndex = 1;
            this.yearLabel.Text = "Year:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTextBox.Location = new System.Drawing.Point(21, 67);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 27);
            this.makeTextBox.TabIndex = 2;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.Location = new System.Drawing.Point(186, 67);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 27);
            this.yearTextBox.TabIndex = 3;
            // 
            // accelerateButton
            // 
            this.accelerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelerateButton.Location = new System.Drawing.Point(32, 35);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(112, 37);
            this.accelerateButton.TabIndex = 4;
            this.accelerateButton.Text = "Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakeButton.Location = new System.Drawing.Point(165, 35);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(112, 37);
            this.brakeButton.TabIndex = 5;
            this.brakeButton.Text = "Brake";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // currentSpeedLabel
            // 
            this.currentSpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSpeedLabel.Location = new System.Drawing.Point(90, 87);
            this.currentSpeedLabel.Name = "currentSpeedLabel";
            this.currentSpeedLabel.Size = new System.Drawing.Size(120, 34);
            this.currentSpeedLabel.TabIndex = 6;
            this.currentSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newCarButton);
            this.groupBox1.Controls.Add(this.makeLabel);
            this.groupBox1.Controls.Add(this.yearLabel);
            this.groupBox1.Controls.Add(this.makeTextBox);
            this.groupBox1.Controls.Add(this.yearTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 179);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.accelerateButton);
            this.groupBox2.Controls.Add(this.brakeButton);
            this.groupBox2.Controls.Add(this.currentSpeedLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(200, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 150);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alter Speed";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(303, 413);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newCarButton
            // 
            this.newCarButton.Location = new System.Drawing.Point(98, 115);
            this.newCarButton.Name = "newCarButton";
            this.newCarButton.Size = new System.Drawing.Size(111, 44);
            this.newCarButton.TabIndex = 8;
            this.newCarButton.Text = "New Car";
            this.newCarButton.UseVisualStyleBackColor = true;
            this.newCarButton.Click += new System.EventHandler(this.newCarButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.currentYearLabel);
            this.groupBox3.Controls.Add(this.currentMakeLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(364, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 179);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Car Data";
            // 
            // currentMakeLabel
            // 
            this.currentMakeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentMakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMakeLabel.Location = new System.Drawing.Point(40, 67);
            this.currentMakeLabel.Name = "currentMakeLabel";
            this.currentMakeLabel.Size = new System.Drawing.Size(100, 34);
            this.currentMakeLabel.TabIndex = 0;
            this.currentMakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentYearLabel
            // 
            this.currentYearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentYearLabel.Location = new System.Drawing.Point(176, 67);
            this.currentYearLabel.Name = "currentYearLabel";
            this.currentYearLabel.Size = new System.Drawing.Size(100, 34);
            this.currentYearLabel.TabIndex = 1;
            this.currentYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Car Class HW7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Label currentSpeedLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newCarButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label currentYearLabel;
        private System.Windows.Forms.Label currentMakeLabel;
    }
}

