namespace Sprint2PizzaProject
{
    partial class CheckoutPageForm
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
            CheckoutPageLabel = new Label();
            DetailsLabel = new Label();
            AddressLabel = new Label();
            ContactInformationLabel = new Label();
            DeliveryOptionButton = new Button();
            CarryOutOptionButton = new Button();
            PaymentLabel = new Label();
            PaymentText = new TextBox();
            SubtotalLabel = new Label();
            TaxLabel = new Label();
            DeliveryFeeLabel = new Label();
            TotalLabel = new Label();
            PlaceOrderButton = new Button();
            ChangeOrderButton = new Button();
            SuspendLayout();
            // 
            // CheckoutPageLabel
            // 
            CheckoutPageLabel.AutoSize = true;
            CheckoutPageLabel.Location = new Point(12, 9);
            CheckoutPageLabel.Name = "CheckoutPageLabel";
            CheckoutPageLabel.Size = new Size(87, 15);
            CheckoutPageLabel.TabIndex = 0;
            CheckoutPageLabel.Text = "Checkout Page";
            // 
            // DetailsLabel
            // 
            DetailsLabel.AutoSize = true;
            DetailsLabel.Location = new Point(414, 80);
            DetailsLabel.Name = "DetailsLabel";
            DetailsLabel.Size = new Size(42, 15);
            DetailsLabel.TabIndex = 1;
            DetailsLabel.Text = "Details";
            DetailsLabel.Click += DetailsLabel_Click;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(12, 80);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(49, 15);
            AddressLabel.TabIndex = 2;
            AddressLabel.Text = "Address";
            AddressLabel.Click += AddressLabel_Click;
            // 
            // ContactInformationLabel
            // 
            ContactInformationLabel.AutoSize = true;
            ContactInformationLabel.Location = new Point(12, 105);
            ContactInformationLabel.Name = "ContactInformationLabel";
            ContactInformationLabel.Size = new Size(115, 15);
            ContactInformationLabel.TabIndex = 3;
            ContactInformationLabel.Text = "Contact Information";
            ContactInformationLabel.Click += ContactInformationLabel_Click;
            // 
            // DeliveryOptionButton
            // 
            DeliveryOptionButton.BackColor = Color.Orange;
            DeliveryOptionButton.Location = new Point(12, 136);
            DeliveryOptionButton.Name = "DeliveryOptionButton";
            DeliveryOptionButton.Size = new Size(123, 38);
            DeliveryOptionButton.TabIndex = 4;
            DeliveryOptionButton.Text = "Delivery";
            DeliveryOptionButton.UseVisualStyleBackColor = false;
            DeliveryOptionButton.Click += DeliveryOptionButton_Click;
            // 
            // CarryOutOptionButton
            // 
            CarryOutOptionButton.BackColor = Color.Orange;
            CarryOutOptionButton.Location = new Point(12, 180);
            CarryOutOptionButton.Name = "CarryOutOptionButton";
            CarryOutOptionButton.Size = new Size(123, 38);
            CarryOutOptionButton.TabIndex = 5;
            CarryOutOptionButton.Text = "Carry-Out";
            CarryOutOptionButton.UseVisualStyleBackColor = false;
            CarryOutOptionButton.Click += CarryOutOptionButton_Click;
            // 
            // PaymentLabel
            // 
            PaymentLabel.AutoSize = true;
            PaymentLabel.Location = new Point(12, 233);
            PaymentLabel.Name = "PaymentLabel";
            PaymentLabel.Size = new Size(54, 15);
            PaymentLabel.TabIndex = 6;
            PaymentLabel.Text = "Payment";
            PaymentLabel.Click += PaymentLabel_Click;
            // 
            // PaymentText
            // 
            PaymentText.Location = new Point(12, 251);
            PaymentText.Name = "PaymentText";
            PaymentText.Size = new Size(216, 23);
            PaymentText.TabIndex = 7;
            PaymentText.TextChanged += PaymentText_TextChanged;
            // 
            // SubtotalLabel
            // 
            SubtotalLabel.AutoSize = true;
            SubtotalLabel.Location = new Point(12, 287);
            SubtotalLabel.Name = "SubtotalLabel";
            SubtotalLabel.Size = new Size(51, 15);
            SubtotalLabel.TabIndex = 8;
            SubtotalLabel.Text = "Subtotal";
            SubtotalLabel.Click += label5_Click;
            // 
            // TaxLabel
            // 
            TaxLabel.AutoSize = true;
            TaxLabel.Location = new Point(12, 311);
            TaxLabel.Name = "TaxLabel";
            TaxLabel.Size = new Size(24, 15);
            TaxLabel.TabIndex = 9;
            TaxLabel.Text = "Tax";
            TaxLabel.Click += TaxLabel_Click;
            // 
            // DeliveryFeeLabel
            // 
            DeliveryFeeLabel.AutoSize = true;
            DeliveryFeeLabel.Location = new Point(12, 336);
            DeliveryFeeLabel.Name = "DeliveryFeeLabel";
            DeliveryFeeLabel.Size = new Size(59, 15);
            DeliveryFeeLabel.TabIndex = 10;
            DeliveryFeeLabel.Text = "Fee if Any";
            DeliveryFeeLabel.Click += DeliveryFeeLabel_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(12, 360);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(32, 15);
            TotalLabel.TabIndex = 11;
            TotalLabel.Text = "Total";
            TotalLabel.Click += TotalLabel_Click;
            // 
            // PlaceOrderButton
            // 
            PlaceOrderButton.BackColor = Color.Orange;
            PlaceOrderButton.Location = new Point(171, 400);
            PlaceOrderButton.Name = "PlaceOrderButton";
            PlaceOrderButton.Size = new Size(123, 38);
            PlaceOrderButton.TabIndex = 12;
            PlaceOrderButton.Text = "Place Order";
            PlaceOrderButton.UseVisualStyleBackColor = false;
            PlaceOrderButton.Click += PlaceOrderButton_Click;
            // 
            // ChangeOrderButton
            // 
            ChangeOrderButton.BackColor = Color.Orange;
            ChangeOrderButton.Location = new Point(399, 400);
            ChangeOrderButton.Name = "ChangeOrderButton";
            ChangeOrderButton.Size = new Size(123, 38);
            ChangeOrderButton.TabIndex = 13;
            ChangeOrderButton.Text = "Change Order";
            ChangeOrderButton.UseVisualStyleBackColor = false;
            ChangeOrderButton.Click += ChangeOrderButton_Click;
            // 
            // CheckoutPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChangeOrderButton);
            Controls.Add(PlaceOrderButton);
            Controls.Add(TotalLabel);
            Controls.Add(DeliveryFeeLabel);
            Controls.Add(TaxLabel);
            Controls.Add(SubtotalLabel);
            Controls.Add(PaymentText);
            Controls.Add(PaymentLabel);
            Controls.Add(CarryOutOptionButton);
            Controls.Add(DeliveryOptionButton);
            Controls.Add(ContactInformationLabel);
            Controls.Add(AddressLabel);
            Controls.Add(DetailsLabel);
            Controls.Add(CheckoutPageLabel);
            Name = "CheckoutPageForm";
            Text = "CheckoutPageForm";
            Load += CheckoutPageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CheckoutPageLabel;
        private Label DetailsLabel;
        private Label AddressLabel;
        private Label ContactInformationLabel;
        private Button DeliveryOptionButton;
        private Button CarryOutOptionButton;
        private Label PaymentLabel;
        private TextBox PaymentText;
        private Label SubtotalLabel;
        private Label TaxLabel;
        private Label DeliveryFeeLabel;
        private Label TotalLabel;
        private Button PlaceOrderButton;
        private Button ChangeOrderButton;
    }
}