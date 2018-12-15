using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Lion : Animal
    {
        private void Start()
        {
            feedtype = FEEDTYPE.carnivores;
            name = "henk";
            hello = "rooaaaoooor";
            eat = "nom nom thx mate";
        }

    }
}
