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
            CustomOrderLabel = new Label();
            CrustTypePanel = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            CancelButton = new Button();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // CustomOrderLabel
            // 
            CustomOrderLabel.AutoSize = true;
            CustomOrderLabel.Location = new Point(12, 23);
            CustomOrderLabel.Name = "CustomOrderLabel";
            CustomOrderLabel.Size = new Size(82, 15);
            CustomOrderLabel.TabIndex = 0;
            CustomOrderLabel.Text = "Custom Order";
            CustomOrderLabel.Click += label1_Click;
            // 
            // CrustTypePanel
            // 
            CrustTypePanel.AccessibleName = "CrustTypePanel";
            CrustTypePanel.Location = new Point(12, 52);
            CrustTypePanel.Name = "CrustTypePanel";
            CrustTypePanel.Size = new Size(138, 75);
            CrustTypePanel.TabIndex = 1;
            CrustTypePanel.Paint += CrustTypePanel_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(202, 52);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(138, 75);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(12, 159);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(138, 75);
            flowLayoutPanel2.TabIndex = 3;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(12, 265);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(138, 75);
            flowLayoutPanel3.TabIndex = 4;
            flowLayoutPanel3.Paint += flowLayoutPanel3_Paint;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Location = new Point(202, 159);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(138, 75);
            flowLayoutPanel4.TabIndex = 5;
            flowLayoutPanel4.Paint += flowLayoutPanel4_Paint;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Location = new Point(202, 265);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(138, 75);
            flowLayoutPanel5.TabIndex = 6;
            flowLayoutPanel5.Paint += flowLayoutPanel5_Paint;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Location = new Point(12, 375);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(138, 75);
            flowLayoutPanel6.TabIndex = 7;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(671, 159);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(138, 63);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(671, 250);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(138, 63);
            ConfirmButton.TabIndex = 9;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // CustomOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 462);
            Controls.Add(ConfirmButton);
            Controls.Add(CancelButton);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(CrustTypePanel);
            Controls.Add(CustomOrderLabel);
            Name = "CustomOrder";
            Text = "CustomOrder";
            Load += CustomOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CustomOrderLabel;
        private FlowLayoutPanel CrustTypePanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button CancelButton;
        private Button ConfirmButton;
    }
}