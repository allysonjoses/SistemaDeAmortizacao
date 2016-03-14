using System.Collections.Generic;
// <copyright file="EmprestimoAmericanoTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDeAmortizacao.Modelo.Modelo;

namespace SistemaDeAmortizacao.Modelo.Modelo.Tests
{
    [TestClass]
    [PexClass(typeof(EmprestimoAmericano))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EmprestimoAmericanoTest
    {

        [PexMethod]
        public List<Parcela> GerarEmprestimo([PexAssumeUnderTest]EmprestimoAmericano target)
        {
            List<Parcela> result = target.GerarEmprestimo();
            return result;
            // TODO: add assertions to method EmprestimoAmericanoTest.GerarEmprestimo(EmprestimoAmericano)
        }
    }
}
