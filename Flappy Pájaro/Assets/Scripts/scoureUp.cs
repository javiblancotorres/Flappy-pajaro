using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoureUp : MonoBehaviour {
	
	//Para poder conectar este Script con el texto, voy a crear una variable de tipo Text publico. para despues arrastrar TextoNivel sobre la opcion publica que he creado.

	private Text Texto;
	private Text TextoFinal;


	void Start(){
		//Al empezar el juego me busca el objeto TextoNivel, y dentro de ese objeto me coje el componente Text

		Texto = GameObject.Find ("textoNivel").GetComponent<Text>(); 
		TextoFinal = GameObject.Find ("TextoFinal").GetComponent<Text> ();
	}



	void OnTriggerEnter2D(Collider2D coll) {
		GameControl.score = GameControl.score + 1;

		//if(coll.gameObject.tag == "Moneda")
			//Destroy;
	

		//Debug.Log (GameControl.score);

		Texto.text = "Level" + GameControl.score.ToString ();
		TextoFinal.text = Texto.text;
	}

}