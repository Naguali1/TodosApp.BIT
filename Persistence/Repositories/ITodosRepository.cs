using Persistence.Models.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    interface ITodosRepository
    {
        Task<IEnumerable<TodoItemReadModel>> GetAllAsync();

        Task<TodoItemReadModel> GetAsync(Guid id);

        Task<int> SaveOrUpdateAsync(TodoItemReadModel model);

        Task<int> DeleteAsync(Guid id);
    }
}
