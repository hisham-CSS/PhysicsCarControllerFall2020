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

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.SetParent(null);
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
                projectileDir.y = 1;
                rb.velocity = projectileDir * speed;
                break;
        }
    }
}
