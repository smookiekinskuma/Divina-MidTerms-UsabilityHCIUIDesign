using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.UI;

public class UIAnimation : MonoBehaviour
{
    //UI
    public GameObject Amelie, AmelieFear, AmelieShock, AmelieDizzy, AmelieHappy;
    public TextMeshProUGUI AmelieChat;
    public string Chat_Update;

    //Timer
    public float timer;

    //Default Location
    public Vector3 defaultPlace;
    public float solid, size;
    public bool defaultAmelie;

    //Scale, Up and Down
    public Vector3 TargetPosScale, TargetPosDown, TargetPosUp, TargetPosLeft, TargetPosRight;

    //Fade
    public Image Amelie_Shock_Sprite, Amelie_Shock_Sprite2;
    public Image Amelie_Dizzy_Sprite, Amelie_Dizzy_Sprite2;
    public float FadeTo;

    // Start is called before the first frame update
    void Start()
    {
        DefaultAmelie();
        defaultAmelie = true;
    }

    // Update is called once per frame
    void Update()
    {
        AmelieChat.text = Chat_Update;
    }

    //Amelie goes up
    public void FlyUp()
    {
        if (defaultAmelie == true)
        {
            AmelieFear.SetActive(false);
            AmelieShock.SetActive(false);
            AmelieDizzy.SetActive(false);
            AmelieHappy.SetActive(true);
            Chat_Update = "GOING UP!";
            Amelie.transform.DOMove(TargetPosUp, timer).SetEase(Ease.InOutBack);
            defaultAmelie = false;
        } else if (defaultAmelie == false)
        {
            DefaultAmelie();
            defaultAmelie = true;
        }      
    }

    //Amelie goes down
    public void FlyDown()
    {
        if (defaultAmelie == true)
        {
            AmelieFear.SetActive(false);
            AmelieShock.SetActive(false);
            AmelieDizzy.SetActive(false);
            AmelieHappy.SetActive(true);
            Chat_Update = "GOING DOWN!";
            Amelie.transform.DOMove(TargetPosDown, timer).SetEase(Ease.InOutBack);
            defaultAmelie = false;
        } else if (defaultAmelie == false)
        {
            DefaultAmelie();
            defaultAmelie = true;
        }
    }

    //Amelie gots to the left
    public void SlideLeft()
    {
        if (defaultAmelie == true)
        {
            AmelieFear.SetActive(false);
            AmelieShock.SetActive(false);
            AmelieDizzy.SetActive(true);
            AmelieHappy.SetActive(false);
            Chat_Update = "Hey, slow down";
            Amelie.transform.DOMove(TargetPosLeft, timer).SetEase(Ease.InOutBack);
            defaultAmelie = false;
        } else if (defaultAmelie == false)
        {
            DefaultAmelie();
            defaultAmelie = true;
        }
    }

    //Amelie goes to the right
    public void SlideRight()
    {
        if (defaultAmelie == true)
        {
            AmelieFear.SetActive(false);
            AmelieShock.SetActive(false);
            AmelieDizzy.SetActive(true);
            AmelieHappy.SetActive(false) ;
            Chat_Update = "Ok, this is actually dizzy...";
            Amelie.transform.DOMove(TargetPosRight, timer).SetEase(Ease.InOutBack);
            defaultAmelie = false;
        } else if (defaultAmelie == false)
        {
            DefaultAmelie();
            defaultAmelie = true;
        }
    }

    //Amelie disappears into the unknown
    public void Fade()
    {
        if (defaultAmelie == true)
        {
            AmelieFear.SetActive(false);
            AmelieShock.SetActive(true);
            AmelieDizzy.SetActive(false);
            AmelieHappy.SetActive(false);
            Chat_Update = "H-HEY!";
            Amelie_Shock_Sprite.DOFade(FadeTo, timer);
            Amelie_Shock_Sprite2.DOFade(FadeTo, timer);
            defaultAmelie = false;
        } else if (defaultAmelie == false)
        {
            DefaultAmelie();
            defaultAmelie = true;
        }
    }

    //Amelie gets consumed by the void
    public void Scale()
    {
        if (defaultAmelie == true)
        {
            AmelieFear.SetActive(true);
            AmelieShock.SetActive(false);
            AmelieDizzy.SetActive(false);
            AmelieHappy.SetActive(true);
            Chat_Update = "WHAT ARE YOU DOING!";
            Amelie.transform.DOScale(TargetPosScale, timer);
            defaultAmelie = false;
        } else if (defaultAmelie == false)
        {
            DefaultAmelie();
            defaultAmelie = true;
        }
    }

    public void DefaultAmelie()
    {
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(false);
        AmelieHappy.SetActive(true);
        Amelie.transform.DOMove(defaultPlace, timer).SetEase(Ease.InOutBack);
        Amelie_Dizzy_Sprite.DOFade(solid, timer);
        Amelie_Dizzy_Sprite2.DOFade(solid, timer);
        Amelie_Shock_Sprite.DOFade(solid, timer);
        Amelie_Shock_Sprite2.DOFade(solid, timer);
        Amelie.transform.DOScale(size, timer);
    }
}
