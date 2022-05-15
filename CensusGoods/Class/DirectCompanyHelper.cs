using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static CensusGoods.Class.Enti;
using static CensusGoods.Class.DataUser;
namespace CensusGoods.Class
{
    class DirectCompanyHelper
    {
        private EF.Vm_User editdirComp;

        public List<EF.Vm_User> GetVm_DirUser()
        {
            List<EF.Vm_User> result;
            try
            {
                result = (User.Companys, CensGoodsEnt.Vm_User).Vm_User.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                MessageBox.Show("Ошибка подключени к базе", "Проблемы с подключением",
MessageBoxButton.OKCancel, MessageBoxImage.Error);
                result = new List<EF.Vm_User>();
            }
            catch (Exception ex)
            {
                result = new List<EF.Vm_User>();
            }
            return result;
        }

    }
}
