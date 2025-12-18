using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    internal class Player
    {
        private int hp;
        private bool hasAccessCard;
        private int lastCheckpointId;

        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {

            }
        }
        public bool HasAccessCard
        {
            get
            {
                return hasAccessCard;
            }
            set
            {

            }
        }
        public int LastCheckpointId
        {
            get
            {
                return lastCheckpointId;
            }
            set
            {

            }
        }

        public Player(int hp)
        {
            this.hp = hp;
        }
    }
}
