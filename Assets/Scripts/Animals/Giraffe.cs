using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class Giraffe : Animal
    {

        // Use this for initialization
        void Start()
        {
            name = "alex";
            hello = "*dab*";
            eat = "nom nom thanks for the meal!";
            feedtype = FEEDTYPE.herbivores;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
