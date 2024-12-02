namespace Sprint2PizzaProject
{
    partial class LoggedIn
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
            continueToOrderButton = new Button();
            loggedInLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // continueToOrderButton
            // 
            continueToOrderButton.BackColor = Color.Orange;
            continueToOrderButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continueToOrderButton.Location = new Point(126, 52);
            continueToOrderButton.Name = "continueToOrderButton";
            continueToOrderButton.Size = new Size(90, 32);
            continueToOrderButton.TabIndex = 0;
            continueToOrderButton.Text = "Continue";
            continueToOrderButton.UseVisualStyleBackColor = false;
            continueToOrderButton.Click += continueToOrderButton_Click;
            // 
            // loggedInLabel
            // 
            loggedInLabel.AutoSize = true;
            loggedInLabel.BackColor = Color.Transparent;
            loggedInLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loggedInLabel.Location = new Point(95, 9);
            loggedInLabel.Name = "loggedInLabel";
            loggedInLabel.Size = new Size(161, 25);
            loggedInLabel.TabIndex = 1;
            loggedInLabel.Text = "Already logged in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(115, 34);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "Continue to order";
            // 
            // LoggedIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundProject;
            ClientSize = new Size(361, 95);
            Controls.Add(label2);
            Controls.Add(loggedInLabel);
            Controls.Add(continueToOrderButton);
            Name = "LoggedIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoggedIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button continueToOrderButton;
        private Label loggedInLabel;
        private Label label2;
    }
}