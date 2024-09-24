using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dusmankodu : MonoBehaviour
{
    public NavMeshAgent benimNavMeshAgent;
    public Transform Base;

    void Start()
    {
        benimNavMeshAgent.SetDestination(Base.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"bi�eye �arpt�k: {collision.transform.name}");
        if (collision.transform.CompareTag("Us"))
        {
            Debug.Log("�arpt���m�z �ey: �s");
            GameManager.Instance.CaniAzalt();
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        int kazanilacakPara = Random.Range(5, 11);
        GameManager.Instance.ParaKazan(kazanilacakPara);
    }
}
