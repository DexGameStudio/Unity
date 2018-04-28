using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion : MonoBehaviour {


    public Image pocaoCirc;
    public Text txtPocao;
    public int valorAtual = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        AtualizaText();
        TiraPocao();
        AddPocao();

	}


    void AtualizaText(){
        if (valorAtual >= 100)
        {
            valorAtual = 100;
            txtPocao.text = valorAtual.ToString();

        }
    
        if (valorAtual <=0)
        {
            valorAtual = 0;
            txtPocao.text = valorAtual.ToString();
        }

    }

    void TiraPocao(){
        if (Input.GetKey(KeyCode.B) && valorAtual > 0)
        {
            valorAtual -= 1;
            pocaoCirc.fillAmount = (float)valorAtual / 100;
            string temp = valorAtual.ToString();
            txtPocao.text = temp;
        }
    }

    void AddPocao()
    {
        if (Input.GetKey(KeyCode.C) && valorAtual < 100)
        {
            valorAtual += 1;
            pocaoCirc.fillAmount = (float)valorAtual / 100;
            string temp = valorAtual.ToString();
            txtPocao.text = temp;
        }
    }
}
