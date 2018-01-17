using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ng_products.Controllers {

    [Route ("api/[controller]")]
    public class ProductsController : Controller {

        [HttpGet]
        public IEnumerable<string> Get () {
            return new string[] {
                "Antenna systems",
                "Attitude actuators",
                "Attitude sensors",
                "Cameras & payloads",
                "Command & data handling",
                "Communication systems",
                "CubeSat kits & buses",
                "Cube Sat Structures",
                "Ground stations",
                "Integrated ADCS",
                "Launch adapters",
                "Propulsion & pressurisation",
                "Solar pannels & power systems",
                "Ground support equipment",
                "Software services",
                "Training & simulators"
            };
        }
    }

    [Route ("api/[controller]")]
    public class VendorsController : Controller {
        [HttpGet]
        public IEnumerable<string> Get () {
            return new string[] {
                "CRYSTALSPACE",
                "DHV TECHNOLOGY",
                "EYASSAT",
                "ECUADORIAN SPACE AGENCY",
                "KUBOS",
                "NEWSPACE SYSTEMS",
                "MICROSPACE",
                "SOLARMEMS",
                "TELEDYNEPARADISEDATACOM",
                "CUBESPACE",
                "EXPULSION",
                "HCT - HELICAL COMMUNICATION TECHNOLOGIES",
                "IQ WIRELESS",
                "SIS - INNOVATIVE SOLUTIONS IN SPACE",
                "MARYLAND AEROSPACE INC",
                "PUMPKIN",
                "SCS SPACE",
                "SOLENIX",
                "THEA SPACE",
                "TV-SPACE"
            };
        }
    }

    [Route ("api/[controller]")]
    public class CategoriesController : Controller {

        [HttpGet]
        public IEnumerable<string> Get () {
            return new string[] {
                "Antenna systems",
                "Attitude actuators",
                "Attitude sensors",
                "Cameras & payloads",
                "Command & data handling",
                "Communication systems",
                "CubeSat kits & buses",
                "Cube Sat Structures",
                "Ground stations",
                "Integrated ADCS",
                "Launch adapters",
                "Propulsion & pressurisation",
                "Solar pannels & power systems",
                "Ground support equipment",
                "Software services",
                "Training & simulators"
            };
        }
    }
}