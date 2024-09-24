using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class taretkodu : MonoBehaviour
{
    public List<Transform> dusmanim;
    public Transform govdemiz;
    public Transform atesEtmeNoktasi;
    public GameObject mermi; // olusturulacak obje
    public float atisAraligi;
    public float mermiItisHizi;
    public float gorusMesafesi;

    float gecenZaman = 0f;

    void Start()
    {
    }

    void Update()
    {
        Collider[] ustustegelenSeyler = Physics.OverlapSphere(transform.position, gorusMesafesi);
        foreach (Collider col in ustustegelenSeyler)
        {
            if (col.transform.tag == "Dusman" && !dusmanim.Contains(col.transform))
            {
                dusmanim.Add(col.transform);
            }
        }

        YokEdilenDusmanlariListedenTemizle();

        if (dusmanim.Count > 0)
        {
            govdemiz.LookAt(dusmanim[0]);

            gecenZaman += Time.deltaTime;
            if (dusmanim[0] == null)
            {
                dusmanim.Remove(dusmanim[0]);
            }
            if (gecenZaman >= atisAraligi && dusmanim[0] != null)
            {
                gecenZaman = 0;
                GameObject mermiGameObjesi = Instantiate(mermi, atesEtmeNoktasi.position, atesEtmeNoktasi.rotation);
                mermiGameObjesi.GetComponent<Rigidbody>().AddForce(atesEtmeNoktasi.forward * mermiItisHizi);
            }
        }
    }

    public void YokEdilenDusmanlariListedenTemizle()
    {
        for (int i = 0; i < dusmanim.Count; i++)
        {
            if (dusmanim[i] == null || Vector3.Distance(transform.position, dusmanim[i].position) > gorusMesafesi)
                dusmanim.Remove(dusmanim[i]);
        }
    }
}
