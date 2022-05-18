using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CensusGoods.Class
{
    public static class Enti
    {
        public static EF.CensusGoodsEntities5 CensGoodsEnt = new EF.CensusGoodsEntities5();


        public static void SaveChanges()
        {
            CensGoodsEnt.SaveChanges();
        }
    }
}
