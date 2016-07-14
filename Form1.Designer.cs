namespace Morse_Code_Converter
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
            this.userInputLabel = new System.Windows.Forms.Label();
            this.morseCodeLabel = new System.Windows.Forms.Label();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.morseCodeOutput = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInputLabel
            // 
            this.userInputLabel.AutoSize = true;
            this.userInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputLabel.Location = new System.Drawing.Point(157, 9);
            this.userInputLabel.Name = "userInputLabel";
            this.userInputLabel.Size = new System.Drawing.Size(73, 16);
            this.userInputLabel.TabIndex = 0;
            this.userInputLabel.Text = "Enter Input:";
            // 
            // morseCodeLabel
            // 
            this.morseCodeLabel.AutoSize = true;
            this.morseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morseCodeLabel.Location = new System.Drawing.Point(114, 78);
            this.morseCodeLabel.Name = "morseCodeLabel";
            this.morseCodeLabel.Size = new System.Drawing.Size(150, 16);
            this.morseCodeLabel.TabIndex = 1;
            this.morseCodeLabel.Text = "Converted Morse Code:";
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputTextBox.Location = new System.Drawing.Point(35, 34);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(312, 22);
            this.userInputTextBox.TabIndex = 2;
            // 
            // morseCodeOutput
            // 
            this.morseCodeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.morseCodeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morseCodeOutput.Location = new System.Drawing.Point(35, 110);
            this.morseCodeOutput.Name = "morseCodeOutput";
            this.morseCodeOutput.Size = new System.Drawing.Size(312, 27);
            this.morseCodeOutput.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(35, 165);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(155, 165);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(272, 165);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 213);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.morseCodeOutput);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.morseCodeLabel);
            this.Controls.Add(this.userInputLabel);
            this.Name = "Form1";
            this.Text = "Morse Code Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userInputLabel;
        private System.Windows.Forms.Label morseCodeLabel;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Label morseCodeOutput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

