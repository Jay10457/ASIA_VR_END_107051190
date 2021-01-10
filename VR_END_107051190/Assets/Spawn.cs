using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    [SerializeField] public GameObject GoldSnata;
    [SerializeField] public GameObject SilverSanta;
    [SerializeField] public GameObject NormalSanta;
    [SerializeField] public GameObject Point;
    
    public int RandomRate;
    
    
    
    
    public void SantaSpawn()
    {
        Vector3 spawnPos = Point.transform.position;
        Vector3 randomSpawn = spawnPos + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-0.25f, 0.25f), Random.Range(-1.25f, 1.25f));
        
        
       
            RandomRate = Random.Range(0, 10);

            if (RandomRate <= 1)
            {
                GameObject.Instantiate(GoldSnata, randomSpawn, Quaternion.identity);
            }
            if (RandomRate > 1 && RandomRate <= 4)
            {
                GameObject.Instantiate(SilverSanta, randomSpawn, Quaternion.identity);
            }
            if (RandomRate > 4 && RandomRate <= 10)
            {
                GameObject.Instantiate(NormalSanta, randomSpawn, Quaternion.identity );
            }
       

    }
    public void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SantaSpawn();
        }
    }
    void OnDrawGizmosSelected()
    {
       
       // Gizmos.color = new Color(1, 0, 0, 0.5f);
        
       // Gizmos.DrawCube(transform.position, new Vector3(3, 0.5f, 2.5f));
        
    }



}
