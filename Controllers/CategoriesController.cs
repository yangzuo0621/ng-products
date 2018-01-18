using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ng_products.Controllers {
    [Route ("api/[controller]")]
    public class CategoriesController : Controller {

        [HttpGet]
        public IEnumerable<string> Get() {
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