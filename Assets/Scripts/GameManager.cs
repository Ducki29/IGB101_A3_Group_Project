using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public int currentPickup = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    public Text pickupText;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();

    }
private void LevelCompleteCheck(){
        if (currentPickup >= maxPickups)
            levelComplete = true;
        else 
            levelComplete = false;
            
        
    }

private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickup + "/" + maxPickups;
    }

}
