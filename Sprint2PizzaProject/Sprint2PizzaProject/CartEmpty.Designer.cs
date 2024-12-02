namespace Sprint2PizzaProject
{
    partial class CartEmpty
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
            cartEmptyReturnButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cartEmptyReturnButton
            // 
            cartEmptyReturnButton.BackColor = Color.Orange;
            cartEmptyReturnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartEmptyReturnButton.Location = new Point(138, 62);
            cartEmptyReturnButton.Name = "cartEmptyReturnButton";
            cartEmptyReturnButton.Size = new Size(75, 31);
            cartEmptyReturnButton.TabIndex = 0;
            cartEmptyReturnButton.Text = "Return";
            cartEmptyReturnButton.UseVisualStyleBackColor = false;
            cartEmptyReturnButton.Click += cartEmptyReturnButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "Cart is empty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 44);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 2;
            label2.Text = "Cannot check out with an empty cart";
            // 
            // CartEmpty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 95);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cartEmptyReturnButton);
            Name = "CartEmpty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CartEmpty";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cartEmptyReturnButton;
        private Label label1;
        private Label label2;
    }
}