using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CensusGoods.Class.Enti;
namespace CensusGoods.Class
{
    class CBoxHelper
    {
        public List<EF.City> GetCities()
        {
            try
            {
                return CensGoodsEnt.City.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                return new List<EF.City>();
            }
            catch (Exception ex)
            {
                return new List<EF.City>();
            }
        }

        public List<EF.City> GetCities(string element)
        {
            List<EF.City> typeMaterials;
            try
            {
                typeMaterials = CensGoodsEnt.City.AsNoTracking().ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                typeMaterials = new List<EF.City>();
            }
            catch (Exception ex)
            {
                typeMaterials = new List<EF.City>();
            }
            typeMaterials.Insert(0, new EF.City
            {
                name = element
            });
            return typeMaterials;

        }

        public List<EF.Product> GetProducts()
        {
            try
            {
                return CensGoodsEnt.Product.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                return new List<EF.Product>();
            }
            catch (Exception ex)
            {
                return new List<EF.Product>();
            }
        }

        public List<EF.Product> GetProducts(string element)
        {
            List<EF.Product> typeMaterials;
            try
            {
                typeMaterials = CensGoodsEnt.Product.AsNoTracking().ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                typeMaterials = new List<EF.Product>();
            }
            catch (Exception ex)
            {
                typeMaterials = new List<EF.Product>();
            }
            typeMaterials.Insert(0, new EF.Product
            {
                name = element
            });
            return typeMaterials;

        }

        public List<EF.Container> GetContainers()
        {
            try
            {
                return CensGoodsEnt.Container.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                return new List<EF.Container>();
            }
            catch (Exception ex)
            {
                return new List<EF.Container>();
            }
        }

        public List<EF.Container> GetContainers(string element)
        {
            List<EF.Container> typeMaterials;
            try
            {
                typeMaterials = CensGoodsEnt.Container.AsNoTracking().ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                typeMaterials = new List<EF.Container>();
            }
            catch (Exception ex)
            {
                typeMaterials = new List<EF.Container>();
            }
            typeMaterials.Insert(0, new EF.Container
            {
                name = element
            });
            return typeMaterials;

        }


        public List<EF.Company> GetCompanies()
        {
            try
            {
                return CensGoodsEnt.Company.ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                return new List<EF.Company>();
            }
            catch (Exception ex)
            {
                return new List<EF.Company>();
            }
        }

        public List<EF.Company> GetCompanies(string element)
        {
            List<EF.Company> typeMaterials;
            try
            {
                typeMaterials = CensGoodsEnt.Company.AsNoTracking().ToList();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                typeMaterials = new List<EF.Company>();
            }
            catch (Exception ex)
            {
                typeMaterials = new List<EF.Company>();
            }
            typeMaterials.Insert(0, new EF.Company
            {
                name = element
            });
            return typeMaterials;

        }

    }
}
