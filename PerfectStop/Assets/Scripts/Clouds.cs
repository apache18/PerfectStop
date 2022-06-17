using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float speed=0.1f;
    private float _yPos;
    public int rand = 0;
    void Start()
    {
        _yPos = transform.position.y;
        rand = Random.Range(0, 2);
        if (rand == 1)
        {
            speed *= -1f;
        }
    }

    
    void Update()
    {
        if (transform.position.y > _yPos + 3f || transform.position.y < _yPos - 3f)
        {
            speed *= -1f;
        }
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }
}
