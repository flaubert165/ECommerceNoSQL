using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceNoSQL.Infrastructure.DataContext
{
    public class ECommerceDbSettings : IECommerceDbSettings
    {
        public string UsersCollectionName { get; set; } 
        public string ProductsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IECommerceDbSettings
    {
        string UsersCollectionName { get; set; }
        string ProductsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
