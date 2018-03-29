using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour {

    public float playerSpeed = 80.0f;
    private float maxPlayerdistance = 20.0f;


    public float shootingSpeed = 0.5f;
    public bool isShooting = true;

    public GameObject projecTile;
    public float projecTileOffSet = 2.0f;


	// Use this for initialization
	void Start () {
        StartCoroutine(ProjecTileShootTimer());
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerMovement();
		
	}

    void PlayerMovement(){
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -maxPlayerdistance)
        {
            transform.Translate(-playerSpeed*Time.deltaTime, 0, 0);
        } else if (Input.GetKey(KeyCode.D) && transform.position.x <= maxPlayerdistance)
        {
            transform.Translate(playerSpeed*Time.deltaTime, 0, 0);
        }
  
    }

    IEnumerator ProjecTileShootTimer(){
        while (isShooting)
        {
            SpawnPojectile();
            yield return new WaitForSeconds(shootingSpeed);
                        }
        }

    void SpawnPojectile(){
        Instantiate(projecTile, new Vector3(transform.position.x, transform.position.y + projecTileOffSet, 0), Quaternion.identity);
    }


	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Collision")
        {
            SceneManager.LoadScene("game");
        }
    }

}
