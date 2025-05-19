using UnityEngine;

public class InfoSombrero : MonoBehaviour
{
    private int sombreroElegido = -1;

    [SerializeField] private int cantidadSombreros = 5; 

    public void AsignarSombrero(int index)
    {
        sombreroElegido = index;
    }

    public int PideSombrero()
    {
        if (sombreroElegido == -1)
        {
            sombreroElegido = Random.Range(0, cantidadSombreros);
        }
        return sombreroElegido;
    }
}
