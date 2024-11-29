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
            continueToCheckoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continueToCheckoutButton.Location = new Point(83, 102);
            continueToCheckoutButton.Name = "continueToCheckoutButton";
            continueToCheckoutButton.Size = new Size(148, 44);
            continueToCheckoutButton.TabIndex = 0;
            continueToCheckoutButton.Text = "Continue";
            continueToCheckoutButton.UseVisualStyleBackColor = true;
            continueToCheckoutButton.Click += continueToCheckoutButton_Click;
            // 
            // cartFullLabel
            // 
            cartFullLabel.AutoSize = true;
            cartFullLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartFullLabel.Location = new Point(186, 9);
            cartFullLabel.Name = "cartFullLabel";
            cartFullLabel.Size = new Size(141, 38);
            cartFullLabel.TabIndex = 1;
            cartFullLabel.Text = "Cart is full";
            // 
            // cartFullTextLabel
            // 
            cartFullTextLabel.Location = new Point(57, 47);
            cartFullTextLabel.Name = "cartFullTextLabel";
            cartFullTextLabel.Size = new Size(409, 52);
            cartFullTextLabel.TabIndex = 2;
            cartFullTextLabel.Text = "We can only accomodate up to 10 items at this time. Either check out or remove an item.";
            // 
            // returnToCartButton
            // 
            returnToCartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnToCartButton.Location = new Point(271, 102);
            returnToCartButton.Name = "returnToCartButton";
            returnToCartButton.Size = new Size(148, 44);
            returnToCartButton.TabIndex = 3;
            returnToCartButton.Text = "Return";
            returnToCartButton.UseVisualStyleBackColor = true;
            returnToCartButton.Click += returnToCartButton_Click;
            // 
            // CartFullForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 158);
            Controls.Add(returnToCartButton);
            Controls.Add(cartFullTextLabel);
            Controls.Add(cartFullLabel);
            Controls.Add(continueToCheckoutButton);
            Name = "CartFullForm";
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