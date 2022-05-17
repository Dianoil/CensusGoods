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

        public List<EF.Vm_InfoContainer> GetVm_InfoContainers()
        {
            List<EF.Vm_InfoContainer> result;
            try
            {
                result = (CensGoodsEnt.Vm_InfoContainer).ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                MessageBox.Show("Ошибка подключени к базе", "Проблемы с подключением",
MessageBoxButton.OKCancel, MessageBoxImage.Error);
                result = new List<EF.Vm_InfoContainer>();
            }
            catch (Exception ex)
            {
                result = new List<EF.Vm_InfoContainer>();
            }
            return result;
        }

        public List<EF.Vm_DirGoods> GetVm_DirGoods()
        {
            List<EF.Vm_DirGoods> result;
            try
            {
                result = (CensGoodsEnt.Vm_DirGoods).ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                MessageBox.Show("Ошибка подключени к базе", "Проблемы с подключением",
MessageBoxButton.OKCancel, MessageBoxImage.Error);
                result = new List<EF.Vm_DirGoods>();
            }
            catch (Exception ex)
            {
                result = new List<EF.Vm_DirGoods>();
            }
            return result;
        }
    }
}
