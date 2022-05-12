using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static CensusGoods.Class.Enti;
namespace CensusGoods.Class
{
    class DirectGoogsHelper
    {
        private EF.Vm_DirComp editdirComp;
        
        public List<EF.Vm_DirComp> GetVm_DirComps()
        {
            List<EF.Vm_DirComp> result;
            try
            {
                result = CensGoodsEnt.Vm_DirComp.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                MessageBox.Show("Ошибка подключени к базе", "Проблемы с подключением",
MessageBoxButton.OKCancel, MessageBoxImage.Error);
                result = new List<EF.Vm_DirComp>();
            }
            catch (Exception ex)
            {
                result = new List<EF.Vm_DirComp>();
            }
            return result;
        }
    }
}
