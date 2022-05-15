using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CensusGoods.Class.Enti;
namespace CensusGoods.Class
{
    public static class SeectorHelper
    {
        public static List<EF.Container> GetContainers()
        {
            return CensGoodsEnt.Container.ToList();
        }

        public static List<EF.Product> GetProducts()
        {
            return CensGoodsEnt.Product.ToList();
        }
    }
}
