using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CabarlesRepository.Interface;
using CabarlesFramework.Models;
using Dapper;
using System.Data;
namespace CabarlesFramework.Queries
{
    public interface IGetAllPOS
    { 
        
            Task<IEnumerable<POS_Models>> ExecuteAsync();
    }

        public class GetAllPOS : IGetAllPOS
        {
            private readonly string _connectionName = "DefaultConnection";
            private readonly string _storeProcedureName;
            private readonly IRepository _repository;

            public GetAllPOS(IRepository repository)
            {
                _storeProcedureName = "GetAllEmployees";
                _repository = repository;
            }

            public async Task<IEnumerable<POS_Models>> ExecuteAsync()
            {
                var data = await _repository.GetDataAsync<POS_Models>(_connectionName, _storeProcedureName);
                return data;
            }
        }
 }

