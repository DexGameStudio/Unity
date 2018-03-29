using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpFunction : MonoBehaviour {

    float health = 100;
    float attackPower = 25;
    bool shieldon = true;
    int shieldAmount = 15;

	private void Start()
	{
        Debug.Log("Health at attack: " + health);
	}


	public void Attack(){
        health -= attackPower;
        Debug.Log("Health after attack: " + health);
    }


    public void Heal(){
        int healAmount = GetRandomNumber();
        health += GetRandomNumber();
        Debug.Log("Received " + healAmount + "health");
        Debug.Log("You now have " + health + "health");
    }

    private int GetRandomNumber(){
        return Random.Range(2, 10);
    }

    private int GetAttackDamage(bool isShieldOn, int theShieldAmount, int theAttackPower){
        float damage = 0;

        if (isShieldOn)
        {
            damage = theAttackPower - (theShieldAmount * 0.10f);
        }else{
            damage = attackPower;
        }

        return (int)damage;
    }


}
