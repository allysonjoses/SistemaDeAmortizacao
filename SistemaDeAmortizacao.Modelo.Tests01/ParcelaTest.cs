// <copyright file="ParcelaTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDeAmortizacao.Modelo.Modelo;

namespace SistemaDeAmortizacao.Modelo.Modelo.Tests
{
    /// <summary>This class contains parameterized unit tests for Parcela</summary>
    [PexClass(typeof(Parcela))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ParcelaTest
    {
        /// <summary>Test stub for .ctor(Double, Double, Double, Double, String)</summary>
        [PexMethod(MaxRunsWithoutNewTests = 1000)]
        [PexAllowedException(typeof(InvalidOperationException))]
        public Parcela ConstructorTest(
            double Prestacao,
            double Juros,
            double Amortizacao,
            double Saldo,
            string Identificador
        )
        {
            Parcela target
               = new Parcela(Prestacao, Juros, Amortizacao, Saldo, Identificador);
            return target;
            // TODO: add assertions to method ParcelaTest.ConstructorTest(Double, Double, Double, Double, String)
        }
    }
}
