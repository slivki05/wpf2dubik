//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpf2dubik
{
    using System;
    using System.Collections.Generic;
    
    public partial class PointSale
    {
        public int IDТочки { get; set; }
        public int IDАгента { get; set; }
        public string Наименование { get; set; }
        public string Адрес { get; set; }
    
        public virtual Agent Agent { get; set; }
    }
}
