using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdScript : MonoBehaviour {

	public float impulso;

	public static bool inGame;
	Rigidbody2D rb;

	void Start () {
		// instancia do componente
		rb = GetComponent<Rigidbody2D> ();

		// desabilita a gravidade enqunto o jogo nao tem inicio
		rb.gravityScale = 0.0f;

	}
	
	// Update is called once per frame
	void Update () {
		if (!inGame && Input.GetButtonDown("Fire1")) {
			inGame = true;
			rb.gravityScale = 1.0f;
		} else if (inGame && Input.GetButtonDown ("Fire1")) {
			rb.velocity = new Vector2 (0.0f, impulso);
		}

	}
		
	void OnTriggerEnter2D(Collider2D c) {
		PrincipalScript.pontos++;
		print (PrincipalScript.pontos);

	}
		
	void OnCollisionEnter2D () {
		SceneManager.LoadScene ("start");
	}
}
