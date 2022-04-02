
namespace DesktopAppVer2
{
    partial class MainWindow
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
            this.IOPanel = new System.Windows.Forms.Panel();
            this.StreamPanel = new System.Windows.Forms.Panel();
            this.tbBaudRate = new System.Windows.Forms.TextBox();
            this.tbMessageToSend = new System.Windows.Forms.TextBox();
            this.tbComPort = new System.Windows.Forms.TextBox();
            this.bClearRXData = new System.Windows.Forms.Button();
            this.bOpenComPort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDataWindow = new System.Windows.Forms.TextBox();
            this.lblVers = new System.Windows.Forms.Label();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.ButtonArea = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRep = new System.Windows.Forms.Button();
            this.lblRepDistRatio = new System.Windows.Forms.Label();
            this.lblRepMax = new System.Windows.Forms.Label();
            this.lblRepAccel = new System.Windows.Forms.Label();
            this.lblRepSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInc = new System.Windows.Forms.Label();
            this.tbDistRatio = new System.Windows.Forms.TextBox();
            this.lblDistRatio = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.tbAccel = new System.Windows.Forms.TextBox();
            this.lblAccel = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.lblSPEED = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StreamPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.ButtonArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IOPanel
            // 
            this.IOPanel.AutoSize = true;
            this.IOPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IOPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IOPanel.Location = new System.Drawing.Point(5, 5);
            this.IOPanel.Name = "IOPanel";
            this.IOPanel.Size = new System.Drawing.Size(774, 0);
            this.IOPanel.TabIndex = 0;
            // 
            // StreamPanel
            // 
            this.StreamPanel.AutoSize = true;
            this.StreamPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StreamPanel.Controls.Add(this.tbBaudRate);
            this.StreamPanel.Controls.Add(this.tbMessageToSend);
            this.StreamPanel.Controls.Add(this.tbComPort);
            this.StreamPanel.Controls.Add(this.bClearRXData);
            this.StreamPanel.Controls.Add(this.bOpenComPort);
            this.StreamPanel.Controls.Add(this.button1);
            this.StreamPanel.Controls.Add(this.tbDataWindow);
            this.StreamPanel.Controls.Add(this.lblVers);
            this.StreamPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StreamPanel.Location = new System.Drawing.Point(5, 556);
            this.StreamPanel.MinimumSize = new System.Drawing.Size(0, 200);
            this.StreamPanel.Name = "StreamPanel";
            this.StreamPanel.Size = new System.Drawing.Size(774, 200);
            this.StreamPanel.TabIndex = 1;
            // 
            // tbBaudRate
            // 
            this.tbBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBaudRate.Location = new System.Drawing.Point(603, 39);
            this.tbBaudRate.Name = "tbBaudRate";
            this.tbBaudRate.Size = new System.Drawing.Size(167, 23);
            this.tbBaudRate.TabIndex = 7;
            this.tbBaudRate.Text = "9600";
            this.tbBaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMessageToSend
            // 
            this.tbMessageToSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessageToSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbMessageToSend.Location = new System.Drawing.Point(100, 10);
            this.tbMessageToSend.Name = "tbMessageToSend";
            this.tbMessageToSend.Size = new System.Drawing.Size(499, 23);
            this.tbMessageToSend.TabIndex = 6;
            // 
            // tbComPort
            // 
            this.tbComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComPort.Location = new System.Drawing.Point(603, 10);
            this.tbComPort.Name = "tbComPort";
            this.tbComPort.Size = new System.Drawing.Size(91, 23);
            this.tbComPort.TabIndex = 5;
            this.tbComPort.Text = "COM1";
            this.tbComPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bClearRXData
            // 
            this.bClearRXData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClearRXData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClearRXData.Location = new System.Drawing.Point(522, 174);
            this.bClearRXData.Name = "bClearRXData";
            this.bClearRXData.Size = new System.Drawing.Size(75, 23);
            this.bClearRXData.TabIndex = 4;
            this.bClearRXData.Text = "clear";
            this.bClearRXData.UseVisualStyleBackColor = true;
            this.bClearRXData.Click += new System.EventHandler(this.bClearRxData_Click);
            // 
            // bOpenComPort
            // 
            this.bOpenComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOpenComPort.Location = new System.Drawing.Point(697, 10);
            this.bOpenComPort.Name = "bOpenComPort";
            this.bOpenComPort.Size = new System.Drawing.Size(75, 23);
            this.bOpenComPort.TabIndex = 3;
            this.bOpenComPort.Text = "Open";
            this.bOpenComPort.UseVisualStyleBackColor = true;
            this.bOpenComPort.Click += new System.EventHandler(this.bOpenComPort_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bSendMessage_Click);
            // 
            // tbDataWindow
            // 
            this.tbDataWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDataWindow.Location = new System.Drawing.Point(5, 35);
            this.tbDataWindow.Multiline = true;
            this.tbDataWindow.Name = "tbDataWindow";
            this.tbDataWindow.Size = new System.Drawing.Size(592, 162);
            this.tbDataWindow.TabIndex = 2;
            // 
            // lblVers
            // 
            this.lblVers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVers.AutoSize = true;
            this.lblVers.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblVers.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVers.Location = new System.Drawing.Point(598, 174);
            this.lblVers.Name = "lblVers";
            this.lblVers.Size = new System.Drawing.Size(134, 23);
            this.lblVers.TabIndex = 1;
            this.lblVers.Text = "SerialMoniter";
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.ButtonArea);
            this.InputPanel.Controls.Add(this.splitContainer1);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPanel.Location = new System.Drawing.Point(5, 5);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Padding = new System.Windows.Forms.Padding(5);
            this.InputPanel.Size = new System.Drawing.Size(774, 551);
            this.InputPanel.TabIndex = 2;
            // 
            // ButtonArea
            // 
            this.ButtonArea.Controls.Add(this.btnReset);
            this.ButtonArea.Controls.Add(this.btnSend);
            this.ButtonArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonArea.Location = new System.Drawing.Point(5, 501);
            this.ButtonArea.Name = "ButtonArea";
            this.ButtonArea.Size = new System.Drawing.Size(764, 45);
            this.ButtonArea.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(647, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 45);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "SendToCraft";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRep);
            this.splitContainer1.Panel1.Controls.Add(this.lblRepDistRatio);
            this.splitContainer1.Panel1.Controls.Add(this.lblRepMax);
            this.splitContainer1.Panel1.Controls.Add(this.lblRepAccel);
            this.splitContainer1.Panel1.Controls.Add(this.lblRepSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.labelInc);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbDistRatio);
            this.splitContainer1.Panel2.Controls.Add(this.lblDistRatio);
            this.splitContainer1.Panel2.Controls.Add(this.tbMax);
            this.splitContainer1.Panel2.Controls.Add(this.lblMax);
            this.splitContainer1.Panel2.Controls.Add(this.tbAccel);
            this.splitContainer1.Panel2.Controls.Add(this.lblAccel);
            this.splitContainer1.Panel2.Controls.Add(this.tbSpeed);
            this.splitContainer1.Panel2.Controls.Add(this.lblSPEED);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(764, 541);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnRep
            // 
            this.btnRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRep.Location = new System.Drawing.Point(251, 470);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(52, 23);
            this.btnRep.TabIndex = 21;
            this.btnRep.Text = "Report";
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // lblRepDistRatio
            // 
            this.lblRepDistRatio.AutoSize = true;
            this.lblRepDistRatio.Location = new System.Drawing.Point(164, 142);
            this.lblRepDistRatio.Name = "lblRepDistRatio";
            this.lblRepDistRatio.Size = new System.Drawing.Size(92, 15);
            this.lblRepDistRatio.TabIndex = 20;
            this.lblRepDistRatio.Tag = "CRAFT";
            this.lblRepDistRatio.Text = "DISTANCERATIO";
            // 
            // lblRepMax
            // 
            this.lblRepMax.AutoSize = true;
            this.lblRepMax.Location = new System.Drawing.Point(178, 111);
            this.lblRepMax.Name = "lblRepMax";
            this.lblRepMax.Size = new System.Drawing.Size(66, 15);
            this.lblRepMax.TabIndex = 19;
            this.lblRepMax.Tag = "CRAFT";
            this.lblRepMax.Text = "MAXSPEED";
            // 
            // lblRepAccel
            // 
            this.lblRepAccel.AutoSize = true;
            this.lblRepAccel.Location = new System.Drawing.Point(185, 77);
            this.lblRepAccel.Name = "lblRepAccel";
            this.lblRepAccel.Size = new System.Drawing.Size(43, 15);
            this.lblRepAccel.TabIndex = 18;
            this.lblRepAccel.Tag = "CRAFT";
            this.lblRepAccel.Text = "ACCEL";
            // 
            // lblRepSpeed
            // 
            this.lblRepSpeed.AutoSize = true;
            this.lblRepSpeed.Location = new System.Drawing.Point(188, 42);
            this.lblRepSpeed.Name = "lblRepSpeed";
            this.lblRepSpeed.Size = new System.Drawing.Size(40, 15);
            this.lblRepSpeed.TabIndex = 17;
            this.lblRepSpeed.Tag = "CRAFT";
            this.lblRepSpeed.Text = "SPEED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 16;
            this.label2.Tag = "CRAFT";
            this.label2.Text = "DISTANCERATIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 14;
            this.label3.Tag = "CRAFT";
            this.label3.Text = "MAXSPEED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 12;
            this.label4.Tag = "CRAFT";
            this.label4.Text = "ACCEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 10;
            this.label5.Tag = "CRAFT";
            this.label5.Text = "SPEED";
            // 
            // labelInc
            // 
            this.labelInc.AutoSize = true;
            this.labelInc.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInc.ForeColor = System.Drawing.Color.Green;
            this.labelInc.Location = new System.Drawing.Point(4, 4);
            this.labelInc.Name = "labelInc";
            this.labelInc.Size = new System.Drawing.Size(123, 25);
            this.labelInc.TabIndex = 0;
            this.labelInc.Text = "Incoming";
            // 
            // tbDistRatio
            // 
            this.tbDistRatio.Location = new System.Drawing.Point(110, 142);
            this.tbDistRatio.Name = "tbDistRatio";
            this.tbDistRatio.Size = new System.Drawing.Size(100, 23);
            this.tbDistRatio.TabIndex = 9;
            this.tbDistRatio.Tag = "CRAFT";
            // 
            // lblDistRatio
            // 
            this.lblDistRatio.AutoSize = true;
            this.lblDistRatio.Location = new System.Drawing.Point(3, 145);
            this.lblDistRatio.Name = "lblDistRatio";
            this.lblDistRatio.Size = new System.Drawing.Size(92, 15);
            this.lblDistRatio.TabIndex = 8;
            this.lblDistRatio.Tag = "CRAFT";
            this.lblDistRatio.Text = "DISTANCERATIO";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(110, 111);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 23);
            this.tbMax.TabIndex = 7;
            this.tbMax.Tag = "CRAFT";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(19, 114);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(66, 15);
            this.lblMax.TabIndex = 6;
            this.lblMax.Tag = "CRAFT";
            this.lblMax.Text = "MAXSPEED";
            // 
            // tbAccel
            // 
            this.tbAccel.Location = new System.Drawing.Point(110, 77);
            this.tbAccel.Name = "tbAccel";
            this.tbAccel.Size = new System.Drawing.Size(100, 23);
            this.tbAccel.TabIndex = 5;
            this.tbAccel.Tag = "CRAFT";
            // 
            // lblAccel
            // 
            this.lblAccel.AutoSize = true;
            this.lblAccel.Location = new System.Drawing.Point(26, 80);
            this.lblAccel.Name = "lblAccel";
            this.lblAccel.Size = new System.Drawing.Size(43, 15);
            this.lblAccel.TabIndex = 4;
            this.lblAccel.Tag = "CRAFT";
            this.lblAccel.Text = "ACCEL";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(110, 42);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(100, 23);
            this.tbSpeed.TabIndex = 3;
            this.tbSpeed.Tag = "CRAFT";
            // 
            // lblSPEED
            // 
            this.lblSPEED.AutoSize = true;
            this.lblSPEED.Location = new System.Drawing.Point(29, 45);
            this.lblSPEED.Name = "lblSPEED";
            this.lblSPEED.Size = new System.Drawing.Size(40, 15);
            this.lblSPEED.TabIndex = 2;
            this.lblSPEED.Tag = "CRAFT";
            this.lblSPEED.Text = "SPEED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Outgoing";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.StreamPanel);
            this.Controls.Add(this.IOPanel);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "CubeSat Communication";
            this.StreamPanel.ResumeLayout(false);
            this.StreamPanel.PerformLayout();
            this.InputPanel.ResumeLayout(false);
            this.ButtonArea.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel IOPanel;
        private System.Windows.Forms.Panel StreamPanel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel ButtonArea;
        private System.Windows.Forms.Label lblVers;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelInc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDataWindow;
        private System.Windows.Forms.Button bClearRXData;
        private System.Windows.Forms.Button bOpenComPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbComPort;
        private System.Windows.Forms.TextBox tbMessageToSend;
        private System.Windows.Forms.TextBox tbBaudRate;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label lblSPEED;
        private System.Windows.Forms.TextBox tbDistRatio;
        private System.Windows.Forms.Label lblDistRatio;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox tbAccel;
        private System.Windows.Forms.Label lblAccel;
        private System.Windows.Forms.Label lblRepDistRatio;
        private System.Windows.Forms.Label lblRepMax;
        private System.Windows.Forms.Label lblRepAccel;
        private System.Windows.Forms.Label lblRepSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRep;
    }
}

