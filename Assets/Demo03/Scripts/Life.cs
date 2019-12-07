using TMPro;
using UniRx;
using UnityEngine;

public class Life : MonoBehaviour
{
    private void Start()
    {
        var _gameSession = FindObjectOfType<GameSession>();
        var textMeshProUgui = GetComponent<TextMeshProUGUI>();
        _gameSession._currentLives.Subscribe(lives => textMeshProUgui.text = lives.ToString());
    }
}
