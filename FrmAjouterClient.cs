using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GestionClients
{
    public partial class FrmAjouterClient : Form
    {
        public FrmAjouterClient()
        {
            InitializeComponent();
        }
        private void butEnregistrer_Click(object sender, EventArgs e)
        {
            //vérifications pour company et ID
            if (txtCompanyname.Text == "" || txtCustomerID.Text == "")
            {
                MessageBox.Show("l'ID et le nom de la société sont obligatoires","erreur ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //sortie
                return;
            }
            //vérifier que l'ID n'a pas déjà été utilisé
            using (NorthwindEntities contexte = new NorthwindEntities())
            {
                var client = contexte.Customers.Find(txtCustomerID.Text);
                if (client != null)
                {
                    MessageBox.Show("cet ID client existe déjà", "erreur Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //sortie
                    return;
                }
            }
            //vérifier que l'ID est conforme : 5 lettres majuscules
            Regex er = new Regex(@"[A-Z]{5}");
            Match m = er.Match(txtCustomerID.Text);
            if (!m.Success)
            {
                MessageBox.Show("l'ID doit comporter 5 caractères alphabétiques majuscules", "erreur ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //sortie
                return;
            }
            //renvoyer OK pour que le code appelant sache que le formulaire est valide 
            this.DialogResult = DialogResult.OK;
            //fermer la fenêtre
            this.Close();
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
