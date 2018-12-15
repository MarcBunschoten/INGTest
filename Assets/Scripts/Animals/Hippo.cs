using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo : Animal
    {
        private void Start()
        {
            feedtype = FEEDTYPE.herbivores;
            name = "elsa";
            hello = "splash";
            eat = "munch munch lovely";
        }
    }
    
}
