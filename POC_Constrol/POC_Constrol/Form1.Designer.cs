namespace POC_Constrol
{
    partial class Total_control
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTestACEConnect = new System.Windows.Forms.Button();
            this.txtTestNowConnectionState = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMotorConnectionTest = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTestEndConnectionState = new System.Windows.Forms.TextBox();
            this.txtTestNowConnectionState2 = new System.Windows.Forms.TextBox();
            this.txtTestBeforeConnectionState = new System.Windows.Forms.TextBox();
            this.txtTestPort = new System.Windows.Forms.TextBox();
            this.txtTestIP = new System.Windows.Forms.TextBox();
            this.txtTestID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestCommandSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTestGPIBID = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGPIBConnectionTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestGPIBPortName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.txtTestNowConnectionState.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.groupBox2);
            this.TabPage1.Controls.Add(this.txtTestNowConnectionState);
            this.TabPage1.Controls.Add(this.groupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(768, 400);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Test";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTestACEConnect);
            this.groupBox2.Location = new System.Drawing.Point(479, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 367);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACE Control Test";
            // 
            // btnTestACEConnect
            // 
            this.btnTestACEConnect.Location = new System.Drawing.Point(7, 168);
            this.btnTestACEConnect.Name = "btnTestACEConnect";
            this.btnTestACEConnect.Size = new System.Drawing.Size(257, 23);
            this.btnTestACEConnect.TabIndex = 0;
            this.btnTestACEConnect.Text = "ACE 프로그램 연결";
            this.btnTestACEConnect.UseVisualStyleBackColor = true;
            this.btnTestACEConnect.Click += new System.EventHandler(this.btnTestACEConnect_Click);
            // 
            // txtTestNowConnectionState
            // 
            this.txtTestNowConnectionState.Controls.Add(this.label13);
            this.txtTestNowConnectionState.Controls.Add(this.label12);
            this.txtTestNowConnectionState.Controls.Add(this.label11);
            this.txtTestNowConnectionState.Controls.Add(this.btnMotorConnectionTest);
            this.txtTestNowConnectionState.Controls.Add(this.label10);
            this.txtTestNowConnectionState.Controls.Add(this.label9);
            this.txtTestNowConnectionState.Controls.Add(this.label8);
            this.txtTestNowConnectionState.Controls.Add(this.label7);
            this.txtTestNowConnectionState.Controls.Add(this.label6);
            this.txtTestNowConnectionState.Controls.Add(this.label5);
            this.txtTestNowConnectionState.Controls.Add(this.txtTestEndConnectionState);
            this.txtTestNowConnectionState.Controls.Add(this.txtTestNowConnectionState2);
            this.txtTestNowConnectionState.Controls.Add(this.txtTestBeforeConnectionState);
            this.txtTestNowConnectionState.Controls.Add(this.txtTestPort);
            this.txtTestNowConnectionState.Controls.Add(this.txtTestIP);
            this.txtTestNowConnectionState.Controls.Add(this.txtTestID);
            this.txtTestNowConnectionState.Location = new System.Drawing.Point(266, 17);
            this.txtTestNowConnectionState.Name = "txtTestNowConnectionState";
            this.txtTestNowConnectionState.Size = new System.Drawing.Size(206, 367);
            this.txtTestNowConnectionState.TabIndex = 4;
            this.txtTestNowConnectionState.TabStop = false;
            this.txtTestNowConnectionState.Text = "Motor Control Test";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(113, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "-1- 이상 없음 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "0 - 이상 없음 ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(113, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "0 - 이상 없음 ";
            // 
            // btnMotorConnectionTest
            // 
            this.btnMotorConnectionTest.Location = new System.Drawing.Point(121, 31);
            this.btnMotorConnectionTest.Name = "btnMotorConnectionTest";
            this.btnMotorConnectionTest.Size = new System.Drawing.Size(75, 117);
            this.btnMotorConnectionTest.TabIndex = 12;
            this.btnMotorConnectionTest.Text = "연결 확인";
            this.btnMotorConnectionTest.UseVisualStyleBackColor = true;
            this.btnMotorConnectionTest.Click += new System.EventHandler(this.btnMotorConnectionTest_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "연결 종료 확인";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "현재 연결 상태";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "이전 연결 상태";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "PORT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID";
            // 
            // txtTestEndConnectionState
            // 
            this.txtTestEndConnectionState.Location = new System.Drawing.Point(7, 262);
            this.txtTestEndConnectionState.Name = "txtTestEndConnectionState";
            this.txtTestEndConnectionState.Size = new System.Drawing.Size(100, 21);
            this.txtTestEndConnectionState.TabIndex = 5;
            // 
            // txtTestNowConnectionState2
            // 
            this.txtTestNowConnectionState2.Location = new System.Drawing.Point(7, 222);
            this.txtTestNowConnectionState2.Name = "txtTestNowConnectionState2";
            this.txtTestNowConnectionState2.Size = new System.Drawing.Size(100, 21);
            this.txtTestNowConnectionState2.TabIndex = 4;
            // 
            // txtTestBeforeConnectionState
            // 
            this.txtTestBeforeConnectionState.Location = new System.Drawing.Point(7, 177);
            this.txtTestBeforeConnectionState.Name = "txtTestBeforeConnectionState";
            this.txtTestBeforeConnectionState.Size = new System.Drawing.Size(100, 21);
            this.txtTestBeforeConnectionState.TabIndex = 3;
            // 
            // txtTestPort
            // 
            this.txtTestPort.Location = new System.Drawing.Point(7, 125);
            this.txtTestPort.Name = "txtTestPort";
            this.txtTestPort.Size = new System.Drawing.Size(100, 21);
            this.txtTestPort.TabIndex = 2;
            // 
            // txtTestIP
            // 
            this.txtTestIP.Location = new System.Drawing.Point(7, 78);
            this.txtTestIP.Name = "txtTestIP";
            this.txtTestIP.Size = new System.Drawing.Size(100, 21);
            this.txtTestIP.TabIndex = 1;
            // 
            // txtTestID
            // 
            this.txtTestID.Location = new System.Drawing.Point(7, 31);
            this.txtTestID.Name = "txtTestID";
            this.txtTestID.Size = new System.Drawing.Size(100, 21);
            this.txtTestID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTestCommandSend);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTestGPIBID);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGPIBConnectionTest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTestGPIBPortName);
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 367);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPIB Test";
            // 
            // btnTestCommandSend
            // 
            this.btnTestCommandSend.Location = new System.Drawing.Point(9, 204);
            this.btnTestCommandSend.Name = "btnTestCommandSend";
            this.btnTestCommandSend.Size = new System.Drawing.Size(231, 23);
            this.btnTestCommandSend.TabIndex = 10;
            this.btnTestCommandSend.Text = "명령어 전송";
            this.btnTestCommandSend.UseVisualStyleBackColor = true;
            this.btnTestCommandSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "장비 ID";
            // 
            // txtTestGPIBID
            // 
            this.txtTestGPIBID.Location = new System.Drawing.Point(9, 112);
            this.txtTestGPIBID.Name = "txtTestGPIBID";
            this.txtTestGPIBID.Size = new System.Drawing.Size(231, 21);
            this.txtTestGPIBID.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 329);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 21);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 21);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "SCPI 명령어 전송(리턴 있는 경우)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "SCPI 명령어 전송(리턴 없는 경우)";
            // 
            // btnGPIBConnectionTest
            // 
            this.btnGPIBConnectionTest.Location = new System.Drawing.Point(9, 59);
            this.btnGPIBConnectionTest.Name = "btnGPIBConnectionTest";
            this.btnGPIBConnectionTest.Size = new System.Drawing.Size(75, 23);
            this.btnGPIBConnectionTest.TabIndex = 3;
            this.btnGPIBConnectionTest.Text = "연결 Test";
            this.btnGPIBConnectionTest.UseVisualStyleBackColor = true;
            this.btnGPIBConnectionTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "GPIB Port Name";
            // 
            // txtTestGPIBPortName
            // 
            this.txtTestGPIBPortName.Location = new System.Drawing.Point(9, 32);
            this.txtTestGPIBPortName.Name = "txtTestGPIBPortName";
            this.txtTestGPIBPortName.Size = new System.Drawing.Size(231, 21);
            this.txtTestGPIBPortName.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(684, 440);
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(100, 21);
            this.txtDebug.TabIndex = 1;
            // 
            // Total_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.tabControl1);
            this.Name = "Total_control";
            this.Text = "POC Control";
            this.Load += new System.EventHandler(this.Total_control_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.txtTestNowConnectionState.ResumeLayout(false);
            this.txtTestNowConnectionState.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGPIBConnectionTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestGPIBPortName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTestGPIBID;
        private System.Windows.Forms.Button btnTestCommandSend;
        private System.Windows.Forms.GroupBox txtTestNowConnectionState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTestEndConnectionState;
        private System.Windows.Forms.TextBox txtTestNowConnectionState2;
        private System.Windows.Forms.TextBox txtTestBeforeConnectionState;
        private System.Windows.Forms.TextBox txtTestPort;
        private System.Windows.Forms.TextBox txtTestIP;
        private System.Windows.Forms.TextBox txtTestID;
        private System.Windows.Forms.Button btnMotorConnectionTest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTestACEConnect;
        private System.Windows.Forms.TextBox txtDebug;
    }
}

