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
            string logBD = context.Company.Where(i => i.Email == logintxt.Text.ToString()).Select(j => j.Email).FirstOrDefault();

            if (numReg.Text == "" || emailtxt.Text == "" || logintxt.Text == "" || passwtxt.Text == "" || namecomptxt.Text == "" || inntxt.Text == "" || ogrntxt.Text == "")
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
            else if (ValidateCompany(namecomptxt.Text) == false)
            {
                MessageBox.Show("Недопустимое название компании", "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); //тут придумать по какой причине нельзя регать компани
            }
            else if (ValidateEmail(emailtxt.Text) == false)
            {
                MessageBox.Show("Неверная почта, проверьте написание", "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); //обычная маска почты %@%.ru или %@%.com
            }
            else if (ValidateINN(inntxt.Text) == false)
            {
                MessageBox.Show("Неверный инн, проверьте написание", "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); // до 11 символов, написание цифрами
            }
            else if (ValidateOGRN(ogrntxt.Text) == false)
            {
                MessageBox.Show("Неверная почта, проверьте написание", "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation); // до 12 симвл, написание цифрами
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                 namecomptxt.Text + " " +
                 "Логин:  " + logintxt.Text + "\n" +
                 "Пароль:  " + passwtxt.Text + "\n", "Создать пользователя:", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    context.Company.Add(new Company()
                    {
                        //Login = txtLogin.Text.ToString(),
                        //Password = pswPassword.Password.ToString(),
                        //Surname = txtSname.Text.ToString(),
                        //Name = txtName.Text.ToString(),

                    });
                    context.SaveChanges();
                }
                Autorization autorization = new Autorization();
                this.Hide();
                autorization.ShowDialog();
            }
            /*else if (ValidateDate(birth.SelectedDate.Value) == false)
            //{
            //    MessageBox.Show("На данный момент вы еще не родились!", "Регистрация абоента", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }*/
        }
        
    }
}
