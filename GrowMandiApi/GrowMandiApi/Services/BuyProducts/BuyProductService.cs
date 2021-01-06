using GrowMandiApi.Repository.BuyProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrowMandiApi.Services.BuyProducts
{

    public class BuyProductService : IBuyProductService
    {
        private readonly IBuyProductRepo _buyProductRepo;
        public BuyProductService(IBuyProductRepo buyProductRepo) {
            _buyProductRepo = buyProductRepo;
        }

        public string test()
        {
            return _buyProductRepo.test();
        }
    }
}
