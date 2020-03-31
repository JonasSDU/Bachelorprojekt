﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterCareBackend.Models
{
    public class Organization
    {

        public String id { get; set; }
        public String Name { get; set; }
        public List<String> Locations { get; set; }
        public String AdminId { get; set; }

        public Organization(string id, string name, List<String> locations, string adminId)
        {
            this.id = id;
            Name = name;
            Locations = locations;
            AdminId = adminId;
        }
    }


}
