using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FEEDTYPE
{
    herbivores = 1,
    carnivores = 2,
    omnivores = 3
}

namespace Zoo
{
    public class Feeder : MonoBehaviour
    {
        public void Feed(string food)
        {
            var x = GameObject.FindObjectsOfType<Animal>();

            if (food == "leaf")
            {
                foreach (var a in x)
                {
                    Animal animal = a.GetComponent<Animal>();
                    if (animal.feedtype == FEEDTYPE.herbivores || animal.feedtype == FEEDTYPE.omnivores)
                    {
                        animal.EatLeaves();
                    }
                }
            }

            if (food == "meat")
            {
                foreach (var a in x)
                {
                    Animal animal = a.GetComponent<Animal>();
                    if (animal.feedtype == FEEDTYPE.carnivores || animal.feedtype == FEEDTYPE.omnivores)
                    {
                        animal.EatMeat();
                    }
                }
            }
        }
    }
}
