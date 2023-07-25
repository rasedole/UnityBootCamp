using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230724_01
{
    internal class Engine
    {
        public Engine()
        {
            gameObjects = new List<GameObject>();
        }

        ~Engine()
        {
            gameObjects.Clear();
        }

        List<GameObject> gameObjects;

        public void Instantiate(GameObject newGameObject)
        {
            gameObjects.Add(newGameObject);
        }

        public void Destroy(GameObject removeGameObject)
        {
            gameObjects.Remove(removeGameObject);
        }

        public void Run()
        {

            //Awake();
            for (int i = 0; i < gameObjects.Count; i++)
            {
                GameObject currentGameObject = gameObjects[i];
                for (int j = 0; j < currentGameObject.components.Count; j++)
                {
                    currentGameObject.components[j].Start();
                }
            }

            while (true)
            {
                //Update()
                for (int i =  0; i < gameObjects.Count;i++)
                {
                    GameObject currentGameObject = gameObjects[i];
                    for(int j = 0; j < currentGameObject.components.Count; j++)
                    {
                        currentGameObject.components[j].Update();
                    }
                }

                for (int i = 0; i < gameObjects.Count; i++)
                {
                    GameObject currentGameObject = gameObjects[i];
                    for (int j = 0; j < currentGameObject.components.Count; j++)
                    {
                        if (currentGameObject.components[j] is Renderer)
                        {
                            (currentGameObject.components[j] as Renderer).Render();
                        }
                    }
                }
            }
        }
    }
}
