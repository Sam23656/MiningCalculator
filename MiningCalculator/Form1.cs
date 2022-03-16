using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiningCalculator
{
    public partial class Form1 : Form
    {

        int number = 1;

        public Form1()
        {
            InitializeComponent();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            number++;
            label1.Text = number.ToString();
            if (number < 1)
            {
                number = 1;
                label1.Text = number.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number--;
            label1.Text = number.ToString();
            if (number < 1)
            {
                number = 1;
                label1.Text = number.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string VideoCards = "";
            string Cpu = "";
            string Earnings1 = "";
            string Earnings2 = "";
            string ElectricityСonsumption1 = "";
            string ElectricityСonsumption2 = "";
            
            string connectionString;
            SqlCommand command;
            SqlConnection connection;
            SqlDataReader dataReader;
            string sql, output = "";
            connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=D:\C#\MiningCalculator\MiningCalculator\Database1.mdf";
            connection = new SqlConnection(connectionString);
            
            if(comboBox1.SelectedIndex == 0 || comboBox2.SelectedIndex == 0)
            {
             connection.Open();
            sql = "Select * from Devices where id = 1";
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                VideoCards = dataReader[1].ToString();
                    Earnings1 = dataReader[2].ToString();
                    ElectricityСonsumption1 = dataReader[3].ToString();
                }
                connection.Close();
            }
            if (comboBox1.SelectedIndex == 10 || comboBox2.SelectedIndex == 10)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 1";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Cpu = dataReader[1].ToString();
                    Earnings2 = dataReader[2].ToString();
                    ElectricityСonsumption2 = dataReader[3].ToString();
                }
                connection.Close();
            }
            if (comboBox1.SelectedIndex == 2 || comboBox2.SelectedIndex == 2)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 1";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Cpu = dataReader[1].ToString();
                    Earnings2 = dataReader[2].ToString();
                    ElectricityСonsumption2 = dataReader[3].ToString();
                }
                connection.Close();
            }
            MessageBox.Show(Cpu);
            MessageBox.Show(Earnings2);
            MessageBox.Show(ElectricityСonsumption2);
            MessageBox.Show(VideoCards);
            MessageBox.Show(Earnings1);
            MessageBox.Show(ElectricityСonsumption1);
        }
    }
}
