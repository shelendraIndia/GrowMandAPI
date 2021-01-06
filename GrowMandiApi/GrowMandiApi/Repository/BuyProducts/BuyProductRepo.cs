using GrowMandiApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowMandiApi.Repository.BuyProducts
{
    
    public class BuyProductRepo : IBuyProductRepo
    {
        private readonly GrowMandi_TestContext _context;

        public BuyProductRepo(GrowMandi_TestContext context) {
            _context = context;
        }
        public string test()
        {
            return _context.MandiBanner.FirstOrDefault().ImageType;
        }

    }
}
