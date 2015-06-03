using UnityEngine;
using System.Collections;

public class MoviePlay : MonoBehaviour {
	public AudioSource audio1;
	// Use this for initialization
	void Start () {
		//((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q)) {
			
			Renderer r = GetComponent<Renderer>();
			MovieTexture movie = (MovieTexture)r.material.mainTexture;
			
			if (movie.isPlaying) {
				movie.Pause();
				audio1.Pause();

			}
			else {
				movie.Play();
				audio1.Play();
			}
		}
	}
}
