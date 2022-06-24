using CoreBusiness;
using System.Collections.Generic;
using UseCases.PluginInterfaces;

namespace UseCases
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository categoryRepository;
        public ViewCategoriesUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRepository.GetCategories();
        }
    }
}
