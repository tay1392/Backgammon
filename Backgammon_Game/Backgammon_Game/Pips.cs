using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backgammon_Game
{
    public class Pips
    {
        private int PipCount;
        private int ind;
        private Person Owner = null;
        private PipGraphic view;
        
        public Pips(int indx, int init = 0)
        {
            this.ind = indx;
            PipCount = init;
        }

        public bool AddPip(Person p)
        {
            if(CanBeAdded(p))
            {
                Owner = p;
                PipCount++;
                return true;
            }
            return false;
        }

        public bool RemovePip(Person p)
        {
            if(CanBeRemoved(p))
            {
                PipCount--;
                if(PipCount == 0)
                    Owner = null;
                return true;
            }
            return false;
        }

        public Person GetOwner { get { return Owner; } set { Owner = value; } }
        public int PipsCount { get { return PipCount; } }

        public int Index { get { return ind; } }

        public Pips Copy()
        {
            return new Pips(this.ind, this.PipCount);
        }


        public bool GetPermission(Person p)
        {
            return (Owner == null || p == Owner);
        }

        public bool CanBeAdded(Person p)
        {
            return (GetPermission(p) || PipCount  == 1);

        }

        public bool CanBeRemoved(Person p)
        {
            return GetPermission(p) && PipCount > 0;
        }

        public void SetView(PipGraphic v)
        {
            view = v;
        }
    }
}
