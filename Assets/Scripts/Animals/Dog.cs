using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class Dog : Animal
    {

        void Start()
        {
            name = "cooper";
            hello = "WROOF WOOF";
            eat = "AWOOOO thats tasty :3";
            feedtype = FEEDTYPE.carnivores;
        }
    }
}
