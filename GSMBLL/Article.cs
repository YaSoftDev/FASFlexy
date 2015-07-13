using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMEF;
using GSMBLL.DTOs;

namespace GSMBLL
{
    public static class Article
    {
        #region Gets

        public static ArticleDTO GetArticle(int id, bool deepLoad)
        {
            ArticleDTO a = new ArticleDTO();
            using (GSMDBEntities ctx = new GSMDBEntities())
            {
                var result = ctx.Articles.Where(x => x.Id.Equals(id)).SingleOrDefault();
                a = Article.ConvertToDTO(result, deepLoad);
            }
            return a;
        }

        #endregion

        #region Save
        
        public static ArticleDTO SaveArticle(ArticleDTO a)
        {
            GSMEF.Article EA = Article.ConvertFromDTO(a);
            using (var ctx = new GSMDBEntities())
            {
                if (EA.Id > 0)
                {
                    ctx.Entry(EA).State = System.Data.Entity.EntityState.Modified;
                    foreach (var child in EA.Ventes)
                    {
                        ctx.Entry(child).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                }
                else
                {
                    EA = Article.ConvertFromDTO(a);
                    ctx.Articles.Add(EA);
                    a.Id = EA.Id;
                    //because of DTOs we need to firm upthe FKs
                    foreach (var child in a.VentesDto)
                    {
                        child.ArticleId = a.Id;
                    }
                }
            }
            return a;
        }

        #endregion

        #region Delete
        
        public static bool DeleteVente(int articleID, int venteID)
        {
            using (var ctx = new GSMDBEntities())
            {

                var venteToRemove = ctx.Ventes.Where(v => v.Id.Equals(venteID) && v.Article.Id.Equals(articleID)).SingleOrDefault();
                ctx.Ventes.Remove(venteToRemove);
                return (ctx.SaveChanges() > 0);
            }
        }

        #endregion

        #region Conversion
        
        public static ArticleDTO ConvertToDTO(GSMEF.Article data,bool deepLoad)
        {
            ArticleDTO A = new ArticleDTO()
            {
                Id = data.Id,
                Désignation = data.Désignation,
                Observations = data.Observations,
                Type = data.Type,

            };
            if (deepLoad)
            {
                foreach (GSMEF.Vente v in data.Ventes)
                {
                    A.VentesDto.Add(Vente.ConvertToDTO(v));
                }
            }
            return A;
        }

        public static GSMEF.Article ConvertFromDTO(ArticleDTO data)
        {
            GSMEF.Article A = new GSMEF.Article()
            {
                Id = data.Id,
                Désignation = data.Désignation,
                Type = data.Type,
                Observations = data.Observations

            };
            foreach(VenteDTO a in data.VentesDto)
            {
                A.Ventes.Add(Vente.ConvertFromDTO(a));
            }
            return A;
        }

        #endregion

    }
}
			 
	
