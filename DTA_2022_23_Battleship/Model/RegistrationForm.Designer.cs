namespace DTA_2022_23_Battleship.Model
{
    partial class RegistrationForm
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
            button1 = new Button();
            button2 = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBoxAdmin = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(259, 421);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(210, 57);
            button1.TabIndex = 0;
            button1.Text = "sign in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += EnterClick;
            // 
            // button2
            // 
            button2.Location = new Point(14, 421);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(210, 57);
            button2.TabIndex = 1;
            button2.Text = "sign up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RegistrationClick;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(118, 156);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(210, 34);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(118, 68);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(210, 34);
            textBoxLogin.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 24);
            label1.Name = "label1";
            label1.Size = new Size(66, 26);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 116);
            label2.Name = "label2";
            label2.Size = new Size(102, 26);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 205);
            label3.Name = "label3";
            label3.Size = new Size(166, 52);
            label3.TabIndex = 7;
            label3.Text = "Date of Birth\r\n(for registration)\r\n";
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Location = new Point(140, 349);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(163, 30);
            checkBoxAdmin.TabIndex = 8;
            checkBoxAdmin.Text = "Administrator";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(101, 287);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 9;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 491);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBoxAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxAdmin;
        private DateTimePicker dateTimePicker1;
    }
}