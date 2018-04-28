using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player01UIController : MonoBehaviour {

    public Image vidaBar;
    public Image ultraBar;
    public Image superBar01;
    public Image superBar02;
    public Image superBar03;

    public int dano = 10;
    public int superInc =  20;
    public int ultrInc = 20;


	// Use this for initialization
	void Start () {
        ultraBar.fillAmount = 0.0f;
        superBar01.fillAmount = 0.0f;
        superBar02.fillAmount = 0.0f;
        superBar03.fillAmount = 0.0f;

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void CausarDano(){

        vidaBar.fillAmount -= .1f;
        Debug.Log("Dano de 10 causado");

    }

    public void AumentaUltra(){
        ultraBar.fillAmount += .1f;
        
    }

    public void UsarUltra(){
       
        if (ultraBar.fillAmount.Equals(1.0f))
        {
            ultraBar.fillAmount = 0;
        }

    }

    public void AumentaSuper()
    {

        if (superBar01.fillAmount.Equals(1.0f))
        {
            if (superBar02.fillAmount.Equals(1.0f))
            {
                superBar03.fillAmount += .20f;
            }
                else{
                superBar02.fillAmount += .20f; 
            }

        } else{
            superBar01.fillAmount += .20f;
        }

    }


    public void GolpeEx()
    {
    
        //if (superBar01.fillAmount.Equals(1.0f) && superBar02.fillAmount.Equals(1.0f))
        //{
        //    if (superBar02.fillAmount.Equals(1.0f) && superBar03.fillAmount.Equals(1.0f))
        //    {
        //        superBar03.fillAmount += .0f;
        //    }
        //    else
        //    {
        //        superBar02.fillAmount += .0f;
        //    }

        //}
        //else if(superBar01.fillAmount.Equals(1.0f)){
        //    superBar01.fillAmount += .0f;
        //}


        if (superBar01.fillAmount.Equals(1.0f))
        {
            if (superBar01.fillAmount.Equals(1.0f) && superBar02.fillAmount.Equals(1.0f))
            {
                superBar02.fillAmount = superBar03.fillAmount;
                superBar03.fillAmount = 0.0f;
            } else
            {

            superBar01.fillAmount = superBar02.fillAmount;
            superBar02.fillAmount = 0.0f;

            }


        }


    }



    public void UsarSuper(){
        if (superBar01.fillAmount.Equals(1.0f) && superBar02.fillAmount.Equals(1.0f) && superBar03.fillAmount.Equals(1.0f))
        {
            superBar01.fillAmount = 0.0f;
            superBar02.fillAmount = 0.0f;
            superBar03.fillAmount = 0.0f;
        }

    }



}
