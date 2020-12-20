using System.Collections.Generic;
using Aurora.Domain.Models;

namespace Aurora.Domain.Interfaces
{
    // Atende à camada de interface do usuário: inserção, atualização, deleção, busca
    public interface IServiceWorker
    {
        WorkerModel Insert(CreateWorkerModel userModel);

        WorkerModel Update(int id, UpdateWorkerModel userModel);

        void Delete(int id);

        WorkerModel RecoverById(int id);

        IEnumerable<WorkerModel> RecoverAll();
    }
}
