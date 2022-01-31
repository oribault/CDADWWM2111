using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneAssise
{
    class Seat
    {
        private  bool _isFree;
        private int _numberOLegs;
        private bool _hasABack;
        private bool _hasArmrest;


        public bool IsFree
        {
            get { return _isFree; }
            protected set { _isFree = value; }
        }
        public int NumberOfLegs
        {
            get { return _numberOLegs; }
        }
        public bool HasABack
        {
            get { return _hasABack; }
        }
        public void AddPersonOnIt()
        {
          
            if (IsFree)
            {
                IsFree = false;
            }
        }
        public void RemoveAPersonFromIt()
        {
            IsFree = true;
            if (IsFree)
            {

            }
        }
    }
}
