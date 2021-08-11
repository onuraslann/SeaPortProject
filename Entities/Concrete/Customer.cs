using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Customer:IEntity
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName   { get; set; }

        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
