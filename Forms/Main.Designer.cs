namespace ChatX {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chatLog = new System.Windows.Forms.RichTextBox();
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.sendMessage = new System.Windows.Forms.Button();
            this.windowHandle = new System.Windows.Forms.Panel();
            this.formExit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.windowHandle.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatLog
            // 
            this.chatLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chatLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatLog.ForeColor = System.Drawing.Color.GhostWhite;
            this.chatLog.Location = new System.Drawing.Point(2, 26);
            this.chatLog.Name = "chatLog";
            this.chatLog.ReadOnly = true;
            this.chatLog.Size = new System.Drawing.Size(523, 287);
            this.chatLog.TabIndex = 5;
            this.chatLog.Text = "";
            // 
            // userTextbox
            // 
            this.userTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.userTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTextbox.Enabled = false;
            this.userTextbox.ForeColor = System.Drawing.Color.GhostWhite;
            this.userTextbox.Location = new System.Drawing.Point(2, 325);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(427, 20);
            this.userTextbox.TabIndex = 0;
            this.userTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // sendMessage
            // 
            this.sendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendMessage.Enabled = false;
            this.sendMessage.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.sendMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.sendMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.sendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMessage.ForeColor = System.Drawing.Color.GhostWhite;
            this.sendMessage.Location = new System.Drawing.Point(435, 324);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(90, 22);
            this.sendMessage.TabIndex = 1;
            this.sendMessage.Text = "SEND";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // windowHandle
            // 
            this.windowHandle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.windowHandle.Controls.Add(this.formExit);
            this.windowHandle.Controls.Add(this.labelTitle);
            this.windowHandle.Location = new System.Drawing.Point(0, 0);
            this.windowHandle.Name = "windowHandle";
            this.windowHandle.Size = new System.Drawing.Size(529, 22);
            this.windowHandle.TabIndex = 6;
            // 
            // formExit
            // 
            this.formExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.formExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.formExit.FlatAppearance.BorderSize = 0;
            this.formExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.formExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.formExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formExit.ForeColor = System.Drawing.Color.GhostWhite;
            this.formExit.Location = new System.Drawing.Point(504, 0);
            this.formExit.Name = "formExit";
            this.formExit.Size = new System.Drawing.Size(24, 22);
            this.formExit.TabIndex = 7;
            this.formExit.Text = "X";
            this.formExit.UseVisualStyleBackColor = true;
            this.formExit.Click += new System.EventHandler(this.formExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTitle.Location = new System.Drawing.Point(3, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(41, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ChatX";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(529, 348);
            this.Controls.Add(this.windowHandle);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.userTextbox);
            this.Controls.Add(this.chatLog);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.windowHandle.ResumeLayout(false);
            this.windowHandle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatLog;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.Panel windowHandle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button formExit;
    }
}

