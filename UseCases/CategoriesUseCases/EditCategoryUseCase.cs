
using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.PluginInterfaces;

namespace UseCases
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly ICategoryRepository categoryepository;

        public EditCategoryUseCase(ICategoryRepository categoryepository)
        {
            this.categoryepository = categoryepository;
        }

        public void Execute(Category category)
        {
            categoryepository.UpdateCategory(category);
        }
    }
}
