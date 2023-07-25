using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class Engine
    {
        protected Engine()
        {
            gameObjects = new List<GameObject>();
            isRunning = true;
        }

        ~Engine()
        {

        }

        protected static Engine instance;

        public static Engine GetInstance()
        {
            if (instance == null)
            {
                instance = new Engine();
            }
            return instance;
        }

        public List<GameObject> gameObjects;

        public static GameObject Find(string name)
        {
            foreach(var gameObject in GetInstance().gameObjects)
            {
                if (gameObject.name.Equals(name))
                {
                    return gameObject;
                }
            }
            return null;
        }

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
            while (isRunning)
            {
                Input();
                AllGameObjectInComponentsUpdate();
                AllGameObjectInMeshRenderersRender();
            }
        }

        protected void Input()
        {
            ConsoleKeyInfo info = Console.ReadKey();
            InputKey.key = info.Key;
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

        protected static bool isRunning;

        public static void Quit()
        {
            isRunning = false;
        }
    }
}
