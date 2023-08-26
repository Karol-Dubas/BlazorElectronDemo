using Microsoft.EntityFrameworkCore;

namespace BlazorElectronDemo.Data;

public class ItemsService
{
    private readonly AppDbContext _dbContext;

    public ItemsService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task Add(string name)
    {
        var newItem = new Item { Name = name };
        _dbContext.Items.Add(newItem);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task Remove(int id)
    {
        var item = await _dbContext.Items.FindAsync(id);
        
        if (item is null)
            return;
        
        _dbContext.Items.Remove(item);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<List<Item>> GetAll()
    {
        return await _dbContext.Items.ToListAsync();
    }
}