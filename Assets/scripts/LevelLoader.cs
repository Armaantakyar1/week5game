using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    AcceptState accept;
    // Start is called before the first frame update
    void Start()
    {
        accept = GetComponent<AcceptState>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        accept.enabled = false;
    }
}
