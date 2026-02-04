using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using CabarlesFramework.Models;

namespace CabarlesFramework.Extensions
{
    public static class POS_Extensions
   
    {
        public static DynamicParameters ToPOSDynamicParameters(this POS_Models model)
        {
            var param = new DynamicParameters();
            param.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);
            param.Add("@ProductName", model.ProductName, DbType.String, ParameterDirection.Input);
            param.Add("@Price", model.Price, DbType.String, ParameterDirection.Input);
            param.Add("@Quantity", model.Quantity, DbType.Int32, ParameterDirection.Input);
            param.Add("@TotalAmount", model.TotalAmount, DbType.String, ParameterDirection.Input);
            return param;
        }


    }
}
