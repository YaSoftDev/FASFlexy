using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSMBLL;
using GSMBLL.DTOs;
namespace GSMFLexy___
{
    public partial class VenteDétails : Form
    {
        ArticleDTO ArticleParentObject = new ArticleDTO();
        VenteDTO CurrentVente = new VenteDTO();
        
        public VenteDétails(VenteDTO dataToModify)
        {
            InitializeComponent();
            CurrentVente = dataToModify;
            this.venteDTOBindingSource.DataSource = CurrentVente;
            this.venteDTOBindingSource.ResetCurrentItem();
           GetArticle(dataToModify.ArticleId);
        }

        private void GetArticle(int id)
        {
            try
            {
                ArticleParentObject = Article.GetArticle(id, false);
                ArticleParentObject.VentesDto.Add(CurrentVente);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void VenteDétails_Load(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                ArticleParentObject = Article.SaveArticle(ArticleParentObject);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
