using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyBikesFactory.Business
{
    public static class Validator
    {
        public static bool ValidateId(string inputToCheck)
        {
            return int.TryParse(inputToCheck, out _);

            
        }

        public static bool ValidateUniqueId(string inputToCheck, List<Bikes> listOfBikes)
        {
            int id = Convert.ToInt32(inputToCheck);
            foreach (var bikes in listOfBikes)
            {
                if (bikes.Serialnumber == id)
                    return false;
            }
            return true;
            //return listOfSkateboards.Any(s => s.Id == id);
        }

        public static bool ValidateModel(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, @"^\w{5}$");
        }

        public static bool ValidateManufacturingYear(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, "^[0-9]{4}$");
        }

    }
}
