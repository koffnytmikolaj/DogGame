using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    // Start is called before the first frame update
    private float backgroundSpeed;
    public Renderer backgroundRenderer;
    private Dog dog;
    [SerializeField] GameObject player;

    private void Awake()
    {
        dog = player.GetComponent<Dog>();
    }

    private void Update()
    {
        if(!dog.dead)
        {
            backgroundSpeed = Mathf.Min(2f/3 * (1 + dog.transform.position.x / 1000), 2f);
            backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
        }
    }
}
