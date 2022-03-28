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
                Company user = context.Company
                .ToList().Where(i => i.Password == PasswSP.Text)
                    .FirstOrDefault();
                if (user != null)
                {
                    if (ValidateFIO(FIOcontfaceCI.Text) ==  true)
                    {
                        if (FIOcontfaceCI != null)
                        {
                            context.Company.Add(new Company()
                            {
                                FioContactFace = FIOcontfaceCI.Text.ToString()
                            });
                        }
                    }
                    if (NubCI != null)
                    {
                        context.Company.Add(new Company()
                        {
                            NumberContactFace = NubCI.Text.ToString()
                           });
                    }
                    if (ValidateEmail(EmailCI.Text) != false)
                    {
                        if (EmailCI != null)
                        {
                            context.Company.Add(new Company()
                            {
                                EmailContactFace = EmailCI.Text.ToString()
                            });
                        }
                    }
                    if (loginCI != null)
                    {
                        context.Company.Add(new Company()
                        {
                            EmailContactFace = EmailCI.Text.ToString()
                        });
                    }
                    if (ValidatePassw(PassqCI.Text) == true)
                    {
                        if (PassqCI != null)
                        {
                            context.Company.Add(new Company()
                            {
                                Password = PassqCI.Text.ToString()
                            });
                        }
                    }
                    if (ContrQuestion != null)
                    {
                        context.Company.Add(new Company()
                        {
                            ControlQuest = ContrQuestion.Text.ToString()
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

