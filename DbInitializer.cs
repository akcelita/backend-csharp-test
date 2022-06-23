using AkcelitaTest.Models;

namespace AkcelitaTest;

public class DbInitializer
{
    private DatabaseContext _context;

    public DbInitializer(DatabaseContext context)
    {
        _context = context;
    }

    public void Initialize()
    {


        _context.SaveChanges();
    }
}