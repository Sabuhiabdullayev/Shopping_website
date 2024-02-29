using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidatorRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.ProductDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contanier
{
    public static class Extensions
    {
        public static void ContanierDependencies(this IServiceCollection Services)
        {
            Services.AddScoped<IProductService, ProductManager>();
            Services.AddScoped<IProductDal, EfProductDal>();
            Services.AddScoped<IProductCommentService, ProductCommentManager>();
            Services.AddScoped<IProductCommentDal, EfProductCommentDal>();
            Services.AddScoped<IOperatorContactService, OperatorContactManager>();
            Services.AddScoped<IOperatorContactDal, EfOperatorContactDal>();
            Services.AddScoped<IProductCommentService, ProductCommentManager>();
            Services.AddScoped<IProductCommentDal, EfProductCommentDal>();
            Services.AddScoped<ICategoryService, CategoryManager>();
            Services.AddScoped<ICategoryDal, EfCategoryDal>();
            Services.AddScoped<ICategory2Service, Category2Manager>();
            Services.AddScoped<ICategory2Dal, EfCategory2Dal>();
            Services.AddScoped<ICatalogService, CatalogManager>();
            Services.AddScoped<ICatalogDal, EfCatalogDal>();
            Services.AddScoped<INotificationService, NotificationManager>();
            Services.AddScoped<INotificationDal, EfNotificationDal>();
            Services.AddScoped<IProductComplaintService, ProductComplaintManager>();
            Services.AddScoped<IProductComplaintDal, EfProductComplaintDal>();
            Services.AddScoped<IAdsService, AdsManager>();
            Services.AddScoped<IAdsDal, EfAdsDal>();
            Services.AddScoped<ICartService, CartManager>();
            Services.AddScoped<ICartDal, EfCartDal>();
            Services.AddScoped<IProductViewService, ProductViewManager>();
            Services.AddScoped<IProductViewDal, EfProductViewDal>(); 
            Services.AddScoped<IProductLikeService, ProductLikeManager>();
            Services.AddScoped<IProductLikeDal, EfProductLikeDal>();
        }
        public static void CustomerValidator(this IServiceCollection Services)
        {
            //Services.AddTransient<IValidator<SignUpDto>, SignUpValidator>();
            Services.AddTransient<IValidator<ProductAddDto>, ProductValidator>();
        }
    }
}
