using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Variables that will be used in Unity
    public string startText;
    public string updateText;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError(startText);
        Debug.LogWarning(startText);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(updateText);
    }
}
