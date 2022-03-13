using System;

namespace CoffeStar.Entites
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname{ get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }

    }
}
