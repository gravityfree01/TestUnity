using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour{
    public GameObject btn1;
    public GameObject btn2;

    // 21-05-29 총알 생성 박성수 작성
    public GameObject bulletsStorage;
    public GameObject bullets;
    private GameObject obj=null;


    // 21-05-29 PAUSE 버튼 생성 박성수 작성
    enum Direction { LEFT, RIGHT, PAUSE};
    Direction dir = Direction.RIGHT;

    public float speed = 3f;
        
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
            obj = GameObject.Find("Charater").gameObject;
            return true;
        }
        return false;

    }


    // 21-05-29 SpriteRenderer 사용하여 캐릭터라 좌우로 방향을 바꾸가며 이동하기
    // 21-05-29 speed * Time.fixedDeltaTime 추가 박성수 (핸드폰에 포딩했을시 시간차를 맞출수 있는 함수)
    // float speed 값을 올려줘야함.(조절해서 확인할것)
    private void Update()
    {
        if (dir == Direction.RIGHT)
        {
            //obj.transform.position += new Vector3(speed * Time.fixedDeltaTime, 0, 0);
            obj.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if(dir == Direction.LEFT)
        {
            //obj.transform.position -= new Vector3(speed * Time.fixedDeltaTime, 0, 0);
            obj.GetComponent<SpriteRenderer>().flipX = true;
        }
        
    }



    // 21-05-28 박성수
    // 1번 버트 클릭할때
    // 2번 버튼 활성화, 1번버튼 비활성화
    public void OnClickButton1()
    {
        /*
        btn2.GetComponent<Button>().interactable = true;
        btn1.GetComponent<Button>().interactable = false;
        btn2.GetComponent<Image>().color= Color.red;
        btn1.GetComponent<Image>().color = Color.white;
        


        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(true);

        // 21-05-29 박성수 작성
        if (!obj.gameObject.activeSelf) return;
        obj.gameObject.SetActive(false);
        */

        // 오른쪽으로 이동

        //obj.transform.position += new Vector3(0.2f,0,0);

        dir = Direction.RIGHT;

    }




    // 21-05-28 박성수
    // 2번 버트 클릭할때
    // 1번 버튼 활성화, 2번버튼 비활성화

    public void OnClickButton2()
    {
        /*
        btn1.GetComponent<Button>().interactable = true;
        btn2.GetComponent<Button>().interactable = false;
        btn1.GetComponent<Image>().color = Color.red;
        btn2.GetComponent<Image>().color = Color.white;

        btn2.gameObject.SetActive(false);
        btn1.gameObject.SetActive(true);

        // 21-05-29 박성수 작성
        if (obj.gameObject.activeSelf) return;
        obj.gameObject.SetActive(true);
        */

        // 왼쪽으로 이동

        //obj.transform.position -= new Vector3(0.15f, 0, 0);
        dir = Direction.LEFT;

    }


    // 21-05-29 PAUSE 버튼 생성 박성수 작성
    public void Pause()
    {
        /*
        btn1.GetComponent<Button>().interactable = true;
        btn2.GetComponent<Button>().interactable = false;
        btn1.GetComponent<Image>().color = Color.red;
        btn2.GetComponent<Image>().color = Color.white;

        btn2.gameObject.SetActive(false);
        btn1.gameObject.SetActive(true);

        // 21-05-29 박성수 작성
        if (obj.gameObject.activeSelf) return;
        obj.gameObject.SetActive(true);
        */

        // 21-05-29 PAUSE 버튼 생성 박성수 작성

        //dir = Direction.PAUSE;

        Vector3 pos = Vector3.zero;

        if(dir == Direction.RIGHT)
        {
            pos = new Vector3(1.2f, 0, 0);
        }
        else if(dir == Direction.LEFT)
        {
            pos = new Vector3(-1.2f, 0, 0);
        }

       
    // 21-05-30 총알 발사 진행중 미완성 박성수 작성
       GameObject createBullet = Instantiate(bullets, pos, Quaternion.identity, bulletsStorage.transform);
       createBullet.GetComponent<Rigidbody2D>().AddForce(pos*10f, ForceMode2D.Impulse);
    }



}
