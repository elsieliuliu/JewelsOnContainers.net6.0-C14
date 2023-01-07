using CartApi.Models;

namespace CartApi.Data
{
    public interface ICartRepository
    {
        Task<Cart> GetCartAsync(string cartId);
        Task<Cart> UpdateCartAsync(Cart basket);
        Task<bool> DeleteCartAsync(string cartId);
    }
}
