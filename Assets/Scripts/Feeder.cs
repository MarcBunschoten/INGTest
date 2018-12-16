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
        public GameObject leaf;
        public GameObject meat;
        public GameObject parent;

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
                        GameObject l = Instantiate(leaf, parent.transform);
                        l.GetComponent<Food>().target = a.gameObject;
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
                        GameObject m = Instantiate(meat, parent.transform);
                        m.GetComponent<Food>().target = a.gameObject;
                    }
                }
            }
        }
    }
}
