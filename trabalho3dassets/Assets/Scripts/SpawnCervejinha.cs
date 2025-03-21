using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCervejinha : MonoBehaviour
{
    float limiteX = 9;
    float limiteZ = -15;

    Vector3 lugarSpawm;
    [SerializeField]  GameObject cervejinha;
    public int numspawm = 1;
   public static SpawnCervejinha instance;


    private void Awake()
    {
        instance = this;
    }



    private void Update()
    {
        if (numspawm<2) 
        {
            Spawm();
        }
       
    }
    void Spawm()
    {
       lugarSpawm.x = Random.Range(-1.46f, limiteX);
       lugarSpawm.z = Random.Range(-3.15f, limiteZ);
       lugarSpawm.y = 1.03f;

       for (int i = 0; i <= 2; i++) 
        {
            numspawm++;
            Instantiate(cervejinha, lugarSpawm, Quaternion.identity);
        }
    }

}
