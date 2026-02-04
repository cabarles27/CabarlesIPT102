using CabarlesFramework.Extensions;
using CabarlesFramework.Models;
using CabarlesRepository.Interface;
using CabarlesDomain.Commands;

namespace CabarlesFramework.Comands
{

    public interface CreatePOS
    {
     
        public class CreatePOS : ICreatePOS
        {
            private readonly string _connectionName = "DefaultConnection";
            private readonly string _storedProcedureName;
            private readonly IRepository _reposository;

            public CreatePOS(IRepository reposository)
            {
                _storedProcedureName = "[dbo].[CreatePOS]";
                _reposository = reposository;
            }

            public async Task<bool> ExecuteAsync(POS_Models model)
            {
                var param = model.ToPOSDynamicParameters();
                return await _reposository.SaveDataAsync(
                    _connectionName,
                    _storedProcedureName,
                    param
                ); 
            }
        }
    }
}

