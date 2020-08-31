using System;
using System.Collections.Generic;
using System.Text;

namespace Hymatik.Model
{ 
    public class Customer
    {
        public int ClientNumber { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCVR { get; set; }
        public string CompanyRole { get; set; }
        public string PhoneNumber { get; set; }
        public string Order { get; set; }

        public Customer()
        { }

        public Customer(int clientNumber, string name, string companyName, string companyCVR, string companyRole, string phoneNumber, string order)
        {
            this.ClientNumber = clientNumber;
            this.Name = name;
            this.CompanyName = companyName;
            this.CompanyCVR = companyCVR;
            this.CompanyRole = companyRole;
            this.PhoneNumber = phoneNumber;
            this.Order = order;


        }



    }
    

}
