using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CensusGoods.Class
{
    public static class Enti
    {
        public static EF.CensusGoodsEntities1 CensGoodsEnt = new EF.CensusGoodsEntities1();

        public static void SaveChanges()
        {
            CensGoodsEnt.SaveChanges();
        }
    }
}
