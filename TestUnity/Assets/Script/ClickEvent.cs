using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour{
    public GameObject btn1;
    public GameObject btn2;

    // 21-05-28 박성수
    // 1번 버트 클릭할때
    // 2번 버튼 활성화, 1번버튼 비활성화
    public void OnClickButton1()
    {
        btn2.GetComponent<Button>().interactable = true;
        btn1.GetComponent<Button>().interactable = false;

        btn2.GetComponent<Image>().color= Color.red;
        btn1.GetComponent<Image>().color = Color.white;
    }



    // 21-05-28 박성수
    // 2번 버트 클릭할때
    // 1번 버튼 활성화, 2번버튼 비활성화

    public void OnClickButton2()
    {
        btn1.GetComponent<Button>().interactable = true;
        btn2.GetComponent<Button>().interactable = false;

        btn1.GetComponent<Image>().color = Color.red;
        btn2.GetComponent<Image>().color = Color.white;
    }

}
