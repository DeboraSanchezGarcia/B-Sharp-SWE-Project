namespace Sprint2PizzaProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailLabel = new Label();
            emailResponse = new Label();
            passwordLabel = new Label();
            passwordResponse = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label5 = new Label();
            loginSubmit = new Button();
            loginCancel = new Button();
            loginPanel = new Panel();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(471, 253);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(400, 48);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email or Phone Number";
            emailLabel.Click += emailLabel_Click;
            // 
            // emailResponse
            // 
            emailResponse.AutoSize = true;
            emailResponse.ForeColor = Color.Red;
            emailResponse.Location = new Point(471, 365);
            emailResponse.Margin = new Padding(4, 0, 4, 0);
            emailResponse.Name = "emailResponse";
            emailResponse.Size = new Size(0, 25);
            emailResponse.TabIndex = 1;
            emailResponse.Click += emailResponse_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(471, 440);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(168, 48);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // passwordResponse
            // 
            passwordResponse.AutoSize = true;
            passwordResponse.ForeColor = Color.Red;
            passwordResponse.Location = new Point(471, 552);
            passwordResponse.Margin = new Padding(4, 0, 4, 0);
            passwordResponse.Name = "passwordResponse";
            passwordResponse.Size = new Size(0, 25);
            passwordResponse.TabIndex = 3;
            passwordResponse.Click += passwordResponse_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(471, 312);
            emailTextBox.Margin = new Padding(4, 5, 4, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(384, 39);
            emailTextBox.TabIndex = 4;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(471, 498);
            passwordTextBox.Margin = new Padding(4, 5, 4, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(141, 39);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(583, 77);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 65);
            label5.TabIndex = 6;
            label5.Text = "Login";
            // 
            // loginSubmit
            // 
            loginSubmit.BackColor = SystemColors.ButtonShadow;
            loginSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginSubmit.ForeColor = SystemColors.Desktop;
            loginSubmit.Location = new Point(471, 655);
            loginSubmit.Margin = new Padding(4, 5, 4, 5);
            loginSubmit.Name = "loginSubmit";
            loginSubmit.Size = new Size(107, 52);
            loginSubmit.TabIndex = 7;
            loginSubmit.Text = "Submit";
            loginSubmit.UseVisualStyleBackColor = false;
            loginSubmit.Click += loginSubmit_Click;
            // 
            // loginCancel
            // 
            loginCancel.BackColor = SystemColors.ButtonShadow;
            loginCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginCancel.Location = new Point(750, 655);
            loginCancel.Margin = new Padding(4, 5, 4, 5);
            loginCancel.Name = "loginCancel";
            loginCancel.Size = new Size(107, 52);
            loginCancel.TabIndex = 8;
            loginCancel.Text = "Cancel";
            loginCancel.UseVisualStyleBackColor = false;
            loginCancel.Click += loginCancel_Click;
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(loginCancel);
            loginPanel.Controls.Add(loginSubmit);
            loginPanel.Controls.Add(label5);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(emailTextBox);
            loginPanel.Controls.Add(passwordResponse);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(emailResponse);
            loginPanel.Controls.Add(emailLabel);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Margin = new Padding(4, 5, 4, 5);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(1406, 935);
            loginPanel.TabIndex = 0;
            loginPanel.Paint += loginPanel_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 935);
            Controls.Add(loginPanel);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label emailLabel;
        private Label emailResponse;
        private Label passwordLabel;
        private Label passwordResponse;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Label label5;
        private Button loginSubmit;
        private Button loginCancel;
        private Panel loginPanel;
    }
}
