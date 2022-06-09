using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CensusGoods.Class.Enti;
namespace CensusGoods.Class
{
    public partial class DataUser
    {
        public static string PatchUser = "materials\\";  //Ссылка на аватары пользователей
        public static string PatchApplication(string str) =>
        System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\" + str;

        public static EF.Company Company{ get; set; }

        public static EF.User User1{ get; set; }

        public static List<EF.Vm_DirComp> dirComps { get; set; }

    }
}
