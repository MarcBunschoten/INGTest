using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Tiger : Animal
    {
        private void Start()
        {
            feedtype = FEEDTYPE.carnivores;
            name = "wally";
            hello = "rraaaaarw";
            eat = "nomnomnom thx wubalubadubdub";
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
