using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {

        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        public Text text;
        public string hello, eat;
        public string name;
        public FEEDTYPE feedtype;
        public RotateTrick trick;

        public void Start()
        {
            Balloon.SetActive(false);
        }

        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = hello;
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = eat;
            //spawn leaves aesthetics
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = eat;
            //spawn meat aesthetics
        }

        public void DoTrick()
        {
            if (trick != null)
            {
                trick.PerformTrick();
            }
        }
    }
}
