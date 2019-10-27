using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{   
    //First int for TextArea is the minimum height of the 
    //TextArea that will be attached to SerializedField in
    //Unity Inspector area. The second number is the maximum
    //height for the expension before scrolling starts.
    [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    [SerializeField] State   prevSteate;
    [SerializeField] KeyCode stateStartKey;

    public string GetStateStory() { return storyText; }
    public KeyCode GetSateStartKey() { return stateStartKey; }

    public State GetNextState(KeyCode userInput)
    {
        if (userInput == KeyCode.Backspace)
        {
            return prevSteate;
        }
        foreach (var state in nextStates)
        {
            if (userInput == state.GetSateStartKey())
                return state;
        }
        return this;
    }
}
