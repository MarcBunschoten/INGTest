using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{

    public class Talk : MonoBehaviour
    {
        public string name = "";

        public void Speak()
        {
            var x = GameObject.FindObjectsOfType<Animal>();
            Debug.Log(name);
            if (name == "")
            {
                foreach (var animal in x)
                {
                    animal.GetComponent<Animal>().SayHello();
                }
            }
            else
            {
                foreach (var animal in x)
                {
                    if (animal.GetComponent<Animal>().name == name)
                    {
                        animal.GetComponent<Animal>().SayHello();
                    }
                }
            }
            
        }

        public void ChangeName(string value)
        {
            name = value;
        }
    }
}
