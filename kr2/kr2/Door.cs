using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    internal class Door : GameObject, IInteractable
    {
        private bool requiredAccess;
        public Door(string name, bool requireAccessCard = true) : base(name)
        {
            requiredAccess = requireAccessCard;
        }
        
        public string Interact(Player player)
        {
            if (IsActive == true)
            {
                Disable();
                return ("Дверь открыта");
            }
            else
            {
                return ("Нет доступа, дверь закрыта");
            }
        }

        public override string Info()
        {
            return ($"имя: {Name}, активно: {IsActive}");
        }

        string IInteractable.Interact(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
