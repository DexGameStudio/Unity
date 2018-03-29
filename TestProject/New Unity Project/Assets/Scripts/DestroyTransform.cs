using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTransform : MonoBehaviour {

    ScoreLogic addToScore;
    public GameObject particules;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter2D(Collision2D transformcollision)
	{
        if (transformcollision.gameObject.tag == "Collision")
        {
            //Sempre spawn o objeto secundário 1º antes de destruir o objeto 
            //primário, se não o sistema não terá a posição (referência)
            SpawnParticle(transformcollision.transform.position);

            Destroy(transformcollision.gameObject);

            CallScorelogicScript();
                       
        }

    }

    void CallScorelogicScript(){
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>();
        addToScore.AddToScoreVOID();

    }

    void SpawnParticle(Vector2 tempPosition){
        Instantiate(particules, tempPosition, Quaternion.identity);
    }
}
