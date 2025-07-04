using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace contlle
{
    public partial class RequestSolar : Form
    {
        public RequestSolar()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHome().Show();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\SlYA\\source\\repos\\contlle\\Database\\Icontrol.accdb");


       
        // Method to insert battery information
        private void InsertBatteryInfo(OleDbConnection con)
        {
            string bType = groupBox1.Text.Trim();
            if (string.IsNullOrEmpty(bType))
            {
                MessageBox.Show("Battery Type is required.");
                return;
            }

            if (!double.TryParse(textBox2.Text.Trim(), out double maxV) ||
                !double.TryParse(textBox3.Text.Trim(), out double minV) ||
                !double.TryParse(textBox4.Text.Trim(), out double bCurrent) ||
                !double.TryParse(textBox5.Text.Trim(), out double bVoltage))
            {
                MessageBox.Show("Invalid input values.");
                return;
            }

            string query = "INSERT INTO [Battery] ([BatteryType], [MaxVoltage], [MinVoltage], [BatteryCurrent], [BatteryVoltage]) VALUES (?, ?, ?, ?, ?)";

            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = bType;
                cmd.Parameters.Add("?", OleDbType.Double).Value = maxV;
                cmd.Parameters.Add("?", OleDbType.Double).Value = minV;
                cmd.Parameters.Add("?", OleDbType.Double).Value = bCurrent;
                cmd.Parameters.Add("?", OleDbType.Double).Value = bVoltage;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Battery information saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving battery information: " + ex.Message);
                }
            }
        }

        // Method to insert solar information
        private void InsertSolarInfo(OleDbConnection con)
        {
            string sType = groupBox2.Text.Trim();
            if (string.IsNullOrEmpty(sType))
            {
                MessageBox.Show("Solar Type is required.");
                return;
            }

            if (!double.TryParse(textBox1.Text.Trim(), out double sCurrent) ||
                !double.TryParse(textBox6.Text.Trim(), out double sVoltage) ||
                !double.TryParse(textBox4.Text.Trim(), out double sPower))
            {
                MessageBox.Show("Invalid input values.");
                return;
            }

            string squery = "INSERT INTO [Solar] ([SolarType], [SolarCurrent], [SolarVoltage], [SolarPower]) VALUES (?, ?, ?, ?)";

            using (OleDbCommand cmd = new OleDbCommand(squery, con))
            {
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = sType;
                cmd.Parameters.Add("?", OleDbType.Double).Value = sCurrent;
                cmd.Parameters.Add("?", OleDbType.Double).Value = sVoltage;
                cmd.Parameters.Add("?", OleDbType.Double).Value = sPower;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Solar information saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving solar information: " + ex.Message);
                }
            }
        }

        //inserting into inverter table 

        private void InsertInverterInfo(OleDbConnection con)
        {
          

            if (!double.TryParse(maskedTextBox1.Text.Trim(), out double iCurrent) ||
                !double.TryParse(maskedTextBox2.Text.Trim(), out double iVoltage) ||
                !double.TryParse(maskedTextBox3.Text.Trim(), out double iPower))
            {
                MessageBox.Show("Invalid input values.");
                return;
            }

            string iquery = "INSERT INTO [Inverter] ([Current], [Voltage], [Power]) VALUES (?, ?, ?)";

            using (OleDbCommand cmd = new OleDbCommand(iquery, con))
            {
               
                cmd.Parameters.Add("?", OleDbType.Double).Value = iCurrent;
                cmd.Parameters.Add("?", OleDbType.Double).Value = iVoltage;
                cmd.Parameters.Add("?", OleDbType.Double).Value = iPower;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inverter information saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving Inverter information: " + ex.Message);
                }
            }
        }

        // Inserting My House Information

        private void InsertMyHouseInfo(OleDbConnection con)
        {
            string sType = groupBox2.Text.Trim();
            if (string.IsNullOrEmpty(sType))
            {
                MessageBox.Show("Solar Type is required.");
                return;
            }

            if (!double.TryParse(textBox1.Text.Trim(), out double sCurrent) ||
                !double.TryParse(textBox6.Text.Trim(), out double sVoltage) ||
                !double.TryParse(textBox4.Text.Trim(), out double sPower))
            {
                MessageBox.Show("Invalid input values.");
                return;
            }

            string bType = groupBox1.Text.Trim();
            if (string.IsNullOrEmpty(bType))
            {
                MessageBox.Show("Battery Type is required.");
                return;
            }

            if (!double.TryParse(textBox2.Text.Trim(), out double maxV) ||
                !double.TryParse(textBox3.Text.Trim(), out double minV) ||
                !double.TryParse(textBox4.Text.Trim(), out double bCurrent) ||
                !double.TryParse(textBox5.Text.Trim(), out double bVoltage))
            {
                MessageBox.Show("Invalid input values.");
                return;
            }

            if (!double.TryParse(maskedTextBox1.Text.Trim(), out double iCurrent) ||
                !double.TryParse(maskedTextBox2.Text.Trim(), out double iVoltage) ||
                !double.TryParse(maskedTextBox3.Text.Trim(), out double iPower))
            {
                MessageBox.Show("Invalid input values.");
                return;
            }
            // Checking and validating email textbox
            string hName = textBox8.Text.Trim();
            if (string.IsNullOrEmpty(hName))
            {
                MessageBox.Show("Email field is required.");
                return;
            }
            try
            {
                var mail = new MailAddress(hName);

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid email address.");
            }

            string mquery = "INSERT INTO [MyHouse] ([HouseName],[BatteryType], [MaxVoltage], [MinVoltage], [BatteryCurrent], [BatteryVoltage],[SolarType], [SolarCurrent], [SolarVoltage], [SolarPower],[Current], [Voltage], [Power]) VALUES (?, ?, ?,?,?,?,?,?,?,?,?,?,?)";

          

            using (OleDbCommand cmd = new OleDbCommand(mquery, con))
            {
                cmd.Parameters.AddWithValue("?", hName);
                //cmd.Parameters.Add("?", OleDbType.VarWChar).Value = hName;
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = bType;
                cmd.Parameters.Add("?", OleDbType.Double).Value = maxV;
                cmd.Parameters.Add("?", OleDbType.Double).Value = minV;
                cmd.Parameters.Add("?", OleDbType.Double).Value = bCurrent;
                cmd.Parameters.Add("?", OleDbType.Double).Value = bVoltage;

                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = sType;
                cmd.Parameters.Add("?", OleDbType.Double).Value = sCurrent;
                cmd.Parameters.Add("?", OleDbType.Double).Value = sVoltage;
                cmd.Parameters.Add("?", OleDbType.Double).Value = sPower;

                cmd.Parameters.Add("?", OleDbType.Double).Value = iCurrent;
                cmd.Parameters.Add("?", OleDbType.Double).Value = iVoltage;
                cmd.Parameters.Add("?", OleDbType.Double).Value = iPower;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("My House information saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving Inverter information: " + ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            // Open the database connection once
            con.Open();

            // Insert Battery Information
            InsertBatteryInfo(con);

            // Insert Solar Information
            InsertSolarInfo(con);

            //Insert Inverter Information
            InsertInverterInfo(con);

            //Insert My House Information
            InsertMyHouseInfo(con);

            // Close the connection after all operations
            con.Close();

        }
    }
}
