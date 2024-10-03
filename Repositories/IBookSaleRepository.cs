using BookSale.Mod;

namespace BookSale.Repositories;

public interface IBookSaleRepository{
    Task AddNewSale(Booksale bookSale);   
}