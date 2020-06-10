using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace GestionClients
{
    public partial class FrmGestion : Form
    {
        NorthwindEntities contexte = new NorthwindEntities();
        public FrmGestion()
        {
            InitializeComponent();
            dgvNorthwind.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            remplirGrille();
            creationCompteurs();
        }
        public void remplirGrille()
        {
            dgvNorthwind.DataSource = contexte.Customers.ToList();
        }
        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjouterClient frm = new FrmAjouterClient();
            DialogResult resultat = frm.ShowDialog();
            //Vérifier que le formulaire est validé
            if (resultat == DialogResult.OK)
            {
                //créer un nouvelle instance de customer
                Customer c = new Customer();
                //remplir les propriétés
                c.CustomerID = frm.txtCustomerID.Text;
                c.CompanyName = frm.txtCompanyname.Text;
                c.Address = frm.txtAddress.Text;
                c.City = frm.txtCity.Text;
                c.ContactName = frm.txtContactName.Text;
                c.ContactTitle = frm.txtContactTitle.Text;
                c.Country = frm.txtCountry.Text;
                c.Fax = frm.txtFax.Text;
                c.Phone = frm.txtPhone.Text;
                c.PostalCode = frm.txtPostalCode.Text;
                c.Region = frm.txtRegion.Text;
                //ajouter le client à la collection DBSET du contexte
                contexte.Customers.Add(c);
                //s'attendre à une erreur
                try
                {
                    //enregistrer dans la base SQL server
                    contexte.SaveChanges();
                    using (PerformanceCounter perfCounter = new PerformanceCounter("compteursClients", "compteurAjouts", ""))
                    {
                        perfCounter.ReadOnly = false;
                        perfCounter.IncrementBy(10);

                    }
                    //mettre la grille à jour
                    remplirGrille();
                } catch (Exception ex)
                {
                    //prendre la version la plus verbeuse de l'erreur (en dev...)
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void supprimerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //récupérer l'ID client de la ligne sélectionnée
            string strID = dgvNorthwind.SelectedRows[0].Cells[0].Value.ToString();
            //trouver l'instance correspondante dans le contexte
            var client = contexte.Customers.Find(strID);
            //si trouvé
            if (strID != null)
            {
                try
                {
                    //confirmation
                    DialogResult reponse = MessageBox.Show("êtes-vous sûr", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (reponse == DialogResult.No)
                        //sortie
                        return;
                    //suppression dans le cache
                    contexte.Customers.Remove(client);
                    //suppression dans la base
                    contexte.SaveChanges();
                    using (PerformanceCounter perfCounter = new PerformanceCounter("compteursClients", "compteurSuppressions", ""))
                    {
                        perfCounter.ReadOnly = false;
                      
                        perfCounter.IncrementBy(10);

                    }
                    //mettre la grille à jour
                    remplirGrille();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void creationCompteurs()
        {
            string categorieCompteurs = "compteursClients";
            if (!PerformanceCounterCategory.Exists(categorieCompteurs))
            {
                CounterCreationDataCollection col = new CounterCreationDataCollection();
                col.Add(new CounterCreationData("compteurAjouts", "compter les ajouts", PerformanceCounterType.NumberOfItems32));
                col.Add(new CounterCreationData("compteurSuppressions", "compter les suppressions", PerformanceCounterType.NumberOfItems32));
                PerformanceCounterCategory.Create(categorieCompteurs, "pour l'appli gestion clients", PerformanceCounterCategoryType.SingleInstance, col);
            }
        }
    }
}
