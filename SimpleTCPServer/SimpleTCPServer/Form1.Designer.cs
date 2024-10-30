
namespace SimpleTCPServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_PORT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_outputData = new System.Windows.Forms.TextBox();
            this.textBox_OutputDebug = new System.Windows.Forms.TextBox();
            this.textBox_send1 = new System.Windows.Forms.TextBox();
            this.button_send1 = new System.Windows.Forms.Button();
            this.textBox_loopTime1 = new System.Windows.Forms.TextBox();
            this.checkBox_loop1 = new System.Windows.Forms.CheckBox();
            this.checkBox_loop2 = new System.Windows.Forms.CheckBox();
            this.textBox_loopTime2 = new System.Windows.Forms.TextBox();
            this.button_send2 = new System.Windows.Forms.Button();
            this.textBox_send2 = new System.Windows.Forms.TextBox();
            this.checkBox_loop3 = new System.Windows.Forms.CheckBox();
            this.textBox_loopTime3 = new System.Windows.Forms.TextBox();
            this.button_send3 = new System.Windows.Forms.Button();
            this.textBox_send3 = new System.Windows.Forms.TextBox();
            this.checkBox_loop4 = new System.Windows.Forms.CheckBox();
            this.textBox_loopTime4 = new System.Windows.Forms.TextBox();
            this.button_send4 = new System.Windows.Forms.Button();
            this.textBox_send4 = new System.Windows.Forms.TextBox();
            this.checkBox_loop5 = new System.Windows.Forms.CheckBox();
            this.textBox_loopTime5 = new System.Windows.Forms.TextBox();
            this.button_send5 = new System.Windows.Forms.Button();
            this.textBox_send5 = new System.Windows.Forms.TextBox();
            this.textBox_IfGet1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_IfSet1 = new System.Windows.Forms.TextBox();
            this.textBox_IfSet2 = new System.Windows.Forms.TextBox();
            this.textBox_IfGet2 = new System.Windows.Forms.TextBox();
            this.textBox_IfSet3 = new System.Windows.Forms.TextBox();
            this.textBox_IfGet3 = new System.Windows.Forms.TextBox();
            this.textBox_ifDelay3 = new System.Windows.Forms.TextBox();
            this.textBox_ifDelay2 = new System.Windows.Forms.TextBox();
            this.textBox_ifDelay1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT: ";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(42, 10);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(100, 20);
            this.textBox_IP.TabIndex = 2;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // textBox_PORT
            // 
            this.textBox_PORT.Location = new System.Drawing.Point(197, 10);
            this.textBox_PORT.Name = "textBox_PORT";
            this.textBox_PORT.Size = new System.Drawing.Size(100, 20);
            this.textBox_PORT.TabIndex = 3;
            this.textBox_PORT.Text = "5001";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "STOP/RESET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_outputData
            // 
            this.textBox_outputData.AcceptsReturn = true;
            this.textBox_outputData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_outputData.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox_outputData.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_outputData.ForeColor = System.Drawing.Color.Honeydew;
            this.textBox_outputData.Location = new System.Drawing.Point(13, 259);
            this.textBox_outputData.Multiline = true;
            this.textBox_outputData.Name = "textBox_outputData";
            this.textBox_outputData.Size = new System.Drawing.Size(284, 185);
            this.textBox_outputData.TabIndex = 6;
            // 
            // textBox_OutputDebug
            // 
            this.textBox_OutputDebug.AcceptsReturn = true;
            this.textBox_OutputDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_OutputDebug.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox_OutputDebug.ForeColor = System.Drawing.Color.Lime;
            this.textBox_OutputDebug.Location = new System.Drawing.Point(303, 259);
            this.textBox_OutputDebug.Multiline = true;
            this.textBox_OutputDebug.Name = "textBox_OutputDebug";
            this.textBox_OutputDebug.Size = new System.Drawing.Size(485, 185);
            this.textBox_OutputDebug.TabIndex = 7;
            // 
            // textBox_send1
            // 
            this.textBox_send1.Location = new System.Drawing.Point(12, 36);
            this.textBox_send1.Name = "textBox_send1";
            this.textBox_send1.Size = new System.Drawing.Size(553, 20);
            this.textBox_send1.TabIndex = 8;
            this.textBox_send1.Text = "100,30 g\\r\\n";
            // 
            // button_send1
            // 
            this.button_send1.Location = new System.Drawing.Point(682, 34);
            this.button_send1.Name = "button_send1";
            this.button_send1.Size = new System.Drawing.Size(106, 23);
            this.button_send1.TabIndex = 13;
            this.button_send1.Text = "Send";
            this.button_send1.UseVisualStyleBackColor = true;
            this.button_send1.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_loopTime1
            // 
            this.textBox_loopTime1.Location = new System.Drawing.Point(627, 36);
            this.textBox_loopTime1.Name = "textBox_loopTime1";
            this.textBox_loopTime1.Size = new System.Drawing.Size(49, 20);
            this.textBox_loopTime1.TabIndex = 18;
            this.textBox_loopTime1.Text = "1000";
            // 
            // checkBox_loop1
            // 
            this.checkBox_loop1.AutoSize = true;
            this.checkBox_loop1.Location = new System.Drawing.Point(571, 38);
            this.checkBox_loop1.Name = "checkBox_loop1";
            this.checkBox_loop1.Size = new System.Drawing.Size(50, 17);
            this.checkBox_loop1.TabIndex = 19;
            this.checkBox_loop1.Text = "Loop";
            this.checkBox_loop1.UseVisualStyleBackColor = true;
            // 
            // checkBox_loop2
            // 
            this.checkBox_loop2.AutoSize = true;
            this.checkBox_loop2.Location = new System.Drawing.Point(571, 64);
            this.checkBox_loop2.Name = "checkBox_loop2";
            this.checkBox_loop2.Size = new System.Drawing.Size(50, 17);
            this.checkBox_loop2.TabIndex = 23;
            this.checkBox_loop2.Text = "Loop";
            this.checkBox_loop2.UseVisualStyleBackColor = true;
            // 
            // textBox_loopTime2
            // 
            this.textBox_loopTime2.Location = new System.Drawing.Point(627, 62);
            this.textBox_loopTime2.Name = "textBox_loopTime2";
            this.textBox_loopTime2.Size = new System.Drawing.Size(49, 20);
            this.textBox_loopTime2.TabIndex = 22;
            this.textBox_loopTime2.Text = "1000";
            // 
            // button_send2
            // 
            this.button_send2.Location = new System.Drawing.Point(682, 60);
            this.button_send2.Name = "button_send2";
            this.button_send2.Size = new System.Drawing.Size(106, 23);
            this.button_send2.TabIndex = 21;
            this.button_send2.Text = "Send";
            this.button_send2.UseVisualStyleBackColor = true;
            this.button_send2.Click += new System.EventHandler(this.button_send2_Click);
            // 
            // textBox_send2
            // 
            this.textBox_send2.Location = new System.Drawing.Point(12, 62);
            this.textBox_send2.Name = "textBox_send2";
            this.textBox_send2.Size = new System.Drawing.Size(553, 20);
            this.textBox_send2.TabIndex = 20;
            this.textBox_send2.Text = "98.20 g\\r\\n";
            // 
            // checkBox_loop3
            // 
            this.checkBox_loop3.AutoSize = true;
            this.checkBox_loop3.Location = new System.Drawing.Point(571, 90);
            this.checkBox_loop3.Name = "checkBox_loop3";
            this.checkBox_loop3.Size = new System.Drawing.Size(50, 17);
            this.checkBox_loop3.TabIndex = 27;
            this.checkBox_loop3.Text = "Loop";
            this.checkBox_loop3.UseVisualStyleBackColor = true;
            // 
            // textBox_loopTime3
            // 
            this.textBox_loopTime3.Location = new System.Drawing.Point(627, 88);
            this.textBox_loopTime3.Name = "textBox_loopTime3";
            this.textBox_loopTime3.Size = new System.Drawing.Size(49, 20);
            this.textBox_loopTime3.TabIndex = 26;
            this.textBox_loopTime3.Text = "1000";
            // 
            // button_send3
            // 
            this.button_send3.Location = new System.Drawing.Point(682, 86);
            this.button_send3.Name = "button_send3";
            this.button_send3.Size = new System.Drawing.Size(106, 23);
            this.button_send3.TabIndex = 25;
            this.button_send3.Text = "Send";
            this.button_send3.UseVisualStyleBackColor = true;
            this.button_send3.Click += new System.EventHandler(this.button_send3_Click);
            // 
            // textBox_send3
            // 
            this.textBox_send3.Location = new System.Drawing.Point(12, 88);
            this.textBox_send3.Name = "textBox_send3";
            this.textBox_send3.Size = new System.Drawing.Size(553, 20);
            this.textBox_send3.TabIndex = 24;
            this.textBox_send3.Text = "123\\r\\n";
            // 
            // checkBox_loop4
            // 
            this.checkBox_loop4.AutoSize = true;
            this.checkBox_loop4.Location = new System.Drawing.Point(571, 116);
            this.checkBox_loop4.Name = "checkBox_loop4";
            this.checkBox_loop4.Size = new System.Drawing.Size(50, 17);
            this.checkBox_loop4.TabIndex = 31;
            this.checkBox_loop4.Text = "Loop";
            this.checkBox_loop4.UseVisualStyleBackColor = true;
            // 
            // textBox_loopTime4
            // 
            this.textBox_loopTime4.Location = new System.Drawing.Point(627, 114);
            this.textBox_loopTime4.Name = "textBox_loopTime4";
            this.textBox_loopTime4.Size = new System.Drawing.Size(49, 20);
            this.textBox_loopTime4.TabIndex = 30;
            this.textBox_loopTime4.Text = "1000";
            // 
            // button_send4
            // 
            this.button_send4.Location = new System.Drawing.Point(682, 112);
            this.button_send4.Name = "button_send4";
            this.button_send4.Size = new System.Drawing.Size(106, 23);
            this.button_send4.TabIndex = 29;
            this.button_send4.Text = "Send";
            this.button_send4.UseVisualStyleBackColor = true;
            this.button_send4.Click += new System.EventHandler(this.button_send4_Click);
            // 
            // textBox_send4
            // 
            this.textBox_send4.Location = new System.Drawing.Point(12, 114);
            this.textBox_send4.Name = "textBox_send4";
            this.textBox_send4.Size = new System.Drawing.Size(553, 20);
            this.textBox_send4.TabIndex = 28;
            // 
            // checkBox_loop5
            // 
            this.checkBox_loop5.AutoSize = true;
            this.checkBox_loop5.Location = new System.Drawing.Point(571, 142);
            this.checkBox_loop5.Name = "checkBox_loop5";
            this.checkBox_loop5.Size = new System.Drawing.Size(50, 17);
            this.checkBox_loop5.TabIndex = 35;
            this.checkBox_loop5.Text = "Loop";
            this.checkBox_loop5.UseVisualStyleBackColor = true;
            // 
            // textBox_loopTime5
            // 
            this.textBox_loopTime5.Location = new System.Drawing.Point(627, 140);
            this.textBox_loopTime5.Name = "textBox_loopTime5";
            this.textBox_loopTime5.Size = new System.Drawing.Size(49, 20);
            this.textBox_loopTime5.TabIndex = 34;
            this.textBox_loopTime5.Text = "1000";
            // 
            // button_send5
            // 
            this.button_send5.Location = new System.Drawing.Point(682, 138);
            this.button_send5.Name = "button_send5";
            this.button_send5.Size = new System.Drawing.Size(106, 23);
            this.button_send5.TabIndex = 33;
            this.button_send5.Text = "Send";
            this.button_send5.UseVisualStyleBackColor = true;
            this.button_send5.Click += new System.EventHandler(this.button_send5_Click);
            // 
            // textBox_send5
            // 
            this.textBox_send5.Location = new System.Drawing.Point(12, 140);
            this.textBox_send5.Name = "textBox_send5";
            this.textBox_send5.Size = new System.Drawing.Size(553, 20);
            this.textBox_send5.TabIndex = 32;
            // 
            // textBox_IfGet1
            // 
            this.textBox_IfGet1.Location = new System.Drawing.Point(215, 166);
            this.textBox_IfGet1.Name = "textBox_IfGet1";
            this.textBox_IfGet1.Size = new System.Drawing.Size(256, 20);
            this.textBox_IfGet1.TabIndex = 36;
            this.textBox_IfGet1.Text = "GET_WEIGHT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "If you get... delay... then send...";
            // 
            // textBox_IfSet1
            // 
            this.textBox_IfSet1.Location = new System.Drawing.Point(532, 166);
            this.textBox_IfSet1.Name = "textBox_IfSet1";
            this.textBox_IfSet1.Size = new System.Drawing.Size(256, 20);
            this.textBox_IfSet1.TabIndex = 38;
            this.textBox_IfSet1.Text = "100,30 g\\r\\n";
            // 
            // textBox_IfSet2
            // 
            this.textBox_IfSet2.Location = new System.Drawing.Point(532, 192);
            this.textBox_IfSet2.Name = "textBox_IfSet2";
            this.textBox_IfSet2.Size = new System.Drawing.Size(256, 20);
            this.textBox_IfSet2.TabIndex = 40;
            this.textBox_IfSet2.Text = "00012345";
            // 
            // textBox_IfGet2
            // 
            this.textBox_IfGet2.Location = new System.Drawing.Point(215, 192);
            this.textBox_IfGet2.Name = "textBox_IfGet2";
            this.textBox_IfGet2.Size = new System.Drawing.Size(256, 20);
            this.textBox_IfGet2.TabIndex = 39;
            this.textBox_IfGet2.Text = "GET_BARCODE";
            // 
            // textBox_IfSet3
            // 
            this.textBox_IfSet3.Location = new System.Drawing.Point(532, 218);
            this.textBox_IfSet3.Name = "textBox_IfSet3";
            this.textBox_IfSet3.Size = new System.Drawing.Size(256, 20);
            this.textBox_IfSet3.TabIndex = 42;
            // 
            // textBox_IfGet3
            // 
            this.textBox_IfGet3.Location = new System.Drawing.Point(215, 218);
            this.textBox_IfGet3.Name = "textBox_IfGet3";
            this.textBox_IfGet3.Size = new System.Drawing.Size(256, 20);
            this.textBox_IfGet3.TabIndex = 41;
            // 
            // textBox_ifDelay3
            // 
            this.textBox_ifDelay3.Location = new System.Drawing.Point(477, 218);
            this.textBox_ifDelay3.Name = "textBox_ifDelay3";
            this.textBox_ifDelay3.Size = new System.Drawing.Size(49, 20);
            this.textBox_ifDelay3.TabIndex = 45;
            this.textBox_ifDelay3.Text = "1000";
            // 
            // textBox_ifDelay2
            // 
            this.textBox_ifDelay2.Location = new System.Drawing.Point(477, 192);
            this.textBox_ifDelay2.Name = "textBox_ifDelay2";
            this.textBox_ifDelay2.Size = new System.Drawing.Size(49, 20);
            this.textBox_ifDelay2.TabIndex = 44;
            this.textBox_ifDelay2.Text = "1000";
            // 
            // textBox_ifDelay1
            // 
            this.textBox_ifDelay1.Location = new System.Drawing.Point(477, 166);
            this.textBox_ifDelay1.Name = "textBox_ifDelay1";
            this.textBox_ifDelay1.Size = new System.Drawing.Size(49, 20);
            this.textBox_ifDelay1.TabIndex = 43;
            this.textBox_ifDelay1.Text = "1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.textBox_ifDelay3);
            this.Controls.Add(this.textBox_ifDelay2);
            this.Controls.Add(this.textBox_ifDelay1);
            this.Controls.Add(this.textBox_IfSet3);
            this.Controls.Add(this.textBox_IfGet3);
            this.Controls.Add(this.textBox_IfSet2);
            this.Controls.Add(this.textBox_IfGet2);
            this.Controls.Add(this.textBox_IfSet1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_IfGet1);
            this.Controls.Add(this.checkBox_loop5);
            this.Controls.Add(this.textBox_loopTime5);
            this.Controls.Add(this.button_send5);
            this.Controls.Add(this.textBox_send5);
            this.Controls.Add(this.checkBox_loop4);
            this.Controls.Add(this.textBox_loopTime4);
            this.Controls.Add(this.button_send4);
            this.Controls.Add(this.textBox_send4);
            this.Controls.Add(this.checkBox_loop3);
            this.Controls.Add(this.textBox_loopTime3);
            this.Controls.Add(this.button_send3);
            this.Controls.Add(this.textBox_send3);
            this.Controls.Add(this.checkBox_loop2);
            this.Controls.Add(this.textBox_loopTime2);
            this.Controls.Add(this.button_send2);
            this.Controls.Add(this.textBox_send2);
            this.Controls.Add(this.checkBox_loop1);
            this.Controls.Add(this.textBox_loopTime1);
            this.Controls.Add(this.button_send1);
            this.Controls.Add(this.textBox_send1);
            this.Controls.Add(this.textBox_OutputDebug);
            this.Controls.Add(this.textBox_outputData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_PORT);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TCP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_PORT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_outputData;
        private System.Windows.Forms.TextBox textBox_OutputDebug;
        private System.Windows.Forms.TextBox textBox_send1;
        private System.Windows.Forms.Button button_send1;
        private System.Windows.Forms.TextBox textBox_loopTime1;
        private System.Windows.Forms.CheckBox checkBox_loop1;
        private System.Windows.Forms.CheckBox checkBox_loop2;
        private System.Windows.Forms.TextBox textBox_loopTime2;
        private System.Windows.Forms.Button button_send2;
        private System.Windows.Forms.TextBox textBox_send2;
        private System.Windows.Forms.CheckBox checkBox_loop3;
        private System.Windows.Forms.TextBox textBox_loopTime3;
        private System.Windows.Forms.Button button_send3;
        private System.Windows.Forms.TextBox textBox_send3;
        private System.Windows.Forms.CheckBox checkBox_loop4;
        private System.Windows.Forms.TextBox textBox_loopTime4;
        private System.Windows.Forms.Button button_send4;
        private System.Windows.Forms.TextBox textBox_send4;
        private System.Windows.Forms.CheckBox checkBox_loop5;
        private System.Windows.Forms.TextBox textBox_loopTime5;
        private System.Windows.Forms.Button button_send5;
        private System.Windows.Forms.TextBox textBox_send5;
        private System.Windows.Forms.TextBox textBox_IfGet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_IfSet1;
        private System.Windows.Forms.TextBox textBox_IfSet2;
        private System.Windows.Forms.TextBox textBox_IfGet2;
        private System.Windows.Forms.TextBox textBox_IfSet3;
        private System.Windows.Forms.TextBox textBox_IfGet3;
        private System.Windows.Forms.TextBox textBox_ifDelay3;
        private System.Windows.Forms.TextBox textBox_ifDelay2;
        private System.Windows.Forms.TextBox textBox_ifDelay1;
    }
}

