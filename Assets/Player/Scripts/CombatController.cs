using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject item;
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject temp = Instantiate(item, spawnPoint);
            Projectile tempScript = temp.GetComponent<Projectile>();
            tempScript.carRB = car.GetComponent<Rigidbody>();
            tempScript.projectileDir = spawnPoint.forward;
        }
    }
}
