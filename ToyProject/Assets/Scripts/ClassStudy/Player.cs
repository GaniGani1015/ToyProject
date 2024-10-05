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
        public float jumpPower = 250f;
        public float moveSpeedModifier = 3;
        public bool isGrounded;
        public LayerMask ground;

        void Start()
        {
            Debug.Log("저의 이름은 Player입니다.");

            //  플레이어의 위치 X : 3.4으로 이동한다.
            // 너의 Transform의 Position의 X를 3.4로 바꿔라
            // 1. 위치를 이동
            transform.position = new Vector3(3.37f, 17.83f, -12.76936f);

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
                transform.Translate(new Vector3(moveSpeedModifier, 0, 0) * Time.deltaTime);
                                
            }

            if (Input.GetKeyDown(KeyCode.W) && isGrounded) //  땅에 있을 때만 점프해라.
            {
                Debug.Log("점프를 했습니다.");
                transform.Translate(new Vector3(0, jumpPower, 0) * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(-moveSpeedModifier, 0, 0) * Time.deltaTime);

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

            // transform.Translate(new Vector3(0, -9.8f, 0) * Time.deltaTime);

            //  현재 플레이어가 땅을 밟았는지 아닌지 체크해주는 함수            
                isGrounded = IsGround();
            
        }

        bool IsGround()
        {
            return Physics.Raycast(transform.position, Vector3.down, 1, ground) ? true : false;
        }

    }
}