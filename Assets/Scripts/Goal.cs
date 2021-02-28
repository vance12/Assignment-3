using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU SCORED!");
		Data.Instance.score++;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
