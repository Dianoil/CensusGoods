//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CensusGoods.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Container
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Container()
        {
            this.InfoContainer = new HashSet<InfoContainer>();
        }
    
        public int id { get; set; }
        public int idSector { get; set; }
        public string weight { get; set; }
        public string height { get; set; }
        public bool status { get; set; }
        public string name { get; set; }
    
        public virtual Sector Sector { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoContainer> InfoContainer { get; set; }
    }
}
