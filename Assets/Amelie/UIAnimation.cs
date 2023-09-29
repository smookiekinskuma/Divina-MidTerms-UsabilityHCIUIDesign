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

    //Default Location
    public Vector3 defaultPlace;
    public float speed, solid, size;

    //Scale, Up and Down
    public Vector3 TargetPosScale, TargetPosDown, TargetPosUp;
    public float travelTimeScale, travelTimeDown, travelTimeUp;

    //Left and Right
    public Vector3 TargetPosLeft, TargetPosRight;
    public float travelTimeLeft, travelTimeRight;
    public float SlideTo, SlideDuration;

    //Fade
    public Image Amelie_Shock_Sprite, Amelie_Shock_Sprite2;
    public float FadeTo, FadeDuration;
    public Image Amelie_Dizzy_Sprite, Amelie_Dizzy_Sprite2;
    


    // Start is called before the first frame update
    void Start()
    {
        DefaultAmelie();
    }

    // Update is called once per frame
    void Update()
    {
        AmelieChat.text = Chat_Update;
    }

    public void FlyUp()
    {
        DefaultAmelie();
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(false);
        AmelieHappy.SetActive(true);
        Chat_Update = "GOING UP!";
        Amelie.transform.DOMove(TargetPosUp, travelTimeUp).SetEase(Ease.InOutBounce);
    }

    public void FlyDown()
    {
        DefaultAmelie();
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(false);
        AmelieHappy.SetActive(true);
        Chat_Update = "GOING DOWN!";
        Amelie.transform.DOMove(TargetPosDown, travelTimeDown).SetEase(Ease.InOutBack);
    }

    public void SlideLeft()
    {
        DefaultAmelie();
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(true);
        AmelieHappy.SetActive(false);
        Chat_Update = "Hey, slow down";
        Amelie.transform.DOMove(TargetPosLeft, travelTimeLeft);
        Amelie_Dizzy_Sprite.DOFade(SlideTo, SlideDuration);
        Amelie_Dizzy_Sprite2.DOFade(SlideTo, SlideDuration);
    }

    public void SlideRight()
    {
        DefaultAmelie();
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(true);
        AmelieHappy.SetActive(false);
        Chat_Update = "Ok, this is actually dizzy...";
        Amelie.transform.DOMove(TargetPosRight, travelTimeRight);
        Amelie_Dizzy_Sprite.DOFade(SlideTo, SlideDuration);
        Amelie_Dizzy_Sprite2.DOFade(SlideTo, SlideDuration);
    }

    public void Fade()
    {
        DefaultAmelie();
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(true);
        AmelieDizzy.SetActive(false);
        AmelieHappy.SetActive(false);
        Chat_Update = "H-HEY!";
        Amelie_Shock_Sprite.DOFade(FadeTo, FadeDuration);
        Amelie_Shock_Sprite2.DOFade(FadeTo, FadeDuration);
    }

    public void Scale()
    {
        DefaultAmelie();
        AmelieFear.SetActive(true);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(false);
        AmelieHappy.SetActive(false);
        Chat_Update = "WHAT ARE YOU DOING!";
        Amelie.transform.DOScale(TargetPosScale, travelTimeScale);
    }

    public void DefaultAmelie()
    {
        AmelieFear.SetActive(false);
        AmelieShock.SetActive(false);
        AmelieDizzy.SetActive(false);
        AmelieHappy.SetActive(true);
        Amelie.transform.DOMove(defaultPlace, speed);
        Amelie_Dizzy_Sprite.DOFade(solid, speed);
        Amelie_Dizzy_Sprite2.DOFade(solid, speed);
        Amelie_Shock_Sprite.DOFade(solid, speed);
        Amelie_Shock_Sprite2.DOFade(solid, speed);
        Amelie.transform.DOScale(size, speed);
    }
}
