using MultiShop.Discount.Dtos;
using MultiShop.Discount.Entities;

namespace MultiShop.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponsAsync();
        Task<GetByIDDiscountCouponDto> GetDiscountCouponsByIDAsync(int id );
        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto);
        Task DeleteDiscountCouponAsync(int id);
        Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto);
    }
}
