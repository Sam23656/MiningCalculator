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
        int number2 = 1;

        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
      private void button3_Click(object sender, EventArgs e)
        {
            number2++;
            label2.Text = number2.ToString();
            if (number2 < 1)
            {
                number2 = 1;
                label2.Text = number2.ToString();
            }
        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            number2--;
            label2.Text = number2.ToString();
            if (number2 < 1)
            {
                number2 = 1;
                label2.Text = number2.ToString();
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
            string sql;
            connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=D:\C#\MiningCalculator\MiningCalculator\Database1.mdf";
            connection = new SqlConnection(connectionString);
            
            if(comboBox1.SelectedIndex == 0)
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
            if (comboBox1.SelectedIndex == 1)
            {
                connection.Open();
                sql = "Select * from Devices where id = 2";
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
            if (comboBox1.SelectedIndex == 2)
            {
                connection.Open();
                sql = "Select * from Devices where id = 3";
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
            if (comboBox1.SelectedIndex == 3)
            {
                connection.Open();
                sql = "Select * from Devices where id = 4";
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
            if (comboBox1.SelectedIndex == 4)
            {
                connection.Open();
                sql = "Select * from Devices where id = 5";
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
            if (comboBox1.SelectedIndex == 5)
            {
                connection.Open();
                sql = "Select * from Devices where id = 6";
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
            if (comboBox1.SelectedIndex == 6)
            {
                connection.Open();
                sql = "Select * from Devices where id = 7";
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
            if (comboBox1.SelectedIndex == 7)
            {
                connection.Open();
                sql = "Select * from Devices where id = 8";
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
            if (comboBox1.SelectedIndex == 8)
            {
                connection.Open();
                sql = "Select * from Devices where id = 9";
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
            if (comboBox1.SelectedIndex == 9)
            {
                connection.Open();
                sql = "Select * from Devices where id = 10";
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
            if (comboBox2.SelectedIndex == 0)
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
            if (comboBox2.SelectedIndex == 1)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 2";
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
            if (comboBox2.SelectedIndex == 2)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 3";
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
            if (comboBox2.SelectedIndex == 3)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 4";
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
            if (comboBox2.SelectedIndex == 4)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 5";
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
            if (comboBox2.SelectedIndex == 5)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 6";
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
            if (comboBox2.SelectedIndex == 6)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 7";
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
            if (comboBox2.SelectedIndex == 7)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 8";
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
            if (comboBox2.SelectedIndex == 8)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 9";
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
            if (comboBox2.SelectedIndex == 9)
            {
                connection.Open();
                sql = "Select * from Cpu where id = 10";
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

            double Numb = Convert.ToDouble(label1.Text);
            double Numb2 = Convert.ToDouble(label2.Text);

            double El1 = 0;
            double Ear1 = 0;
            double El2 = 0;
            double Ear2 = 0;

            double ElectrInput = 0;
            if (textBox1.Text != "")
            {
                ElectrInput = Convert.ToDouble(textBox1.Text);

            }
            if (comboBox1.SelectedIndex >= 0)
            {

             El1 = Numb * Convert.ToDouble(ElectricityСonsumption1); 
             Ear1 = Numb * Convert.ToDouble(Earnings1);
                
            }
              if(comboBox2.SelectedIndex >= 0)
            {

                El2 = Numb2 * Convert.ToDouble(ElectricityСonsumption2);
                Ear2 = Numb2 * Convert.ToDouble(Earnings2);
                
            }

            if (Ear1 != default && Ear2 != default)
            {
                double ObEar = Ear1 + Ear2;
                double day = ObEar * 24;
                double month = day * 31;
                double year = month * 12;
                label23.Text = year.ToString();
                label20.Text = month.ToString();
                label12.Text = ObEar.ToString();
                label17.Text = day.ToString();
            }
            if(Ear1 == default)
            {
                double day = Ear2 * 24;
                double month = day * 31;
                double year = month * 12;
                label23.Text = year.ToString();
                label20.Text = month.ToString();
                label17.Text = day.ToString();
                label12.Text = Ear2.ToString();
            }
            if (Ear2 == default)
            {
                double day = Ear1 * 24;
                double month = day * 31;
                double year = month * 12;
                label23.Text = year.ToString();
                label20.Text = month.ToString();
                label17.Text = day.ToString();
                label12.Text = Ear1.ToString();
            }


            if (El1 != default && El2 != default)
            {
                
                double ObEar = (El1 + El2) * ElectrInput;
                double day = ObEar * 24;
                double month = day * 31;
                double year = month * 12;
                label22.Text = year.ToString();
                label19.Text = month.ToString();
                label16.Text = day.ToString();
                label13.Text = ObEar.ToString();
            }
            if (El1 == default)
            {
                double ObEar = El2 * ElectrInput;
                double day = ObEar * 24;
                double month = day * 31;
                double year = month * 12;
                label22.Text = year.ToString();
                label19.Text = month.ToString();
                label16.Text = day.ToString();
                label13.Text = ObEar.ToString();
            }
            if (El2 == default)
            {
                double ObEar = El1 * ElectrInput;
                double day = ObEar * 24;
                double month = day * 31;
                double year = month * 12;
                label22.Text = year.ToString();
                label19.Text = month.ToString();
                label16.Text = day.ToString();
                label13.Text = ObEar.ToString();
            }


            if (Ear1 != default && Ear2 != default && El1 != default && El2 != default)
            {
                double ObEar = (Ear1 + Ear2)-((El1 + El2)*ElectrInput);
                double day = ObEar * 24;
                double month = day * 31;
                double year = month * 12;
                label21.Text = year.ToString();
                label18.Text = month.ToString();
                label15.Text = day.ToString();
                label14.Text = ObEar.ToString();
            }
            if (El1 == default || Ear1 == default)
            { 
                double ObEar = Ear2 - (El2*ElectrInput);
                double day = ObEar * 24;
                double month = day * 31;
                double year = month * 12;
                label21.Text = year.ToString();
                label18.Text = month.ToString();
                label15.Text = day.ToString();
                label14.Text = ObEar.ToString();
            }
            if (El2 == default || Ear2 == default)
            {
                double ObEar = Ear1-(El1* ElectrInput);
                double day = ObEar * 24;
                double month = day * 31;
                double year = month * 12;
                label21.Text = year.ToString();
                label18.Text = month.ToString();
                label15.Text = day.ToString();
                label14.Text = ObEar.ToString();
            }

        }

       
    }
}
