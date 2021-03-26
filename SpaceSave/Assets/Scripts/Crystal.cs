using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Crystal : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    public Text crystalText;
    private int totalCrystal=0;
    private int totalAsteroid=0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCrystalText();
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
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
        if(hit.CompareTag("Asteroid")){
                totalAsteroid++;
                playerInventoryDisplay.OnChangeHeartTotal(totalAsteroid);
                Destroy(hit.gameObject);
            }
        
    }
}
