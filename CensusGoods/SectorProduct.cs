//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CensusGoods
{
    using System;
    using System.Collections.Generic;
    
    public partial class SectorProduct
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdSector { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Sector Sector { get; set; }
    }
}