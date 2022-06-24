using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.PluginInterfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
    }
}
