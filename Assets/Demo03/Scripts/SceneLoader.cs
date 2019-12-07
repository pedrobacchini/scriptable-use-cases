﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Cached component references
    private GameSession _gameSession;

    private void Start()
    {
        _gameSession = FindObjectOfType<GameSession>();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("Start Menu Block");
        if (_gameSession != null)
            _gameSession.ResetGame();
    }
}