using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CensusGoods.EF
{
    public partial class User
    {
        public string Companys { get
            {
                var titles = String.Join(", ", InfoUserCompany.Select(s => s.Company.name));
                if (titles.Length == 0)
                {
                    return null;
                }
                else
                {
                    return String.Join(", ", InfoUserCompany.Select(s => s.Company.name));
                }
            }
        }
    }
}
