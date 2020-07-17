using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour {

    public GameObject gameManagerGameObject; //Referência para o objeto GameController
    public Text timerText; //Referência para o Texto do objeto Timer
    public Text pointsText; //Referência para o Texto do objeto Points
    public Text gameOverText; //Referência para o Texto do objeto GameOver

    void Start () {

        gameManagerGameObject = GameObject.Find("GameManager");  //Associa o GameController
        
        //Associa o componente Text que se encontra dentro do objeto Timer
        timerText = GameObject.Find("Timer").GetComponent<Text>();
        //Associa o componente Text que se encontra dentro do objeto Points
        pointsText = GameObject.Find("Points").GetComponent<Text>();
        //Associa o componente Text que se encontra dentro do objeto GameOver
        gameOverText = GameObject.Find("GameOver").GetComponent<Text>();

        //Ativa os objetos Points e Timer, além de desativar o GameOver
        timerText.gameObject.SetActive(true);
        pointsText.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
    }
	
	void Update () {

        //Se a váriavel isGameOver localizada no GameController for true
        if (gameManagerGameObject.GetComponent<GameController>().isGameOver) {
            
            //Desativa os objetos Points e Timer, além de ativar o GameOver
            timerText.gameObject.SetActive(false);
            pointsText.gameObject.SetActive(false);
            gameOverText.gameObject.SetActive(true);

            //Coloca o texto de GameOver para uma junção "Game Over! \n Final Score: "
            // e o valor da variável points, convertida em texto
            gameOverText.text = "Game Over! \n Final Score: " 
            + gameManagerGameObject.GetComponent<GameController>().points.ToString();
        }
        //Se a verificação acima NÃO for verdadeira
        else{
            //Coloca os textos de Timer e Points, para seus respectivos valores
            timerText.text = gameManagerGameObject.GetComponent<GameController>().time.ToString();
            pointsText.text = gameManagerGameObject.GetComponent<GameController>().points.ToString();
        }
    }
}
