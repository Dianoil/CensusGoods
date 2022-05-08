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
using System.Windows.Shapes;
using static CensusGoods.Class.Enti;
using static CensusGoods.Class.ValidationClass;
namespace CensusGoods.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddInfo.xaml
    /// </summary>
    public partial class AddInfo : Window
    {
        public AddInfo()
        {
            InitializeComponent();
        }
        #region verify
        private void loginTBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (loginTBox.Text == "Логин")
            {
                loginTBox.Text = "";
            }
            if (loginTBox1.Text == "Логин")
            {
                loginTBox1.Text = "";
            }
            if (loginTBox2.Text == "Логин")
            {
                loginTBox2.Text = "";
            }

        }

        private void loginTBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (loginTBox.Text == "")
            {
                loginTBox.Text = "Логин";
            }
            if (loginTBox1.Text == "")
            {
                loginTBox1.Text = "Логин";
            }
            if (loginTBox2.Text == "")
            {
                loginTBox2.Text = "Логин";
            }
        }

        private void PasswTBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswTBox.Text == "Пароль")
            {
                PasswTBox.Text = "";
            }
            if (PasswTBox1.Text == "Пароль")
            {
                PasswTBox1.Text = "";
            }
            if (PasswTBox2.Text == "Пароль")
            {
                PasswTBox2.Text = "";
            }

        }

        private void PasswTBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswTBox.Text == "")
            {
                PasswTBox.Text = "Пароль";
            }
            if (PasswTBox1.Text == "")
            {
                PasswTBox1.Text = "Пароль";
            }
            if (PasswTBox2.Text == "")
            {
                PasswTBox2.Text = "Пароль";
            }
        }

        #endregion

        #region Директор склада
        private void NameMainGoods_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameMainGoods.Text == "ФИО Руководителя склада")
            {
                NameMainGoods.Text = "";
            }
        }

        private void NameMainGoods_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameMainGoods.Text == "")
            {
                NameMainGoods.Text = "ФИО Руководителя склада";
            }

        }
        private void NumberMainGoods_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NumberMainGoods.Text == "Номер Руководителя склада")
            {
                NumberMainGoods.Text = "";
            }

        }

        private void NumberMainGoods_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NumberMainGoods.Text == "")
            {
                NumberMainGoods.Text = "Номер Руководителя склада";
            }

        }

        private void EmailMainGoods_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailMainGoods.Text == "Почта Руководителя склада")
            {
                EmailMainGoods.Text = "";
            }

        }

        private void EmailMainGoods_LostFocus(object sender, RoutedEventArgs e)
        {
            if (EmailMainGoods.Text == "")
            {
                EmailMainGoods.Text = "Почта Руководителя склада";
            }

        }


        #endregion

        #region Директор компании

        private void NameMainCompany_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameMainCompany.Text == "ФИО Руководителя компании")
            {
                NameMainCompany.Text = "";
            }

        }

        private void NameMainCompany_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameMainCompany.Text == "")
            {
                NameMainCompany.Text = "ФИО Руководителя компании";
            }

        }

        private void NumberMainCompany_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NumberMainCompany.Text == "Номер Руководителя компании")
            {
                NumberMainCompany.Text = "";
            }

        }

        private void NumberMainCompany_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NumberMainCompany.Text == "")
            {
                NumberMainCompany.Text = "Номер Руководителя компании";
            }

        }

        private void EmailMainCompany_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailMainCompany.Text == "Почта Руководителя компании")
            {
                EmailMainCompany.Text = "";
            }

        }

        private void EmailMainCompany_LostFocus(object sender, RoutedEventArgs e)
        {
            if (EmailMainCompany.Text == "")
            {
                EmailMainCompany.Text = "Почта Руководителя компании";
            }

        }
        #endregion

        #region Работник склада
        private void NameEmployee_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameEmployee.Text == "ФИО Работника")
            {
                NameEmployee.Text = "";
            }

        }

        private void NameEmployee_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameEmployee.Text == "")
            {
                NameEmployee.Text = "ФИО Работника";
            }

        }

        private void NumberEmployee_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NumberEmployee.Text == "Номер Работника")
            {
                NumberEmployee.Text = "";
            }

        }

        private void NumberEmployee_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NumberEmployee.Text == "")
            {
                NumberEmployee.Text = "Номер Работника";
            }

        }

        private void EmailEmployee_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailEmployee.Text == "Почта Работника")
            {
                EmailEmployee.Text = "";
            }

        }

        private void EmailEmployee_LostFocus(object sender, RoutedEventArgs e)
        {
            if (EmailEmployee.Text == "")
            {
                EmailEmployee.Text = "Почта Работника";
            }

        }
        #endregion

        #region Тариф
        private void NameTariff_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameTariff.Text == "Название тарифа")
            {
                NameTariff.Text = "";
            }

        }

        private void NameTariff_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameTariff.Text == "")
            {
                NameTariff.Text = "Название тарифа";
            }

        }

        private void precentForTariff_GotFocus(object sender, RoutedEventArgs e)
        {
            if (precentForTariff.Text == "Процент по тарифу")
            {
                precentForTariff.Text = "";
            }

        }

        private void precentForTariff_LostFocus(object sender, RoutedEventArgs e)
        {
            if (precentForTariff.Text == "")
            {
                precentForTariff.Text = "Процент по тарифу";
            }

        }
        #endregion

        #region Продукт

        private void NameProduct_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameProduct.Text == "Название продукта")
            {
                NameProduct.Text = "";
            }

        }

        private void NameProduct_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameProduct.Text == "")
            {
                NameProduct.Text = "Название продукта";
            }


        }

        private void imageProduct_GotFocus(object sender, RoutedEventArgs e)
        {
            if (imageProduct.Text == "Изображение")
            {
                imageProduct.Text = "";
            }

        }

        private void imageProduct_LostFocus(object sender, RoutedEventArgs e)
        {
            if (imageProduct.Text == "")
            {
                imageProduct.Text = "Изображение";
            }

        }

        private void descriptionTBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (descriptionTBox.Text == "Описание")
            {
                descriptionTBox.Text = "";
            }

        }

        private void descriptionTBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (descriptionTBox.Text == "")
            {
                descriptionTBox.Text = "Описание";
            }

        }
        #endregion

        #region ИнфоКонтейнер


        private void QuantityProductTBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (QuantityProductTBox.Text == "Количество продукта")
            {
                QuantityProductTBox.Text = "";
            }

        }

        private void QuantityProductTBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (QuantityProductTBox.Text == "")
            {
                QuantityProductTBox.Text = "Количество продукта";
            }

        }

        private void BruttoTBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (BruttoTBox.Text == "Брутто")
            {
                BruttoTBox.Text = "";
            }

        }

        private void BruttoTBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (BruttoTBox.Text == "")
            {
                BruttoTBox.Text = "Брутто";
            }

        }
        #endregion

        #region Функционал

        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.IsEnabled = true;
            this.Close();
        }

        private void NextStage_Click(object sender, RoutedEventArgs e)
        {

            string logBD = CensGoodsEnt.User.Where(i => i.emailContactFace ==
            loginTBox.Text.ToString()).Select(j => j.emailContactFace)
            .FirstOrDefault();

            #region Директор склада
            if (loginTBox.Text == "" || PasswTBox.Text == "" ||
            NameMainGoods.Text == "" || NumberMainGoods.Text == ""
            || EmailMainGoods.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else if (logBD != null)
            {
                MessageBox.Show("Почта уже используется");
            }
            else if (ValidatePassw(PasswTBox.Text) == false)
            {
                MessageBox.Show("Недопустимый пароль, необходимо ввести (от 8 символов, минимум одна: заглавная, строчная, знак)",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateEmail(EmailMainGoods.Text) == false)
            {
                MessageBox.Show("Неверная почта, проверьте написание",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); //обычная маска почты %@%.ru или %@%.com
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                 NameMainGoods.Text + " " +
                 "Логин:  " + loginTBox.Text + "\n" +
                 "Пароль:  " + PasswTBox.Text + "\n", "Создать пользователя:", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    CensGoodsEnt.User.Add(new EF.User()
                    {
                        login = loginTBox.Text.ToString(),
                        password = PasswTBox.Text.ToString(),
                        fioContastFace = NameMainGoods.Text.ToString(),
                        numberContactFace = NumberMainGoods.Text.ToString(),
                        emailContactFace = EmailMainGoods.Text.ToString(),
                        idRole = 3

                    });
                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();
                }
            }
            #endregion

            #region Директор компании

            if (loginTBox1.Text == "" || PasswTBox1.Text == "" ||
            NameMainCompany.Text == "" || NumberMainCompany.Text == ""
            || EmailMainCompany.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else if (logBD != null)
            {
                MessageBox.Show("Почта уже используется");
            }
            else if (ValidatePassw(PasswTBox1.Text) == false)
            {
                MessageBox.Show("Недопустимый пароль, необходимо ввести (от 8 символов, минимум одна: заглавная, строчная, знак)",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateEmail(EmailMainCompany.Text) == false)
            {
                MessageBox.Show("Неверная почта, проверьте написание",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); //обычная маска почты %@%.ru или %@%.com
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                 NameMainCompany.Text + " " +
                 "Логин:  " + loginTBox.Text + "\n" +
                 "Пароль:  " + PasswTBox.Text + "\n",
                 "Создать пользователя:", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    CensGoodsEnt.User.Add(new EF.User()
                    {
                        login = loginTBox1.Text.ToString(),
                        password = PasswTBox1.Text.ToString(),
                        fioContastFace = NameMainCompany.Text.ToString(),
                        numberContactFace = NumberMainCompany.Text.ToString(),
                        emailContactFace = EmailMainCompany.Text.ToString(),
                        idRole = 2
                    });
                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();
                }
            }

            #endregion

            #region Работник склада

            if (loginTBox2.Text == "" || PasswTBox2.Text == "" ||
            NameEmployee.Text == "" || NumberEmployee.Text == ""
            || EmailEmployee.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else if (logBD != null)
            {
                MessageBox.Show("Почта уже используется");
            }
            else if (ValidatePassw(PasswTBox2.Text) == false)
            {
                MessageBox.Show("Недопустимый пароль, необходимо ввести (от 8 символов, минимум одна: заглавная, строчная, знак)",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateEmail(EmailEmployee.Text) == false)
            {
                MessageBox.Show("Неверная почта, проверьте написание",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); //обычная маска почты %@%.ru или %@%.com
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                 NameEmployee.Text + " " +
                 "Логин:  " + loginTBox2.Text + "\n" +
                 "Пароль:  " + PasswTBox2.Text + "\n",
                 "Создать пользователя:", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    CensGoodsEnt.User.Add(new EF.User()
                    {
                        login = loginTBox2.Text.ToString(),
                        password = PasswTBox2.Text.ToString(),
                        fioContastFace = NameEmployee.Text.ToString(),
                        numberContactFace = NumberEmployee.Text.ToString(),
                        emailContactFace = EmailEmployee.Text.ToString(),
                        idRole = 1
                    });
                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();

                }
            }

            #endregion

            #region Тариф

            if (NameTariff.Text == "" || precentForTariff.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                 NameTariff.Text + " ",
                 "Добавить тариф", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    CensGoodsEnt.Tariff.Add(new EF.Tariff()
                    {
                        name = loginTBox2.Text.ToString(),
                        cost = Convert.ToDecimal(precentForTariff),
                        available = false,
                    });
                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();

                }
            }

            #endregion

            #region Продукт

            if (NameProduct.Text == "" || imageProduct.Text == "" ||
            descriptionTBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                 NameProduct.Text + " ",
                 "Добавить продукт", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    CensGoodsEnt.Product.Add(new EF.Product()
                    {
                        name = NameProduct.Text.ToString(),
                        image = imageProduct.Text.ToString(),
                        description = descriptionTBox.Text.ToString()
                    });
                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();

                }
            }


            #endregion

            #region Инфоконтенер
            if (NumContainerCBox.SelectedValuePath == "" ||
                NameProductCBox.SelectedValuePath == "" ||
            QuantityProductTBox.Text == ""
            || BruttoTBox.Text == ""
            || Convert.ToString(DateStart.DataContext) == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                 NameProductCBox.Text + " ",
                 "Добавить информацию", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    //CensGoodsEnt.InfoContainer.Add(new EF.InfoContainer()
                    //{
                    //    //Тут блин айдишники, походу джоины прописывать надо будет
                    //});
                    //CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();
                }
            }
            #endregion
        }
        #endregion
    }
}