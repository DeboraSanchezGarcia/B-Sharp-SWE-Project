namespace Sprint2PizzaProject
{
    partial class ShoppingCart
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
            ShoppingCartLabel = new Label();
            PriceLabel1 = new Label();
            Item1Label = new Label();
            PriceLabel2 = new Label();
            Item2Label = new Label();
            SubtotalLabel = new Label();
            Description1Label = new Label();
            Item1CountLabel = new Label();
            ItemDescription2Label = new Label();
            Item2CountLabel = new Label();
            Item1Picture = new PictureBox();
            Item2Picture = new PictureBox();
            CancelButton = new Button();
            ShopButton = new Button();
            CheckoutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Item1Picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Item2Picture).BeginInit();
            SuspendLayout();
            // 
            // ShoppingCartLabel
            // 
            ShoppingCartLabel.AutoSize = true;
            ShoppingCartLabel.Location = new Point(12, 9);
            ShoppingCartLabel.Name = "ShoppingCartLabel";
            ShoppingCartLabel.Size = new Size(83, 15);
            ShoppingCartLabel.TabIndex = 0;
            ShoppingCartLabel.Text = "Shopping Cart";
            ShoppingCartLabel.Click += ShoppingCartLabel_Click;
            // 
            // PriceLabel1
            // 
            PriceLabel1.AutoSize = true;
            PriceLabel1.Location = new Point(12, 66);
            PriceLabel1.Name = "PriceLabel1";
            PriceLabel1.Size = new Size(33, 15);
            PriceLabel1.TabIndex = 1;
            PriceLabel1.Text = "Price";
            PriceLabel1.Click += PriceLabel1_Click;
            // 
            // Item1Label
            // 
            Item1Label.AutoSize = true;
            Item1Label.Location = new Point(347, 66);
            Item1Label.Name = "Item1Label";
            Item1Label.Size = new Size(31, 15);
            Item1Label.TabIndex = 2;
            Item1Label.Text = "Item";
            Item1Label.Click += Item1Label_Click;
            // 
            // PriceLabel2
            // 
            PriceLabel2.AutoSize = true;
            PriceLabel2.Location = new Point(12, 172);
            PriceLabel2.Name = "PriceLabel2";
            PriceLabel2.Size = new Size(33, 15);
            PriceLabel2.TabIndex = 3;
            PriceLabel2.Text = "Price";
            PriceLabel2.Click += PriceLabel2_Click;
            // 
            // Item2Label
            // 
            Item2Label.AutoSize = true;
            Item2Label.Location = new Point(347, 172);
            Item2Label.Name = "Item2Label";
            Item2Label.Size = new Size(31, 15);
            Item2Label.TabIndex = 4;
            Item2Label.Text = "Item";
            Item2Label.Click += Item2Label_Click;
            // 
            // SubtotalLabel
            // 
            SubtotalLabel.AutoSize = true;
            SubtotalLabel.Location = new Point(12, 309);
            SubtotalLabel.Name = "SubtotalLabel";
            SubtotalLabel.Size = new Size(54, 15);
            SubtotalLabel.TabIndex = 5;
            SubtotalLabel.Text = "Subtotal:";
            SubtotalLabel.Click += SubtotalLabel_Click;
            // 
            // Description1Label
            // 
            Description1Label.AutoSize = true;
            Description1Label.Location = new Point(347, 81);
            Description1Label.Name = "Description1Label";
            Description1Label.Size = new Size(67, 15);
            Description1Label.TabIndex = 6;
            Description1Label.Text = "Description";
            Description1Label.Click += Description1Label_Click;
            // 
            // Item1CountLabel
            // 
            Item1CountLabel.AutoSize = true;
            Item1CountLabel.Location = new Point(347, 96);
            Item1CountLabel.Name = "Item1CountLabel";
            Item1CountLabel.Size = new Size(40, 15);
            Item1CountLabel.TabIndex = 7;
            Item1CountLabel.Text = "Count";
            Item1CountLabel.Click += Item1CountLabel_Click;
            // 
            // ItemDescription2Label
            // 
            ItemDescription2Label.AutoSize = true;
            ItemDescription2Label.Location = new Point(347, 187);
            ItemDescription2Label.Name = "ItemDescription2Label";
            ItemDescription2Label.Size = new Size(67, 15);
            ItemDescription2Label.TabIndex = 8;
            ItemDescription2Label.Text = "Description";
            ItemDescription2Label.Click += ItemDescription2Label_Click;
            // 
            // Item2CountLabel
            // 
            Item2CountLabel.AutoSize = true;
            Item2CountLabel.Location = new Point(347, 202);
            Item2CountLabel.Name = "Item2CountLabel";
            Item2CountLabel.Size = new Size(40, 15);
            Item2CountLabel.TabIndex = 9;
            Item2CountLabel.Text = "Count";
            Item2CountLabel.Click += Item2CountLabel_Click;
            // 
            // Item1Picture
            // 
            Item1Picture.Location = new Point(591, 66);
            Item1Picture.Name = "Item1Picture";
            Item1Picture.Size = new Size(159, 70);
            Item1Picture.TabIndex = 10;
            Item1Picture.TabStop = false;
            Item1Picture.Click += Item1Picture_Click;
            // 
            // Item2Picture
            // 
            Item2Picture.Location = new Point(591, 172);
            Item2Picture.Name = "Item2Picture";
            Item2Picture.Size = new Size(159, 70);
            Item2Picture.TabIndex = 11;
            Item2Picture.TabStop = false;
            Item2Picture.Click += Item2Picture_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(299, 393);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(86, 45);
            CancelButton.TabIndex = 12;
            CancelButton.Text = "Cancel Cart";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ShopButton
            // 
            ShopButton.Location = new Point(447, 393);
            ShopButton.Name = "ShopButton";
            ShopButton.Size = new Size(93, 45);
            ShopButton.TabIndex = 13;
            ShopButton.Text = "KeepShopping";
            ShopButton.UseVisualStyleBackColor = true;
            ShopButton.Click += ShopButton_Click;
            // 
            // CheckoutButton
            // 
            CheckoutButton.Location = new Point(591, 393);
            CheckoutButton.Name = "CheckoutButton";
            CheckoutButton.Size = new Size(88, 45);
            CheckoutButton.TabIndex = 14;
            CheckoutButton.Text = "Checkout";
            CheckoutButton.UseVisualStyleBackColor = true;
            CheckoutButton.Click += CheckoutButton_Click;
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CheckoutButton);
            Controls.Add(ShopButton);
            Controls.Add(CancelButton);
            Controls.Add(Item2Picture);
            Controls.Add(Item1Picture);
            Controls.Add(Item2CountLabel);
            Controls.Add(ItemDescription2Label);
            Controls.Add(Item1CountLabel);
            Controls.Add(Description1Label);
            Controls.Add(SubtotalLabel);
            Controls.Add(Item2Label);
            Controls.Add(PriceLabel2);
            Controls.Add(Item1Label);
            Controls.Add(PriceLabel1);
            Controls.Add(ShoppingCartLabel);
            Name = "ShoppingCart";
            Text = "ShoppingCart";
            ((System.ComponentModel.ISupportInitialize)Item1Picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)Item2Picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShoppingCartLabel;
        private Label PriceLabel1;
        private Label Item1Label;
        private Label PriceLabel2;
        private Label Item2Label;
        private Label SubtotalLabel;
        private Label Description1Label;
        private Label Item1CountLabel;
        private Label ItemDescription2Label;
        private Label Item2CountLabel;
        private PictureBox Item1Picture;
        private PictureBox Item2Picture;
        private Button CancelButton;
        private Button ShopButton;
        private Button CheckoutButton;
    }
}