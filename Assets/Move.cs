using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speedMoove = 7.0f;
	// Use this for initialization
	void Start () {
        Debug.Log("yoloo");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speedMoove * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * speedMoove * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.forward * speedMoove * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speedMoove * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 1, 0);
        }
    }
}
