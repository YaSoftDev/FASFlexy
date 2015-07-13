using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GSMBLL.DTOs
{
    public class VenteDTO
    {
        private int _Id;
        [DataMember]

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _ArticleId;
        [DataMember]

        public int ArticleId
        {
            get { return _ArticleId; }
            set { _ArticleId = value; }
        }

        private decimal _MontantVente;
        [DataMember]

        public decimal MontantVente
        {
            get { return _MontantVente; }
            set { _MontantVente = value; }
        }

        private Nullable<System.DateTime> _DateVente;
        [DataMember]

        public Nullable<System.DateTime> DateVente
        {
            get { return _DateVente; }
            set { _DateVente = value; }
        }
        
        private bool _IsNew;
        [DataMember]

        public bool IsNew
        {
            get { return _IsNew; }
            set { _IsNew = value; }
        }

        private bool _IsDeleted;
        [DataMember]
        
        public bool IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
        }

        private ArticleDTO _ArticleDto = new ArticleDTO();
        [DataMember]

        public ArticleDTO ArticleDto
        {
            get { return _ArticleDto; }
            set { _ArticleDto = value; }
        }

        
     
    }
}
