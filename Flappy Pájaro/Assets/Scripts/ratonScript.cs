using UnityEngine;
using System.Collections;

public class ratonScript : MonoBehaviour {

	public int vhorizontal = 10;
	public int vvertical = 10;
	//esto de abajo significa que vas a crear una variable llamada movimiento, de tipo Vector3
	Vector3 movimiento;
	Vector3 posicionRaton;
	
	// Update is called once per frame
	void Update () {
	
		posicionRaton = Input.mousePosition;
		
		//La frase de abajo es muy importante, ya que te transforma las coordenadas del raton en la pantalla al raton en la camara.
		posicionRaton = Camera.main.ScreenToWorldPoint (posicionRaton);
		
		//movimiento = new Vector3 (vhorizontal * h, vvertical * v, 0);
		
		//transform.Translate (movimiento * Time.deltaTime);
		
		if (Input.GetMouseButton (0)) {
			transform.position = Vector2.Lerp (transform.position, posicionRaton, vvertical * 0.1f);
		}

	}
}
