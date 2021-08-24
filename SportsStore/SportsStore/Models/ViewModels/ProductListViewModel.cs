using SportsStore.Models;
using SportsStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Views
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Poducts { get; set; }
        public PagingInfo PagingInfo{ get; set; }
    }
}
