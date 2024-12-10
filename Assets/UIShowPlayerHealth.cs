using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIShowPlayerHealth : MonoBehaviour
{
    public PlayerHealth playerHealthScript;
    TextMeshProUGUI UItext;
    // Start is called before the first frame update
    void Start()
    {
        UItext = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if((playerHealthScript.playerHealth - playerHealthScript.damageTaken) <= 0)
        {
            UItext.text = "";
        }
        else
        {
            UItext.text = "Health: " + (playerHealthScript.playerHealth - playerHealthScript.damageTaken);
        }
    }
}
