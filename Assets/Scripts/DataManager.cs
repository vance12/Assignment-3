using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public Dropdown Lives;

    public Slider Speed;

    public InputField Player_name;

    public void SetData()
    {
        Data.Instance.speed = Speed.value;
        Data.Instance.player_name = Player_name.text;
        if (Lives.value == 0)
        {
            Data.Instance.lives = 3;
        }
        if (Lives.value == 1)
        {
            Data.Instance.lives = 2;
        }
        if (Lives.value == 2)
        {
            Data.Instance.lives = 1;
        }

    }
}

