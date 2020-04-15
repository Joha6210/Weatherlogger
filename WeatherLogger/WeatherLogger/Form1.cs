using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Windows.Forms;

namespace WeatherLogger
{


    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        private GlobalVars gv;
        bool databaseIsConnected = false;
        public delegate void UpdateListboxData();

        private string connType = "database";

        string httpType = "http";
        string databaseType = "database";

        bool isLoggingEnabled = false;

        bool UpData = false;

        public Form1()
        {
            InitializeComponent();

            comboBox_ConnType.Items.Add(databaseType);
            comboBox_ConnType.Items.Add(httpType);

            isLoggingEnabled = checkBox_Logging.Checked;

            _serialPort = new SerialPort();

            String[] serialPorts = SerialPort.GetPortNames();

            for (int i = 0; i < serialPorts.Length; i++)
            {
                comboBox_SerialPort.Items.Add(serialPorts[i]);
            }


            String[] baudRates = { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200" };

            for (int i = 0; i < baudRates.Length; i++)
            {
                comboBox_Baudrate.Items.Add(baudRates[i]);
            }

            comboBox_Baudrate.SelectedIndex = comboBox_Baudrate.Items.IndexOf("115200");

        }


        private void buttonPortConnect_Click(object sender, EventArgs e)
        {


            if (!_serialPort.IsOpen)
            {
                // Allow the user to set the appropriate properties.
                _serialPort.PortName = (string)comboBox_SerialPort.SelectedItem;
                _serialPort.BaudRate = int.Parse(comboBox_Baudrate.SelectedItem.ToString());
                _serialPort.Parity = Parity.None;
                _serialPort.DataBits = 8;
                _serialPort.StopBits = StopBits.One;
                _serialPort.Handshake = Handshake.None;

                // Set the read/write timeouts
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;

                try
                {
                    _serialPort.Open();
                    _serialPort.DataReceived += serialPort1_DataReceived;

                    button_Click.Text = "Close Port";
                    label_Status.Text = "Open";
                    WriteConsole("Serial port opened", true);
                }
                catch (Exception exc)
                {
                    WriteConsole(exc.Message, true);
                }



            }
            else
            {
                try
                {
                    _serialPort.Close();
                    button_Click.Text = "Open Port";
                    label_Status.Text = "Closed";
                    WriteConsole("Serial port closed", true);
                }
                catch (Exception exc)
                {
                    WriteConsole(exc.Message, true);
                }


            }



        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            if (listBox_data.InvokeRequired)
                listBox_data.Invoke(new myDelegate(updateTextBox));

        }
        public delegate void myDelegate();

        public void updateTextBox()
        {
            string message;

            message = _serialPort.ReadLine();
            string[] data = message.Split(',');

            if (data.Length>2)
            {
                String listboxData = "ID: " + data[0] + " Temperatur: " + data[1] + " Humidity: " + data[2];
                WriteConsole(listboxData, false);
                if (UpData == true)
                {
                    UploadData(data);
                }
            }
           

        }

        //Source: 
        //https://www.youtube.com/watch?v=EPSjxg4Rzs8
        async public void UploadData(string[] weatherData)
        {
            if (connType == httpType)
            {
                IEnumerable<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("temp",weatherData[1]),
                new KeyValuePair<string, string>("hum", weatherData[2])
            };

                HttpContent q = new FormUrlEncodedContent(data);
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.PostAsync(textBox_URL.Text, q))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string myContent = await content.ReadAsStringAsync();
                            HttpContentHeaders headers = content.Headers;
                            WriteConsole(myContent, true);
                        }
                    }
                }
            }
            if (connType == databaseType)
            {
                if (gv.MyDBConnection.State == ConnectionState.Open)
                {
                    string query = "INSERT INTO " + textBox_tableName.Text + " (temperature, airhumidity) VALUES (" + weatherData[1] + "," + weatherData[2] + ")";
                    var cmd = new MySqlCommand(query, gv.MyDBConnection);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    WriteConsole("Data uploaded. Rows affected: " + rowsAffected, true);
                }
            }





        }

        /// <summary>
        /// Writes to the console in the correct format
        /// </summary>
        /// <param name="message">The message to write</param>
        /// <param name="log">should it only be written when loggin is enabled</param>
        private void WriteConsole(string message, bool log)
        {
            if (log == false)
            {
                string update = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "-->  " + message;
                listBox_data.Items.Add(update);
            }
            else if (log == true && isLoggingEnabled == true)
            {
                string update = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "-->  " + message;
                listBox_data.Items.Add(update);
            }

        }

        private void buttonDBConnect_Click(object sender, EventArgs e)
        {
            gv = new GlobalVars();
            // Sslmode = none to make sure we can connect to the server without SSL failure.
            string sql = "Server=" + textBox_ServerName.Text + ";Port=3306;Sslmode=none;User Id=" + textBox_Username.Text;
            sql += ";Password=" + textBox_Password.Text + ";Database=" + textBox_Database.Text;

            gv.MyDBConnection = new MySqlConnection(sql);

            if (databaseIsConnected == false)
            {
                // Connect to the DB, and throw the error if a failure occur.
                try
                {
                    gv.MyDBConnection.Open();
                    labelDBStatus.Text = "Connected";
                    buttonDBConnect.Text = "Disconnect";
                    checkBox_UpData1.Enabled = true;
                    databaseIsConnected = true;
                    WriteConsole("Connection to database established", true);
                }
                catch (MySqlException exc)
                {
                    WriteConsole("Could not connect to database: " + exc.Message, true);
                }
            }
            else
            {
                gv.MyDBConnection.Close();
                labelDBStatus.Text = "Disconnected";
                buttonDBConnect.Text = "Connect";
                checkBox_UpData1.Enabled = false;
                databaseIsConnected = false;
                WriteConsole("Connection to database disconnected", true);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gv != null)
            {
                if (gv.MyDBConnection.State == ConnectionState.Open)
                {
                    gv.MyDBConnection.Close();
                }
            }

            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listBox_data.Items.Clear();
        }

        private void comboBox_SerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Click.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Logging.CheckState == CheckState.Checked)
            {
                isLoggingEnabled = true;
            }
            else
            {
                isLoggingEnabled = false;
            }
        }

        private void comboBox_ConnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ConnType.SelectedItem.ToString() == databaseType)
            {
                connType = databaseType;
                groupBox_database.Visible = true;
                groupBox_http.Visible = false;
                groupBox_database.BringToFront();
                groupBox_http.SendToBack();
            }
            if (comboBox_ConnType.SelectedItem.ToString() == httpType)
            {
                connType = httpType;
                groupBox_database.Visible = false;
                groupBox_http.Visible = true;
                groupBox_http.BringToFront();
                groupBox_database.SendToBack();
            }
        }

        private void CheckUpDateChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;

            UpData = currentCheckBox.Checked;
        }
    }
}
