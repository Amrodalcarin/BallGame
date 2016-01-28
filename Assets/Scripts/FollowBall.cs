using UnityEngine;
using System.Collections;

public class FollowBall : MonoBehaviour {
    public GameObject ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y + (float)0.3, ball.transform.position.z);
	}
}
