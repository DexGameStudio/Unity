using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Camera gameCamera;
    public GameObject bulletPrefab;

    public float shootingCooldown;
    float shootingTimer;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 mousePosition = Input.mousePosition;
        Vector3 worldPosition = gameCamera.ScreenToWorldPoint(mousePosition);

        this.transform.position = new Vector3(worldPosition.x, worldPosition.y, this.transform.position.z);

        //timer count down para atribuir cooldown para os disparos
        shootingTimer -= Time.deltaTime;


        if (Input.GetMouseButtonDown(0) && shootingTimer <=0)
        {
            shootingTimer = shootingCooldown;
            //array directions contendo as 4 direções
            Vector2[] directions = new Vector2[]{
                Vector2.up,
                Vector2.down,
                Vector2.left,
                Vector2.right
            };

            // Laço no array directions
            foreach (Vector2 direction in directions)
            {
                // Instancia um prefab da bala
                GameObject bulletObject = Instantiate(bulletPrefab);
                bulletObject.transform.position = this.transform.position;

                // desloca o prefab da bala
                Bullet bullet = bulletObject.GetComponent<Bullet>();
                bullet.moveDirection = direction;
            }





        }
    }
}
