using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SpawinPoints : MonoBehaviour
{
    public Transform playerSpawnPoints;
    Transform[] spawnPoints;
    public bool respawn=false;
    public bool lastToggle = false;
    public int i;
    FirstPersonController temp;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        print(spawnPoints.Length);
        temp = GetComponent<FirstPersonController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lastToggle!=respawn)
        {
            Respawn();
            temp.enabled = false;
            respawn = false;
           
        }
        else
        {
            temp.enabled = true;
            lastToggle = respawn;
        }
    }
    public void Respawn()
    {
         i = Random.Range(1, spawnPoints.Length);
       
    }
}
