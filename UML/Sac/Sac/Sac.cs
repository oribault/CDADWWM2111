using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sac
{
    class Sac
    {
        //Attribut 
        private int _volume;
        private string _couleur;

        //Methodes

        //Constructor
        public Sac(int volume, string couleur)
        {
            this._volume = volume;
            this._couleur = couleur;
        }
        public int Volume
        {
            get { return _volume; }
            private set { _volume = value; }
        }
        
        public string Couleur
        {
            get { return _couleur; }
            private set { _couleur = value; }
        }
        public void Ouvrir()//methode
        {

        }
        public void Fermer()//methode
        {

        }
    }
}
