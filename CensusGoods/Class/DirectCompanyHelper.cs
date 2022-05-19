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
            string idCompany;
            var addedCompany = CensGoodsEnt.InfoUserCompany.Where(i => User1.id == i.idUser).FirstOrDefault();
            idCompany = addedCompany.Company.name;
            var infoComp = CensGoodsEnt.Vm_User.Where(s => s.Компания == idCompany);
            List <EF.Vm_User> result;
            try
            {
                result = infoComp.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                MsgBoxHelper.ShowError("Ошибка подключения к базе");
                result = new List<EF.Vm_User>();
            }
            catch (Exception ex)
            {
                MsgBoxHelper.ShowError(ex);
                result = new List<EF.Vm_User>();
            }
            return result;
        }

        public List<EF.Vm_InfoContainer> GetVm_InfoContainers()
        {
            string idCompany;
            var addedCompany = CensGoodsEnt.InfoUserCompany.Where(i => User1.id == i.idUser).FirstOrDefault();
            idCompany = addedCompany.Company.name;
            var infoComp = CensGoodsEnt.Vm_InfoContainer.Where(s => s.Название_компании == idCompany);

            List<EF.Vm_InfoContainer> result;
            try
            {
                result = infoComp.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                MsgBoxHelper.ShowError("Ошибка подключения к базе");
                result = new List<EF.Vm_InfoContainer>();
            }
            catch (Exception ex)
            {
                MsgBoxHelper.ShowError(ex);
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
                MsgBoxHelper.ShowError("Ошибка подключения к базе");
                result = new List<EF.Vm_DirGoods>();
            }
            catch (Exception ex)
            {
                MsgBoxHelper.ShowError(ex);
                result = new List<EF.Vm_DirGoods>();
            }
            return result;
        }
    }
}
