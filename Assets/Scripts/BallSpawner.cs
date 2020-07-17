using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject ballGameObject; //Referência para o prefab referente à Ball
    public GameObject gameManagerGameObject; //Referência para o objeto GameController
    public float spawnTime; //Tempo entre a criação de cada bola


	// Use this for initialization
	void Start () {

        spawnTime = 1f; //inicializando o spawnTime
        gameManagerGameObject = GameObject.Find("GameManager"); //Associa o GameController

        //Executa a função de nome SpawnBall após um tempo definido pela variável spawnTime
        Invoke("SpawnBall", spawnTime); 
    }

    //Função que cria uma bola e adiciona força a ela
    public void SpawnBall()
    {
        //Cria uma bola e armazena ela dentro da referência tempBall
        GameObject tempBall = Instantiate(ballGameObject, transform.position +  transform.forward, transform.rotation);
        
        //Acessa o componente Rigidbody presente na tempBall e a apartir dele adiciona uma força para frente de valor 800
        tempBall.GetComponent<Rigidbody>().AddForce(transform.forward * 800f);

        //Acessa o componente GameController dentro de GameManager e verifica 
        //se o valor de isGameOver é falso (indicado pelo "!" no inicio)
        if (!gameManagerGameObject.GetComponent<GameController>().isGameOver){
            //Executa essa função novamente após um tempo definido pela variável spawnTime
            Invoke("SpawnBall", spawnTime);
        }   
    }
}
