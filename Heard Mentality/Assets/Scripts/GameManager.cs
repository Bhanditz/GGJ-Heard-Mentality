using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    private string startLevel = "test";

	// Use this for initialization
	void Start () {
        LoadLevel(startLevel);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void LoadLevel(string filename)
    {

        GameObject obj = (GameObject)GameObject.Instantiate(Resources.Load("Prefabs/" + filename));
    }
}
