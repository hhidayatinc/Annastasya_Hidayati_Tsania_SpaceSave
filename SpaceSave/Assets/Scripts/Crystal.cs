using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Crystal : MonoBehaviour
{
    public Text crystalText;
    private int totalCrystal=0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCrystalText();
    }

    // Update is called once per frame
    void UpdateCrystalText()
    {
        string crystalMessage = "Crystals = " + totalCrystal;
        crystalText.text = crystalMessage;
    }

    void OnTriggerEnter2D(Collider2D hit) {
        if(hit.CompareTag("Crystal")){
            totalCrystal++;
            UpdateCrystalText();
            Destroy(hit.gameObject);
        }
        
    }
}
