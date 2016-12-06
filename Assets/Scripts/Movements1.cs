using UnityEngine;
using System.Collections;

public class Movements1 : MonoBehaviour {


    float speed = 5;
	
	void Start () {
	
	}
	
	
	void Update () {

        if (Input.GetAxis("Horizontal") > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.Translate(0, speed* Time.deltaTime, 0);
        }
	}
}
