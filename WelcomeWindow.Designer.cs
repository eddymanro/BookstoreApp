namespace BookstoreApp
{
    partial class WelcomeWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookstoreBtn = new System.Windows.Forms.Button();
            this.clientBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.bookStoreLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(216, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome !";
            // 
            // bookstoreBtn
            // 
            this.bookstoreBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.bookstoreBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookstoreBtn.ForeColor = System.Drawing.Color.White;
            this.bookstoreBtn.Location = new System.Drawing.Point(128, 111);
            this.bookstoreBtn.Name = "bookstoreBtn";
            this.bookstoreBtn.Size = new System.Drawing.Size(340, 75);
            this.bookstoreBtn.TabIndex = 1;
            this.bookstoreBtn.Text = "Admin";
            this.bookstoreBtn.UseVisualStyleBackColor = false;
            this.bookstoreBtn.Click += new System.EventHandler(this.bookstoreBtn_Click);
            // 
            // clientBtn
            // 
            this.clientBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.clientBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientBtn.ForeColor = System.Drawing.Color.White;
            this.clientBtn.Location = new System.Drawing.Point(128, 273);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(340, 75);
            this.clientBtn.TabIndex = 2;
            this.clientBtn.Text = "Book Reservations";
            this.clientBtn.UseVisualStyleBackColor = false;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(128, 354);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(340, 75);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Quit Application";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // bookStoreLoginBtn
            // 
            this.bookStoreLoginBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.bookStoreLoginBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookStoreLoginBtn.ForeColor = System.Drawing.Color.White;
            this.bookStoreLoginBtn.Location = new System.Drawing.Point(128, 192);
            this.bookStoreLoginBtn.Name = "bookStoreLoginBtn";
            this.bookStoreLoginBtn.Size = new System.Drawing.Size(340, 75);
            this.bookStoreLoginBtn.TabIndex = 4;
            this.bookStoreLoginBtn.Text = "Bookstore Login";
            this.bookStoreLoginBtn.UseVisualStyleBackColor = false;
            this.bookStoreLoginBtn.Click += new System.EventHandler(this.bookStoreLoginBtn_Click);
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 492);
            this.Controls.Add(this.bookStoreLoginBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clientBtn);
            this.Controls.Add(this.bookstoreBtn);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeWindow";
            this.Text = "Welcome to the Bookstore";
            this.Load += new System.EventHandler(this.WelcomeWindow_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button bookstoreBtn;
        private Button clientBtn;
        private Button exitBtn;
        private Button bookStoreLoginBtn;
    }
}