using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public TMP_Text score;
	
	// Update is called once per frame
	void Update () {
		score.text = "SCORE: "+player.position.z.ToString("0");
	}
}
