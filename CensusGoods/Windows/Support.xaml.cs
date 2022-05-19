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
namespace CensusGoods.Wind
{
    /// <summary>
    /// Логика взаимодействия для Support.xaml
    /// </summary>
    public partial class Support : Window
    {
        List<string> GoalOfRequestList = new List<string>() { "Выберите цель обращения", "Забыл логин", "Забыл пароль", "Другая причина" };

        public Support() 
        {
            InitializeComponent();
            InitializeComponent();
            cmbGoalOfRequest.ItemsSource = GoalOfRequestList;
            cmbGoalOfRequest.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Autorization autorization = new Autorization();
            this.Close();
            autorization.ShowDialog();
        }

        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            if (ApplyTBox.Text == "" || EmailSupportTBox.Text == "" || 
                cmbGoalOfRequest.SelectedIndex == 0)
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else if (ValidateEmail(EmailSupportTBox.Text) == false)
            {
                MessageBox.Show("Неверная почта, проверьте написание",
                    "Регистрация пользователя", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(
                EmailSupportTBox.Text + " ",
                "Отправить обращение от адреса:", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    CensGoodsEnt.Support.Add(new EF.Support()
                    {
                        email = EmailSupportTBox.Text.ToString(),
                        appeal = cmbGoalOfRequest.SelectedItem.ToString(),
                        question = ApplyTBox.Text.ToString()
                    });
                    CensGoodsEnt.SaveChanges();
                    MessageBox.Show("Сообщение отправлено");
                    Autorization autorization = new Autorization();
                    this.Close();
                    autorization.ShowDialog();
                }

            }
        }
        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void TextBox_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
