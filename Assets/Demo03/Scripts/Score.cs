using TMPro;
using UniRx;
using UnityEngine;

public class Score : MonoBehaviour
{
    public void Start()
    {
        var _gameSession = FindObjectOfType<GameSession>();
        var textMeshProUgui = GetComponent<TextMeshProUGUI>();
        _gameSession._currentScore.Subscribe(score => textMeshProUgui.text = score.ToString());
    }
}
