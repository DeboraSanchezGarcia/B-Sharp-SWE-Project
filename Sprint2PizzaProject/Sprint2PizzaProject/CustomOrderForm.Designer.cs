namespace Sprint2PizzaProject
{
    partial class CustomOrder
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
            customOrderLabel = new Label();
            cancelButton = new Button();
            confirmButton = new Button();
            crustComboBox = new ComboBox();
            topping1ComboBox = new ComboBox();
            crustLabel = new Label();
            topping1Label = new Label();
            topping2Label = new Label();
            topping3Label = new Label();
            topping4Label = new Label();
            cheese1Label = new Label();
            cheese2Label = new Label();
            topping2ComboBox = new ComboBox();
            topping3ComboBox = new ComboBox();
            topping4ComboBox = new ComboBox();
            cheese1ComboBox = new ComboBox();
            cheese2ComboBox = new ComboBox();
            topping3OptionComboBox = new ComboBox();
            topping1OptionComboBox = new ComboBox();
            topping2OptionComboBox = new ComboBox();
            topping4OptionComboBox = new ComboBox();
            cheese1OptionComboBox = new ComboBox();
            cheese2OptionComboBox = new ComboBox();
            quantityComboBox = new ComboBox();
            crustOptionComboBox = new ComboBox();
            customTotalLabel = new Label();
            customTotalDisplayLabel = new Label();
            SuspendLayout();
            // 
            // customOrderLabel
            // 
            customOrderLabel.AutoSize = true;
            customOrderLabel.Location = new Point(17, 38);
            customOrderLabel.Margin = new Padding(4, 0, 4, 0);
            customOrderLabel.Name = "customOrderLabel";
            customOrderLabel.Size = new Size(125, 25);
            customOrderLabel.TabIndex = 0;
            customOrderLabel.Text = "Custom Order";
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(833, 413);
            cancelButton.Margin = new Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(197, 105);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmButton.Location = new Point(833, 227);
            confirmButton.Margin = new Padding(4, 5, 4, 5);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(197, 105);
            confirmButton.TabIndex = 9;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // crustComboBox
            // 
            crustComboBox.FormattingEnabled = true;
            crustComboBox.Items.AddRange(new object[] { "Regular +$0.50", "Thin +$0.50", "Thick +$1.00", "Stuffed +$1.50" });
            crustComboBox.Location = new Point(17, 153);
            crustComboBox.Margin = new Padding(4, 5, 4, 5);
            crustComboBox.Name = "crustComboBox";
            crustComboBox.Size = new Size(257, 33);
            crustComboBox.TabIndex = 10;
            crustComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // topping1ComboBox
            // 
            topping1ComboBox.FormattingEnabled = true;
            topping1ComboBox.Items.AddRange(new object[] { "Pepperoni $0.99 ", "Sausage $0.99 ", "Ham $0.99 ", "Bacon $0.99 ", "Chicken $0.99 ", "Beef $0.99 ", "Salami $0.99 ", "Anchovies\t $0.99 ", "Banana Peppers $0.50 ", "Green Peppers $0.50 ", "Jalapeno Peppers $0.50 ", "Black Olives $0.50 ", "Pineapple $0.50 ", "Mushrooms $0.50 " });
            topping1ComboBox.Location = new Point(17, 227);
            topping1ComboBox.Margin = new Padding(4, 5, 4, 5);
            topping1ComboBox.Name = "topping1ComboBox";
            topping1ComboBox.Size = new Size(257, 33);
            topping1ComboBox.TabIndex = 12;
            topping1ComboBox.SelectedIndexChanged += topping1ComboBox_SelectedIndexChanged;
            // 
            // crustLabel
            // 
            crustLabel.AutoSize = true;
            crustLabel.Location = new Point(17, 123);
            crustLabel.Margin = new Padding(4, 0, 4, 0);
            crustLabel.Name = "crustLabel";
            crustLabel.Size = new Size(53, 25);
            crustLabel.TabIndex = 13;
            crustLabel.Text = "Crust";
            // 
            // topping1Label
            // 
            topping1Label.AutoSize = true;
            topping1Label.Location = new Point(17, 197);
            topping1Label.Margin = new Padding(4, 0, 4, 0);
            topping1Label.Name = "topping1Label";
            topping1Label.Size = new Size(92, 25);
            topping1Label.TabIndex = 14;
            topping1Label.Text = "Topping 1";
            // 
            // topping2Label
            // 
            topping2Label.AutoSize = true;
            topping2Label.Location = new Point(17, 270);
            topping2Label.Margin = new Padding(4, 0, 4, 0);
            topping2Label.Name = "topping2Label";
            topping2Label.Size = new Size(92, 25);
            topping2Label.TabIndex = 15;
            topping2Label.Text = "Topping 2";
            // 
            // topping3Label
            // 
            topping3Label.AutoSize = true;
            topping3Label.Location = new Point(17, 345);
            topping3Label.Margin = new Padding(4, 0, 4, 0);
            topping3Label.Name = "topping3Label";
            topping3Label.Size = new Size(92, 25);
            topping3Label.TabIndex = 16;
            topping3Label.Text = "Topping 3";
            // 
            // topping4Label
            // 
            topping4Label.AutoSize = true;
            topping4Label.Location = new Point(17, 418);
            topping4Label.Margin = new Padding(4, 0, 4, 0);
            topping4Label.Name = "topping4Label";
            topping4Label.Size = new Size(92, 25);
            topping4Label.TabIndex = 17;
            topping4Label.Text = "Topping 4";
            // 
            // cheese1Label
            // 
            cheese1Label.AutoSize = true;
            cheese1Label.Location = new Point(17, 492);
            cheese1Label.Margin = new Padding(4, 0, 4, 0);
            cheese1Label.Name = "cheese1Label";
            cheese1Label.Size = new Size(83, 25);
            cheese1Label.TabIndex = 18;
            cheese1Label.Text = "Cheese 1";
            // 
            // cheese2Label
            // 
            cheese2Label.AutoSize = true;
            cheese2Label.Location = new Point(17, 565);
            cheese2Label.Margin = new Padding(4, 0, 4, 0);
            cheese2Label.Name = "cheese2Label";
            cheese2Label.Size = new Size(83, 25);
            cheese2Label.TabIndex = 19;
            cheese2Label.Text = "Cheese 2";
            // 
            // topping2ComboBox
            // 
            topping2ComboBox.FormattingEnabled = true;
            topping2ComboBox.Items.AddRange(new object[] { "Pepperoni $0.99 ", "Sausage $0.99 ", "Ham $0.99 ", "Bacon $0.99 ", "Chicken $0.99 ", "Beef $0.99 ", "Salami $0.99 ", "Anchovies\t $0.99 ", "Banana Peppers $0.50 ", "Green Peppers $0.50 ", "Jalapeno Peppers $0.50 ", "Black Olives $0.50 ", "Pineapple $0.50 ", "Mushrooms $0.50 ", "None" });
            topping2ComboBox.Location = new Point(17, 300);
            topping2ComboBox.Margin = new Padding(4, 5, 4, 5);
            topping2ComboBox.Name = "topping2ComboBox";
            topping2ComboBox.Size = new Size(257, 33);
            topping2ComboBox.TabIndex = 20;
            topping2ComboBox.SelectedIndexChanged += topping2ComboBox_SelectedIndexChanged;
            // 
            // topping3ComboBox
            // 
            topping3ComboBox.FormattingEnabled = true;
            topping3ComboBox.Items.AddRange(new object[] { "Pepperoni $0.99 ", "Sausage $0.99 ", "Ham $0.99 ", "Bacon $0.99 ", "Chicken $0.99 ", "Beef $0.99 ", "Salami $0.99 ", "Anchovies\t $0.99 ", "Banana Peppers $0.50 ", "Green Peppers $0.50 ", "Jalapeno Peppers $0.50 ", "Black Olives $0.50 ", "Pineapple $0.50 ", "Mushrooms $0.50 ", "None" });
            topping3ComboBox.Location = new Point(17, 375);
            topping3ComboBox.Margin = new Padding(4, 5, 4, 5);
            topping3ComboBox.Name = "topping3ComboBox";
            topping3ComboBox.Size = new Size(257, 33);
            topping3ComboBox.TabIndex = 21;
            topping3ComboBox.SelectedIndexChanged += topping3ComboBox_SelectedIndexChanged;
            // 
            // topping4ComboBox
            // 
            topping4ComboBox.FormattingEnabled = true;
            topping4ComboBox.Items.AddRange(new object[] { "Pepperoni $0.99 ", "Sausage $0.99 ", "Ham $0.99 ", "Bacon $0.99 ", "Chicken $0.99 ", "Beef $0.99 ", "Salami $0.99 ", "Anchovies\t $0.99 ", "Banana Peppers $0.50 ", "Green Peppers $0.50 ", "Jalapeno Peppers $0.50 ", "Black Olives $0.50 ", "Pineapple $0.50 ", "Mushrooms $0.50 ", "None" });
            topping4ComboBox.Location = new Point(17, 448);
            topping4ComboBox.Margin = new Padding(4, 5, 4, 5);
            topping4ComboBox.Name = "topping4ComboBox";
            topping4ComboBox.Size = new Size(257, 33);
            topping4ComboBox.TabIndex = 22;
            topping4ComboBox.SelectedIndexChanged += topping4ComboBox_SelectedIndexChanged;
            // 
            // cheese1ComboBox
            // 
            cheese1ComboBox.FormattingEnabled = true;
            cheese1ComboBox.Items.AddRange(new object[] { "Feta $0.50 ", "Parmesan $0.50 ", "Provolone $0.50 ", "Mozzarella $0.50 ", "Blend $0.50 " });
            cheese1ComboBox.Location = new Point(17, 522);
            cheese1ComboBox.Margin = new Padding(4, 5, 4, 5);
            cheese1ComboBox.Name = "cheese1ComboBox";
            cheese1ComboBox.Size = new Size(257, 33);
            cheese1ComboBox.TabIndex = 23;
            cheese1ComboBox.SelectedIndexChanged += cheese1ComboBox_SelectedIndexChanged;
            // 
            // cheese2ComboBox
            // 
            cheese2ComboBox.FormattingEnabled = true;
            cheese2ComboBox.Items.AddRange(new object[] { "Feta $0.50 ", "Parmesan $0.50 ", "Provolone $0.50 ", "Mozzarella $0.50 ", "Blend $0.50 ", "None" });
            cheese2ComboBox.Location = new Point(17, 595);
            cheese2ComboBox.Margin = new Padding(4, 5, 4, 5);
            cheese2ComboBox.Name = "cheese2ComboBox";
            cheese2ComboBox.Size = new Size(257, 33);
            cheese2ComboBox.TabIndex = 24;
            cheese2ComboBox.SelectedIndexChanged += cheese2ComboBox_SelectedIndexChanged;
            // 
            // topping3OptionComboBox
            // 
            topping3OptionComboBox.FormattingEnabled = true;
            topping3OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            topping3OptionComboBox.Location = new Point(284, 375);
            topping3OptionComboBox.Margin = new Padding(4, 5, 4, 5);
            topping3OptionComboBox.Name = "topping3OptionComboBox";
            topping3OptionComboBox.Size = new Size(108, 33);
            topping3OptionComboBox.TabIndex = 25;
            topping3OptionComboBox.SelectedIndexChanged += topping3OptionComboBox_SelectedIndexChanged;
            // 
            // topping1OptionComboBox
            // 
            topping1OptionComboBox.FormattingEnabled = true;
            topping1OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            topping1OptionComboBox.Location = new Point(284, 227);
            topping1OptionComboBox.Margin = new Padding(4, 5, 4, 5);
            topping1OptionComboBox.Name = "topping1OptionComboBox";
            topping1OptionComboBox.Size = new Size(108, 33);
            topping1OptionComboBox.TabIndex = 26;
            topping1OptionComboBox.SelectedIndexChanged += topping1OptionComboBox_SelectedIndexChanged;
            // 
            // topping2OptionComboBox
            // 
            topping2OptionComboBox.FormattingEnabled = true;
            topping2OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            topping2OptionComboBox.Location = new Point(284, 308);
            topping2OptionComboBox.Margin = new Padding(4, 5, 4, 5);
            topping2OptionComboBox.Name = "topping2OptionComboBox";
            topping2OptionComboBox.Size = new Size(108, 33);
            topping2OptionComboBox.TabIndex = 27;
            topping2OptionComboBox.SelectedIndexChanged += topping2OptionComboBox_SelectedIndexChanged;
            // 
            // topping4OptionComboBox
            // 
            topping4OptionComboBox.FormattingEnabled = true;
            topping4OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            topping4OptionComboBox.Location = new Point(284, 448);
            topping4OptionComboBox.Margin = new Padding(4, 5, 4, 5);
            topping4OptionComboBox.Name = "topping4OptionComboBox";
            topping4OptionComboBox.Size = new Size(108, 33);
            topping4OptionComboBox.TabIndex = 28;
            topping4OptionComboBox.SelectedIndexChanged += topping4OptionComboBox_SelectedIndexChanged;
            // 
            // cheese1OptionComboBox
            // 
            cheese1OptionComboBox.FormattingEnabled = true;
            cheese1OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            cheese1OptionComboBox.Location = new Point(284, 522);
            cheese1OptionComboBox.Margin = new Padding(4, 5, 4, 5);
            cheese1OptionComboBox.Name = "cheese1OptionComboBox";
            cheese1OptionComboBox.Size = new Size(108, 33);
            cheese1OptionComboBox.TabIndex = 29;
            cheese1OptionComboBox.SelectedIndexChanged += cheese1OptionComboBox_SelectedIndexChanged;
            // 
            // cheese2OptionComboBox
            // 
            cheese2OptionComboBox.FormattingEnabled = true;
            cheese2OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            cheese2OptionComboBox.Location = new Point(284, 595);
            cheese2OptionComboBox.Margin = new Padding(4, 5, 4, 5);
            cheese2OptionComboBox.Name = "cheese2OptionComboBox";
            cheese2OptionComboBox.Size = new Size(108, 33);
            cheese2OptionComboBox.TabIndex = 30;
            cheese2OptionComboBox.SelectedIndexChanged += cheese2OptionComboBox_SelectedIndexChanged;
            // 
            // quantityComboBox
            // 
            quantityComboBox.FormattingEnabled = true;
            quantityComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            quantityComboBox.Location = new Point(586, 227);
            quantityComboBox.Margin = new Padding(4, 5, 4, 5);
            quantityComboBox.Name = "quantityComboBox";
            quantityComboBox.Size = new Size(171, 33);
            quantityComboBox.TabIndex = 31;
            quantityComboBox.SelectedIndexChanged += quantityComboBox_SelectedIndexChanged;
            // 
            // crustOptionComboBox
            // 
            crustOptionComboBox.FormattingEnabled = true;
            crustOptionComboBox.Items.AddRange(new object[] { "Small +$6.99", "Medium +$8.99", "Large +$9.99", "Extra Large +$11.99" });
            crustOptionComboBox.Location = new Point(284, 153);
            crustOptionComboBox.Margin = new Padding(4, 5, 4, 5);
            crustOptionComboBox.Name = "crustOptionComboBox";
            crustOptionComboBox.Size = new Size(108, 33);
            crustOptionComboBox.TabIndex = 11;
            crustOptionComboBox.SelectedIndexChanged += crustOptionComboBox_SelectedIndexChanged;
            // 
            // customTotalLabel
            // 
            customTotalLabel.AutoSize = true;
            customTotalLabel.Location = new Point(586, 270);
            customTotalLabel.Margin = new Padding(4, 0, 4, 0);
            customTotalLabel.Name = "customTotalLabel";
            customTotalLabel.Size = new Size(49, 25);
            customTotalLabel.TabIndex = 32;
            customTotalLabel.Text = "Total";
            // 
            // customTotalDisplayLabel
            // 
            customTotalDisplayLabel.AutoSize = true;
            customTotalDisplayLabel.Location = new Point(586, 313);
            customTotalDisplayLabel.Margin = new Padding(4, 0, 4, 0);
            customTotalDisplayLabel.Name = "customTotalDisplayLabel";
            customTotalDisplayLabel.Size = new Size(59, 25);
            customTotalDisplayLabel.TabIndex = 33;
            customTotalDisplayLabel.Text = "label1";
            // 
            // CustomOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 770);
            Controls.Add(customTotalDisplayLabel);
            Controls.Add(customTotalLabel);
            Controls.Add(quantityComboBox);
            Controls.Add(cheese2OptionComboBox);
            Controls.Add(cheese1OptionComboBox);
            Controls.Add(topping4OptionComboBox);
            Controls.Add(topping2OptionComboBox);
            Controls.Add(topping1OptionComboBox);
            Controls.Add(topping3OptionComboBox);
            Controls.Add(cheese2ComboBox);
            Controls.Add(cheese1ComboBox);
            Controls.Add(topping4ComboBox);
            Controls.Add(topping3ComboBox);
            Controls.Add(topping2ComboBox);
            Controls.Add(cheese2Label);
            Controls.Add(cheese1Label);
            Controls.Add(topping4Label);
            Controls.Add(topping3Label);
            Controls.Add(topping2Label);
            Controls.Add(topping1Label);
            Controls.Add(crustLabel);
            Controls.Add(topping1ComboBox);
            Controls.Add(crustOptionComboBox);
            Controls.Add(crustComboBox);
            Controls.Add(confirmButton);
            Controls.Add(cancelButton);
            Controls.Add(customOrderLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CustomOrder";
            Text = "CustomOrder";
            Load += CustomOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customOrderLabel;
        private Button cancelButton;
        private Button confirmButton;
        private ComboBox crustComboBox;
        private ComboBox topping1ComboBox;
        private Label crustLabel;
        private Label topping1Label;
        private Label topping2Label;
        private Label topping3Label;
        private Label topping4Label;
        private Label cheese1Label;
        private Label cheese2Label;
        private ComboBox topping2ComboBox;
        private ComboBox topping3ComboBox;
        private ComboBox topping4ComboBox;
        private ComboBox cheese1ComboBox;
        private ComboBox cheese2ComboBox;
        private ComboBox topping3OptionComboBox;
        private ComboBox topping1OptionComboBox;
        private ComboBox topping2OptionComboBox;
        private ComboBox topping4OptionComboBox;
        private ComboBox cheese1OptionComboBox;
        private ComboBox cheese2OptionComboBox;
        private ComboBox quantityComboBox;
        private ComboBox crustOptionComboBox;
        private Label customTotalLabel;
        private Label customTotalDisplayLabel;
    }
}