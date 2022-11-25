using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraAppleShot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject player;
    private Vector3 offset = new Vector3(1.5f, 0, -1);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Input to launch a projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Projectile is launched from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        transform.position = player.transform.position + offset;
    }
}
