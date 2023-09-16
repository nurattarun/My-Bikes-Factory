using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyBikesFactory.Business
{
    [Serializable]

    [XmlInclude(typeof(RoadBikes))]
    [XmlInclude(typeof(MountainBikes))]
    public class Bikes
    {
        private int _serialnumber;
        private string _model;
        private int _manufacturingyear;
        private EColor color;

      

        public int Serialnumber { get => _serialnumber; set => _serialnumber = value; }
        public string Model { get => _model; set => _model = value; }
        public int Manufacturingyear { get => _manufacturingyear; set => _manufacturingyear = value; }
       
        public EColor Color { get =>  color; set => color = value; }

        public Bikes()
        {
            _serialnumber = 0;
            _model = "";
            _manufacturingyear = 0;
            color = EColor.Blue;
          
        }

        public Bikes(int intialSerialNumber) : this()
        {
            _serialnumber = intialSerialNumber;
        }

        public override string ToString()
        {
            return $" Serial Number: {_serialnumber}, Model: {_model}, Manufacturing Year: {_manufacturingyear},  Color: {color}";
        }
    }
}

    

