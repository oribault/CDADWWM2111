using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicePoupeeRusse
{
    class PoupeeRusse
    {
        //Attributs
        private int _taille;
        private bool _estOuverte;
        private PoupeeRusse _dans;
        private PoupeeRusse _contenue;

        public PoupeeRusse(int _taille)
        {
            this._taille = _taille;
            this._estOuverte = false;
            this._dans = null;
            this._contenue = null;
        } 
        
        public int Taille
        {
            get { return this._taille; }
            init { this._taille = value; } 
        }
        public bool EstOuverte
        {
            get { return this._estOuverte; }
            private set { this._estOuverte = value; }
        }
        public PoupeeRusse Dans
        {
            get { return this._dans; }
            set { this._dans = value; }
        }
        public PoupeeRusse Contenue
        {
            get { return this._contenue; }
            set { this._contenue = value; }
        }
        public void Ouvrir()
        {
            if(!this.EstOuverte && this._dans == null)
            {
                this.EstOuverte = true;
                Console.WriteLine($"Ouverture de la poupée de taille {this.Taille}");
            }
            else
            {
                Console.WriteLine($"Ouverture impossible de la poupée de taille {this.Taille}");
            }
        }
        public void Fermer()
        {
            if(this.EstOuverte && this.Dans == null)
            {
                this.EstOuverte = false;
                Console.WriteLine($"Fermeture de la poupée de taille {this.Taille}");
            }
            else
            {
                Console.WriteLine($"Fermeture impossible de la poupée de taille {this.Taille}");
            }
        }
        public void PlacerDans(PoupeeRusse p)
        {
            if(!this.EstOuverte && this.Dans == null && p.EstOuverte && p.Contenue == null)
            {
                this.Dans = p;
                p.Contenue = this;
                Console.WriteLine($"Je met une poupée de taille {this.Taille} dans une autre poupée de taille {p.Taille}");
            }
            else
            {
                Console.WriteLine($"Je ne peux pas mettre une poupée de taille {this.Taille} dans une autre poupée de taille {p.Taille}");
            }
        }
        public void SortirDe(PoupeeRusse p)
        {
            if (this.Dans == p && p.EstOuverte)
            {
                this.Dans = null;
                p.Contenue = null;
                Console.WriteLine($"Je sors une poupée de taille {this.Taille} d'une autre poupée de taille {p.Taille}");
            }
            else 
            {
                Console.WriteLine($"Impossible de  sortir une poupée de taille {this.Taille} d'une autre poupée de taille {p.Taille}");
            }
        }
    }

}
