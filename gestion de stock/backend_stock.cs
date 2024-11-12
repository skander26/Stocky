using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gestion_de_stock
{
    internal class backend_stock

    {
        public static DataTable etat_stock()
        {
            DataTable dtresult = new DataTable();



            Bd b = new Bd();
            string id_entre = Entre.id;


            string slc = @"
    select produit.code ,produit.designation,quantite_entre,Entre_Article.prix_u,round(quantite_entre * Entre_Article.prix_u ,3) as total,Entre.num_entre,Entre.date_entrer,Devise.designation as devise,Reglement.designation as reglement ,Fournisseur.nom,fournisseur.matricule,Fournisseur.adresse,Fournisseur.telephone,fournisseur.ville
from Entre_Article 
inner join produit on Entre_Article.id_article = produit.id inner join Entre on id_entre = Entre.id inner join Devise on Entre.id_devise = Devise.id inner join Reglement on id_reglement = Reglement.id inner join Fournisseur on id_fournisseur = Fournisseur.id
where entre.id = @id


                     ";
            try
            {
                SqlCommand cmd = new SqlCommand(slc, b.cnn);
                cmd.Parameters.AddWithValue("id", id_entre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {

                    dtresult = dt;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            //}
            return dtresult;
        }

        public static DataTable etat_stock2()
        {
            DataTable dtresult = new DataTable();



            Bd b = new Bd();
            string id_entre = voiresortie.id;


            var slc = @"  SELECT  client as nom, SUBSTRING(CAST(date AS VARCHAR(19)), 0, 12) as date, Devise.designation as devise , Reglement.designation as reglement, num_article as num , produit.designation as produit ,sortie_article.prix_u as prix_u ,sortie_article.qt as qt
                FROM sortie
                 inner join Devise on Devise.id = id_devise inner join Reglement on Reglement.id = id_reglement inner join sortie_article on sortie.id = sortie_article.id_sortie inner join produit on sortie_article.id_article = produit.id 
                WHERE sortie.id = @id";


            try
            {
                SqlCommand cmd = new SqlCommand(slc, b.cnn);
                cmd.Parameters.AddWithValue("id", id_entre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {

                    dtresult = dt;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            //}
            return dtresult;
        }
    }
}
