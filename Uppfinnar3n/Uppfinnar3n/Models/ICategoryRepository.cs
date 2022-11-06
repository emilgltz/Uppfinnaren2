using System.Collections.Generic;

namespace Uppfinnar3n.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
