﻿namespace Sprint2PizzaProject
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
            SuspendLayout();
            // 
            // customOrderLabel
            // 
            customOrderLabel.AutoSize = true;
            customOrderLabel.Location = new Point(12, 23);
            customOrderLabel.Name = "customOrderLabel";
            customOrderLabel.Size = new Size(82, 15);
            customOrderLabel.TabIndex = 0;
            customOrderLabel.Text = "Custom Order";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Orange;
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(583, 248);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(138, 63);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.Orange;
            confirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmButton.Location = new Point(583, 136);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(138, 63);
            confirmButton.TabIndex = 9;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // crustComboBox
            // 
            crustComboBox.FormattingEnabled = true;
            crustComboBox.Items.AddRange(new object[] { "Regular +$0.50", "Thin +$0.50", "Thick +$1.00", "Stuffed +$1.50" });
            crustComboBox.Location = new Point(12, 92);
            crustComboBox.Name = "crustComboBox";
            crustComboBox.Size = new Size(181, 23);
            crustComboBox.TabIndex = 10;
            // 
            // topping1ComboBox
            // 
            topping1ComboBox.FormattingEnabled = true;
            topping1ComboBox.Items.AddRange(new object[] { "Pepperoni $0.99 ", "Sausage $0.99 ", "Ham $0.99 ", "Bacon $0.99 ", "Chicken $0.99 ", "Beef $0.99 ", "Salami $0.99 ", "Anchovies\t $0.99 ", "Banana Peppers $0.50 ", "Green Peppers $0.50 ", "Jalapeno Peppers $0.50 ", "Black Olives $0.50 ", "Pineapple $0.50 ", "Mushrooms $0.50 " });
            topping1ComboBox.Location = new Point(12, 136);
            topping1ComboBox.Name = "topping1ComboBox";
            topping1ComboBox.Size = new Size(181, 23);
            topping1ComboBox.TabIndex = 12;
            // 
            // crustLabel
            // 
            crustLabel.AutoSize = true;
            crustLabel.BackColor = Color.Transparent;
            crustLabel.Location = new Point(12, 74);
            crustLabel.Name = "crustLabel";
            crustLabel.Size = new Size(35, 15);
            crustLabel.TabIndex = 13;
            crustLabel.Text = "Crust";
            // 
            // topping1Label
            // 
            topping1Label.AutoSize = true;
            topping1Label.BackColor = Color.Transparent;
            topping1Label.Location = new Point(12, 118);
            topping1Label.Name = "topping1Label";
            topping1Label.Size = new Size(59, 15);
            topping1Label.TabIndex = 14;
            topping1Label.Text = "Topping 1";
            // 
            // topping2Label
            // 
            topping2Label.AutoSize = true;
            topping2Label.BackColor = Color.Transparent;
            topping2Label.Location = new Point(12, 162);
            topping2Label.Name = "topping2Label";
            topping2Label.Size = new Size(59, 15);
            topping2Label.TabIndex = 15;
            topping2Label.Text = "Topping 2";
            // 
            // topping3Label
            // 
            topping3Label.AutoSize = true;
            topping3Label.BackColor = Color.Transparent;
            topping3Label.Location = new Point(12, 207);
            topping3Label.Name = "topping3Label";
            topping3Label.Size = new Size(59, 15);
            topping3Label.TabIndex = 16;
            topping3Label.Text = "Topping 3";
            // 
            // topping4Label
            // 
            topping4Label.AutoSize = true;
            topping4Label.BackColor = Color.Transparent;
            topping4Label.Location = new Point(12, 251);
            topping4Label.Name = "topping4Label";
            topping4Label.Size = new Size(59, 15);
            topping4Label.TabIndex = 17;
            topping4Label.Text = "Topping 4";
            // 
            // cheese1Label
            // 
            cheese1Label.AutoSize = true;
            cheese1Label.BackColor = Color.Transparent;
            cheese1Label.Location = new Point(12, 295);
            cheese1Label.Name = "cheese1Label";
            cheese1Label.Size = new Size(54, 15);
            cheese1Label.TabIndex = 18;
            cheese1Label.Text = "Cheese 1";
            // 
            // cheese2Label
            // 
            cheese2Label.AutoSize = true;
            cheese2Label.BackColor = Color.Transparent;
            cheese2Label.Location = new Point(12, 339);
            cheese2Label.Name = "cheese2Label";
            cheese2Label.Size = new Size(54, 15);
            cheese2Label.TabIndex = 19;
            cheese2Label.Text = "Cheese 2";
            // 
            // topping2ComboBox
            // 
            topping2ComboBox.FormattingEnabled = true;
            topping2ComboBox.Items.AddRange(new object[] { "Pepperoni $0.99 ", "Sausage $0.99 ", "Ham $0.99 ", "Bacon $0.99 ", "Chicken $0.99 ", "Beef $0.99 ", "Salami $0.99 ", "Anchovies\t $0.99 ", "Banana Peppers $0.50 ", "Green Peppers $0.50 ", "Jalapeno Peppers $0.50 ", "Black Olives $0.50 ", "Pineapple $0.50 ", "Mushrooms $0.50 ", "None" });
            topping2ComboBox.Location = new Point(12, 180);
            topping2ComboBox.Name = "topping2ComboBox";
            topping2ComboBox.Size = new Size(181, 23);
            topping2ComboBox.TabIndex = 20;
            // 
            // topping3ComboBox
            // 
            topping3ComboBox.FormattingEnabled = true;
            topping3ComboBox.Items.AddRange(new object[] { "Pepperoni $0.99 ", "Sausage $0.99 ", "Ham $0.99 ", "Bacon $0.99 ", "Chicken $0.99 ", "Beef $0.99 ", "Salami $0.99 ", "Anchovies\t $0.99 ", "Banana Peppers $0.50 ", "Green Peppers $0.50 ", "Jalapeno Peppers $0.50 ", "Black Olives $0.50 ", "Pineapple $0.50 ", "Mushrooms $0.50 ", "None" });
            topping3ComboBox.Location = new Point(12, 225);
            topping3ComboBox.Name = "topping3ComboBox";
            topping3ComboBox.Size = new Size(181, 23);
            topping3ComboBox.TabIndex = 21;
            // 
            // topping4ComboBox
            // 
            topping4ComboBox.FormattingEnabled = true;
            topping4ComboBox.Items.AddRange(new object[] { "Pepperoni $0.99 ", "Sausage $0.99 ", "Ham $0.99 ", "Bacon $0.99 ", "Chicken $0.99 ", "Beef $0.99 ", "Salami $0.99 ", "Anchovies\t $0.99 ", "Banana Peppers $0.50 ", "Green Peppers $0.50 ", "Jalapeno Peppers $0.50 ", "Black Olives $0.50 ", "Pineapple $0.50 ", "Mushrooms $0.50 ", "None" });
            topping4ComboBox.Location = new Point(12, 269);
            topping4ComboBox.Name = "topping4ComboBox";
            topping4ComboBox.Size = new Size(181, 23);
            topping4ComboBox.TabIndex = 22;
            // 
            // cheese1ComboBox
            // 
            cheese1ComboBox.FormattingEnabled = true;
            cheese1ComboBox.Items.AddRange(new object[] { "Feta $0.50 ", "Parmesan $0.50 ", "Provolone $0.50 ", "Mozzarella $0.50 ", "Blend $0.50 " });
            cheese1ComboBox.Location = new Point(12, 313);
            cheese1ComboBox.Name = "cheese1ComboBox";
            cheese1ComboBox.Size = new Size(181, 23);
            cheese1ComboBox.TabIndex = 23;
            // 
            // cheese2ComboBox
            // 
            cheese2ComboBox.FormattingEnabled = true;
            cheese2ComboBox.Items.AddRange(new object[] { "Feta $0.50 ", "Parmesan $0.50 ", "Provolone $0.50 ", "Mozzarella $0.50 ", "Blend $0.50 ", "None" });
            cheese2ComboBox.Location = new Point(12, 357);
            cheese2ComboBox.Name = "cheese2ComboBox";
            cheese2ComboBox.Size = new Size(181, 23);
            cheese2ComboBox.TabIndex = 24;
            // 
            // topping3OptionComboBox
            // 
            topping3OptionComboBox.FormattingEnabled = true;
            topping3OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            topping3OptionComboBox.Location = new Point(199, 225);
            topping3OptionComboBox.Name = "topping3OptionComboBox";
            topping3OptionComboBox.Size = new Size(77, 23);
            topping3OptionComboBox.TabIndex = 25;
            // 
            // topping1OptionComboBox
            // 
            topping1OptionComboBox.FormattingEnabled = true;
            topping1OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            topping1OptionComboBox.Location = new Point(199, 136);
            topping1OptionComboBox.Name = "topping1OptionComboBox";
            topping1OptionComboBox.Size = new Size(77, 23);
            topping1OptionComboBox.TabIndex = 26;
            // 
            // topping2OptionComboBox
            // 
            topping2OptionComboBox.FormattingEnabled = true;
            topping2OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            topping2OptionComboBox.Location = new Point(199, 185);
            topping2OptionComboBox.Name = "topping2OptionComboBox";
            topping2OptionComboBox.Size = new Size(77, 23);
            topping2OptionComboBox.TabIndex = 27;
            // 
            // topping4OptionComboBox
            // 
            topping4OptionComboBox.FormattingEnabled = true;
            topping4OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            topping4OptionComboBox.Location = new Point(199, 269);
            topping4OptionComboBox.Name = "topping4OptionComboBox";
            topping4OptionComboBox.Size = new Size(77, 23);
            topping4OptionComboBox.TabIndex = 28;
            // 
            // cheese1OptionComboBox
            // 
            cheese1OptionComboBox.FormattingEnabled = true;
            cheese1OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            cheese1OptionComboBox.Location = new Point(199, 313);
            cheese1OptionComboBox.Name = "cheese1OptionComboBox";
            cheese1OptionComboBox.Size = new Size(77, 23);
            cheese1OptionComboBox.TabIndex = 29;
            // 
            // cheese2OptionComboBox
            // 
            cheese2OptionComboBox.FormattingEnabled = true;
            cheese2OptionComboBox.Items.AddRange(new object[] { "Light x1", "Regular x1", "Extra x2" });
            cheese2OptionComboBox.Location = new Point(199, 357);
            cheese2OptionComboBox.Name = "cheese2OptionComboBox";
            cheese2OptionComboBox.Size = new Size(77, 23);
            cheese2OptionComboBox.TabIndex = 30;
            // 
            // quantityComboBox
            // 
            quantityComboBox.FormattingEnabled = true;
            quantityComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            quantityComboBox.Location = new Point(410, 136);
            quantityComboBox.Name = "quantityComboBox";
            quantityComboBox.Size = new Size(121, 23);
            quantityComboBox.TabIndex = 31;
            // 
            // crustOptionComboBox
            // 
            crustOptionComboBox.FormattingEnabled = true;
            crustOptionComboBox.Items.AddRange(new object[] { "Small +$6.99", "Medium +$8.99", "Large +$9.99", "Extra Large +$11.99" });
            crustOptionComboBox.Location = new Point(199, 92);
            crustOptionComboBox.Name = "crustOptionComboBox";
            crustOptionComboBox.Size = new Size(148, 23);
            crustOptionComboBox.TabIndex = 11;
            // 
            // CustomOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundProject;
            ClientSize = new Size(821, 462);
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
            Name = "CustomOrder";
            Text = "CustomOrder";
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
    }
}