using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;
public class SystemController : MonoBehaviour
{
    public AudioSource music;
    public void CreateSave()
    {
        SaveGame();
    }
    private Save CreateSaveGameObject()
    {
        Save save = new Save();

        save.speed = Data.Instance.pausedSpeed;
        save.playerName = Data.Instance.player_name;
        save.score = Data.Instance.score;
        save.lives = Data.Instance.lives;

        return save;
    }
    public void SaveGame()
    {
        Save save = CreateSaveGameObject();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
        Debug.Log("Game Saved");
    }
    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            Data.Instance.pausedSpeed = save.speed;
            Data.Instance.player_name = save.playerName;
            Data.Instance.score = save.score;
            Data.Instance.lives = save.lives;


            Debug.Log("Game Loaded");
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }
    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }
    public void toggleMusic()
    {
        if (music.mute)
        {
            music.mute = false;
        }
        else
        {
            music.mute = true;
        }
            
    }
}
