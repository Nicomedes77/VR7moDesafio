using UnityEngine;

public class EnemyIII : MonoBehaviour
{
    public Transform transformJugador;  //referencia a la posicion del jugador
//    public GameObject cejasMalas;
//    public GameObject cejasNeutrales;
    public float enemySpeed = 1f;

    public enum ModoEnemigo
    {
        Enemy_1,
        Enemy_2
    };

    public ModoEnemigo modoActual;

    void Start()
    {
        
    }

    void Update()
    {
        switch(modoActual)
        {
            case ModoEnemigo.Enemy_1:
                LookAt();
                //SeguirAlJugador();
                //LookAtPlayerQuat();
                SeguirLerp();
            break;

            case ModoEnemigo.Enemy_2:
                ChequearDistanciaConElJugador();
            break;   

            default: break;                     
        }
    }

    void ChequearDistanciaConElJugador()
    {
        float dist = Vector3.Distance(transform.position,transformJugador.position);
        Debug.Log("distancia contra el enemigo: " + dist); 

        if(dist <= 2)
        {

        }

        else
        {
            LookAt();
            SeguirLerp();            
        }
    }

    void LookAtPlayerQuat()
    {
        Quaternion rot = Quaternion.LookRotation(transformJugador.position - transform.position);
        transform.rotation = rot;
    }

    void LookAt()
    {
        transform.LookAt(transformJugador);
    }

    void SeguirAlJugador()
    {
        transform.position = Vector3.MoveTowards(transform.position, transformJugador.position , enemySpeed * Time.deltaTime);
    }

    void SeguirLerp()
    {
        transform.position = Vector3.Lerp(transform.position, transformJugador.position , enemySpeed * Time.deltaTime);
    }
}
