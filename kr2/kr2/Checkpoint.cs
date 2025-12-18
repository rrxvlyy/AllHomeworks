using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    internal class Checkpoint : GameObject, IInteractable
    {
        public Checkpoint(string name) : base(name)
        {
        }
        public override string Info()
        {
            return ($"имя: {Name}");
        }
        public string Interact(Player player)
        {
            if (IsActive == false)
            {
                return ("Чекпоинт неактивен");
            }
            player.LastCheckpointId = Id;
            return ("Чекпоинт активен"); 
        }
    }
}
