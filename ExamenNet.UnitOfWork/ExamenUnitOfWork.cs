using ExamenNet.Business.Implementacion;
using ExamenNet.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNet.UnitOfWork
{
    public class ExamenUnitOfWork : IExamenDBUnitOfWork
    {

        public ExamenUnitOfWork(string connectionString)
        {
            Product = new Product(connectionString);
            Login = new Login(connectionString);
        }

        public IProduct Product { get; private set; }
        public ILogin Login { get; private set; }
    }
}
