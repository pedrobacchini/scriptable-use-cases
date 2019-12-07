using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    // Configure parameters
    [Range(0.1f, 10f)] [SerializeField] private float gameSpeed = 1f;
    [SerializeField] private int pointsPerBlockDestroyed = 80;
    [SerializeField] private bool autoPlay = false;
    
    // State variables
    public readonly ReactiveProperty<int> _currentScore = new ReactiveProperty<int>(0);
    public readonly ReactiveProperty<int> _currentLives = new ReactiveProperty<int>(0);

    // Singleton DontDestroyOnLoad
    private void Awake()
    {
        if (FindObjectsOfType<GameSession>().Length > 1)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        _currentScore.Value += pointsPerBlockDestroyed;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
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