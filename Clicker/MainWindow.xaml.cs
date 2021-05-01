using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using FirebirdSql.Data.Client;
using System.ComponentModel;
using Clicker.Models;

namespace Clicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<ClickerModel> _clickerData;
        long value;
        int day;
        int mounth;
        int year;
        int i, d;
        string x,c,jk,g,h;
        int count = 1,count1 = 1;
        long money;
        long Cmoney = 50;
        long C1money = 100;
        long C2money = 150;
        int Tolevel = 100;
        int level;
        public MainWindow()
        {
          
            InitializeComponent();
            txtValue.Text = value.ToString() + "/" + Tolevel.ToString();
            LevelS.Text = "Level: " + level.ToString();
            Money.Text = "Money: " + money.ToString();
            Button1.Content = "+1 к кликам: " + Cmoney.ToString();
            Button2.Content = "+1 к монетам: " + C1money.ToString();
            Button3.Content = "+1/sec к монетам: " + C2money.ToString();
            Day.Text = "День: " + day.ToString();
            XZ.Text = "Enter Your name: " + x;
            x = Enterd.Text;
            Ser.Text = x;

        }

        //Прибавляем
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            value += 1;
            money += 1;
            if(count != 1)
            {
                value += i;
            }
            if(count1 != 1)
            {
                money += d;
            }
            UpdateTextbox();
        }
        
      
        private void UpdateTextbox()
        {
            
            txtValue.Text = value.ToString() + "/" + Tolevel.ToString();
            LevelS.Text = "Level: " + level.ToString();
            Money.Text = "Money: " + money.ToString();
            ProgressBear.Value = value;
            if (value == Tolevel || value > Tolevel)
            {
                ProgressBear.Maximum *= 2;
                level++;
                switch (level)
                {
                    case 1:
                Rank1.Visibility = Visibility.Collapsed;
                Rank2.Visibility = Visibility.Visible;
                    break;
                    case 2:
                        Rank2.Visibility = Visibility.Collapsed;
                        Rank3.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        Rank3.Visibility = Visibility.Collapsed;
                        Rank4.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        Rank4.Visibility = Visibility.Collapsed;
                        Rank5.Visibility = Visibility.Visible;
                        Button3.IsEnabled = true;
                        break;
                    case 5:
                        Rank5.Visibility = Visibility.Collapsed;
                        Rank6.Visibility = Visibility.Visible;
                        break;
                    case 6:
                        Rank6.Visibility = Visibility.Collapsed;
                        Rank7.Visibility = Visibility.Visible;
                        break;
                    case 7:
                        Rank7.Visibility = Visibility.Collapsed;
                        Rank8.Visibility = Visibility.Visible;
                        break;
                    case 8:
                        Rank8.Visibility = Visibility.Collapsed;
                        Rank9.Visibility = Visibility.Visible;
                        break;
                    case 9:
                        Rank9.Visibility = Visibility.Collapsed;
                        Rank10.Visibility = Visibility.Visible;
                        break;
                    case 10:
                        Rank10.Visibility = Visibility.Collapsed;
                        Rank11.Visibility = Visibility.Visible;
                        break;
                }
                Tolevel *= 2;
                value = 0;
                MessageBox.Show("Level Up!");

            }
            
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
          
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (money < C2money)
            {
                MessageBox.Show("Недостаточно монет!");
            }
            else
            {
                
                money -= C2money;
                C2money *= 2;
                Button3.Content = "+1/sec к монетам: " + C2money.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _clickerData = new BindingList<ClickerModel>()
            {
                new ClickerModel(){Value = value },
                new ClickerModel(){Level = level }

            };
            
        }

        private void Enterd_TextChanged(object sender, TextChangedEventArgs e)
        {

            //x = Enterd.Text;
            Ser.Text = x;
        }

        private void Enterd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                XZ.Text = "Enter Your name: " + x;
                Ser.Text = x;
                XZ.Text = x;
               
               
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if(money < Cmoney)
            {
                MessageBox.Show("Недостаточно монет!");
            }
            else
            {
                count++;
                i++;
                money -= Cmoney;
                Cmoney *= 2;
                Button1.Content = "+1 к кликам: " + Cmoney.ToString();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (money < C1money)
            {
                MessageBox.Show("Недостаточно монет!");
            }
            else
            {
                count1++;
                d++;
                money -= C1money;
                C1money *= 2;
                Button2.Content = "+1 к монетам: " + C1money.ToString();
            }
        }

        
    }
}
