using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class SoundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		audio.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
	       if(GameControl.dead)
			audio.Stop
	}
}
