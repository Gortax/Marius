using UnityEngine;
using System.Collections;

public class Movements1 : MonoBehaviour {


    float speed = 5;
	
	void Start () {
	
	}
	
	
	void Update () {

        if (Input.GetAxis("Horizontal") > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.Translate(speed* Time.deltaTime,0, 0);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
            transform.Translate( speed * Time.deltaTime,0, 0);
        }


        else if (Input.GetAxis("Vertical") > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
            transform.Translate(0, speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 270);
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}
