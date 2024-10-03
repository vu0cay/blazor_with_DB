using BookSale.Mod;
using BookSale.Repositories;
using Microsoft.AspNetCore.Components;

namespace BookSale.Components.Pages;

public class AddBookSaleBase : ComponentBase
{

    public Booksale bookSale { get; set; } = new Booksale();

    [Inject]
    IBookSaleRepository bookSaleRepository { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }

    public async Task HandleValidSubmit()
    {
        await bookSaleRepository.AddNewSale(bookSale);
        navigationManager.NavigateTo("/");
    }
    public async Task Form_Calculate()
    {
        HandleValidSubmit();
    }

}