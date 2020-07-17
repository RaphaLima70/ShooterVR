using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int points; //Variável que controla os pontos
    public float time; //Variável que controla os tempo
    public bool isGameOver; //Variável que diz se o jogo acabou ou não

    void Start () {
        //Inicializando o valor das variáveis
        isGameOver = false; 
        points = 0;
        time = 30;
	}
	
	void Update () {
        //Se o tempo for maior que zero
        if (time > 0)
        {
            time -= Time.deltaTime; //Diminui o tempo        
        }
        //Se não
        else
        {
            isGameOver = true; //Coloca isGameOver para true, indicando que o jogo acabou
        }
	}
}
