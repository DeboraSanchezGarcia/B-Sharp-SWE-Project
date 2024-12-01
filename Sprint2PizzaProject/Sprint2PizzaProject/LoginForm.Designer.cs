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
            loginLabel = new Label();
            loginSubmit = new Button();
            loginCancel = new Button();
            loginPanel = new Panel();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(330, 152);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(270, 32);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email or Phone Number";
            emailLabel.Click += emailLabel_Click;
            // 
            // emailResponse
            // 
            emailResponse.AutoSize = true;
            emailResponse.ForeColor = Color.Red;
            emailResponse.Location = new Point(330, 219);
            emailResponse.Name = "emailResponse";
            emailResponse.Size = new Size(0, 15);
            emailResponse.TabIndex = 1;
            emailResponse.Click += emailResponse_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(330, 264);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(111, 32);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // passwordResponse
            // 
            passwordResponse.AutoSize = true;
            passwordResponse.ForeColor = Color.Red;
            passwordResponse.Location = new Point(330, 331);
            passwordResponse.Name = "passwordResponse";
            passwordResponse.Size = new Size(0, 15);
            passwordResponse.TabIndex = 3;
            passwordResponse.Click += passwordResponse_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(330, 187);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(270, 29);
            emailTextBox.TabIndex = 4;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(330, 299);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(100, 29);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLabel.Location = new Point(408, 46);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(99, 45);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "Login";
            // 
            // loginSubmit
            // 
            loginSubmit.BackColor = Color.Orange;
            loginSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginSubmit.ForeColor = SystemColors.ControlText;
            loginSubmit.Location = new Point(330, 393);
            loginSubmit.Name = "loginSubmit";
            loginSubmit.Size = new Size(75, 31);
            loginSubmit.TabIndex = 7;
            loginSubmit.Text = "Submit";
            loginSubmit.UseVisualStyleBackColor = false;
            loginSubmit.Click += loginSubmit_Click;
            // 
            // loginCancel
            // 
            loginCancel.BackColor = Color.Orange;
            loginCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginCancel.Location = new Point(525, 393);
            loginCancel.Name = "loginCancel";
            loginCancel.Size = new Size(75, 31);
            loginCancel.TabIndex = 8;
            loginCancel.Text = "Cancel";
            loginCancel.UseVisualStyleBackColor = false;
            loginCancel.Click += loginCancel_Click;
            // 
            // loginPanel
            // 
            loginPanel.BackgroundImage = Properties.Resources.BackgroundProject;
            loginPanel.Controls.Add(loginCancel);
            loginPanel.Controls.Add(loginSubmit);
            loginPanel.Controls.Add(loginLabel);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(emailTextBox);
            loginPanel.Controls.Add(passwordResponse);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(emailResponse);
            loginPanel.Controls.Add(emailLabel);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(984, 561);
            loginPanel.TabIndex = 0;
            loginPanel.Paint += loginPanel_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(loginPanel);
            Margin = new Padding(2, 2, 2, 2);
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
        private Label loginLabel;
    }
}
