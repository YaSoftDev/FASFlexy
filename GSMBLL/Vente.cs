using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMEF;
using GSMBLL.DTOs;
namespace GSMBLL
{
    public static class Vente
    {

        public static VenteDTO ConvertToDTO(GSMEF.Vente data)
        {
            VenteDTO A = new VenteDTO()
            {
                Id = data.Id,
                ArticleId = data.ArticleId,
                DateVente = data.DateVente,
                MontantVente = data.MontantVente

            };
            return A;
        }

        public static GSMEF.Vente ConvertFromDTO(VenteDTO data)
        {
            GSMEF.Vente V = new GSMEF.Vente()
            {
                Id = data.Id,
                ArticleId = data.ArticleId,
                DateVente = data.DateVente,
                MontantVente = data.MontantVente
            };
            return V;

        }
    }
}
