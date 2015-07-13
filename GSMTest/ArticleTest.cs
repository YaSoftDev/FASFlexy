using System;
using GSMEF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Data;

namespace GSMTest
{
    [TestClass]
    public class ArticleTest
    {
        [TestMethod]
        public void TestAjouterArticle()
        {
            using (var ctx = new GSMDBEntities())
            {
                Article art = new Article();
                art.Désignation = "05 55 26 33 20";
                art.Type = "Puce Oooredoo";
                ctx.Articles.Add(art);
                int affectedRecords = ctx.SaveChanges();
                Assert.IsTrue(affectedRecords > 0);
            }
        }

        [TestMethod]
        public void TestFetchArticle()
        {
            using (var ctx = new GSMDBEntities())
            
            {
                Article art = ctx.Articles.Where(a => a.Désignation.Equals("05 55 26 33 20")).FirstOrDefault();
                Assert.IsTrue(art != null);
            }
        }
    }
}
