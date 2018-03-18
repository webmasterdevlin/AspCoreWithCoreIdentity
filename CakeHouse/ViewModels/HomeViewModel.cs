using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeHouse.Models;

namespace CakeHouse.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Cake> Cakes { get; set; }
    }
}
