using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	private int score = 0;
	
	void Start () {
		GetComponent<Text>().text = "Score: " + score.ToString();
	}
	
	public void ScoreUp (int point)
	{
		score += point;
		GetComponent<Text> ().text = "Score: " + score.ToString ();
	}


}
