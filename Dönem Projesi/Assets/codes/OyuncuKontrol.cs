using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OyuncuKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public void OyuncuKayit()
    {
        SceneManager.LoadScene("Oyuncu Kayıt");
    }

    public void OyuncuGiris()
    {
        SceneManager.LoadScene("Oyuncu Giris");
    }

}
