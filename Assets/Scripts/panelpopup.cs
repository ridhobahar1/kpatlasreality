using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelpopup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    int counter;
   public void popuppanel()
    {
        counter++;
        if(counter % 2 == 1)
        {
            Panel.gameObject.SetActive(true);
        }
        else
        {
            Panel.gameObject.SetActive(false);
        }
    }
}
