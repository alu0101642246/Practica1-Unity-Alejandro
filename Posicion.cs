using UnityEngine;

public class Posicion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnGUI()
    {
        Vector3 posicion = transform.position;
        string posicionString = "La esfera está en:    " + posicion.x + "    " + posicion.y + "    " + posicion.z;
        GUI.Label(new Rect(100, 100, 300, 100), posicionString);
    }
}
