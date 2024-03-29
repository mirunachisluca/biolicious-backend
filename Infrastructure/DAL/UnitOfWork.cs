﻿using Core.Entities;
using Core.Entities.Order;
using Core.Interfaces;
using Infrastructure.Data;
using System;
using System.Threading.Tasks;

namespace Infrastructure.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDbContext _context;
        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<ProductBrand> _productBrandRepository;
        private IGenericRepository<ProductCategory> _productCategoryRepository;
        private IGenericRepository<ProductSubcategory> _productSubcategoryRepository;
        private IGenericRepository<Recipe> _recipeRepository;
        private IGenericRepository<RecipeIngredient> _recipeIngredientRepository;
        private IGenericRepository<RecipeStep> _recipeStepRepository;
        private IGenericRepository<RecipeCategory> _recipeCategoryRepository;
        private IGenericRepository<Intake> _intakeRepository;
        private IGenericRepository<Diet> _dietRepository;
        private IGenericRepository<Order> _orderRepository;
        private IGenericRepository<OrderItem> _orderItemRepository;
        private IGenericRepository<DeliveryMethod> _deliveryMethodRepository;

        public UnitOfWork(StoreDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Product> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new GenericRepository<Product>(_context);

                }
                return _productRepository;
            }
            set
            {
                _productRepository = value;
            }
        }

        public IGenericRepository<ProductBrand> ProductBrandRepository
        {
            get
            {
                if (_productBrandRepository == null)
                {
                    _productBrandRepository = new GenericRepository<ProductBrand>(_context);
                }
                return _productBrandRepository;
            }
            set
            {
                _productBrandRepository = value;
            }
        }

        public IGenericRepository<ProductCategory> ProductCategoryRepository
        {
            get
            {
                if (_productCategoryRepository == null)
                {
                    _productCategoryRepository = new GenericRepository<ProductCategory>(_context);
                }
                return _productCategoryRepository;
            }
            set
            {
                _productCategoryRepository = value;
            }
        }

        public IGenericRepository<ProductSubcategory> ProductSubcategoryRepository
        {
            get
            {
                if (_productSubcategoryRepository == null)
                {
                    _productSubcategoryRepository = new GenericRepository<ProductSubcategory>(_context);
                }
                return _productSubcategoryRepository;
            }
            set
            {
                _productSubcategoryRepository = value;
            }
        }

        public IGenericRepository<Recipe> RecipeRepository
        {
            get
            {
                if (_recipeRepository == null)
                {
                    _recipeRepository = new GenericRepository<Recipe>(_context);
                }
                return _recipeRepository;
            }
            set
            {
                _recipeRepository = value;
            }
        }

        public IGenericRepository<RecipeIngredient> RecipeIngredientRepository
        {
            get
            {
                if (_recipeIngredientRepository == null)
                {
                    _recipeIngredientRepository = new GenericRepository<RecipeIngredient>(_context);
                }
                return _recipeIngredientRepository;
            }
            set
            {
                _recipeIngredientRepository = value;
            }
        }

        public IGenericRepository<RecipeStep> RecipeStepRepository
        {
            get
            {
                if (_recipeStepRepository == null)
                {
                    _recipeStepRepository = new GenericRepository<RecipeStep>(_context);
                }
                return _recipeStepRepository;
            }
            set
            {
                _recipeStepRepository = value;
            }
        }

        public IGenericRepository<RecipeCategory> RecipeCategoryRepository
        {
            get
            {
                if (_recipeCategoryRepository == null)
                {
                    _recipeCategoryRepository = new GenericRepository<RecipeCategory>(_context);
                }
                return _recipeCategoryRepository;
            }
            set
            {
                _recipeCategoryRepository = value;
            }
        }

        public IGenericRepository<Intake> IntakeRepository
        {
            get
            {
                if (_intakeRepository == null)
                {
                    _intakeRepository = new GenericRepository<Intake>(_context);
                }
                return _intakeRepository;
            }
            set
            {
                _intakeRepository = value;
            }
        }

        public IGenericRepository<Diet> DietRepository
        {
            get
            {
                if (_dietRepository == null)
                {
                    _dietRepository = new GenericRepository<Diet>(_context);
                }
                return _dietRepository;
            }
            set
            {
                _dietRepository = value;
            }
        }

        public IGenericRepository<Order> OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new GenericRepository<Order>(_context);
                }
                return _orderRepository;
            }
            set
            {
                _orderRepository = value;
            }
        }

        public IGenericRepository<OrderItem> OrderItemRepository
        {
            get
            {
                if (_orderItemRepository == null)
                {
                    _orderItemRepository = new GenericRepository<OrderItem>(_context);
                }
                return _orderItemRepository;
            }
            set
            {
                _orderItemRepository = value;
            }
        }

        public IGenericRepository<DeliveryMethod> DeliveryMethodRepository
        {
            get
            {
                if (_deliveryMethodRepository == null)
                {
                    _deliveryMethodRepository = new GenericRepository<DeliveryMethod>(_context);
                }
                return _deliveryMethodRepository;
            }
            set
            {
                _deliveryMethodRepository = value;
            }
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}
