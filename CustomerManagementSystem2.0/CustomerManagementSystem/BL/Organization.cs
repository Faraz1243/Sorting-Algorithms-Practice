using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
    public class Organization
    {
        public int index { get; set; }
        public string OrganizationId { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Founded { get; set; }
        public string Industry { get; set; }
        public int Employees { get; set; }
        //parametrized constructor
        public Organization(int index, string id, string name, string website, string country, string description, string founded, string industry, int employees)
        {
            this.index = index;
            this.OrganizationId = id;
            this.Name = name;
            this.Website = website;
            this.Country = country;
            this.Description = description;
            this.Founded = founded;
            this.Industry = industry;
            this.Employees = employees;
        }
    }
}
