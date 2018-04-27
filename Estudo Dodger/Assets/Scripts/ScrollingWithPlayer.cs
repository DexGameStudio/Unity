using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingWithPlayer : MonoBehaviour {

    public float parallax = 2f;
    public GameObject player;

    // OFFSET SCROLLING 

	void Update () {

        //Pegue o mash render do objeto
        MeshRenderer mr = GetComponent<MeshRenderer>();

        //crie um material
        Material mat = mr.material;

        //Crie um vetor para movimentar
        Vector2 offset = mat.mainTextureOffset;

        //Desloque o material
        offset.x = player.transform.position.x/ player.transform.localScale.x/ parallax ;
        offset.y = player.transform.position.y / player.transform.localScale.y / parallax;

        // Altere o parâmetro Offset do Material
        mat.mainTextureOffset = offset;
	
    }
}
