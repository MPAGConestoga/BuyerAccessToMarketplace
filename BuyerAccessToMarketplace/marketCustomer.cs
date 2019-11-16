using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyerAccessToMarketplace
{
    public class marketCustomer
    {
        private string clientName;
        private int jobType;
        private int quantity;
        private string origin;
        private string destination;
        private int vanType;

        public marketCustomer(string clientName, string jobType, string quantity, string origin, string destination, string vanType)
        {
            this.clientName = clientName;
            try
            {
                this.jobType = System.Convert.ToInt32(jobType);
            }
            catch(OverflowException)
            {

            }
            catch(FormatException)
            {

            }

            try
            {
                this.jobType = System.Convert.ToInt32(quantity);
            }
            catch (OverflowException)
            {

            }
            catch (FormatException)
            {

            }

            this.origin = origin;
            this.destination = destination;

            try
            {
                this.vanType = System.Convert.ToInt32(vanType);
            }
            catch(OverflowException)
            {
               
            }
            catch(FormatException)
            {

            }

        }
    }
}
