using UnityEngine;

public class timeChange : MonoBehaviour
{
    public float rotatSpeed = 1f;
    public Material material;

    private void Start()
    {
        material.mainTextureOffset = new Vector2(Random.Range(0f, 0.2f), 0);
    }

    private void Update()
    {
        material.mainTextureOffset += new Vector2(rotatSpeed * Time.deltaTime, 0);
    }
}
