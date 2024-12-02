namespace Sprint2PizzaProject
{
    partial class LoginRequestForm
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
            loginRequestLabel = new Label();
            confirmRequestButton = new Button();
            cancelRequestButton = new Button();
            notLoggedInLabel = new Label();
            SuspendLayout();
            // 
            // loginRequestLabel
            // 
            loginRequestLabel.AutoSize = true;
            loginRequestLabel.BackColor = Color.Transparent;
            loginRequestLabel.Location = new Point(80, 35);
            loginRequestLabel.Margin = new Padding(2, 0, 2, 0);
            loginRequestLabel.Name = "loginRequestLabel";
            loginRequestLabel.Size = new Size(178, 30);
            loginRequestLabel.TabIndex = 0;
            loginRequestLabel.Text = "Must be logged in to check out. \r\n                Please log in";
            // 
            // confirmRequestButton
            // 
            confirmRequestButton.BackColor = Color.Orange;
            confirmRequestButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmRequestButton.Location = new Point(52, 64);
            confirmRequestButton.Margin = new Padding(2);
            confirmRequestButton.Name = "confirmRequestButton";
            confirmRequestButton.Size = new Size(96, 28);
            confirmRequestButton.TabIndex = 1;
            confirmRequestButton.Text = "Confirm";
            confirmRequestButton.UseVisualStyleBackColor = false;
            confirmRequestButton.Click += confirmRequestButton_Click;
            // 
            // cancelRequestButton
            // 
            cancelRequestButton.BackColor = Color.Orange;
            cancelRequestButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelRequestButton.Location = new Point(197, 64);
            cancelRequestButton.Margin = new Padding(2);
            cancelRequestButton.Name = "cancelRequestButton";
            cancelRequestButton.Size = new Size(96, 28);
            cancelRequestButton.TabIndex = 2;
            cancelRequestButton.Text = "Cancel";
            cancelRequestButton.UseVisualStyleBackColor = false;
            cancelRequestButton.Click += cancelRequestButton_Click;
            // 
            // notLoggedInLabel
            // 
            notLoggedInLabel.AutoSize = true;
            notLoggedInLabel.BackColor = Color.Transparent;
            notLoggedInLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notLoggedInLabel.Location = new Point(108, 5);
            notLoggedInLabel.Margin = new Padding(2, 0, 2, 0);
            notLoggedInLabel.Name = "notLoggedInLabel";
            notLoggedInLabel.Size = new Size(128, 25);
            notLoggedInLabel.TabIndex = 3;
            notLoggedInLabel.Text = "Not logged in";
            // 
            // LoginRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundProject;
            ClientSize = new Size(361, 95);
            Controls.Add(notLoggedInLabel);
            Controls.Add(cancelRequestButton);
            Controls.Add(confirmRequestButton);
            Controls.Add(loginRequestLabel);
            Margin = new Padding(2);
            Name = "LoginRequestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginRequestForm";
            Load += LoginRequestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginRequestLabel;
        private Button confirmRequestButton;
        private Button cancelRequestButton;
        private Label notLoggedInLabel;
    }
}