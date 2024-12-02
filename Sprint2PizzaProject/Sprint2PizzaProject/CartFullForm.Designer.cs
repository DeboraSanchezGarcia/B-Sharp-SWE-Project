namespace Sprint2PizzaProject
{
    partial class CartFullForm
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
            continueToCheckoutButton = new Button();
            cartFullLabel = new Label();
            cartFullTextLabel = new Label();
            returnToCartButton = new Button();
            SuspendLayout();
            // 
            // continueToCheckoutButton
            // 
            continueToCheckoutButton.BackColor = Color.Orange;
            continueToCheckoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continueToCheckoutButton.Location = new Point(58, 61);
            continueToCheckoutButton.Margin = new Padding(2);
            continueToCheckoutButton.Name = "continueToCheckoutButton";
            continueToCheckoutButton.Size = new Size(104, 26);
            continueToCheckoutButton.TabIndex = 0;
            continueToCheckoutButton.Text = "Continue";
            continueToCheckoutButton.UseVisualStyleBackColor = false;
            continueToCheckoutButton.Click += continueToCheckoutButton_Click;
            // 
            // cartFullLabel
            // 
            cartFullLabel.AutoSize = true;
            cartFullLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartFullLabel.Location = new Point(130, 5);
            cartFullLabel.Margin = new Padding(2, 0, 2, 0);
            cartFullLabel.Name = "cartFullLabel";
            cartFullLabel.Size = new Size(97, 25);
            cartFullLabel.TabIndex = 1;
            cartFullLabel.Text = "Cart is full";
            // 
            // cartFullTextLabel
            // 
            cartFullTextLabel.Location = new Point(40, 28);
            cartFullTextLabel.Margin = new Padding(2, 0, 2, 0);
            cartFullTextLabel.Name = "cartFullTextLabel";
            cartFullTextLabel.Size = new Size(286, 31);
            cartFullTextLabel.TabIndex = 2;
            cartFullTextLabel.Text = "We can only accomodate up to 10 items at this time. Either check out or remove an item.";
            // 
            // returnToCartButton
            // 
            returnToCartButton.BackColor = Color.Orange;
            returnToCartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnToCartButton.Location = new Point(190, 61);
            returnToCartButton.Margin = new Padding(2);
            returnToCartButton.Name = "returnToCartButton";
            returnToCartButton.Size = new Size(104, 26);
            returnToCartButton.TabIndex = 3;
            returnToCartButton.Text = "Return";
            returnToCartButton.UseVisualStyleBackColor = false;
            returnToCartButton.Click += returnToCartButton_Click;
            // 
            // CartFullForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 95);
            Controls.Add(returnToCartButton);
            Controls.Add(cartFullTextLabel);
            Controls.Add(cartFullLabel);
            Controls.Add(continueToCheckoutButton);
            Margin = new Padding(2);
            Name = "CartFullForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CartFullForm";
            Load += CartFullForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button continueToCheckoutButton;
        private Label cartFullLabel;
        private Label cartFullTextLabel;
        private Button returnToCartButton;
    }
}