using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AcceptState : MonoBehaviour
{
    PlayState play;

    private void Start()
    {
        PlayState play = GetComponent<PlayState>();
    }
    private void Update()
    {
        Disable();
        nextlevel();
    }
    public void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Disable()
    {
        play.enabled = false;
    }
}

