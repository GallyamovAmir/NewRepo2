//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTrain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Routes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Routes()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int Id { get; set; }
        public System.DateTime DepartureDate { get; set; }
        public int DepartureCityId { get; set; }
        public int ArrivalCityId { get; set; }
        public System.DateTime ArrivalDate { get; set; }
        public int TrainsId { get; set; }
        public decimal PriceCoupe { get; set; }
        public decimal PriceEconom { get; set; }
    
        public virtual Cities Cities { get; set; }
        public virtual Cities Cities1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
        public virtual Trains Trains { get; set; }
    }
}