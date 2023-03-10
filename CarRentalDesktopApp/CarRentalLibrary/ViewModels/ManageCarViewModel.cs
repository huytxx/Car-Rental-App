using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalDesktopApp.CarRentalLibrary.ViewModels
{
    public class ManageCarViewModel
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string VIN { get; set; }
        public string LicensePlate { get; set; }
    }
}
