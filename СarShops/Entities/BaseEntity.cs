using System;
using System.Collections.Generic;
using System.Text;

namespace СarShops.Entities
{
    public class BaseEntity
    {
        public string Name { get; set; }

        public BaseEntity()
        {
            Name = "New";
        }
    }
}