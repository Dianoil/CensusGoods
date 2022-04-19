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
using static CensusGoods.classi.ValidationClass;
using static CensusGoods.classi.Enti;
namespace CensusGoods.Wind
{
    /// <summary>
    /// Логика взаимодействия для Registrat.xaml
    /// </summary>
    public partial class Registrat : Window
    {
        public Registrat(){
            InitializeComponent();
        }

        private void regist_Click(object sender, RoutedEventArgs e){
            string logBD = context.Company.Where(i => i.Login == logintxt.Text.ToString()).Select(j => j.Login).FirstOrDefault();

            if (numbertxt.Text == "" || emailtxt.Text == "" || logintxt.Text == "" || passwtxt.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else if (logBD != null)
            {
                MessageBox.Show("Логин уже используется");
            } 
            else if (ValidatePassw(passwtxt.Text) == false)
            {
                MessageBox.Show("Недопустимый пароль, необходимо ввести (от 8 символов, минимум одна: заглавная, строчная, знак)", "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (ValidateEmail(emailtxt.Text) == false)
            {
                MessageBox.Show("Неверная почта, проверьте написание", "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); //обычная маска почты %@%.ru или %@%.com
            }
            else
            {
                //MessageBoxResult result = MessageBox.Show(
                // namecomptxt.Text + " " +
                // "Логин:  " + logintxt.Text + "\n" +
                // "Пароль:  " + passwtxt.Text + "\n", "Создать пользователя:", MessageBoxButton.YesNo);
                //if (result == MessageBoxResult.Yes)
                //{
                //    context.Company.Add(new EF.Company()
                //    {
                //        Login = logintxt.Text.ToString(),
                //        Password = passwtxt.Text.ToString(),
                //        //Valute = valutecb.Text.ToString(),
                //        //TypeMagazine = typemagascb.Text.ToString(),
                //        Name = namecomptxt.Text.ToString(),
                //        Inn = inntxt.Text.ToString(),
                //        Ogrn = ogrntxt.Text.ToString(),
                //        //ContrQuesst
                //        Answer = Anser.Text.ToString()
                //    });
                //    context.Contacts.Add(new EF.Contacts()
                //    {
                //        NumberContactFace = numbertxt.Text.ToString(),
                //        EmailContactFace = emailtxt.Text.ToString(),
                //    });
                //    context.SaveChanges();
                //}
                Autorization autorization = new Autorization();
                this.Hide();
                autorization.ShowDialog();
            }
            /*else if (ValidateDate(birth.SelectedDate.Value) == false)
            //{
            //    MessageBox.Show("На данный момент вы еще не родились!", "Регистрация абоента", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }*/
        }
        private void emailtxt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (emailtxt.Text == "")
            {
                emailtxt.Text = "Email";
            }
        }

        private void logintxt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (logintxt.Text == "")
            {
                logintxt.Text = "Login";
            }
        }

        private void passwtxt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (passwtxt.Text == "")
            {
                passwtxt.Text = "Password";
            }

        }
       
        private void emailtxt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (emailtxt.Text == "Email")
            {
                emailtxt.Text = "";
            }
        }

        private void logintxt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (logintxt.Text == "Login")
            {
                logintxt.Text = "";
            }
        }

        private void passwtxt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (passwtxt.Text == "Password")
            {
                passwtxt.Text = "";
            }
        }

        private void FIO_GotFocus(object sender, RoutedEventArgs e)
        {
            if (FIO.Text == "ФИО")
            {
                FIO.Text = "";
            }
        }

        private void FIO_LostFocus(object sender, RoutedEventArgs e)
        {
            if (FIO.Text == "")
            {
                FIO.Text = "ФИО";
            }

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Autorization autorization = new Autorization();
            this.Hide();
            autorization.ShowDialog();
        }

        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
