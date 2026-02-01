using CabarlesDomain.Commands;
using CabarlesFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CabarlesDomain.Commands
{
    public interface ICreatePOS
    {
            Task<bool> ExecuteAsync(POS_Models model);
        
    }
}
