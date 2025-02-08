﻿using Ecommerce.Application.DTOs;

namespace Ecommerce.Application.Interfaces;
public interface ICategoryService
{
    Task<IEnumerable<CategoryDTO>> GetCategorias();
    Task<CategoryDTO> GetById(int? id);
    Task Add(CategoryDTO categoryDto);
    Task Update(CategoryDTO categoryDto);
    Task Remove(int? id);
}
