using Demo03.Scripts;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private int screenWidthInUnits = 0;

    // Cached component references
    private Ball _ball;

    private void Start()
    {
        _ball = FindObjectOfType<Ball>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        Time.timeScale = GameSessionScritableObject.Instance.gameSpeed;
        var paddleXPos = Mathf.Clamp(GetXPos(), 1, screenWidthInUnits - 1);
        transform.position = new Vector2(paddleXPos, transform.localPosition.y);
    }

    private float GetXPos()
    {
        return GameSessionScritableObject.Instance.IsAutoPlayEnable() ? GetBallPosition() : GetMousePosInUnits();
    }

    private float GetBallPosition()
    {
        return _ball.transform.position.x;
    }

    private static float GetMousePosInUnits()
    {
        return Input.mousePosition.x / Screen.width * 16;
    }
}