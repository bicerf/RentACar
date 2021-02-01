using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductCar:IEntity
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Desciption { get; set; }
    }
}
