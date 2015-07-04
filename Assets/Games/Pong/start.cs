using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

    public float rand = 3.5F;
    Rigidbody rg;
    public float speed;
    bool firstStart = false;

    void Start() {
        rg = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
	void Update () {
        if (firstStart == false) {
            rand = Random.Range(0, 2);
            if (rand <= 1)
            {
                Debug.Log("Right");
                rg.AddForce (new Vector3 (speed, speed, 0));
                firstStart = true;
            }
            //else
            //{
            //    Debug.Log("Left");
            //    firstStart = true;
            //}
            //Debug.Log("Works maybe");
        }
	}
}
