using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Zebra : Animal
    {
        private void Start()
        {
            feedtype = FEEDTYPE.herbivores;
            name = "marty";
            hello = "zebra zebra";
            eat = "munch munch zank yee bra";
        }
    }
}
