namespace Client_Server
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_IPServer = new System.Windows.Forms.TextBox();
            this.txtb_PortServer = new System.Windows.Forms.TextBox();
            this.txtb_IPClient = new System.Windows.Forms.TextBox();
            this.txtb_PortClient = new System.Windows.Forms.TextBox();
            this.txtb_Message = new System.Windows.Forms.TextBox();
            this.rtb_ScreenMessage = new System.Windows.Forms.RichTextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CLIENT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "PORT";
            // 
            // txtb_IPServer
            // 
            this.txtb_IPServer.Location = new System.Drawing.Point(73, 84);
            this.txtb_IPServer.Name = "txtb_IPServer";
            this.txtb_IPServer.Size = new System.Drawing.Size(219, 22);
            this.txtb_IPServer.TabIndex = 6;
            // 
            // txtb_PortServer
            // 
            this.txtb_PortServer.Location = new System.Drawing.Point(376, 84);
            this.txtb_PortServer.Name = "txtb_PortServer";
            this.txtb_PortServer.Size = new System.Drawing.Size(219, 22);
            this.txtb_PortServer.TabIndex = 7;
            // 
            // txtb_IPClient
            // 
            this.txtb_IPClient.Location = new System.Drawing.Point(73, 209);
            this.txtb_IPClient.Name = "txtb_IPClient";
            this.txtb_IPClient.Size = new System.Drawing.Size(219, 22);
            this.txtb_IPClient.TabIndex = 8;
            // 
            // txtb_PortClient
            // 
            this.txtb_PortClient.Location = new System.Drawing.Point(376, 209);
            this.txtb_PortClient.Name = "txtb_PortClient";
            this.txtb_PortClient.Size = new System.Drawing.Size(219, 22);
            this.txtb_PortClient.TabIndex = 9;
            // 
            // txtb_Message
            // 
            this.txtb_Message.Location = new System.Drawing.Point(627, 280);
            this.txtb_Message.Name = "txtb_Message";
            this.txtb_Message.Size = new System.Drawing.Size(559, 22);
            this.txtb_Message.TabIndex = 10;
            // 
            // rtb_ScreenMessage
            // 
            this.rtb_ScreenMessage.Location = new System.Drawing.Point(627, 24);
            this.rtb_ScreenMessage.Name = "rtb_ScreenMessage";
            this.rtb_ScreenMessage.Size = new System.Drawing.Size(686, 224);
            this.rtb_ScreenMessage.TabIndex = 11;
            this.rtb_ScreenMessage.Text = "";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(50, 128);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(89, 23);
            this.btn_Start.TabIndex = 12;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(50, 254);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(89, 23);
            this.btn_Connect.TabIndex = 13;
            this.btn_Connect.Text = "CONNECT";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(1204, 272);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(109, 38);
            this.btn_Send.TabIndex = 14;
            this.btn_Send.Text = "SEND";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 343);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.rtb_ScreenMessage);
            this.Controls.Add(this.txtb_Message);
            this.Controls.Add(this.txtb_PortClient);
            this.Controls.Add(this.txtb_IPClient);
            this.Controls.Add(this.txtb_PortServer);
            this.Controls.Add(this.txtb_IPServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_IPServer;
        private System.Windows.Forms.TextBox txtb_PortServer;
        private System.Windows.Forms.TextBox txtb_IPClient;
        private System.Windows.Forms.TextBox txtb_PortClient;
        private System.Windows.Forms.TextBox txtb_Message;
        private System.Windows.Forms.RichTextBox rtb_ScreenMessage;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Send;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

