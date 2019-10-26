using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvantureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "WOKE UP!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
