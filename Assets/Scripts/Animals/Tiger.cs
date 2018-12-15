using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Tiger : Animal
    {
        private void Start()
        {
            feedtype = FEEDTYPE.carnivores;
            name = "wally";
            hello = "rraaaaarw";
            eat = "nomnomnom thx wubalubadubdub";
            trick = GetComponent<RotateTrick>();
        }
    }
}
