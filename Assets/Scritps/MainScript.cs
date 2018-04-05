using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {

	public Text txtPontos;

	//statica variavel que pode ser acessada de outro font
	public static int pontos;
	public bool inGame;

	// Use this for initialization
	void Start () {
		// zera a pontuação somente se estiver na cena do jogo
		if (inGame) {
			pontos = 0;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		txtPontos.text = pontos.ToString () ;
		EntrarNoJogo ();
	}

	//inicia o jogo se estiver como inGame false
	void EntrarNoJogo() {
		//inicia o jogo se estiver na tela inicial e pressionar alguma
		if (inGame == false && Input.anyKey) {
			Application.LoadLevel ("game");
		}
	}
}
