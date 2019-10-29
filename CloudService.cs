using ServiceManagement.CloudServices.Models;
using System;

using System.Net.Http;


// Learned from a oline Azure Cloud Service course and implement the code as follows

namespace ServiceManagement.CloudServices
{
    public class CloudServicesApi : BaseApi
    {
        public CloudServicesApi(AzureSubscription Subscription)
            : base(Subscription)
        { }

        public override Uri ServiceManagementUri
        {
            get
            {
                return new Uri(string.Format("{0}/services/hostedservices",
                    base.ServiceManagementUri));
            }
        }

        public Uri Create(string ServiceName, string Location)
        {
          
            byte[] serviceNameBytes = System.Text.Encoding.UTF8.GetBytes(ServiceName);
            CreateHostedService requestBody = new CreateHostedService()
            {
                ServiceName = ServiceName,
                Label = Convert.ToBase64String(serviceNameBytes),
                Location = Location
            };


            HttpResponseMessage response;


            return response.Headers.Location;
        }

        public void Delete(string ServiceName)
        {
            
            HttpResponseMessage response = this.HttpClientInstance.DeleteAsync(
                string.Format("{0}/{1}", this.ServiceManagementUri, ServiceName)).Result;
            response.EnsureSuccessStatusCode();
        }
    }