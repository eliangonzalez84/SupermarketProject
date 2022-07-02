using CoreBusiness;

namespace UseCases
{
    public interface IViewProductsUseCase
    {
        public System.Collections.Generic.IEnumerable<Product> Execute();
    }
}