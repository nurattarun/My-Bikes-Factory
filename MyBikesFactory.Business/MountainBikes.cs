using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class MountainBikes : Bikes
    {
        private ESuspensionType _suspensiontype;

        public ESuspensionType SuspensionType { get => _suspensiontype; set => _suspensiontype = value; }

        public MountainBikes() : base()
        {
            _suspensiontype = ESuspensionType.Dual;
        }

        public MountainBikes(ESuspensionType suspensiontype) : base()
        {
            _suspensiontype = suspensiontype;
        }

        public override string ToString()
        {
            return "Bike Type: Mountain, " + base.ToString() + $", Suspension Type: {_suspensiontype}";
        }
    }
}
