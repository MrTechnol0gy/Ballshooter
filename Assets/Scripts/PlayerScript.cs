using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public TextMeshProUGUI keysAmountText;
    private int keys;

    // Start is called before the first frame update
    void Start()
    {
        keys = 0;  
        SetKeysText();
    }
    
    void SetKeysText()
    {
        keysAmountText.text = "Keys: " + keys.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            keys = keys++;

            SetKeysText();
        }
    }
}
