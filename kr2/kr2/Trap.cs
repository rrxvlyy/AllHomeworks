using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    internal class Trap : GameObject, IInteractable, IDamageable
    {
        private int damage;
        public Trap(string name, int damage) : base(name)
        {
            damage = 10;
        }
        public override string Info()
        {
            return ($"имя: {Name}, урон: {damage}");
        }
        public string Interact(Player player)
        {
            if (IsActive == false)
            {
                return ("Ловушка неактивна");
            }
            player.Hp = player.Hp - 1;
            return ("Ловушка активна");

        }
        public void ApplyDamage(int amount)
        {
            Disable();
        }
    }
}
