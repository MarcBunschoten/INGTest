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
        }

        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
