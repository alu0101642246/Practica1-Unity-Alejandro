using UnityEngine;

public class DistanciaEntreCuboCilindro : MonoBehaviour
{
    public float distanciaEsferaCilindro = 0;
    public float distanciaEsferaCubo = 0;
    public GameObject cubo;
    public GameObject cilindro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubo = GameObject.FindWithTag("Cube");
        cilindro = GameObject.FindWithTag("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        distanciaEsferaCilindro = Vector3.Distance(cilindro.transform.position, transform.position);
        distanciaEsferaCubo = Vector3.Distance(cubo.transform.position, transform.position);
        Debug.Log("La distancia de la esfera al cilindro es de " + distanciaEsferaCilindro);
        Debug.Log("La distancia de la esfera al cubo es de " + distanciaEsferaCubo);
        
    }
}
