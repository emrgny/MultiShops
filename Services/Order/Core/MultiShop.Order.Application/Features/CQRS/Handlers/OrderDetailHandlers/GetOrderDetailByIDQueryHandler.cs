using MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries;
using MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailByIDQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailByIDQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderDetailQueryByIDResult> Handle(GetOrderDetailByIDQuery query)
        {
            var x = await _repository.GetByIDAsync(query.ID);
            return new GetOrderDetailQueryByIDResult
            {

                ProductID = x.ProductID,
                OrderDetailID = x.OrderDetailID,
                ProductAmount = x.ProductAmount,
                ProductPrice = x.ProductPrice,
                ProductTotalPrice = x.ProductTotalPrice,
                ProductName = x.ProductName,
                OrderingID = x.OrderingID,

            };
        }
    }
}
