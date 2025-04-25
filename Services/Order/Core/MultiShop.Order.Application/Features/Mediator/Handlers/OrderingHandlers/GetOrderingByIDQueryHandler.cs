using MediatR;
using MultiShop.Order.Application.Features.Mediator.Queries.OrderingQueries;
using MultiShop.Order.Application.Features.Mediator.Results.OrderingResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class GetOrderingByIDQueryHandler : IRequestHandler<GetOrderingByIDQuery, GetOrderingByIDQueryResult>
    {
        private readonly IRepository<Ordering> _repository;

        public GetOrderingByIDQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderingByIDQueryResult> Handle(GetOrderingByIDQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetByIDAsync(request.ID);
            return new GetOrderingByIDQueryResult
            {
                UserID = result.UserID,
                OrderingID = result.OrderingID,
                TotalPrice = result.TotalPrice,
                OrderDate = result.OrderDate,
                
            };
        }
    }
   
}
