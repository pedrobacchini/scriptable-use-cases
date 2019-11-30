using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
     [TextArea(14,10)] [SerializeField] private string storyText = null;
     [SerializeField] private State[] nextStates = null;

     public string GetStoryText()
     {
          return storyText;
     }

     public State[] GetNextStates()
     {
          return nextStates;
     }
}
