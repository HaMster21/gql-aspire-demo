namespace DemoServer.Types;

[QueryType]
public class Query
{
    public async Task<Book?> GetBookAsync(int bookId, CatalogDbContext dbContext)
        => await dbContext.Books.FindAsync(bookId);
}
