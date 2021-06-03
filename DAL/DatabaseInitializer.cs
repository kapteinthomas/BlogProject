using System.Data.Entity;

namespace Blog.DAL
{
    public class DatabaseInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<DatabaseContext>
    {

    }
}