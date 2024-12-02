namespace Sprint2PizzaProject
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            MainMenuPanel = new Panel();
            drinkQuantity = new ComboBox();
            pepperoniQuantity = new ComboBox();
            meatQuantity = new ComboBox();
            veggieQuantity = new ComboBox();
            cheeseQuantity = new ComboBox();
            cartLabel = new Label();
            drinkAddButton = new Button();
            toCheckOutButton = new Button();
            toCartButton = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            drinkOptionComboBox = new ComboBox();
            drinkTypeComboBox = new ComboBox();
            label7 = new Label();
            createOwnButton = new Button();
            meatAddButton = new Button();
            pepperoniAddButton = new Button();
            veggieAddButton = new Button();
            cheeseAddButton = new Button();
            meatComboBox = new ComboBox();
            pepperoniComboBox = new ComboBox();
            veggieComboBox = new ComboBox();
            cheeseComboBox = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            toLoginButton = new Button();
            MainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainMenuPanel
            // 
            MainMenuPanel.BackgroundImage = Properties.Resources.BackgroundProject;
            MainMenuPanel.Controls.Add(drinkQuantity);
            MainMenuPanel.Controls.Add(pepperoniQuantity);
            MainMenuPanel.Controls.Add(meatQuantity);
            MainMenuPanel.Controls.Add(veggieQuantity);
            MainMenuPanel.Controls.Add(cheeseQuantity);
            MainMenuPanel.Controls.Add(cartLabel);
            MainMenuPanel.Controls.Add(drinkAddButton);
            MainMenuPanel.Controls.Add(toCheckOutButton);
            MainMenuPanel.Controls.Add(toCartButton);
            MainMenuPanel.Controls.Add(label11);
            MainMenuPanel.Controls.Add(label10);
            MainMenuPanel.Controls.Add(label9);
            MainMenuPanel.Controls.Add(label8);
            MainMenuPanel.Controls.Add(drinkOptionComboBox);
            MainMenuPanel.Controls.Add(drinkTypeComboBox);
            MainMenuPanel.Controls.Add(label7);
            MainMenuPanel.Controls.Add(createOwnButton);
            MainMenuPanel.Controls.Add(meatAddButton);
            MainMenuPanel.Controls.Add(pepperoniAddButton);
            MainMenuPanel.Controls.Add(veggieAddButton);
            MainMenuPanel.Controls.Add(cheeseAddButton);
            MainMenuPanel.Controls.Add(meatComboBox);
            MainMenuPanel.Controls.Add(pepperoniComboBox);
            MainMenuPanel.Controls.Add(veggieComboBox);
            MainMenuPanel.Controls.Add(cheeseComboBox);
            MainMenuPanel.Controls.Add(label6);
            MainMenuPanel.Controls.Add(label5);
            MainMenuPanel.Controls.Add(label4);
            MainMenuPanel.Controls.Add(label3);
            MainMenuPanel.Controls.Add(label2);
            MainMenuPanel.Controls.Add(pictureBox1);
            MainMenuPanel.Controls.Add(label1);
            MainMenuPanel.Controls.Add(toLoginButton);
            MainMenuPanel.Location = new Point(0, 0);
            MainMenuPanel.Name = "MainMenuPanel";
            MainMenuPanel.Size = new Size(980, 880);
            MainMenuPanel.TabIndex = 0;
            // 
            // drinkQuantity
            // 
            drinkQuantity.FormattingEnabled = true;
            drinkQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            drinkQuantity.Location = new Point(302, 454);
            drinkQuantity.Margin = new Padding(2);
            drinkQuantity.Name = "drinkQuantity";
            drinkQuantity.Size = new Size(42, 23);
            drinkQuantity.TabIndex = 34;
            // 
            // pepperoniQuantity
            // 
            pepperoniQuantity.FormattingEnabled = true;
            pepperoniQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            pepperoniQuantity.Location = new Point(662, 315);
            pepperoniQuantity.Margin = new Padding(2);
            pepperoniQuantity.Name = "pepperoniQuantity";
            pepperoniQuantity.Size = new Size(42, 23);
            pepperoniQuantity.TabIndex = 33;
            // 
            // meatQuantity
            // 
            meatQuantity.FormattingEnabled = true;
            meatQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            meatQuantity.Location = new Point(883, 315);
            meatQuantity.Margin = new Padding(2);
            meatQuantity.Name = "meatQuantity";
            meatQuantity.Size = new Size(42, 23);
            meatQuantity.TabIndex = 32;
            // 
            // veggieQuantity
            // 
            veggieQuantity.FormattingEnabled = true;
            veggieQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            veggieQuantity.Location = new Point(432, 315);
            veggieQuantity.Margin = new Padding(2);
            veggieQuantity.Name = "veggieQuantity";
            veggieQuantity.Size = new Size(42, 23);
            veggieQuantity.TabIndex = 31;
            // 
            // cheeseQuantity
            // 
            cheeseQuantity.FormattingEnabled = true;
            cheeseQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cheeseQuantity.Location = new Point(178, 315);
            cheeseQuantity.Margin = new Padding(2);
            cheeseQuantity.Name = "cheeseQuantity";
            cheeseQuantity.Size = new Size(42, 23);
            cheeseQuantity.TabIndex = 30;
            // 
            // cartLabel
            // 
            cartLabel.Location = new Point(524, 458);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(448, 211);
            cartLabel.TabIndex = 29;
            // 
            // drinkAddButton
            // 
            drinkAddButton.BackColor = Color.Orange;
            drinkAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            drinkAddButton.Location = new Point(399, 447);
            drinkAddButton.Name = "drinkAddButton";
            drinkAddButton.Size = new Size(75, 32);
            drinkAddButton.TabIndex = 28;
            drinkAddButton.Text = "Add";
            drinkAddButton.UseVisualStyleBackColor = false;
            drinkAddButton.Click += drinkAddButton_Click;
            // 
            // toCheckOutButton
            // 
            toCheckOutButton.BackColor = Color.Orange;
            toCheckOutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toCheckOutButton.Location = new Point(775, 26);
            toCheckOutButton.Name = "toCheckOutButton";
            toCheckOutButton.Size = new Size(105, 28);
            toCheckOutButton.TabIndex = 27;
            toCheckOutButton.Text = "Check Out";
            toCheckOutButton.UseVisualStyleBackColor = false;
            toCheckOutButton.Click += toCheckOutButton_Click;
            // 
            // toCartButton
            // 
            toCartButton.BackColor = Color.Orange;
            toCartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toCartButton.Location = new Point(684, 26);
            toCartButton.Name = "toCartButton";
            toCartButton.Size = new Size(85, 28);
            toCartButton.TabIndex = 26;
            toCartButton.Text = "Cart";
            toCartButton.UseVisualStyleBackColor = false;
            toCartButton.Click += toCartButton_Click;
            // 
            // label11
            // 
            label11.Location = new Point(12, 802);
            label11.Name = "label11";
            label11.Size = new Size(139, 54);
            label11.TabIndex = 25;
            label11.Text = "1-888-Fresh-Pizza​\r\n3220, North Pizza Drive, \r\nKennesaw GA 30123";
            // 
            // label10
            // 
            label10.Location = new Point(12, 669);
            label10.Name = "label10";
            label10.Size = new Size(960, 52);
            label10.TabIndex = 24;
            label10.Text = resources.GetString("label10.Text");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 654);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 23;
            label9.Text = "About Us";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(519, 436);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 21;
            label8.Text = "Cart";
            // 
            // drinkOptionComboBox
            // 
            drinkOptionComboBox.FormattingEnabled = true;
            drinkOptionComboBox.Items.AddRange(new object[] { "16oz Bottle$1.50", "20oz Bottle$2.00", "2L Bottle\t $3.00" });
            drinkOptionComboBox.Location = new Point(177, 454);
            drinkOptionComboBox.Name = "drinkOptionComboBox";
            drinkOptionComboBox.Size = new Size(121, 23);
            drinkOptionComboBox.TabIndex = 20;
            // 
            // drinkTypeComboBox
            // 
            drinkTypeComboBox.FormattingEnabled = true;
            drinkTypeComboBox.Items.AddRange(new object[] { "Coke", "Diet Coke", "Sprite", "Fanta", "Water" });
            drinkTypeComboBox.Location = new Point(52, 454);
            drinkTypeComboBox.Name = "drinkTypeComboBox";
            drinkTypeComboBox.Size = new Size(121, 23);
            drinkTypeComboBox.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(53, 436);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 18;
            label7.Text = "Drinks";
            // 
            // createOwnButton
            // 
            createOwnButton.BackColor = Color.Orange;
            createOwnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createOwnButton.Location = new Point(53, 400);
            createOwnButton.Name = "createOwnButton";
            createOwnButton.Size = new Size(165, 33);
            createOwnButton.TabIndex = 17;
            createOwnButton.Text = "Create Your Own Pizza";
            createOwnButton.UseVisualStyleBackColor = false;
            createOwnButton.Click += createOwnButton_Click;
            // 
            // meatAddButton
            // 
            meatAddButton.BackColor = Color.Orange;
            meatAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            meatAddButton.Location = new Point(759, 344);
            meatAddButton.Name = "meatAddButton";
            meatAddButton.Size = new Size(75, 32);
            meatAddButton.TabIndex = 16;
            meatAddButton.Text = "Add";
            meatAddButton.UseVisualStyleBackColor = false;
            meatAddButton.Click += meatAddButton_Click;
            // 
            // pepperoniAddButton
            // 
            pepperoniAddButton.BackColor = Color.Orange;
            pepperoniAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pepperoniAddButton.Location = new Point(537, 344);
            pepperoniAddButton.Name = "pepperoniAddButton";
            pepperoniAddButton.Size = new Size(75, 32);
            pepperoniAddButton.TabIndex = 15;
            pepperoniAddButton.Text = "Add";
            pepperoniAddButton.UseVisualStyleBackColor = false;
            pepperoniAddButton.Click += pepperoniAddButton_Click;
            // 
            // veggieAddButton
            // 
            veggieAddButton.BackColor = Color.Orange;
            veggieAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            veggieAddButton.Location = new Point(307, 344);
            veggieAddButton.Name = "veggieAddButton";
            veggieAddButton.Size = new Size(75, 32);
            veggieAddButton.TabIndex = 14;
            veggieAddButton.Text = "Add";
            veggieAddButton.UseVisualStyleBackColor = false;
            veggieAddButton.Click += veggieAddButton_Click;
            // 
            // cheeseAddButton
            // 
            cheeseAddButton.BackColor = Color.Orange;
            cheeseAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cheeseAddButton.Location = new Point(52, 344);
            cheeseAddButton.Name = "cheeseAddButton";
            cheeseAddButton.Size = new Size(75, 32);
            cheeseAddButton.TabIndex = 13;
            cheeseAddButton.Text = "Add";
            cheeseAddButton.UseVisualStyleBackColor = false;
            cheeseAddButton.Click += cheeseAddButton_Click;
            // 
            // meatComboBox
            // 
            meatComboBox.FormattingEnabled = true;
            meatComboBox.Items.AddRange(new object[] { "Small\t $10.99", "Medium\t $12.99", "Large\t $13.99", "Extra Large$15.99" });
            meatComboBox.Location = new Point(759, 315);
            meatComboBox.Name = "meatComboBox";
            meatComboBox.Size = new Size(121, 23);
            meatComboBox.TabIndex = 12;
            // 
            // pepperoniComboBox
            // 
            pepperoniComboBox.FormattingEnabled = true;
            pepperoniComboBox.Items.AddRange(new object[] { "Small\t $7.98", "Medium\t $9.98", "Large\t $10.98", "Extra Large$14.99" });
            pepperoniComboBox.Location = new Point(537, 315);
            pepperoniComboBox.Name = "pepperoniComboBox";
            pepperoniComboBox.Size = new Size(121, 23);
            pepperoniComboBox.TabIndex = 11;
            // 
            // veggieComboBox
            // 
            veggieComboBox.FormattingEnabled = true;
            veggieComboBox.Items.AddRange(new object[] { "Small\t $9.99", "Medium\t $11.99", "Large\t $12.99", "Extra Large$14.99" });
            veggieComboBox.Location = new Point(307, 315);
            veggieComboBox.Name = "veggieComboBox";
            veggieComboBox.Size = new Size(121, 23);
            veggieComboBox.TabIndex = 10;
            // 
            // cheeseComboBox
            // 
            cheeseComboBox.FormattingEnabled = true;
            cheeseComboBox.Items.AddRange(new object[] { "Small\t $7.49", "Medium\t $9.49", "Large\t $10.49", "Extra Large$12.49" });
            cheeseComboBox.Location = new Point(53, 315);
            cheeseComboBox.Name = "cheeseComboBox";
            cheeseComboBox.Size = new Size(121, 23);
            cheeseComboBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(759, 297);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 8;
            label6.Text = "Meat-lovers Pizza";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(537, 297);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 7;
            label5.Text = "Pepperoni Pizza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(307, 297);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 6;
            label4.Text = "Veggie Pizza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(53, 297);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 5;
            label3.Text = "Cheese Pizza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(53, 282);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Ready Made Pizzas";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.website_feature___national_pepperoni_pizza_day__september_20;
            pictureBox1.Location = new Point(70, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(810, 219);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 19);
            label1.Name = "label1";
            label1.Size = new Size(231, 32);
            label1.TabIndex = 2;
            label1.Text = "Home-Town Pizzaria";
            // 
            // toLoginButton
            // 
            toLoginButton.BackColor = Color.Orange;
            toLoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toLoginButton.Location = new Point(593, 26);
            toLoginButton.Name = "toLoginButton";
            toLoginButton.Size = new Size(85, 28);
            toLoginButton.TabIndex = 1;
            toLoginButton.Text = "Login";
            toLoginButton.UseVisualStyleBackColor = false;
            toLoginButton.Click += toLoginButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(984, 561);
            Controls.Add(MainMenuPanel);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            MainMenuPanel.ResumeLayout(false);
            MainMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainMenuPanel;
        private Button toLoginButton;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox meatComboBox;
        private ComboBox pepperoniComboBox;
        private ComboBox veggieComboBox;
        private ComboBox cheeseComboBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button meatAddButton;
        private Button pepperoniAddButton;
        private Button veggieAddButton;
        private Button cheeseAddButton;
        private Label label3;
        private ComboBox drinkOptionComboBox;
        private ComboBox drinkTypeComboBox;
        private Label label7;
        private Button createOwnButton;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button toCheckOutButton;
        private Button toCartButton;
        private Button drinkAddButton;
        private Label cartLabel;
        private ComboBox drinkQuantity;
        private ComboBox pepperoniQuantity;
        private ComboBox meatQuantity;
        private ComboBox veggieQuantity;
        private ComboBox cheeseQuantity;
    }
}