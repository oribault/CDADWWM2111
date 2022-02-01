using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SujetExamen
{
    class Question
    {
        private string _enonce;
        private int _difficulte;

        public Question(string e, int d)
        {
            this._enonce = e;
            this.Difficulte = d;
        }
        public string Enonce
        {
            get { return _enonce; } init { _enonce = value; }
        }
        public int Difficulte
        {
            get { return _difficulte; }
            set { if (value < 0) 
                {
                    _difficulte = 0;
                }
               else  if (value > 100)
                {
                    _difficulte = 100;
                }
                else
                {
                    _difficulte = value;
                }
            }
              
        }
    }
}
