using CensusGoods.EF;
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
using System.Windows.Shapes;
using static CensusGoods.Class.Enti;
using static CensusGoods.Class.ValidationClass;
using static CensusGoods.Class.SeectorHelper;
using static CensusGoods.Class.DataUser;
using Microsoft.Win32;

namespace CensusGoods.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddInfo.xaml
    /// </summary>
    public partial class AddInfo : Window
    {
        private Class.CBoxHelper boxHelper =
            new Class.CBoxHelper();
        public AddInfo()
        {
            InitializeComponent();
            LoadFilter();
        }
        #region focus

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

        #region Добавление компании
        private void NameCompany_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameCompany.Text == "Название компании")
            {
                NameCompany.Text = "";
            }

        }

        private void NameCompany_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameCompany.Text == "")
            {
                NameCompany.Text = "Название компании";
            }

        }

        private void inn_GotFocus(object sender, RoutedEventArgs e)
        {
            if (inn.Text == "ИНН")
            {
                inn.Text = "";
            }
        }

        private void inn_LostFocus(object sender, RoutedEventArgs e)
        {
            if (inn.Text == "")
            {
                inn.Text = "ИНН";
            }
        }

        private void ogrn_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ogrn.Text == "ОГРН")
            {
                ogrn.Text = "";
            }

        }

        private void ogrn_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ogrn.Text == "")
            {
                ogrn.Text = "ОГРН";
            }

        }

        private void regNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            if (regNumber.Text == "Регистрационный номер")
            {
                regNumber.Text = "";
            }
        }

        private void regNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (regNumber.Text == "")
            {
                regNumber.Text = "Регистрационный номер";
            }
        }

        private void personDiscount_GotFocus(object sender, RoutedEventArgs e)
        {
            if (personDiscount.Text == "Персональная скидка")
            {
                personDiscount.Text = "";
            }
        }

        private void personDiscount_LostFocus(object sender, RoutedEventArgs e)
        {
            if (personDiscount.Text == "")
            {
                personDiscount.Text = "Персональная скидка";
            }
        }

        #endregion

        #endregion

        #region Функционал

        private void LoadFilter()
        {
            cityCBox.ItemsSource = boxHelper.GetCities("Все города");
            cityCBox.SelectedIndex = 0;
            NameProductCBox.ItemsSource = boxHelper.GetProducts("Все продукты");
            NameProductCBox.SelectedIndex = 0;
            NumContainerCBox.ItemsSource = boxHelper.GetContainers("Все типы");
            NumContainerCBox.SelectedIndex = 0;
            NumCompanyCbox.ItemsSource = boxHelper.GetCompanies("Все компании");
            NumCompanyCbox.SelectedIndex = 0;


        }

        private void LoadFilter(int i)
        {
            cityCBox.ItemsSource = boxHelper.GetCities("Все города");
            cityCBox.SelectedIndex = i;
            NameProductCBox.ItemsSource = boxHelper.GetProducts("Все продукты");
            NameProductCBox.SelectedIndex = i;
            NumContainerCBox.ItemsSource = boxHelper.GetContainers("Все типы");
            NumContainerCBox.SelectedIndex = i;
            NumCompanyCbox.ItemsSource = boxHelper.GetCompanies("Все компании");
            NumCompanyCbox.SelectedIndex = i;


        }
        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }


        private void SaveAddCompanyInfo_Click(object sender, RoutedEventArgs e)
        {
            string logBD = CensGoodsEnt.User.Where(i => i.emailContactFace ==
            loginTBox.Text.ToString()).Select(j => j.emailContactFace)
            .FirstOrDefault();

            #region Добавление информации о компании
            if (NameCompany.Text == "" || inn.Text == "" ||
            ogrn.Text == "" || regNumber.Text == ""
            || personDiscount.Text == "" ||
             cityCBox.SelectedIndex == 0)
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else if (ValidateCompany(NameCompany.Text) == false)
            {
                MessageBox.Show("Недопустимое название, введите от 8 символов, без чисел и знаков",
                    "Регистрация компании", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateINN(inn.Text) == false)
            {
                MessageBox.Show("Неверный формат инн, проверьте написание (инн состоит из 11 символов)",
                    "Регистрация компании", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateOGRN(ogrn.Text) == false)
            {
                MessageBox.Show("Неверный формат огрн, проверьте написание (огрн состоит из 12 символов))",
                    "Регистрация компании", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateOGRN(regNumber.Text) == false)
            {
                MessageBox.Show("Неверный формат регистрационного номера, проверьте написание (рег. номер состоит из 12 символов))",
                    "Регистрация компании", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateDiscount(personDiscount.Text) == false)
            {
                MessageBox.Show("Неверный формат скидки, проверьте написание (макс значение - 3 символа, без каких либо знаков))",
                    "Регистрация компании", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                 NameCompany.Text + " ", "Создать пользователя:", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    CensGoodsEnt.Company.Add(new EF.Company()
                    {
                        name = NameCompany.Text.ToString(),
                        inn = inn.Text.ToString(),
                        ogrn = ogrn.Text.ToString(),
                        registrNum = regNumber.Text.ToString(),
                        discount = personDiscount.Text.ToString(),
                        city = cityCBox.SelectedIndex
                    });
                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();
                }
            }
            #endregion
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.IsEnabled = true;
            this.Close();
        }
        private void SaveAddDirectory_Click(object sender, RoutedEventArgs e)
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
                MessageBox.Show("Недопустимый пароль, необходимо ввести (от 8 символов, латиница, минимум одна: заглавная, строчная, число)",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidatePhone(NumberMainGoods.Text) == false)
            {
                MessageBox.Show("Недопустимый номер телефона, проверьте написание",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            else if (ValidateFIO(NameMainGoods.Text) == false)
            {
                MessageBox.Show("Недопустимое имя пользовател, (введите фио в подряд через пробел)",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateEmail(EmailMainGoods.Text) == false)
            {
                MessageBox.Show("Неверная почта, проверьте написание",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); 
            }
            else if (ValidateLogin(loginTBox.Text) == false)
            {
                MessageBox.Show("Недопустимый логин, необходимо ввести (латиницей, от 8 символов, минимум одна: заглавная, строчная)",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
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
                    var addedUser = CensGoodsEnt.User.Where(x => EmailMainGoods.Text == x.emailContactFace).FirstOrDefault();
                    int idAdUs;
                    idAdUs = addedUser.id;
                    CensGoodsEnt.InfoUserCompany.Add(new EF.InfoUserCompany()
                    {
                        idCompany = 104,
                        idUser = idAdUs
                    });
                    CensGoodsEnt.SaveChanges();

                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();
                }
            }
            #endregion
        }

        private void SaveAddCompany_Click(object sender, RoutedEventArgs e)
        {
            string logBD = CensGoodsEnt.User.Where(i => i.emailContactFace ==
            loginTBox.Text.ToString()).Select(j => j.emailContactFace)
            .FirstOrDefault();
            #region Директор компании

            if (loginTBox1.Text == "" || PasswTBox1.Text == "" ||
            NameMainCompany.Text == "" || NumberMainCompany.Text == ""
            || EmailMainCompany.Text == "" || NumCompanyCbox.SelectedIndex == 0)
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else if (logBD != null)
            {
                MessageBox.Show("Почта уже используется");
            }
            else if (ValidateFIO(NameMainCompany.Text) == false)
            {
                MessageBox.Show("Недопустимое имя пользователя",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidatePhone(NumberMainCompany.Text) == false)
            {
                MessageBox.Show("Недопустимый номер телефона, проверьте написание",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidatePassw(PasswTBox1.Text) == false)
            {
                MessageBox.Show("Недопустимый пароль, необходимо ввести (латиницей, от 8 символов, минимум одна: заглавная, строчная, число)",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateEmail(EmailMainCompany.Text) == false)
            {
                MessageBox.Show("Неверная почта, проверьте написание",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); 
            }
            else if (ValidateLogin(loginTBox1.Text) == false)
            {
                MessageBox.Show("Недопустимый логин, необходимо ввести (литиницей, от 8 символов, минимум одна: заглавная, строчная)",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); 
            }

            else
            {
                MessageBoxResult result = MessageBox.Show(
                 NameMainCompany.Text + " " +
                 "Логин:  " + loginTBox1.Text + "\n" +
                 "Пароль:  " + PasswTBox1.Text + "\n",
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
                    int addedUser = CensGoodsEnt.User.Where(x => EmailMainCompany.Text == x.emailContactFace.ToString()).Select(j => j.id).FirstOrDefault();
                    CensGoodsEnt.InfoUserCompany.Add(new EF.InfoUserCompany()
                    {
                        idCompany = NumCompanyCbox.SelectedIndex,
                        idUser = addedUser
                    });

                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();
                }
            }

            #endregion

        }

        private void SaveAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            string logBD = CensGoodsEnt.User.Where(i => i.emailContactFace ==
            loginTBox.Text.ToString()).Select(j => j.emailContactFace)
            .FirstOrDefault();
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
                MessageBox.Show("Недопустимый пароль, необходимо ввести (латиницей, от 8 символов, минимум одна: заглавная, строчная, число)",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidatePhone(NumberEmployee.Text) == false)
            {
                MessageBox.Show("Недопустимый номер телефона, проверьте написание",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateFIO(NameEmployee.Text) == false)
            {
                MessageBox.Show("Недопустимое имя пользователя",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            else if (ValidateEmail(EmailEmployee.Text) == false)
            {
                MessageBox.Show("Неверная почта, проверьте написание",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); 
            }
            else if (ValidateLogin(loginTBox2.Text) == false)
            {
                MessageBox.Show("Недопустимый логин, необходимо ввести (латиницей, от 8 символов, минимум одна: заглавная, строчная)",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            else
            {
                MessageBoxResult result = MessageBox.Show(
                 NameEmployee.Text + " " +
                 "Логин:  " + loginTBox2.Text + "\n" +
                 "Пароль:  " + PasswTBox2.Text + "\n",
                 "Создать пользователя:", MessageBoxButton.YesNo);
                int idAdUs;
                int idAdCom;
                if (result == MessageBoxResult.Yes)
                {                    
                    CensGoodsEnt.User.Add(new EF.User()
                    {
                        login = loginTBox2.Text.ToString(),
                        password = PasswTBox2.Text.ToString(),
                        fioContastFace = NameEmployee.Text.ToString(),
                        numberContactFace = NumberEmployee.Text.ToString(),
                        emailContactFace = EmailEmployee.Text.ToString(),
                        idRole = 1,
                        
                    }) ;
                    CensGoodsEnt.SaveChanges();

                    var addedUser = CensGoodsEnt.User.Where(x => EmailEmployee.Text == x.emailContactFace).FirstOrDefault();
                    idAdUs = addedUser.id;
                    var addedCompany = CensGoodsEnt.InfoUserCompany.Where(i => i.idUser == User1.id).FirstOrDefault();
                    idAdCom = addedCompany.idCompany;
                    CensGoodsEnt.InfoUserCompany.Add(new EF.InfoUserCompany()
                    {
                        idCompany = idAdCom,
                        idUser = idAdUs
                    });
                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();

                }
            }

            #endregion

        }

        private void SaveTariff_Click(object sender, RoutedEventArgs e)
        {
            #region Тариф

            if (NameTariff.Text == "" || precentForTariff.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else if (ValidateTariff(NameTariff.Text) == false)
            {
                MessageBox.Show("Недопустимое название тарифа, проверьте написание",
                    "Добавление тарифа", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidatePersTariff(precentForTariff.Text) == false)
            {
                MessageBox.Show("Недопустимое значение, проверьте написание (введите значение состоящее из чисел и знака ,)",
                "Добавление тарифа", MessageBoxButton.OK, MessageBoxImage.Exclamation);
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
                        name = NameTariff.Text.ToString(),
                        cost =  Convert.ToDecimal(precentForTariff.Text),
                        available = false,
                    });
                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();

                }
            }

            #endregion

        }

        private void SaveProduct_Click(object sender, RoutedEventArgs e)
        {
            #region Продукт

            if (NameProduct.Text == "")
            {
                MessageBox.Show("Не заполнено поле с названием!");
            }
            else if (ValidateFIO(NameProduct.Text) == false)
            {
                MessageBox.Show("Недопустимое название продукта, проверьте написание",
                    "Добавление продукта", MessageBoxButton.OK, MessageBoxImage.Exclamation); 
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
                        image = NameFiles.Text.ToString(),
                        description = descriptionTBox.Text.ToString()
                    });
                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();

                }
            }


            #endregion

        }

        private void SaveInfoContainer_Click(object sender, RoutedEventArgs e)
        {
            #region Инфоконтенер

            if (NumContainerCBox.SelectedIndex == 0 ||
                NameProductCBox.SelectedIndex == 0||
                QuantityProductTBox.Text == ""
            || BruttoTBox.Text == ""
            || DateStart.Text == "")
                 {
                      MessageBox.Show("Не все поля заполнены!");
                  }
            else if (ValidateDate(DateStart.SelectedDate) == false)
            {
                MessageBox.Show("Неверная дата, проверьте сведения",
                    "Добавление информации о контейнере", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                 NameProductCBox.Text + " ",
                 "Добавить информацию", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    CensGoodsEnt.InfoContainer.Add(new EF.InfoContainer()
                    {
                        idContainer = NumContainerCBox.SelectedIndex,
                        idProduct = NameProductCBox.SelectedIndex,
                        QuantityProduct = QuantityProductTBox.Text,
                        CargoWeight = BruttoTBox.Text,
                        dateStart = DateStart.SelectedDate.Value,
                        available = false
                    }) ;
                    CensGoodsEnt.SaveChanges();
                    var addedUser = CensGoodsEnt.InfoContainer.Where(x => NameProductCBox.SelectedIndex == x.idProduct && NumContainerCBox.SelectedIndex == x.idContainer &&
                    DateStart.SelectedDate.Value == x.dateStart).FirstOrDefault();
                    int idAdUs;
                    idAdUs = addedUser.id;
                    var addedCompany = CensGoodsEnt.InfoUserCompany.Where(i => i.idUser == User1.id).FirstOrDefault();
                    int idAdCom = addedCompany.idCompany;

                    
                    CensGoodsEnt.Receipt.Add(new EF.Receipt()
                    {
                        idCompany = idAdCom,
                        idTariff = 1,
                        infoContainer = idAdUs,
                        delay = true
                    });

                    CensGoodsEnt.SaveChanges();
                    Menu menu = new Menu();
                    menu.IsEnabled = true;
                    this.Close();
                }
            }
            #endregion

        }

        #endregion

        private void AvatarUser_Click(object sender, RoutedEventArgs e)
        {
            string fullPathFile = "";
            OpenFileDialog photo = new OpenFileDialog();
            photo.Multiselect = false;
            photo.Filter = "Image files (*.png;*.jpg;*.ico;*.jpeg)|*.png;*.jpg;*.ico;*.jpeg|All files (*.*)|*.*";
            photo.InitialDirectory = Class.DataUser.PatchApplication(Class.DataUser.PatchUser);
            var aaa = photo.ShowDialog();
            if (aaa == true)
            {
                fullPathFile = PatchApplication(PatchUser + photo.SafeFileName);

                if (string.Equals(photo.FileName, fullPathFile))
                {
                    NameFiles.Text = photo.SafeFileName;
                    ImageUser.ImageSource = new BitmapImage(new Uri(fullPathFile));
                    ImageUser.Stretch = Stretch.UniformToFill;
                }
                else
                    MessageBox.Show("Полные пути файлов не совпадают ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
