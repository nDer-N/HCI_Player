using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerCont : MonoBehaviour
{
    public float velocidad = 8f;
    public float fuerzaSalto = 7f;
    
    private Rigidbody2D rb;
    private bool enElSuelo = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
    }
}
