using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        public GameObject[] animals;

        private void Start()
        {
            List<GameObject> anm = new List<GameObject>();

            foreach (GameObject a in animals)
            {
                anm.Add(Instantiate(a, transform) as GameObject);
            }
        }
    }
}
