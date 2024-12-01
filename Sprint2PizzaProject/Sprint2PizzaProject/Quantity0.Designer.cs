namespace Sprint2PizzaProject
{
    partial class Quantity0
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
            returnToMenuButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // returnToMenuButton
            // 
            returnToMenuButton.BackColor = Color.Orange;
            returnToMenuButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnToMenuButton.Location = new Point(130, 60);
            returnToMenuButton.Name = "returnToMenuButton";
            returnToMenuButton.Size = new Size(75, 31);
            returnToMenuButton.TabIndex = 0;
            returnToMenuButton.Text = "Return";
            returnToMenuButton.UseVisualStyleBackColor = false;
            returnToMenuButton.Click += returnToMenuButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 1;
            label1.Text = "Quantity not chosen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 42);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Choose a quantity";
            // 
            // Quantity0
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 95);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(returnToMenuButton);
            Name = "Quantity0";
            Text = "Quantity0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnToMenuButton;
        private Label label1;
        private Label label2;
    }
}