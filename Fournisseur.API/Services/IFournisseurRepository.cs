
using Fournisseur.API.Models;

namespace Fournisseur.API.Services
{
    public interface IFournisseurRepository
    {
        public IEnumerable<Models.Fournisseur> GetFournisseurs();
        public Models.Fournisseur AddFournisseur(Models.Fournisseur fournisseur);
    }
}
