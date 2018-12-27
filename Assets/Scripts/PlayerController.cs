using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    void Start()
    {

    }

    void Update()
    {

    }

    public void OnVirtualPress()
    {
        Debug.Log("OnVirtualPress");
    }

    public void OnVirtualClick()
    {
        Debug.Log("OnVirtualClick()");
    }

    public void OnVirtualPressDown()
    {
        Debug.Log("OnVirtualPressDown()");
    }

    public void OnVirtualPressUp()
    {
        Debug.Log("OnVirtualPressUp()");
    }
}
