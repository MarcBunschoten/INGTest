using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    public GameObject target;

	void Update ()
    {
        MoveToTarget();
	}

    private void MoveToTarget()
    {
        Debug.Log(Vector3.Distance(transform.position, target.transform.position));
        if(Vector3.Distance(transform.position, target.transform.position) > 50f)
        {
            Vector3 dir = target.transform.localPosition - transform.localPosition;
            transform.Translate(dir * 2 * Time.deltaTime);
            //this.transform.position = Vector3.MoveTowards(transform.localPosition, target.transform.localPosition, 1 * Time.deltaTime);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
