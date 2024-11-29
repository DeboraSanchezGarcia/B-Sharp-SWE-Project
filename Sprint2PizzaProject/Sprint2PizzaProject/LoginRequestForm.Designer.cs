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
            loginRequestLabel.Location = new Point(115, 59);
            loginRequestLabel.Name = "loginRequestLabel";
            loginRequestLabel.Size = new Size(270, 50);
            loginRequestLabel.TabIndex = 0;
            loginRequestLabel.Text = "Must be logged in to check out. \r\n                Please log in";
            // 
            // confirmRequestButton
            // 
            confirmRequestButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmRequestButton.Location = new Point(75, 106);
            confirmRequestButton.Name = "confirmRequestButton";
            confirmRequestButton.Size = new Size(137, 46);
            confirmRequestButton.TabIndex = 1;
            confirmRequestButton.Text = "Confirm";
            confirmRequestButton.UseVisualStyleBackColor = true;
            confirmRequestButton.Click += confirmRequestButton_Click;
            // 
            // cancelRequestButton
            // 
            cancelRequestButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelRequestButton.Location = new Point(281, 106);
            cancelRequestButton.Name = "cancelRequestButton";
            cancelRequestButton.Size = new Size(137, 46);
            cancelRequestButton.TabIndex = 2;
            cancelRequestButton.Text = "Cancel";
            cancelRequestButton.UseVisualStyleBackColor = true;
            cancelRequestButton.Click += cancelRequestButton_Click;
            // 
            // notLoggedInLabel
            // 
            notLoggedInLabel.AutoSize = true;
            notLoggedInLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notLoggedInLabel.Location = new Point(155, 9);
            notLoggedInLabel.Name = "notLoggedInLabel";
            notLoggedInLabel.Size = new Size(188, 38);
            notLoggedInLabel.TabIndex = 3;
            notLoggedInLabel.Text = "Not logged in";
            // 
            // LoginRequestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 158);
            Controls.Add(notLoggedInLabel);
            Controls.Add(cancelRequestButton);
            Controls.Add(confirmRequestButton);
            Controls.Add(loginRequestLabel);
            Name = "LoginRequestForm";
            Text = "LoginRequestForm";
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