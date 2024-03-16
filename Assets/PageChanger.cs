using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PageChanger : MonoBehaviour
{

    public TextMeshProUGUI[] texts;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeText(int number)
    {
        if (number == 1) { texts[0].gameObject.SetActive(true); texts[1].gameObject.SetActive(false); texts[2].gameObject.SetActive(false); }
    else if ( number == 2 )
        {
            texts[0].gameObject.SetActive(false); texts[1].gameObject.SetActive(true); texts[2].gameObject.SetActive(false);
        }
        else if (number == 3)
        {
            texts[0].gameObject.SetActive(false); texts[1].gameObject.SetActive(false); texts[2].gameObject.SetActive(true);
        }

    }
}
