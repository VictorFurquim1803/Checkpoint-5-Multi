using UnityEngine;

public class RobotInteraction : MonoBehaviour
{
    public float velocidadeRotacao = 100f;
    public Vector3 eixoRotacao = Vector3.up;
    private bool girando = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (girando)
        {
            transform.Rotate(eixoRotacao * velocidadeRotacao * Time.deltaTime);
        }
    }

    public void OnMouseDown()
    {
        girando = !girando;
    }

    public void Aumentar()
    {
        transform.localScale *= 1.2f;
    }

    public void Diminuir()
    {
        transform.localScale *= 0.8f;
    }
}
