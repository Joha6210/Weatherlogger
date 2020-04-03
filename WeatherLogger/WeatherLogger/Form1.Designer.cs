namespace WeatherLogger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Baudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SerialPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxUpData = new System.Windows.Forms.CheckBox();
            this.textBox_HttpUrl = new System.Windows.Forms.TextBox();
            this.textBox_Database = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDBStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDBConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_data = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_Logging = new System.Windows.Forms.CheckBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_Click);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Baudrate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_SerialPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Connection";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(53, 141);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(39, 13);
            this.label_Status.TabIndex = 7;
            this.label_Status.Text = "Closed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // button_Click
            // 
            this.button_Click.Enabled = false;
            this.button_Click.Location = new System.Drawing.Point(6, 115);
            this.button_Click.Name = "button_Click";
            this.button_Click.Size = new System.Drawing.Size(213, 23);
            this.button_Click.TabIndex = 5;
            this.button_Click.Text = "Open Port";
            this.button_Click.UseVisualStyleBackColor = true;
            this.button_Click.Click += new System.EventHandler(this.buttonPortConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baudrate:";
            // 
            // comboBox_Baudrate
            // 
            this.comboBox_Baudrate.FormattingEnabled = true;
            this.comboBox_Baudrate.Location = new System.Drawing.Point(6, 79);
            this.comboBox_Baudrate.Name = "comboBox_Baudrate";
            this.comboBox_Baudrate.Size = new System.Drawing.Size(213, 21);
            this.comboBox_Baudrate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serial Port:";
            // 
            // comboBox_SerialPort
            // 
            this.comboBox_SerialPort.FormattingEnabled = true;
            this.comboBox_SerialPort.Location = new System.Drawing.Point(6, 39);
            this.comboBox_SerialPort.Name = "comboBox_SerialPort";
            this.comboBox_SerialPort.Size = new System.Drawing.Size(213, 21);
            this.comboBox_SerialPort.TabIndex = 1;
            this.comboBox_SerialPort.SelectedIndexChanged += new System.EventHandler(this.comboBox_SerialPort_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxUpData);
            this.groupBox2.Controls.Add(this.textBox_HttpUrl);
            this.groupBox2.Controls.Add(this.textBox_Database);
            this.groupBox2.Controls.Add(this.textBox_Password);
            this.groupBox2.Controls.Add(this.textBox_Username);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelDBStatus);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonDBConnect);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 245);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Connection";
            // 
            // checkBoxUpData
            // 
            this.checkBoxUpData.AutoSize = true;
            this.checkBoxUpData.Location = new System.Drawing.Point(122, 225);
            this.checkBoxUpData.Name = "checkBoxUpData";
            this.checkBoxUpData.Size = new System.Drawing.Size(86, 17);
            this.checkBoxUpData.TabIndex = 14;
            this.checkBoxUpData.Text = "Upload Data";
            this.checkBoxUpData.UseVisualStyleBackColor = true;
            // 
            // textBox_HttpUrl
            // 
            this.textBox_HttpUrl.Location = new System.Drawing.Point(6, 39);
            this.textBox_HttpUrl.Name = "textBox_HttpUrl";
            this.textBox_HttpUrl.Size = new System.Drawing.Size(210, 20);
            this.textBox_HttpUrl.TabIndex = 13;
            this.textBox_HttpUrl.Text = "http://www.projectweather.one/postrequest.php";
            // 
            // textBox_Database
            // 
            this.textBox_Database.Location = new System.Drawing.Point(6, 79);
            this.textBox_Database.Name = "textBox_Database";
            this.textBox_Database.Size = new System.Drawing.Size(210, 20);
            this.textBox_Database.TabIndex = 12;
            this.textBox_Database.Text = "projectweather_oneweatherdata";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(6, 168);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(210, 20);
            this.textBox_Password.TabIndex = 11;
            this.textBox_Password.Text = "X0y7*rm1R";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(6, 126);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(210, 20);
            this.textBox_Username.TabIndex = 10;
            this.textBox_Username.Text = "projectweather_oneweatherdata";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Username:";
            // 
            // labelDBStatus
            // 
            this.labelDBStatus.AutoSize = true;
            this.labelDBStatus.Location = new System.Drawing.Point(43, 225);
            this.labelDBStatus.Name = "labelDBStatus";
            this.labelDBStatus.Size = new System.Drawing.Size(73, 13);
            this.labelDBStatus.TabIndex = 7;
            this.labelDBStatus.Text = "Disconnected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status:";
            // 
            // buttonDBConnect
            // 
            this.buttonDBConnect.Location = new System.Drawing.Point(6, 199);
            this.buttonDBConnect.Name = "buttonDBConnect";
            this.buttonDBConnect.Size = new System.Drawing.Size(210, 23);
            this.buttonDBConnect.TabIndex = 5;
            this.buttonDBConnect.Text = "Connect";
            this.buttonDBConnect.UseVisualStyleBackColor = true;
            this.buttonDBConnect.Click += new System.EventHandler(this.buttonDBConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Database:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Url:";
            // 
            // listBox_data
            // 
            this.listBox_data.FormattingEnabled = true;
            this.listBox_data.Location = new System.Drawing.Point(6, 19);
            this.listBox_data.Name = "listBox_data";
            this.listBox_data.Size = new System.Drawing.Size(515, 368);
            this.listBox_data.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_Logging);
            this.groupBox3.Controls.Add(this.button_Clear);
            this.groupBox3.Controls.Add(this.listBox_data);
            this.groupBox3.Location = new System.Drawing.Point(241, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 425);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Console";
            // 
            // checkBox_Logging
            // 
            this.checkBox_Logging.AutoSize = true;
            this.checkBox_Logging.Location = new System.Drawing.Point(97, 397);
            this.checkBox_Logging.Name = "checkBox_Logging";
            this.checkBox_Logging.Size = new System.Drawing.Size(100, 17);
            this.checkBox_Logging.TabIndex = 11;
            this.checkBox_Logging.Text = "Enable Logging";
            this.checkBox_Logging.UseVisualStyleBackColor = true;
            this.checkBox_Logging.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(6, 393);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(85, 23);
            this.button_Clear.TabIndex = 10;
            this.button_Clear.Text = "Clear Console";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Weather Logger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Baudrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_SerialPort;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Click;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDBStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDBConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_HttpUrl;
        private System.Windows.Forms.TextBox textBox_Database;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.ListBox listBox_data;
        private System.Windows.Forms.CheckBox checkBoxUpData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.CheckBox checkBox_Logging;
    }
}

