using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float jumpPower;
	public GameObject Score;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")){
			GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
			}

    }
	 
	void OnCollisionEnter (Collision Collision) {
		Application.LoadLevel("GameOver");
	}

	void OnTriggerEnter (Collider col){
		//Score(GUIText)のScoreUpメソッドを呼び出す
		Score.SendMessage("ScoreUp", 1);
		Destroy(col.gameObject);
	}



}