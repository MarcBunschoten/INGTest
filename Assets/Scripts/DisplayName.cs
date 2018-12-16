using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class DisplayName : MonoBehaviour
    {

        private Text text;
        private string name;

        private void Start()
        {
            name = transform.parent.GetComponent<Animal>().name;
            text = GetComponent<Text>();
            text.text = name;
        }
    }
}

