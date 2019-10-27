using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvantureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    
    State state;
    KeyCode pressedKey;

    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        if (DetectInput())
        {
            var nextState = state.GetNextState(pressedKey);
            state = nextState;
            textComponent.text = state.GetStateStory();
        }
    }

    public bool DetectInput()
    {
        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
            {
                pressedKey = kcode;
                return true;
            }
        }
        return false;
    }
}
