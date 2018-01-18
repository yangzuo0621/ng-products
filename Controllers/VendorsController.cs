using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ng_products.Controllers {

    [Route ("api/[controller]")]
    public class VendorsController : Controller {
        [HttpGet]
        public IEnumerable<Vendor> Get() {
            return new Vendor[] {
                new Vendor { Id = 1, VendorName = "CrystalSpace", ImageUrl = "crystal_space.png" },
                new Vendor { Id = 2, VendorName = "CubeSpace", ImageUrl = "cube_space.jpg" },
                new Vendor { Id = 3, VendorName = "DHV Technology", ImageUrl = "dhv-technology.png" },
                new Vendor { Id = 4, VendorName = "Ecuadorian Space Agency", ImageUrl = "ecuadorian_space_agency.jpg" },
                new Vendor { Id = 5, VendorName = "Enpulsion", ImageUrl = "enpulsion-logo.jpg" },
                new Vendor { Id = 6, VendorName = "EyasSat", ImageUrl = "eyassat.png" },
                new Vendor { Id = 7, VendorName = "HEAD", ImageUrl = "head.png" },
                new Vendor { Id = 8, VendorName = "HCT", ImageUrl = "HCT-logo.png" },
                new Vendor { Id = 9, VendorName = "IQ Wireless", ImageUrl = "iq_wireless_logo.png" },
                new Vendor { Id = 10, VendorName = "ISIS", ImageUrl = "ISIS_logo.png" },
                new Vendor { Id = 11, VendorName = "Kubos", ImageUrl = "Kubos.png" },
                new Vendor { Id = 12, VendorName = "Lens R&D", ImageUrl = "Lens-RD.png" },
                new Vendor { Id = 13, VendorName = "Maryland Aerospace Inc.", ImageUrl = "maryland_aerospace_inc.png" },
                new Vendor { Id = 14, VendorName = "Microspace", ImageUrl = "microspace.png" },
                new Vendor { Id = 15, VendorName = "NewSpace", ImageUrl = "newpsace.png" },
                new Vendor { Id = 16, VendorName = "Pumpkin", ImageUrl = "pumpkin.png" },
                new Vendor { Id = 17, VendorName = "RUAG", ImageUrl = "ruag_logo.png" },
                new Vendor { Id = 18, VendorName = "SCS Space", ImageUrl = "SCS-space-logo.png" },
                new Vendor { Id = 19, VendorName = "SolarMEMS", ImageUrl = "solarmems.png" },
                new Vendor { Id = 20, VendorName = "Solenix", ImageUrl = "solenix.png" },
                new Vendor { Id = 21, VendorName = "Teledyne", ImageUrl = "Teledyne-logo.jpg" },
                new Vendor { Id = 22, VendorName = "Theia Space", ImageUrl = "theia_space.png" },
                new Vendor { Id = 23, VendorName = "Thoth", ImageUrl = "thoth.png" },
                new Vendor { Id = 24, VendorName = "TY-Space", ImageUrl = "TY_space.png" }
            };
        }
    }

    public class Vendor {
        public int Id { get; set; }
        public string VendorName { get; set; }
        public string ImageUrl { get; set; }
    }
}