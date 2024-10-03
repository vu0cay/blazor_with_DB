

using BookSale.Mod;

namespace BookSale.Repositories;

public class BookSaleRepository : IBookSaleRepository {
    MydbContext mydContext;

    public BookSaleRepository(MydbContext context) {
        this.mydContext = context;
    }
    
    public async Task AddNewSale(Booksale bookSale) {
        this.mydContext.Add(bookSale);
        this.mydContext.SaveChangesAsync();
    }
}