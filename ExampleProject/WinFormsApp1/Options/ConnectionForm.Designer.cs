namespace WinFormsApp1.Options
{
    partial class ConnectionForm
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
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtServerHost = new System.Windows.Forms.TextBox();
            this.SavingButton = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnConnectionCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Label1.Location = new System.Drawing.Point(152, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 30);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Server";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtServerHost
            // 
            this.TxtServerHost.Location = new System.Drawing.Point(152, 76);
            this.TxtServerHost.Name = "TxtServerHost";
            this.TxtServerHost.Size = new System.Drawing.Size(164, 29);
            this.TxtServerHost.TabIndex = 1;
            this.TxtServerHost.TextChanged += new System.EventHandler(this.TxtServerHost_TextChanged);
            // 
            // SavingButton
            // 
            this.SavingButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SavingButton.Location = new System.Drawing.Point(414, 46);
            this.SavingButton.Name = "SavingButton";
            this.SavingButton.Size = new System.Drawing.Size(133, 59);
            this.SavingButton.TabIndex = 2;
            this.SavingButton.Text = "Save";
            this.SavingButton.UseVisualStyleBackColor = true;
            this.SavingButton.Click += new System.EventHandler(this.SavingButton_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(414, 111);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(133, 57);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Discard";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(152, 139);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(164, 29);
            this.txtUserName.TabIndex = 4;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(152, 204);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(164, 29);
            this.txtUserPassword.TabIndex = 5;
            this.txtUserPassword.TextChanged += new System.EventHandler(this.txtUserPassword_TextChanged);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUser.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblUser.Location = new System.Drawing.Point(152, 106);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(57, 30);
            this.LblUser.TabIndex = 6;
            this.LblUser.Text = "User";
            this.LblUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblPassword.Location = new System.Drawing.Point(152, 171);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(103, 30);
            this.LblPassword.TabIndex = 7;
            this.LblPassword.Text = "Password";
            this.LblPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnConnectionCheck
            // 
            this.BtnConnectionCheck.ForeColor = System.Drawing.Color.Blue;
            this.BtnConnectionCheck.Location = new System.Drawing.Point(152, 268);
            this.BtnConnectionCheck.Name = "BtnConnectionCheck";
            this.BtnConnectionCheck.Size = new System.Drawing.Size(153, 41);
            this.BtnConnectionCheck.TabIndex = 8;
            this.BtnConnectionCheck.Text = "Check connection";
            this.BtnConnectionCheck.UseVisualStyleBackColor = true;
            this.BtnConnectionCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 500);
            this.Controls.Add(this.BtnConnectionCheck);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.SavingButton);
            this.Controls.Add(this.TxtServerHost);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConnectionForm";
            this.Text = "ConnectionForm";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label1;
        private TextBox TxtServerHost;
        private Button SavingButton;
        private Button ButtonCancel;
        private TextBox txtUserName;
        private TextBox txtUserPassword;
        private Label LblUser;
        private Label LblPassword;
        private Button BtnConnectionCheck;
    }
}