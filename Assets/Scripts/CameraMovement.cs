using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float cameraSpeed;
    private Dog dog;
    [SerializeField] GameObject player;

    private void Awake()
    {
        dog = player.GetComponent<Dog>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!dog.dead)
        {
            cameraSpeed = Mathf.Min(12 * (1 + dog.transform.position.x / 1000), 36f);
            transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
        }
    }
}
