using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie3
{
    public partial class Form1 : Form
    {
        Dictionary<string, ChainOfMarkets> chains = new Dictionary<string, ChainOfMarkets>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addNewChainButton_Click(object sender, EventArgs e)
        {
            if (nameOfChainTextBox.Text.Length <= 1) 
            {
                MessageBox.Show("Длина названия сети должна быть от двух символов");
                return;
            }
            if (!CheckNumber(countOfSalesTextBox.Text, "Количество продаж")||!CheckNumber(monthlyRevenueTextBox.Text,"Выручка за месяц"))
            {
                return;
            }
            if (!CheckField("Фамилия директора",ownerSurnameTextBox.Text))
            {
                MessageBox.Show("Длина фамилии владельца сети должна быть от двух символов");
                return;
            }
            chains.Add(nameOfChainTextBox.Text, new ChainOfMarkets(int.Parse(countOfSalesTextBox.Text), int.Parse(monthlyRevenueTextBox.Text),
                nameOfChainTextBox.Text, ownerSurnameTextBox.Text));
            UpdateComboBox();
        }
        private bool CheckNumber(string num,string field)
        {
            try
            {
                int number = int.Parse(num);
                if (number <= 0)
                {
                    throw new Exception($"Поле {field} должно быть больше 0 ");                    
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void UpdateComboBox()
        {
            chainsOfMarketsComboBox.Items.Clear();
            foreach(KeyValuePair<string,ChainOfMarkets> item in chains)
            {
                chainsOfMarketsComboBox.Items.Add(item.Key);
            }
        }
        private bool CheckField(string field,string value) 
        {
            if(field.Length== 0)
            {
                MessageBox.Show($"Поле {field} не может быть пустым");
                return false;
            }
            foreach(char i in value)
            {
                if (!Char.IsLetter(i))
                {
                    MessageBox.Show($"Поле {field} может содержать только буквы");
                    return false;
                }
            }
            return true;
        }
    }
}
