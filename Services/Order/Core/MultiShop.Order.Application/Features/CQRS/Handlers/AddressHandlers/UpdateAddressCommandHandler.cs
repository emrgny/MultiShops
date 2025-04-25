using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommmands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddressCommand command)
        {
            var value = await _repository.GetByIDAsync(command.AddressID);
            value.Detail = command.Detail;
            value.UserID = command.UserID;
            value.District=command.District;
            value.City=command.City;

            await _repository.UpdateAsync(value);

        }
    }
}
