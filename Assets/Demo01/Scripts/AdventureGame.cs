using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent = null;
    [SerializeField] private State startingState = null;

    private State _state;

    private void Start()
    {
        _state = startingState;
        textComponent.text = _state.GetStoryText();
    }

    private void Update()
    {
        var nextStates = _state.GetNextStates();
        for (var indexState = 0; indexState < nextStates.Length; indexState++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + indexState))
            {
                _state = nextStates[indexState];
            }
        }
        textComponent.text = _state.GetStoryText();
    }
}