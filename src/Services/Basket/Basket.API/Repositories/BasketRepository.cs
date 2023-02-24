using Basket.API.Data;
using Basket.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Basket.API.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly BasketDbContext _context;

        public BasketRepository(BasketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task DeleteBasket(string userName)
        {
            ShoppingCart ShoppingCart = await _context.ShoppingCart.FindAsync(userName);
            if (ShoppingCart != null)
            {
                _context.ShoppingCart.Remove(ShoppingCart);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ShoppingCart> GetBasket(string userName)
        {
            var ShoppingCart = await _context.ShoppingCart.FindAsync(userName);
            var CartDetails =  await _context.ShoppingCartItem.Where(x => x.ShoppingCartUserName == userName).ToListAsync();
            var newCart = new ShoppingCart()
            {
                UserName = ShoppingCart.UserName,
                CartItems = CartDetails
            };
            return newCart;
        }

        public async Task<ShoppingCart> UpdateBasket(ShoppingCart basket)
        {
            //var updateResult = _context.ShoppingCart.Attach(basket);
            //updateResult.State = EntityState.Modified;
            //await _context.SaveChangesAsync();
            var userExist = _context.ShoppingCart.Any(u => u.UserName == basket.UserName);
            if (!userExist)
            {
                await _context.ShoppingCart.AddAsync(basket);
            }
            else
            {
                var updateResult = _context.ShoppingCart.Attach(basket);
                updateResult.State = EntityState.Modified;
            }

            await _context.SaveChangesAsync();

            return await GetBasket(basket.UserName);
        }
    }
}
