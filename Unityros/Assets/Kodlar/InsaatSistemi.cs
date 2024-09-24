using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsaatSistemi : MonoBehaviour
{
    public GameObject taretPrefabi;
    public Camera mainCamera;
    public LayerMask insaatNoktalari;
    public LayerMask taretLayeri;

    public int taretFiyati = 75;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // 0 1920
            // 0 1080
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit, Mathf.Infinity, insaatNoktalari))
            {
                if (hit.collider != null)
                {
                    // Taret kurmadan önce zaten var mý kontrol et.
                    if (GameManager.Instance.ParamYetiyomu(taretFiyati))
                    {
                        GameManager.Instance.ParaHarca(taretFiyati);
                        if (!Physics.CheckSphere(hit.collider.transform.position, 0.1f, taretLayeri))
                        {
                            Instantiate(taretPrefabi, hit.collider.transform);
                        }
                        else
                        {
                            Debug.Log("lan mal orda zaten taret var");
                        }
                    }
                    else
                    {
                        Debug.Log("paran yetmiyo ki...");
                    }
                }
            }
        }
    }
}
