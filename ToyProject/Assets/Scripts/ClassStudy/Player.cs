using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Player : MonoBehaviour
    {
        //  게임이 시작된 후 한번만 실행된다.
        // Start is called before the first frame update

        public int gauge = 0;

        void Start()
        {
            Debug.Log("저의 이름은 Player입니다.");

            //  플레이어의 위치 X : 3.4으로 이동한다.
            // 너의 Transform의 Position의 X를 3.4로 바꿔라
            // 1. 위치를 이동
            transform.position = new Vector3(3, 17, -12);

            // 2. 회전
            transform.Rotate(new Vector3(0, 0, 0));

            // 3. 크기 변경
            transform.localScale = new Vector3(1, 1, 1);

            //transform.position.X = 3.4;
           
        }

        //  반복되는 로직을 처리할 수 있다.
        //  Frame : 1초에 60Frame FPS : Frame Per Second
        //  1Frame을 생성할 때 update가 한번 실행된다.
        // Update is called once per frame
        void Update()
        {
            //  플레이어의 입력을 구현해보자!
            //  키보드 입력.

            if(Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("D키를 입력했습니다."); // 앞으로 움직인다.



            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                Debug.Log("D키를 뗏습니다.");
                gauge = 0;
                //  gauge 수치 만큼 특정 기능을 실행한다.
            }

            if (Input.GetKey(KeyCode.D))
            {
                gauge = gauge + 1;

                Debug.Log($"현재 게이지 : {gauge}");

                
            }

            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("점프를 했습니다.");
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("A키를 눌렀습니다.");
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                Debug.Log("A키를 뗏습니다.");
            }
                //  마우스 입력.
                if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("마우스 왼쪽 클릭을 했습니다.");
            }

            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("마우스 오른쪽 클릭을 했습니다.");
            }

            if (Input.GetMouseButtonDown(2))
            {
                Debug.Log("마우스 휠클릭을 했습니다.");
            }
        }
    }
}