﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyerAccessToMarketplace;

namespace BuyerAccessToMarketplace
{
    public class InternalContract
    {
        //InternalID representing Supplier - Product Management
        public int InternalId { get; set; }
        public string ClientName { get; set; }
        public InternalContract() { }

        //CHECK CITIES FOR TRUTH SAY

        public List<InternalContract> GetInternalContracts()
        {
            var internalContract = new ContractMarketDals().GetInternalContracts();
            return internalContract;
        }
    }
}