using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Action onGameStart;
    public Action onGameWin;
    public Action onGameFail;

    private void Update()
    {
        
        if (Input.anyKey)
        {
            GameStart();
        }
    }

    public void GameStart()
    {
        onGameStart?.Invoke();
    }
    public void GameWin()
    {
        onGameWin?.Invoke();
    }
    public void GameFail()
    {
        onGameFail?.Invoke();
    }
}
