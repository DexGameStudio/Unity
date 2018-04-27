using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUIV : MonoBehaviour {

    // OFFSET SCROLLING 

	void Update () {


        //Pegue o mash render do objeto
        MeshRenderer mr = GetComponent<MeshRenderer>();

        //crie um material
        Material mat = mr.material;

        //Crie um vetor para movimentar
        Vector2 offset = mat.mainTextureOffset;

        //Desloque o material
        offset.x += Time.deltaTime/ 5f ;
        // Altere o parâmetro Offset do Material
        mat.mainTextureOffset = offset;
	
    }
}
