﻿using System;
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

namespace pr8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void infoClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать интерфейс - человек. Создать классы - работник и работник-отец семейства.\r\n Классы должны включать конструкторы, функцию для формирования строки информации о работнике.\r\n Сравнение производить по фамилии.");
        }

        private void ExitCLick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void resultClick(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(tbchild.Text, out int a) == true & Int32.TryParse(tbname.Text, out a) != true & Int32.TryParse(tbsurname.Text, out a) != true)
            {
                string sex, name = tbname.Text, surname = tbsurname.Text, information;
               if(tb1.Text != "")
                {
                    if (Convert.ToInt32(tbchild.Text) == 0)
                    {
                        if (rbm.IsChecked == true)
                        {
                            worker work = new worker(name, surname, sex = "мужчина");
                            information = work.info();
                            tb2.Text = information;
                        }
                        else { worker work = new worker(name, surname, sex = "женщина"); information = work.info(); tb2.Text = information; }
                    }
                    else if (Convert.ToInt32(tbchild.Text) > 0)
                    {
                        int child = Convert.ToInt32(tbchild.Text);
                        if (rbm.IsChecked == true)
                        {
                            worker_dad worka = new worker_dad(name, surname, sex = "мужчина", child);
                            information = worka.dad_info();
                            tb2.Text = information;
                        }
                    }
               } 
                if (tb1.Text == "")
                {
                    if (Convert.ToInt32(tbchild.Text) == 0)
                    {
                        if (rbm.IsChecked == true)
                        {
                            worker work = new worker(name, surname, sex = "мужчина");
                            information = work.info();
                            tb1.Text = information;
                        }
                        else { worker work = new worker(name, surname, sex = "женщина"); information = work.info(); tb1.Text = information; }
                    }
                    else if (Convert.ToInt32(tbchild.Text) > 0)
                    {
                        int child = Convert.ToInt32(tbchild.Text);
                        if (rbm.IsChecked == true)
                        {
                            worker_dad worka = new worker_dad(name, surname, sex = "мужчина", child);
                            information = worka.dad_info();
                            tb1.Text = information;
                        }
                    }
                }
                
            }
        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tbchild.Text = "0";
            tbname.Text = "";
            tbsurname.Text = "";
        }

        private void CompareClick(object sender, RoutedEventArgs e)
        {
                        if (Int32.TryParse(tbchild.Text, out int a) == true & Int32.TryParse(tbname.Text, out a) != true & Int32.TryParse(tbsurname.Text, out a) != true)
            {
                string sex, name = tbname.Text, surname = tbsurname.Text, information;
               if(tb1.Text != "")
                {
                    if (Convert.ToInt32(tbchild.Text) == 0)
                    {
                        if (rbm.IsChecked == true)
                        {
                            worker work = new worker(name, surname, sex = "мужчина");
                            information = work.info();
                            tb2.Text = information;
                        }
                        else { worker work = new worker(name, surname, sex = "женщина"); information = work.info(); tb2.Text = information; }
                    }
                    else if (Convert.ToInt32(tbchild.Text) > 0)
                    {
                        int child = Convert.ToInt32(tbchild.Text);
                        if (rbm.IsChecked == true)
                        {
                            worker_dad worka = new worker_dad(name, surname, sex = "мужчина", child);
                            information = worka.dad_info();
                            tb2.Text = information;
                        }
                    }
               } 
                if (tb1.Text == "")
                {
                    if (Convert.ToInt32(tbchild.Text) == 0)
                    {
                        if (rbm.IsChecked == true)
                        {
                            worker work = new worker(name, surname, sex = "мужчина");
                            information = work.info();
                            tb1.Text = information;
                        }
                        else { worker work = new worker(name, surname, sex = "женщина"); information = work.info(); tb1.Text = information; }
                    }
                    else if (Convert.ToInt32(tbchild.Text) > 0)
                    {
                        int child = Convert.ToInt32(tbchild.Text);
                        if (rbm.IsChecked == true)
                        {
                            worker_dad worka = new worker_dad(name, surname, sex = "мужчина", child);
                            information = worka.dad_info();
                            tb1.Text = information;
                        }
                    }
                }
                
            }
        }
        private void can(object sender, EventArgs e)
        {
            if()
        }
        private void CloneClick(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(tbchild.Text, out int a) == true & Int32.TryParse(tbname.Text, out a) != true & Int32.TryParse(tbsurname.Text, out a) != true)
            {
                string sex, name = tbname.Text, surname = tbsurname.Text;
                if (tb1.Text == "")
                {
                    if (Convert.ToInt32(tbchild.Text) == 0)
                    {
                        if (rbm.IsChecked == true)
                        {
                            worker work = new worker(name, surname, sex = "мужчина");
                            tb1.Text = work.info();
                            work.Clone();
                            tb2.Text = $"{work.Clone()}";
                        }
                        else { worker work = new worker(name, surname, sex = "женщина"); tb2.Text = $"{work.Clone()}"; }
                    }
                    else if (Convert.ToInt32(tbchild.Text) > 0)
                    {
                        int child = Convert.ToInt32(tbchild.Text);
                        if (rbm.IsChecked == true)
                        {
                            worker_dad worka = new worker_dad(name, surname, sex = "мужчина", child);
                            tb2.Text = $"{worka.Clone()}";
                        }
                    }
                }

            }
        }
    }
}
