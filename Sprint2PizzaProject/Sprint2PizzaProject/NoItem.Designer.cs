namespace Sprint2PizzaProject
{
    partial class NoItem
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
            notItemReturnButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // notItemReturnButton
            // 
            notItemReturnButton.BackColor = Color.Orange;
            notItemReturnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notItemReturnButton.Location = new Point(135, 61);
            notItemReturnButton.Name = "notItemReturnButton";
            notItemReturnButton.Size = new Size(75, 31);
            notItemReturnButton.TabIndex = 0;
            notItemReturnButton.Text = "Return";
            notItemReturnButton.UseVisualStyleBackColor = false;
            notItemReturnButton.Click += notItemReturnButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 1;
            label1.Text = "No item chosen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 43);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 2;
            label2.Text = "Please choose an item";
            // 
            // NoItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 95);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(notItemReturnButton);
            Name = "NoItem";
            Text = "NoItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button notItemReturnButton;
        private Label label1;
        private Label label2;
    }
}