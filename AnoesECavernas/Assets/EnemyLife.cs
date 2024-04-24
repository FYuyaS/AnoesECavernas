using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int life = 1;
    [SerializeField] GameObject bloodParticle;

    private void Update()
    {
        //apenas para testar a fun��o de dano, lembrar de tirar isso
        if(Input.GetKeyDown(KeyCode.X))
        {
            //TakeHit(1);
        }
    }

    //fun��o p�blica para tomar dano, adicionar uma refer�ncia no script da torre para bater nele
    public void TakeHit(int dmg)
    {
        life -= dmg;
        if(life <= 0 )
        {
            Die();
        }
    }

    //Sequencia de a��es ao morrer (podemos add uma anima��o ou algo assim
    void Die()
    {
        GameObject blood = Instantiate(bloodParticle, transform.position, Quaternion.identity);
        blood.transform.parent = null;
        Destroy(gameObject);
    }
}
