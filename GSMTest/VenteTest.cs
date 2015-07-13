using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSMEF;
using System.Linq;
using System.Data;

namespace GSMTest
{
    [TestClass]
    public class VenteTest
    {
        [TestMethod]
        public void TestAddVente()
        {
            using (var ctx = new GSMDBEntities())
            {
                var art = ctx.Articles.Where(a => a.Désignation.Equals("05 55 26 33 20")).SingleOrDefault();
                Vente v = new Vente()
                {
                    ArticleId = art.Id,
                    DateVente = DateTime.Now.AddDays(-1),
                    MontantVente = 10000
                };
                art.Ventes.Add(v);
                int count = ctx.SaveChanges();
                Assert.IsTrue(count != 0 && v.Id != 0);
            }
        }
    }
}
