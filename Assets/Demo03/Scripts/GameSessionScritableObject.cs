using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Demo03.Scripts
{
    [CreateAssetMenu(fileName = "New Game Session", menuName = "Managers/Game Session")]
    public class GameSessionScritableObject : SingletonScriptableObject<GameSessionScritableObject>
    {
        //    // Configure parameters
    [Range(0.1f, 10f)] [SerializeField] public float gameSpeed = 1f;
    [SerializeField] private int pointsPerBlockDestroyed = 80;
    [SerializeField] private bool autoPlay = false;
    
    // State variables
    public readonly ReactiveProperty<int> _currentScore = new ReactiveProperty<int>(0);
    public readonly ReactiveProperty<int> _currentLives = new ReactiveProperty<int>(0);

    public void AddToScore()
    {
        _currentScore.Value += pointsPerBlockDestroyed;
    }

    public void ResetGame()
    {
        _currentScore.Value = 0;
        _currentScore.Value = 0;
    }

    public bool IsAutoPlayEnable()
    {
        return autoPlay;
    }

    public void AddLive()
    {
        _currentLives.Value++;
    }

    public void TriggerLoseCollider()
    {
        _currentLives.Value--;
        if (_currentLives.Value < 0)
        {
            SceneManager.LoadScene("Game Over Block");
            Cursor.visible = true;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    }
}