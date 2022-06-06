using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject menuPanel;
    private Dog dog;
    private bool dogDead = false;
    [SerializeField] GameObject player;

    void Awake()
    {
        dog = player.GetComponent<Dog>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!dogDead && dog.dead)
        {
            dogDead = true;
            Invoke(nameof(OpenMenu), 1);
        }
            
    }

    private void OpenMenu()
    {
        menuPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
