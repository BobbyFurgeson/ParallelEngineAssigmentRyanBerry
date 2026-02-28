using UnityEngine;

public class CoinBehavior : MonoBehaviour
{

    public float xSpeed = 0f;
    public float ySpeed = 50f;
    public float zSpeed = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate((ySpeed * Time.deltaTime), (xSpeed * Time.deltaTime), (zSpeed* Time.deltaTime));
    }


    void OnCollisionEnter()
    {
        Debug.Log("Coin collected!");
        Destroy(gameObject);
    }
}
