using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SujetExamen
{
    class QuestionAChoixMultiple : Question
    {


        private List<Reponse> _reponses;
        public QuestionAChoixMultiple(string e, int d) :base(e,d)
          {
                this._reponses = new();
          }
        public List<Reponse> Reponses
        {
            get { return _reponses; }
        }
        public void AjouterUneReponse(Reponse r)
        {
           this.Reponses.Add(r);
        }
        public void SupprimerReponse(Reponse r)
        {
            this.Reponses.Remove(r);
        }
    }
}
