﻿using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces;

namespace Ecommerce.Application.Services;

public class CategoryService : ICategoryService
{
    public Task<IEnumerable<CategoryDTO>> GetCategorias()
    {
        throw new NotImplementedException();
    }

    public Task<CategoryDTO> GetById(int? id)
    {
        throw new NotImplementedException();
    }
    
    public Task Add(CategoryDTO categoryDto)
    {
        throw new NotImplementedException();
    }
    
    public Task Update(CategoryDTO categoryDto)
    {
        throw new NotImplementedException();
    }

    public Task Remove(int? id)
    {
        throw new NotImplementedException();
    }

}
