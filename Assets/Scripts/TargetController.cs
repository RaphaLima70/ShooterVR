using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Executa a função de nome Rotate após 5 segundos
        Invoke("Rotate",5f);
		
	}

    //Função que rotaciona o Target
    public void Rotate()
    {
        //Rotaciona o Target em torno do ponto central (Vector3.zero)
        //fixado no eixo y (Vector3.up) a uma distância aleatória entre -120 e 120
        transform.RotateAround(Vector3.zero, Vector3.up, Random.Range(-120,120));
        
        //Executa novamente a função de nome Rotate após 5 segundos
        Invoke("Rotate", 5f);
    }
}
