using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    internal abstract class GameObject
    {
        private int id;
        private string name;
        private bool isActive;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {

            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {

            }
        }
        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {

            }
        }

        public GameObject(int id, string name, bool isActive)
        {
            this.id = id;
            this.name = name;
            this.isActive = isActive;
        }

        protected GameObject(string name)
        {
            this.name = name;
        }

        public GameObject(string name, bool isActive) : this(name)
        {
        }

        public void Enable()
        {
            isActive = true;
        }
        public void Disable()
        {
            isActive = false;
        }


        public abstract string Info();
    }
}
