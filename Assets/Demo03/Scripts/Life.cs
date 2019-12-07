using Demo03.Scripts;
using TMPro;
using UniRx;
using UnityEngine;

public class Life : MonoBehaviour
{
    private void Start()
    {
        var _gameSession = GameSessionScritableObject.Instance;
        var textMeshProUgui = GetComponent<TextMeshProUGUI>();
        _gameSession._currentLives.Subscribe(lives => textMeshProUgui.text = lives.ToString());
    }
}
