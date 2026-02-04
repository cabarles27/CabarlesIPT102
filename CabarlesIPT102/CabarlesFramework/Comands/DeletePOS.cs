using CabarlesDomain.Commands;
using CabarlesFramework.Comands; 
using CabarlesFramework.Extensions;
using CabarlesFramework.Models;
using CabarlesRepository.Interface;
using System.Collections.Generic;
using System.Text;


namespace CabarlesFramework.Coomands
{
    
    public class DeletePOS : IDeletePOS
    {
        private readonly string _connectionName = "DefaultConnection";
        private readonly string _storedProcedureName;
        private readonly IRepository _reposository;

        public DeletePOS(IRepository reposository)
        {
            _storedProcedureName = "DeletePOS";
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

