using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour
{
    public void OnButtonUp()
    {
        SceneManager.LoadScene("GameScene");
    }
}
