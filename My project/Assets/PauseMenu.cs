using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //IF the escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            //display the pause menu
            GetComponent<Canvas>().enabled = true;
            //pause the game
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
        {
            //hide the pause canvas again
            GetComponent <Canvas>().enabled = false;
            //reset the time scale to 1
            Time.timeScale = 1;
        }
    }
}
