﻿namespace Sprint2PizzaProject
{
    partial class NoCheese
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
            label1 = new Label();
            label2 = new Label();
            noCheeseReturnButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 8);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 0;
            label1.Text = "No cheese chosen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 43);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 1;
            label2.Text = "Please choose a cheese";
            // 
            // noCheeseReturnButton
            // 
            noCheeseReturnButton.BackColor = Color.Orange;
            noCheeseReturnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noCheeseReturnButton.Location = new Point(127, 61);
            noCheeseReturnButton.Name = "noCheeseReturnButton";
            noCheeseReturnButton.Size = new Size(75, 31);
            noCheeseReturnButton.TabIndex = 2;
            noCheeseReturnButton.Text = "Return";
            noCheeseReturnButton.UseVisualStyleBackColor = false;
            noCheeseReturnButton.Click += noCheeseReturnButton_Click;
            // 
            // NoCheese
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 95);
            Controls.Add(noCheeseReturnButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NoCheese";
            Text = "NoCheese";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button noCheeseReturnButton;
    }
}