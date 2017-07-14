using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;

namespace UnitTestProject1
{
    [TestClass]
    public class TurbomixConRepositoryTest
    {
        [TestMethod]
        public void TestCocinarConRepository()
        {
            //IBascula bascula = new BasculaService();
            //ICocina cocina = new CocinaService();
            Alimento mAlimento1 = new Alimento();
            Alimento mAlimento2 = new Alimento();
            mAlimento1.Peso = 7;
            mAlimento1.Nombre = "Alimento1";
            mAlimento2.Peso = 5;
            mAlimento2.Nombre = "Alimento2";
            Receta receta = new Receta("Alimento1", "Alimento2", 2, 2);
            IRecetaRepository recetaRepository = new RecetaRepository();


            IRecetarioService sut = new RecetarioService();

            sut.CocinarReceta(mAlimento1, mAlimento2, receta);

            //Assert.IsTrue(recetaRepository.list);
        }
    }
}
