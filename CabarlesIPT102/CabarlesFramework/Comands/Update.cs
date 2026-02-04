using CabarlesFramework.Extensions;
using CabarlesFramework.Models;
using CabarlesRepository.Interface;
using System.Text;
using CabarlesDomain.Commands;

namespace CabarlesFramework.Coomands
{
   
        public class UpdatePOS : IUpdatePOS
        {
            private readonly string _connectionName = "DefaultConnection";
            private readonly string _storedProcedureName;
            private readonly IRepository _reposository;

            public UpdatePOS(IRepository reposository)
            {
                _storedProcedureName = "UpdatePOS";
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



