using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanspawnerkodu : MonoBehaviour
{
    public float dusmanSpawnAraligi;
    public int dusmanSpawnSayisi;
    public GameObject dusmaninKendisi;
    public Transform saldiracaklariBase;

    float gecenZaman = 0f;

    void Update()
    {
        gecenZaman += Time.deltaTime;

        if (gecenZaman >= dusmanSpawnAraligi && dusmanSpawnSayisi > 0)
        {
            gecenZaman = 0f;
            dusmanSpawnSayisi -= 1;
            GameObject dusmaninObjesi = Instantiate(dusmaninKendisi, transform);
            dusmaninObjesi.GetComponent<dusmankodu>().Base = saldiracaklariBase;
        }
    }
}
