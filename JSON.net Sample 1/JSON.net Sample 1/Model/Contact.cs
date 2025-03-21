using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON.net_Sample_1.Model
{
    public class Contact
    {
        internal List<Phone> Phones;

        public string Name { get; set; }

        public Address Address { get; set; }

        public List<Phone> Phone { get; set;}

        public DateTime DateOfBirth { get; set; }
}
