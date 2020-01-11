using ExamenNet.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNet.UnitOfWork
{
    public interface IExamenDBUnitOfWork
    {
        IProduct Product { get; }
        ILogin Login { get; }
    }
}
