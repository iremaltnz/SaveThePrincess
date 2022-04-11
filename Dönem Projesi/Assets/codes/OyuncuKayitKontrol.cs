using Assets.codes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class OyuncuKayitKontrol : MonoBehaviour
{
    // Start is called before the first frame update

   public GameObject UserName;
   public  GameObject Password;
    Gamer gamer;
    public void GirisEkrani()
    {
        gamer = new Gamer();
        gamer.UserName = UserName.GetComponent<InputField>().text;
        gamer.Password = Password.GetComponent<InputField>().text;

        Debug.Log(gamer.UserName);
        SceneManager.LoadScene("Oyuncu Giris");
       

    }
}
