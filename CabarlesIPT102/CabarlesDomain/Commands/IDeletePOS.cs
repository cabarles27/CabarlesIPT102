using CabarlesFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace CabarlesDomain.Commands
{

    public interface IDeletePOS
    {
        Task<bool> ExecuteAsync(POS_Models model);

    }
}
