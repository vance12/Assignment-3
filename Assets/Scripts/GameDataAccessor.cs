using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDataAccessor : MonoBehaviour
{
    public Text Lives;
    public Text Player_Name;
    public Text Score;

    private void Update()
    {
        Lives.text = Data.Instance.lives.ToString();
        Player_Name.text = Data.Instance.player_name;
        Score.text = "" + Data.Instance.score;

    }
}
