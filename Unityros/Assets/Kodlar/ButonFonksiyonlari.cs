using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButonFonksiyonlari : MonoBehaviour
{
    public void OyundanCik()
    {
        Application.Quit();
    }



    public void SahneAc(string sahneAdi)
    {
        SceneManager.LoadScene(sahneAdi);
    }
}
