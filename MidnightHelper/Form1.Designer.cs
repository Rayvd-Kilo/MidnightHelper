
namespace MidnightHelper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.setTimerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // numericHours
            // 
            this.numericHours.Location = new System.Drawing.Point(11, 10);
            this.numericHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericHours.Name = "numericHours";
            this.numericHours.Size = new System.Drawing.Size(51, 23);
            this.numericHours.TabIndex = 0;
            // 
            // numericMinutes
            // 
            this.numericMinutes.Location = new System.Drawing.Point(77, 9);
            this.numericMinutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMinutes.Name = "numericMinutes";
            this.numericMinutes.Size = new System.Drawing.Size(51, 23);
            this.numericMinutes.TabIndex = 1;
            // 
            // setTimerButton
            // 
            this.setTimerButton.Location = new System.Drawing.Point(144, 8);
            this.setTimerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setTimerButton.Name = "setTimerButton";
            this.setTimerButton.Size = new System.Drawing.Size(82, 22);
            this.setTimerButton.TabIndex = 2;
            this.setTimerButton.Text = "Set Time";
            this.setTimerButton.UseVisualStyleBackColor = true;
            this.setTimerButton.Click += new System.EventHandler(this.setTimerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 45);
            this.Controls.Add(this.setTimerButton);
            this.Controls.Add(this.numericMinutes);
            this.Controls.Add(this.numericHours);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Midnight Helper";
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericHours;
        private System.Windows.Forms.NumericUpDown numericMinutes;
        private System.Windows.Forms.Button setTimerButton;
    }
}

