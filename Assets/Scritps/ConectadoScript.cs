using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConectadoScript : MonoBehaviour {

	Rigidbody2D rb;
	bool jogando;

	// Use this for initialization
	void Start () {
		//interface com o componente Rigidbody2D
		rb = GetComponent<Rigidbody2D> ();

		//remove inicialmente a gravidade enquando o jogo nao inicia
		rb.gravityScale = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		ControleConectado (5.0f);
	}

	// contrala o conectado
	void ControleConectado(float f) {
		
		if (Input.GetButtonDown("Fire1")) {
			//inicial a gravidade no primeiro toque
			if (!jogando) {
				rb.gravityScale = 1.0f;
				jogando = true;
			}		

			//inpulsiona o conectado
			rb.velocity = new Vector2 (0.0f, f);


		}
	}

	void OnCollisionEnter2D (Collision2D c) {
		print ("Conectado foi derrotado..");
		Application.LoadLevel ("start");
	}

	void OnTriggerEnter2D(Collider2D c) {
		MainScript.pontos++;
	}
}
