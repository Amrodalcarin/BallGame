using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Comprobar_estado : MonoBehaviour {
    public GameObject canvas;
    public Text text;
    public GameObject canvas_victory;
	// Use this for initialization
	void Start () {
        canvas.SetActive(false);
        canvas_victory.SetActive(false);
    }

    private void OnTriggerEnter(Collider collider)
    {
        canvas.SetActive(true);
        if (collider.tag == "win")
        {
            text.text = "You Win!";
            text.color = Color.green;
            canvas_victory.SetActive(true);
            Time.timeScale = 0;
        }
        if (collider.tag == "muerte")
        {
            text.text = "Game Over";
            text.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update () {

    }
}
