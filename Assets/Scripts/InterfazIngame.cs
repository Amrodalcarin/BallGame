using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InterfazIngame : MonoBehaviour {

    public Text tiempo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        tiempo.text = Time.timeSinceLevelLoad.ToString("F2");
	}
}
