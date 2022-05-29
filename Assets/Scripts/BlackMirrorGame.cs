using UnityEngine;
using UnityEngine.UI;

public class BlackMirrorGame : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] State startingState;

    State currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = startingState;
        storyText.text = currentState.getStoryText();
    }

    // Update is called once per frame
    void Update()
    {
        var nextStates = currentState.getNextStates();

        if (nextStates.Length == 0 && Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
            return;
        }

        manageStates(nextStates);
    }

    private void manageStates(State[] nextStates)
    {

        if (nextStates.Length == 0) {
            storyText.text = currentState.getStoryText() + "\n\nGame is over! Press Q to exit!";
            return;
        }

        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                currentState = nextStates[index];
            }
        }

        storyText.text = currentState.getStoryText();
    }
}
