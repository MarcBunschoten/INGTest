using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : Animal
    {
        private void Start()
        {
            feedtype = FEEDTYPE.omnivores;
            name = "dora";
            hello = "oink oink";
            eat = "munch munch oink";
            trick = GetComponent<RotateTrick>();
        }
    }
}
