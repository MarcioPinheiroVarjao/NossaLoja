﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NossaLoja.Cadastros.Application.Application;

namespace NossaLoja.Cadastros.Application.Test.Application
{
    [TestClass]
    public class ClienteApplicationTest : BaseApplicationTest
    {
        [TestMethod]
        public void Clientes_SomaUmMaisUm_Sucesso()
        {
            var clienteApplication = new ClienteApplication();

            var resultado = clienteApplication.SomaMaisUm();

            Assert.AreEqual(2, resultado);
        }
    }
}
