using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class GameObject
    {
        public GameObject() 
        {
            components = new List<Component> ();
            name = string.Empty;
            transform = new Transform();
            AddComponents (transform);
        }

        ~GameObject() 
        {
            components.Clear();
        }

        public List<Component> components;
        public string name;
        public Transform transform;

        public void AddComponents(Component newComponent)
        {
            newComponent.transform = transform;
            newComponent.gameObject = this;
            components.Add(newComponent);
        }

        public void RemoveComponents(Component removeComponent)
        {
            components.Remove(removeComponent);
        }

    }
}
