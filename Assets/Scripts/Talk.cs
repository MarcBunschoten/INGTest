using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{

    public class Talk : MonoBehaviour
    {

        public void Speak()
        {
            var x = GameObject.FindObjectsOfType<Animal>();
            foreach (var animal in x)
            {
                animal.GetComponent<Animal>().SayHello();
            }
        }
    }
}
