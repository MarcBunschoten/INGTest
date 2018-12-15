using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FEEDTYPE
{
    herbivores = 1,
    carnivores = 2,
    omnivores = 3
}

public class Feeder : MonoBehaviour {
    public GameObject[] animals;

    public void Feed(string food)
    {
        if (food == "leaf")
        {
            foreach (GameObject a in animals)
            {
                Debug.Log(a.name);
                Animal animal = a.GetComponent<Animal>();
                if (animal.feedtype == FEEDTYPE.herbivores || animal.feedtype == FEEDTYPE.omnivores)
                {
                    animal.EatLeaves();
                }
            }
        }

        if (food == "meat")
        {
            foreach (GameObject a in animals)
            {
                Animal animal = a.GetComponent<Animal>();
                if (animal.feedtype == FEEDTYPE.carnivores || animal.feedtype == FEEDTYPE.omnivores)
                {
                    animal.EatMeat();
                }
            }
        }
    }

    public void test()
    {

    }
}
