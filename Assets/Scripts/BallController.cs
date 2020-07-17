using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public GameObject gameManagerGameObject; //Referência para o objeto GameController

    void Start () {
        //Associa o GameController
        gameManagerGameObject = GameObject.Find("GameManager"); 
        
        //Executa a função de nome BallDestroy após 5 segundos
        Invoke("BallDestroy", 5f);
	}

    //Toda vez que a Ball colidir com algum objeto o OnCollisionEnter será executado
    private void OnCollisionEnter(Collision collision)
    {
        //se o objeto que colidiu possui a tag "Target
        if (collision.gameObject.tag == "Target"){
            //Acessa o GameController e incrementa a variável points
            gameManagerGameObject.GetComponent<GameController>().points++;
            //Executa função que destrói a Ball
            BallDestroy();
        }

        //se o objeto que colidiu possui a tag "TimeTarget"
        if (collision.gameObject.tag == "TimeTarget")
        {
            //Acessa o GameController e incrementa a variável time
            gameManagerGameObject.GetComponent<GameController>().time += 5;
            //Executa função que destrói a Ball
            BallDestroy();
        }
    }

    //Função que destrói a Ball
    public void BallDestroy()
    {
        //Destrói o GameObject ao qual esse script está associado
        Destroy(gameObject);
    }
}
