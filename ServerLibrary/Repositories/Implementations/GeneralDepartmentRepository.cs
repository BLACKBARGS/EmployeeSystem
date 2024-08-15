using BaseLibrary.Entities;
using BaseLibrary.Responses;
using Microsoft.EntityFrameworkCore;
using ServerLibrary.Data;
using ServerLibrary.Repositories.Contracts;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ServerLibrary.Repositories.Implementations
{
    public class GeneralDepartmentRepository : IGenericRepositoryInterface<GeneralDepartment>
    {
        private readonly AppDbContext _appDbContext;

        // Construtor correto
        public GeneralDepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<GeneralResponse> DeleteById(int id)
        {
            var dep = await _appDbContext.GeneralDepartments.FindAsync(id);
            if (dep is null) return NotFound();
            _appDbContext.GeneralDepartments.Remove(dep);
            await Commit();
            return Success();
        }

        public async Task<List<GeneralDepartment>> GetAll() => await _appDbContext.GeneralDepartments.ToListAsync();

        public async Task<GeneralDepartment> GetById(int id) => await _appDbContext.GeneralDepartments.FindAsync(id);

        public async Task<GeneralResponse> Insert(GeneralDepartment item)
        {
            if (!await CheckName(item.Name!)) return new GeneralResponse(false, "Sorry department already added");
            _appDbContext.GeneralDepartments.Add(item);
            await Commit();
            return Success();
        }

        public async Task<GeneralResponse> Update(GeneralDepartment item)
        {
            var dep = await _appDbContext.GeneralDepartments.FindAsync(item.Id);
            if (dep is null) return NotFound();
            dep.Name = item.Name;
            await Commit(); // Adicione o Commit após a atualização
            return Success();
        }

        private static GeneralResponse NotFound() => new(false, "Sorry department not found");
        private static GeneralResponse Success() => new(true, "Process completed");
        private async Task Commit() => await _appDbContext.SaveChangesAsync();
        private async Task<bool> CheckName(string name)
        {
            var item = await _appDbContext.GeneralDepartments.FirstOrDefaultAsync(x => x.Name!.ToLower() == name.ToLower());
            return item is null;
        }
    }
}
