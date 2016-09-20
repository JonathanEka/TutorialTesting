using UnityEngine;
using System.Collections;

public class KlikDissapear : MonoBehaviour {
	public GameObject cubes, cubes2;
	// Use this for initialization
	void Start () {
		cubes.SetActive (true);
		cubes2.SetActive (false);
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void hide()
	{
		cubes.SetActive (false);
	}

	public void show(){
		cubes2.SetActive (true);
	}
}
 