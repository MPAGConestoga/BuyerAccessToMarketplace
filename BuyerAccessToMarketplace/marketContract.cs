using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyerAccessToMarketplace
{
    //Similar to products - Product Management
    public class marketContract
    {
        public string clientName { get; set; }
        public int jobType { get; set; }
        public int quantity { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public int vanType { get; set; }

        public marketContract() { }

        //Save?

        //GetById..?

        //GetProducts
        public List<marketContract> GetMarketContracts()
        {
            var contracts = new ContractMarketDals().GetMarketContracts();
            return contracts;
        }
        //Tables

        //Delete

    }
}

