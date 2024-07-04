using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSettings : MonoBehaviour
{
    public GameObject paruParuPanel, lungsPanel;

    // Start is called before the first frame update
    void Start()
    {
        paruParuPanel.SetActive(true);
        lungsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void indButton()
    {
        if (paruParuPanel == null)
        {
            bool isActive = paruParuPanel.activeSelf;
            paruParuPanel.SetActive(isActive);
        }

        else
        {
            lungsPanel.SetActive(false);
            paruParuPanel.SetActive(true);
        }
    }

    public void engButton()
    {
        if (lungsPanel == null)
        {
            bool isActive = lungsPanel.activeSelf;
            lungsPanel.SetActive(isActive);
        }

        else
        {
            paruParuPanel.SetActive(false);
            lungsPanel.SetActive(true);
        }
    }
}
