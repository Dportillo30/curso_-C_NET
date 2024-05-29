using api.core.ejemplo.Models;
using System.Threading.Tasks;

namespace api.core.ejemplo.Repository
{
    public interface IModelItemRepository
    {
        Task AddModelItem(ModelItem model);

        Task<ModelItem> Get(int id);

        void UpdateModelITem(ModelItem model);
    }
}
