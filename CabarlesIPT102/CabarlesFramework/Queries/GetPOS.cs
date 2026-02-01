using CabarlesRepository.Interface;
using CabarlesFramework.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CabarlesFramework.Queries
{
    public interface IGetPOSById
    {
        Task<POS_Models?> ExecuteAsync(int posId);
    }
    public class GetEmployeeById : IGetPOSById
    {
        private readonly string _connectionName = "DefaultConnection";
        private readonly string _storeProcedureName;
        private readonly IRepository _repository;

        public GetEmployeeById(IRepository repository)
        {
            _storeProcedureName = "GetPOS";
            _repository = repository;
        }

        public async Task<POS_Models?> ExecuteAsync(int Id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", Id);
            var data = await _repository.GetDataAsync<POS_Models>(_connectionName, _storeProcedureName, parameters);
            return data.FirstOrDefault();
        }
    }
}
    

