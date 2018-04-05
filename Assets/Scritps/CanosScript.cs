using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanosScript : MonoBehaviour {

	public float velocidade;
	public float limite;
	public float limiteSuperior, limiteInferior;

	float altura;

	// Use this for initialization
	void Start () {
		//sorteio de uma nova altura para o cano
		altura = Random.Range (limiteInferior, limiteSuperior);
	}
	
	// Update is called once per frame
	void Update () {
		Mover ();
	}

	void Mover(){
		//move o cano
		transform.Translate(Vector2.left * velocidade * Time.deltaTime);

		//retorna quando chegar no limite
		if (transform.position.x < limite) {
			transform.position = new Vector2 (6.0f, Random.Range (limiteInferior, limiteSuperior));
		}
	}
}
