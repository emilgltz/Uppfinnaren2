﻿using System.Collections.Generic;

namespace Uppfinnar3n.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _appDbContext.Categories;
            }
        }
    }
}
