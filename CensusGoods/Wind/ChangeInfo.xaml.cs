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
using static CensusGoods.classi.Enti;
using static CensusGoods.classi.ValidationClass;
using static CensusGoods.classi.DataUser;
namespace CensusGoods.Wind
{
    /// <summary>
    /// Логика взаимодействия для ChangeInfo.xaml
    /// </summary>
    public partial class ChangeInfo : Window
    {
        public ChangeInfo()
        {
            InitializeComponent();
        }

        private void saveinfo_Click(object sender, RoutedEventArgs e)
        {
            StackPanPassw.Visibility = Visibility.Visible;
        }

        private void exitSP_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveSP_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EF.Company user = context.Company
                .ToList().Where(i => i.Password == PasswSP.Text)
                    .FirstOrDefault();
                if (user != null)
                {
                    if (ValidateFIO(FIOcontfaceCI.Text) ==  true)
                    {
                        if (FIOcontfaceCI != null)
                        {
                            context.Contacts.Add(new EF.Contacts()
                            {
                                FioContastFace = FIOcontfaceCI.Text.ToString()
                            });
                        }
                    }
                    if (NubCI != null)
                    {
                        context.Contacts.Add(new EF.Contacts()
                        {
                            NumberContactFace = NubCI.Text.ToString()
                           });
                    }
                    if (ValidateEmail(EmailCI.Text) != false)
                    {
                        if (EmailCI != null)
                        {
                            context.Contacts.Add(new EF.Contacts()
                            {
                                EmailContactFace = EmailCI.Text.ToString()
                            });
                        }
                    }
                    if (loginCI != null)
                    {
                        context.Company.Add(new EF.Company()
                        {
                            Login = EmailCI.Text.ToString()
                        });
                    }
                    if (ValidatePassw(PassqCI.Text) == true)
                    {
                        if (PassqCI != null)
                        {
                            context.Company.Add(new EF.Company()
                            {
                                Password = PassqCI.Text.ToString()
                            });
                        }
                    }
                    if (ContrQuestion != null)
                    {
                        context.Company.Add(new EF.Company()
                        {
                            Answer = ContrQuestion.Text.ToString()
                        });
                    }
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Пароль введен неверно");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FIOcontfaceCI_LostFocus(object sender, RoutedEventArgs e)
        {
            if (FIOcontfaceCI.Text == "")
            {
                FIOcontfaceCI.Text = "ФИО контактного номера";
            }
        }

        private void EmailCI_LostFocus(object sender, RoutedEventArgs e)
        {
            if (EmailCI.Text == "")
            {
                EmailCI.Text = "Email";
            }
        }

        private void loginCI_LostFocus(object sender, RoutedEventArgs e)
        {
            if (loginCI.Text == "")
            {
                loginCI.Text = "Login";
            }

        }

        private void PassqCI_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PassqCI.Text == "")
            {
                PassqCI.Text = "Password";
            }

        }

        private void ContrQuestion_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ContrQuestion.Text == "")
            {
                ContrQuestion.Text = "Ответ на вопрос";
            }
        }
        private void FIOcontfaceCI_GotFocus(object sender, RoutedEventArgs e)
        {
            if (FIOcontfaceCI.Text == "ФИО контактного номера")
            {
                FIOcontfaceCI.Text = "";
            }
        }

        private void EmailCI_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailCI.Text == "Email")
            {
                EmailCI.Text = "";
            }
        }

        private void loginCI_GotFocus(object sender, RoutedEventArgs e)
        {
            if (loginCI.Text == "Login")
            {
                loginCI.Text = "";
            }
        }

        private void PassqCI_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PassqCI.Text == "Password")
            {
                PassqCI.Text = "";
            }
        }

        private void ContrQuestion_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ContrQuestion.Text == "Ответ на вопрос")
            {
                ContrQuestion.Text = "";
            }
        }       
    }
}
/*context.Company.Add(new Company()
{
    //Login = txtLogin.Text.ToString(),
    //Password = pswPassword.Password.ToString(),
    //Surname = txtSname.Text.ToString(),
    //Name = txtName.Text.ToString(),

});
context.SaveChanges();

classi.DataUser.Company = user;
context.SaveChanges();
Menu menu = new Menu();
this.Hide();
menu.ShowDialog();

 */

