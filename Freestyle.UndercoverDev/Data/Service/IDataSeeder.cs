using Data.Models;

namespace Data.Service;
public interface IDataSeeder
{
    Task ExtractMatchDatasetToDatabase();
}