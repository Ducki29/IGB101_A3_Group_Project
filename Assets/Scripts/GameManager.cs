using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    public int currentPickup = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    public AudioSource[] audioSources;
    public float audioProximity = 5f;

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
        playAudio();

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

    private void playAudio()
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            if (Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity)
            {
                if (!audioSources[i].isPlaying)
                {
                    audioSources[i].Play();
                }

            }

        }
    }



}   
