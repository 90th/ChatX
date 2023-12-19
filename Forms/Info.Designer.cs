namespace ChatX.Forms {
    partial class Info {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.setUsername = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.windowHandle = new System.Windows.Forms.Panel();
            this.formExit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.LinkLabel();
            this.roomGenerateButton = new System.Windows.Forms.Button();
            this.windowHandle.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.usernameLabel.Location = new System.Drawing.Point(12, 30);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(65, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "username:";
            // 
            // setUsername
            // 
            this.setUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setUsername.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.setUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.setUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.setUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setUsername.ForeColor = System.Drawing.Color.GhostWhite;
            this.setUsername.Location = new System.Drawing.Point(155, 112);
            this.setUsername.Name = "setUsername";
            this.setUsername.Size = new System.Drawing.Size(123, 22);
            this.setUsername.TabIndex = 3;
            this.setUsername.Text = "Set";
            this.setUsername.UseVisualStyleBackColor = true;
            this.setUsername.Click += new System.EventHandler(this.setUsername_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.usernameTextbox.ForeColor = System.Drawing.Color.GhostWhite;
            this.usernameTextbox.Location = new System.Drawing.Point(12, 46);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(290, 20);
            this.usernameTextbox.TabIndex = 1;
            this.usernameTextbox.Text = "anon";
            // 
            // windowHandle
            // 
            this.windowHandle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.windowHandle.Controls.Add(this.formExit);
            this.windowHandle.Controls.Add(this.labelTitle);
            this.windowHandle.Location = new System.Drawing.Point(-1, -1);
            this.windowHandle.Name = "windowHandle";
            this.windowHandle.Size = new System.Drawing.Size(315, 22);
            this.windowHandle.TabIndex = 7;
            // 
            // formExit
            // 
            this.formExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.formExit.FlatAppearance.BorderSize = 0;
            this.formExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.formExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.formExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formExit.ForeColor = System.Drawing.Color.GhostWhite;
            this.formExit.Location = new System.Drawing.Point(291, 0);
            this.formExit.Name = "formExit";
            this.formExit.Size = new System.Drawing.Size(24, 22);
            this.formExit.TabIndex = 7;
            this.formExit.Text = "X";
            this.formExit.UseVisualStyleBackColor = true;
            this.formExit.Click += new System.EventHandler(this.formExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTitle.Location = new System.Drawing.Point(3, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(45, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "handle";
            // 
            // roomTextBox
            // 
            this.roomTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.roomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.roomTextBox.Location = new System.Drawing.Point(12, 86);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(290, 20);
            this.roomTextBox.TabIndex = 2;
            this.roomTextBox.Text = "general";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Bold);
            this.roomLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.roomLabel.Location = new System.Drawing.Point(12, 70);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(43, 13);
            this.roomLabel.TabIndex = 9;
            this.roomLabel.Text = "Room:";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.helpLabel.Location = new System.Drawing.Point(284, 117);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(19, 13);
            this.helpLabel.TabIndex = 10;
            this.helpLabel.TabStop = true;
            this.helpLabel.Text = "(?)";
            this.helpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLabel_LinkClicked);
            // 
            // roomGenerateButton
            // 
            this.roomGenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomGenerateButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.roomGenerateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.roomGenerateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.roomGenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomGenerateButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.roomGenerateButton.Location = new System.Drawing.Point(12, 112);
            this.roomGenerateButton.Name = "roomGenerateButton";
            this.roomGenerateButton.Size = new System.Drawing.Size(137, 22);
            this.roomGenerateButton.TabIndex = 11;
            this.roomGenerateButton.Text = "Private";
            this.roomGenerateButton.UseVisualStyleBackColor = true;
            this.roomGenerateButton.Click += new System.EventHandler(this.roomGenerateButton_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(315, 142);
            this.ControlBox = false;
            this.Controls.Add(this.roomGenerateButton);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(this.windowHandle);
            this.Controls.Add(this.setUsername);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Info";
            this.windowHandle.ResumeLayout(false);
            this.windowHandle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button setUsername;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Panel windowHandle;
        private System.Windows.Forms.Button formExit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.LinkLabel helpLabel;
        private System.Windows.Forms.Button roomGenerateButton;
    }
}