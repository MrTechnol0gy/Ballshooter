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
        Debug.Log("This should change the amount of keys.");
        keysAmountText.text = "Keys: " + keys.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            Debug.Log("The pickup is recognized.");
            Debug.Log("The pickup will be set inactive.");

            other.gameObject.SetActive(false);

            Debug.Log("The pickup should now be inactive.");
            Debug.Log("The keys int should now go up by one in the code.");

            keys = keys + 1;

            Debug.Log("The keys int should now be increased by one in the code.");
            Debug.Log("SetKeysText method will now be called.");

            SetKeysText();

            Debug.Log("SetKeysText method has been called and the keys amount shown in the UI should be increased by one.");
        }
    }
}
