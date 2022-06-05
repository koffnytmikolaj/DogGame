using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    // Start is called before the first frame update
    public float backgroundSpeed = 12;
    public Renderer backgroundRenderer;

    private void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
