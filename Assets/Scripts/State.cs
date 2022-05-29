using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string getStoryText()
    {
        return storyText;
    }

    public State[] getNextStates()
    {
        return nextStates;
    }
}
