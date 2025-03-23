

namespace Fournisseur.API.Services
{
    public class FournisseurRepository : IFournisseurRepository
    {
        static List<Models.Fournisseur> fournisseurs { get; }
        static int nextId = 5;
        static FournisseurRepository()
        {
            fournisseurs = new List<Models.Fournisseur>{
            new Models.Fournisseur { Id = 1, Nom = "Fournisseur A", Adresse = "123 Rue Principale", Ville = "Québec", CodePostal = "G1K 3H4", Pays = "Canada", Téléphone = "418-123-4567", Email = "contact@fournisseura.com" },
            new Models.Fournisseur { Id = 2, Nom = "Fournisseur B", Adresse = "456 Avenue des Pins", Ville = "Montréal", CodePostal = "H2X 1V4", Pays = "Canada", Téléphone = "514-234-5678", Email = "contact@fournisseurb.com" },
            new Models.Fournisseur { Id = 3, Nom = "Fournisseur C", Adresse = "789 Boulevard René-Lévesque", Ville = "Québec", CodePostal = "G1R 2B5", Pays = "Canada", Téléphone = "418-345-6789", Email = "contact@fournisseurc.com" },
            new Models.Fournisseur { Id = 4, Nom = "Fournisseur D", Adresse = "1010 Rue Sainte-Catherine", Ville = "Montréal", CodePostal = "H3B 1E3", Pays = "Canada", Téléphone = "514-456-7890", Email = "contact@fournisseurd.com" },
            new Models.Fournisseur { Id = 5, Nom = "Fournisseur E", Adresse = "1111 Rue Saint-Jean", Ville = "Québec", CodePostal = "G1R 1S3", Pays = "Canada", Téléphone = "418-567-8901", Email = "contact@fournisseure.com" },
            };
        }

        public Models.Fournisseur AddFournisseur(Models.Fournisseur fournisseur)
        {
            fournisseur.Id = ++nextId;
            fournisseurs.Add(fournisseur);

            return fournisseur;
        }

        public IEnumerable<Models.Fournisseur> GetFournisseurs()
        {
            return fournisseurs;
        }
    }
}
