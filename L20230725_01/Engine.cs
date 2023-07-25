using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class Engine
    {
        public Engine() 
        {
            gameObjects = new List<GameObject>();
        }

        ~Engine()
        {

        }

        public List<GameObject> gameObjects;

        public void Instantiate(GameObject newGameObject)
        {
            gameObjects.Add(newGameObject);
        }

        public void Run()
        {
            GameLoop();
        }

        protected void GameLoop()
        {
            AllGameObjectInComponentsStart();
            while (true)
            {
                Input();
                AllGameObjectInComponentsUpdate();
                AllGameObjectInMeshRenderersRender();
            }
        }

        protected void Input()
        {

        }

        protected void AllGameObjectInComponentsStart()
        {
            foreach(var gameObject in gameObjects)
            {
                foreach(var component in gameObject.components)
                {
                    component.Start();
                }
            }
        }

        protected void AllGameObjectInComponentsUpdate()
        {
            foreach (var gameObject in gameObjects)
            {
                foreach (var component in gameObject.components)
                {
                    component.Update();
                }
            }
        }

        protected void AllGameObjectInMeshRenderersRender()
        {
            foreach (var gameObject in gameObjects)
            {
                foreach (var component in gameObject.components)
                {
                    bool result = (component is MeshRenderer);
                    if (result)
                    {
                        MeshRenderer temp = component as MeshRenderer;
                        temp.Render();
                    }
                }
            }
        }

        public void Destroy()
        {
            gameObjects.Clear();
        }
    }
}
