using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230724_01
{
    class GameObject
    {
        public GameObject()
        {
            components = new List<Component>();
            Component newComponent = new Transform();
            newComponent.gameObject = this;
            AddComponent(new Transform());
            name = String.Empty;
        }

        ~GameObject()
        {
            components.Clear();
        }

        public List<Component> components;

        public void AddComponent(Component newComponent)
        {
            components.Add(newComponent);
        }

        public void RemoveComponent(Component removeComponent)
        {
            components.Remove(removeComponent);
        }

        public string name;
    }
}
