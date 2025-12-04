using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level3
{
    internal class Spell
    {
        private string name;
        private int cooldown;
        private int timeBeforeNextUse;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Cooldown
        {
            get
            {
                return cooldown;
            }
        }
        public int TimeBeforeNextUse
        {
            get
            {
                return timeBeforeNextUse;
            }
        }
        public Spell(string name, int cooldown)
        {
            this.name = name;
            this.cooldown = cooldown;
            timeBeforeNextUse = 0;
        }
        public bool UseOrNot()
        {
            if (timeBeforeNextUse == 0)
            {
                timeBeforeNextUse = cooldown;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdateCooldown()
        {
            if (timeBeforeNextUse > 0)
            {
                timeBeforeNextUse--;
            }
        }
    }
}
