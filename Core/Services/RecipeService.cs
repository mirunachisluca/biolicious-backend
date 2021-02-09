﻿using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RecipeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<RecipeDTO> GetByIdAsync(int id)
        {
            var spec = new RecipeSpecification(id);

            var recipe = await _unitOfWork.RecipeRepository.GetEntityWithSpec(spec);

            return _mapper.Map<RecipeDTO>(recipe);
        }

        public async Task<IReadOnlyList<RecipeDTO>> GetRecipesAsync(RecipeSpecificationParams parameters)
        {
            var spec = new RecipeSpecification(parameters);

            var recipes = await _unitOfWork.RecipeRepository.ListAsync(spec);

            return _mapper.Map<IReadOnlyList<RecipeDTO>>(recipes);
        }

        public async Task InsertAsync(Recipe recipe)
        {
            await _unitOfWork.RecipeRepository.InsertAsync(recipe);
            await _unitOfWork.Save();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.RecipeRepository.DeleteAsync(id);
            await _unitOfWork.Save();
        }

        public async Task DeleteAsync(Recipe recipe)
        {
            _unitOfWork.RecipeRepository.Delete(recipe);
            await _unitOfWork.Save();
        }

        public async Task UpdateAsync(Recipe recipe)
        {
            _unitOfWork.RecipeRepository.Update(recipe);
            await _unitOfWork.Save();
        }


    }
}