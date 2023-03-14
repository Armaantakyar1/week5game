using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataChecker : MonoBehaviour
{
    public List<Button> buttons;
    public GameObject objectToActivate;
    public float collectionTimer;
    bool text =false;
    private List<Button> clickedButtons;

    private void Start()
    {
        
        clickedButtons = new List<Button>();
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => OnButtonClick(button));
        }
    }
    private void Update()
    {
        if(text == true)
        {
            collectionTimer -= Time.deltaTime;
            if (collectionTimer <= 0)
            {
                objectToActivate.SetActive(false);
                collectionTimer = 1f;
                text = false;
            }
        }
      
    }
    private void OnButtonClick(Button button)
    {
     
        if (clickedButtons.Contains(button))
        {
            clickedButtons.Remove(button);
        }
        else
        {
            clickedButtons.Add(button);
        }
        
        if (clickedButtons.Count == 2)
        {
            objectToActivate.SetActive(true);
            text = true;
        }
    }
}
