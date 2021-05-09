using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int VehicleClassId { get; set; }//arac sınıfı
        public string Name { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string Fuel { get; set; }//yakıt
        public string Gear { get; set; }//vites
        public string LuggageVolume { get; set; }//bagaj hacmi

        public virtual Brand Brand { get; set; }
    }
}
