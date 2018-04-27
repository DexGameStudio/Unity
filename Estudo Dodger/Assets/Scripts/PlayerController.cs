using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Text txt;
    int pontuacao = 0;





    //float maxX = 10.0f;
    //float maxY = 4.10f;

    //vincula informações do Objeto Camera
    public Camera gameCamera;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        playerMovement();
	}

    void playerMovement(){
        Vector2 mousePosition = Input.mousePosition;
        Vector3 worldPosition = gameCamera.ScreenToWorldPoint(mousePosition);


        //if ((worldPosition.x <= maxX && worldPosition.x >= -maxX) && (worldPosition.y <= maxY && worldPosition.y >= -maxY))
        //{
        //    this.transform.position = new Vector3(worldPosition.x, worldPosition.y, this.transform.position.z);
        //}


        this.transform.position = new Vector3(worldPosition.x, worldPosition.y, this.transform.position.z);

    }


	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.CompareTag("PowerUps"))
        {
            pontuacao++;
            txt.text = pontuacao.ToString();

            Destroy(collision.gameObject);
        }


	}

}
