namespace SamlIdp.Owin
{
    using System.Collections.Generic;
    using System.Security.Cryptography.X509Certificates;
    using Kentor.AuthServices.WebSso;
    using Microsoft.Owin.Security.DataProtection;
    using System;
     
    public class SamlIdpOptions
    {
        public SamlIdpOptions()
        {
            BindingType = Saml2BindingType.HttpPost;
            ServiceProviders = new List<ServiceProvider>();
        }
        public bool ValidateServiceProvider { get; set; }
        public Func<string, string> ServiceProviderValidationMessage { get; set; }
        public string AuthenticationType { get; set; }
        public X509Certificate2 SigningCertificate { get; set; }
        public Saml2BindingType BindingType { get; set; }
        public IDictionary<string, string> ClaimMappings { get; set; }
        public List<ServiceProvider> ServiceProviders { get; set; }
        internal IDataProtector DataProtector { get; set; }
    }
}
