using UnityEngine;
using System.Collections;

public class MoviePlay : MonoBehaviour {
	public MovieTexture Movie;
	public AudioSource Audio;
	public GUITexture Overlay;
	public float FadeTime;
	private bool faded = false;
	// Use this for initialization
	void Awake()
	{
		//Overlay.pixelInset = new Rect (0, 0, Screen.width, Screen.height);

	}

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P) && !Audio.isPlaying) {
			//StartCoroutine(FadeToClear());
			Movie.Play();
			Audio.Play();
		}
		if (Input.GetKeyDown(KeyCode.Escape)) {
			StartCoroutine(FadeToClear());
			Screen.fullScreen = false;
			Movie.Stop();
			Audio.Stop();
		}
	}

//	void OnGUI()
//	{
//		if (Movie != null && Movie.isPlaying) {
//			Color c = GUI.color;
//			Color old = c;
//			c.a = 1f;
//			GUI.color = c;
//			GUI.DrawTexture(new Rect(0,0, Screen.width, Screen.height), Movie, ScaleMode.StretchToFill,alphaBlend:false);
//			GUI.color = old;
//
//		}
//	}

	private IEnumerator FadeToClear()
	{
		Overlay.pixelInset = new Rect (0, 0, Screen.width, Screen.height);
		Overlay.gameObject.SetActive (true);
		Overlay.color = Color.black;

		float rate = 0.1f / FadeTime;

		float progress = 0.0f;

		while (progress<1.0f) {
			Overlay.color = Color.Lerp(Color.black , Color.clear, progress);
			progress += rate * Time.deltaTime;
			yield return null;
		}

		Overlay.color = Color.clear;
		Overlay.gameObject.SetActive (false);

	}
}
