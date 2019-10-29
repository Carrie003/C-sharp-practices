using System;

using System.Linq;
using System.Net.Http;


namespace ServiceManagement
{
    public class BaseApi
    {
        private AzureSubscription azureSubscription = null;

        public BaseApi(AzureSubscription Subscription)
        {
            if (Subscription == null)
            {
                throw new ArgumentNullException(
                    "Subscription", "Subscription parameter cannot be null.");
            }

            this.azureSubscription = Subscription;
        }

        
        public virtual Uri ServiceManagementUri
        {
            get;
        }

       
        
    }
}