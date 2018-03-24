using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour {

    GameObject[] cubes = new GameObject[5];

    public GameObject cubePrefab;

    float spacer = 2f;

	// Use this for initialization
	void Start () {
       
        for (int i = 0; i < cubes.Length; i++)
        {
            GameObject cube = Instantiate(cubePrefab);
            cubes[i] = cube;
            cube.transform.position = new Vector3(i*spacer, cube.transform.position.y);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
