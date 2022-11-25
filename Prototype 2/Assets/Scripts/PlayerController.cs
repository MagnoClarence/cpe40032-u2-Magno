using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private float horizontalInput;
    public float speed = 20f;
    private float xRange = 20;
    private float cooldown = 0;

    public GameObject projectilePrefab;
    public GameObject bigProjPrefab;
    public GameObject cookie;
    public GameObject addProjPrefab;
    public GameObject[] allyDogs;
    private Vector3 offset = new Vector3(1, 0, -1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Keeps the player from going out of bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Makes the user control the farmer
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Input to launch a projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Projectile is launched from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        // Alternate fire
        if (Input.GetKeyDown(KeyCode.W) && cooldown <= 0)
        {
            // Alternate fire has cooldown
            Instantiate(bigProjPrefab, transform.position, bigProjPrefab.transform.rotation);
            cooldown = 3;
        }
        if (cooldown >= 0)
        {
            cooldown -= Time.deltaTime;
        }
    }
}
