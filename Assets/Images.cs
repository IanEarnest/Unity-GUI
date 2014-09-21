using UnityEngine;
using System.Collections;

public class Images : MonoBehaviour {

	public Texture[] images = new Texture[9];

	// Use this for initialization
	void Start () {
		for (int a = 0; a < images.Length; a++) {
			int b = a+1;
			images[a] = Resources.Load(b.ToString()) as Texture;
		}
	}
}
