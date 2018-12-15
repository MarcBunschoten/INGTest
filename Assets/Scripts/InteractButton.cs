using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Zoo
{
    public class InteractButton : MonoBehaviour
    {
        //[SerializeField]
        //private Feeder feeder;
        public void Trick()
        {
            var x = GameObject.FindObjectsOfType<Animal>();
            foreach (var animal in x)
            {
                animal.GetComponent<Animal>().DoTrick();
            }
        }

        //werkt niet i.v.m. geen assets kunnen slepen in unity
        //
        //public void StartFeeding(string food)
        //{
        //    var x = GameObject.FindObjectsOfType<Animal>();
        //    feeder.Feed(food);
        //}
    }
}
