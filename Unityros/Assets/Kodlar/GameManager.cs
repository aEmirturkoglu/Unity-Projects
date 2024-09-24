using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    void Awake()
    {
        Instance = this;
    }

    public int kalanCan;
    public TMP_Text canMetni;

    public int para;
    public TMP_Text paraMetni;

    public GameObject kaybetmeEkrani;

    void Start()
    {
        CaniGuncelle();
        ParayiGuncelle();
    }

    #region Guncelleme Islemleri
    public void CaniGuncelle()
    {
        canMetni.text = kalanCan.ToString();
    }
    public void ParayiGuncelle()
    {
        paraMetni.text = para.ToString();
    }
    #endregion

    public void CaniAzalt()
    {
        kalanCan -= 1;
        CaniGuncelle();
        if (kalanCan <= 0)
        {
            // Kaybet
            kaybetmeEkrani.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ParaKazan(int kazanilacakPara)
    {
        para += kazanilacakPara;
        ParayiGuncelle();
    }

    public void ParaHarca(int harcanilacakPara)
    {
        if (para >= harcanilacakPara)
        {
            // Satýn alabilir
            para -= harcanilacakPara;
            ParayiGuncelle();
        }
        else
        {
            // parasý yok
            Debug.Log("parasý yok");
        }
    }

    public bool ParamYetiyomu(int fiyat)
    {
        return (para >= fiyat);
    }
}
