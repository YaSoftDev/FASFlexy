using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GSMBLL.DTOs
{
    [DataContract]
    public  class ArticleDTO
    {
        
        private int _Id;
        [DataMember]

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        private string _Désignation;
        [DataMember]

        public string Désignation
        {
            get { return _Désignation; }
            set { _Désignation = value; }
        }

        private string _Type;
        [DataMember]

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string _Observations;
        [DataMember]

        public string Observations
        {
            get { return _Observations; }
            set { _Observations = value; }
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

        private List<VenteDTO> _VentesDto = new List<VenteDTO>();
        [DataMember]

        public List<VenteDTO> VentesDto
        {
            get { return _VentesDto; }
            set { _VentesDto = value; }
        }

        
        

        
    }
}
