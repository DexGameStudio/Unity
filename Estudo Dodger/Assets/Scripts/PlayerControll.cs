using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour {

    float speed = 5.0f;

	void Update () {

        transform.Translate(new Vector3(
            Input.GetAxis("Horizontal") * speed,
            Input.GetAxis("Vertical") * speed,
            0) * Time.deltaTime);
	}
}
