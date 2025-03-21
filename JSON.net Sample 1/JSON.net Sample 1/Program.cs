using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using JSON.net_Sample_1.Model;
using Newtonsoft.Json;

namespace JSON.net_Sample
{
    class Program
    {
        private static string _path = @"C:\Json Sample\Contacts.json";
        static void Main(string[] args)
        {
            var contacts = GetContacts();
            SerializeJsonFile(contacts);
        }

        public static void SerializeJsonFile(List<Contact> contacts)
        {
            string contactsJson = JsonConvert.SerializeObject(contacts.ToArray(), Formatting.Indented);

            File.WriteAllText(_path, contactsJson);
        }

        public  static List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            new Contact
            {
                Name = "John Wick",
                DateOfBirth = new DateTime(1980, 05, 17),
                Address = new Address
                {
                    Street = "Centennial Dr",
                    Number = 15,
                    City = new City
                    {
                        Name = "Chicago",
                        Country = new Country { Code = "USA", Name = "United States" }
                    }
                },
                Phones = new List<Phone> {
                    new Phone { Name = "Personal", Number = "02978641" },
                    new Phone {Name = "Work", Number = "908762398" }
                }
            };
            new Contact
            {
                Name = "Ashley Mejia",
                DateOfBirth = new DateTime(2006, 03, 7),
                Address = new Address
                {
                    Street = "Av Duarte",
                    Number = 7,
                    City = new City
                    {
                        Name = "Santo Domingo",
                        Country = new Country { Code = "RD", Name = "Republica Dominicana" }
                    }
                },
                 Phones = new List<Phone> {
                    new Phone { Name = "Personal", Number = "8097653421" },
                    new Phone {Name = "Work", Number = "890654328" }
                }
            };
              new Contact
              {
                  Name = "Frank Castle",
                  DateOfBirth = new DateTime(1970, 07, 25),
                  Address = new Address
                  {
                      Street = "Wall street",
                      Number = 2,
                      City = new City
                      {
                          Name = "New York",
                          Country = new Country { Code = "USA", Name = "United States" }
                      }
                  },
                  Phones = new List<Phone> {
                    new Phone { Name = "Personal", Number = "12345678" },
                    new Phone {Name = "Work", Number = "908765321" }
                }
              };

            return contacts; 
        }
    }

}