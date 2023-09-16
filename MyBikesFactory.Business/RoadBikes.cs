using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class RoadBikes : Bikes
    {
        private ETireType _tiretype;

        public ETireType TireType { get => _tiretype; set => _tiretype = value; }

        public RoadBikes() : base()
        {
            _tiretype = ETireType.Gravel;
        }

        public RoadBikes(ETireType tiretype) : base()
        {
            _tiretype = tiretype;
        }

        public override string ToString()
        {
            return "Bike Type: Road, " + base.ToString() + $", Tire Type: {_tiretype}";
        }
    }
}
