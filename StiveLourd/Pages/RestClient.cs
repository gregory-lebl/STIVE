using RestSharp;
using System;

namespace StiveLourd.Pages
{
    internal class RestClient
    {
        private string v;

        public RestClient(string v)
        {
            this.v=v;
        }

        internal void Execute(RestRequest request)
        {
            throw new NotImplementedException();
        }
    }
}