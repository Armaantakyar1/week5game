using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayState : MonoBehaviour
{
    private void Awake()
    {
        this.enabled = true;
    }
    private void Start()
    {
        DeclineState decline = GetComponent<DeclineState>();
        AcceptState accept = GetComponent<AcceptState>();
    
        decline.enabled = false;
        accept.enabled = false;

    }

}
