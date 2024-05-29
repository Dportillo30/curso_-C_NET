using api.core.ejemplo.DataAccess;
using api.core.ejemplo.Models;
using System.Threading.Tasks;

namespace api.core.ejemplo.Repository
{
    public class ModelItemRepository : IModelItemRepository
    {
        private readonly IDataAccess _context;

        public ModelItemRepository(IDataAccess context)
        {
            _context = context;
        }

        public void UpdateModelITem(ModelItem model)
        {
             _context.ModelItem.Update(model);
             _context.SaveChangesAsync();
        }
        public async Task AddModelItem (ModelItem model)
        {
            await _context.ModelItem.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task<ModelItem> Get(int id)
        {
            return await _context.ModelItem.FindAsync(id);
        }
    }
}
