using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    public enum ProjectileType
    {
        GreenShell, Banana
    }

    public ProjectileType currentProjectile;

    Rigidbody rb;

    public Vector3 projectileDir;
    public float speed;
    public Rigidbody carRB;

    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.SetParent(null);
        startTime = Time.time;
        switch(currentProjectile)
        {
            case ProjectileType.Banana:
                projectileDir.y = 1;
                rb.AddForce(projectileDir * speed);
                break;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (currentProjectile)
        {
            case ProjectileType.GreenShell:
                rb.velocity = projectileDir * speed;
                break;
            case ProjectileType.Banana:
                //float yVelocity = 0;
                //float timeAlive = Time.time - startTime;
                //if (timeAlive > 1)
                //{
                //    yVelocity = 1 / timeAlive;
                //}
                //else if (timeAlive >= 0)
                //{
                //    yVelocity = timeAlive / 1;
                //}
                //else
                //{
                //    //catch case - will program errors if code doesn't work.
                //}

                //projectileDir.y = projectileDir.y + yVelocity;
                //rb.velocity = projectileDir * speed;
                break;
        }
    }
}
