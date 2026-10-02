using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    public int frames = 0;
    public Vector3 colorVector;
    public int framesEspera = 120;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colorVector = new Vector3(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        ++frames;
        if (framesEspera != 0 && frames % framesEspera == 0) {
            int randomPosition = Random.Range(0, 3);
            colorVector[randomPosition] = Random.value;
            GetComponent<Renderer>().material.color = new Color(colorVector.x, colorVector.y, colorVector.z);
        }
    }
}
