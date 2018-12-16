using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class Cat : Animal
    {

        void Start()
        {
            name = "kimmy";
            hello = "Miauw!";
            eat = "Nibble nibble thanks!";
            feedtype = FEEDTYPE.carnivores;
            trick = GetComponent<RotateTrick>();
        }
    }
}

