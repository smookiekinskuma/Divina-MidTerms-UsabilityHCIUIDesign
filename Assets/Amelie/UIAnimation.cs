using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIAnimation : MonoBehaviour
{
    public GameObject Amelie, AmelieFear, AmelieShock, AmelieDizzy, AmelieHappy;

    public TextMeshProUGUI AmelieChat;
    public string Chat_Update;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AmelieChat.text = Chat_Update;
    }

    public void SwingUp()
    {
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(false);
        AmelieHappy.SetActive(true);
        Chat_Update = "You're swinging me!";
    }

    public void FlyDown()
    {
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(false);
        AmelieHappy.SetActive(true);
        Chat_Update = "HIIII!";
    }

    public void HorizontalFlip()
    {
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(true);
        AmelieHappy.SetActive(false);
        Chat_Update = "Woah...";
    }

    public void VerticalFlip()
    {
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(true);
        AmelieHappy.SetActive(false);
        Chat_Update = "Ok, this is actually dizzy...";
    }

    public void Fade()
    {
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(true);
        AmelieDizzy.SetActive(false);
        AmelieHappy.SetActive(false);
        Chat_Update = "H-HEY!";
    }

    public void Scale()
    {
        AmelieFear.SetActive(true);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(false);
        AmelieHappy.SetActive(false);
        Chat_Update = "WHAT ARE YOU DOING!";
    }
}
