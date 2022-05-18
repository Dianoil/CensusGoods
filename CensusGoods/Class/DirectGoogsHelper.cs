﻿using System;
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
                MsgBoxHelper.ShowError("Ошибка подключения к базе");
                result = new List<EF.Vm_DirComp>();
            }
            catch (Exception ex)
            {
                MsgBoxHelper.ShowError(ex);
                result = new List<EF.Vm_DirComp>();
            }
            return result;
        }
        public List<EF.Vm_TotalReceipt> GetVm_TotalReceipts()
        {
            List<EF.Vm_TotalReceipt> result;

            try
            {
                result = CensGoodsEnt.Vm_TotalReceipt.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                MsgBoxHelper.ShowError("Ошибка подключения к базе");
                result = new List<EF.Vm_TotalReceipt>();
            }
            catch (Exception ex)
            {
                MsgBoxHelper.ShowError(ex);
                result = new List<EF.Vm_TotalReceipt>();
            }
            return result;
        }

    }
}
