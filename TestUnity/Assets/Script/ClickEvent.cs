using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour{
    public GameObject btn1;
    public GameObject btn2;

    private GameObject obj=null;


        
    private void Start()
    {
        if(FindObject())
        {
            Debug.Log("Find Object");

        }
        else
        {
            Debug.Log("Not Found");
        }

        
    }


    private bool  FindObject()
    {
        if (obj == null){
            obj = GameObject.Find("Obj").gameObject;
            return true;
        }
        return false;

    }

    // 21-05-28 박성수
    // 1번 버트 클릭할때
    // 2번 버튼 활성화, 1번버튼 비활성화
    public void OnClickButton1()
    {
        btn2.GetComponent<Button>().interactable = true;
        btn1.GetComponent<Button>().interactable = false;
        btn2.GetComponent<Image>().color= Color.red;
        btn1.GetComponent<Image>().color = Color.white;

        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(true);

        // 21-05-29 박성수 작성
        if (!obj.gameObject.activeSelf) return;
        obj.gameObject.SetActive(false);
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

        btn2.gameObject.SetActive(false);
        btn1.gameObject.SetActive(true);

        // 21-05-29 박성수 작성
        if (obj.gameObject.activeSelf) return;
        obj.gameObject.SetActive(true);
    }

}
