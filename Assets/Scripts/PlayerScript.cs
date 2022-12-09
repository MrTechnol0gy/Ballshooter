using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public TextMeshProUGUI keysAmountText;
    private int keys;
    public PlayableDirector entryWay;
    public PlayableDirector audienceHall;
    public PlayableDirector audienceHall2;
    public PlayableDirector portalRoom;
    public PlayableDirector secretHall;
    public PlayableDirector secretHall2;

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
            keys = keys + 1;
            SetKeysText();
            OpenDoor();
            
        }
    }
    private void OpenDoor()
    {
        switch (keys)
        {
            case 1:
                entryWay.Play();
                break;
            case 2:
                audienceHall.Play();
                audienceHall2.Play();
                break;
            case 6:
                secretHall.Play();
                break;
            case 7:
                secretHall2.Play();
                break;
            case 8:
                portalRoom.Play();
                break;
            default:
                break;
        }
    }
}
