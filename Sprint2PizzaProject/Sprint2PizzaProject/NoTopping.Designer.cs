namespace Sprint2PizzaProject
{
    partial class NoTopping
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
            noToppingReturnButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "No topping chosen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 42);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 1;
            label2.Text = "Please choose a topping";
            // 
            // noToppingReturnButton
            // 
            noToppingReturnButton.BackColor = Color.Orange;
            noToppingReturnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noToppingReturnButton.Location = new Point(133, 60);
            noToppingReturnButton.Name = "noToppingReturnButton";
            noToppingReturnButton.Size = new Size(75, 31);
            noToppingReturnButton.TabIndex = 2;
            noToppingReturnButton.Text = "Return";
            noToppingReturnButton.UseVisualStyleBackColor = false;
            noToppingReturnButton.Click += noToppingReturnButton_Click;
            // 
            // NoTopping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 95);
            Controls.Add(noToppingReturnButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NoTopping";
            Text = "NoTopping";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button noToppingReturnButton;
    }
}