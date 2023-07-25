﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725_01
{
    class Component
    {
        public Component() 
        { 

        }

        ~Component() 
        {

        }

        public virtual void Start()
        {

        }

        public virtual void Update() 
        {

        }

        public Transform transform;
        public GameObject gameObject;
    }
}
