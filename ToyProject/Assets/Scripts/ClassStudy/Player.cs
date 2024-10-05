using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Player : MonoBehaviour
    {
        //  ������ ���۵� �� �ѹ��� ����ȴ�.
        // Start is called before the first frame update

        public int gauge = 0;
        public float jumpPower = 250f;
        public float moveSpeedModifier = 3;
        public bool isGrounded;
        public LayerMask ground;

        void Start()
        {
            Debug.Log("���� �̸��� Player�Դϴ�.");

            //  �÷��̾��� ��ġ X : 3.4���� �̵��Ѵ�.
            // ���� Transform�� Position�� X�� 3.4�� �ٲ��
            // 1. ��ġ�� �̵�
            transform.position = new Vector3(3.37f, 17.83f, -12.76936f);

            // 2. ȸ��
            transform.Rotate(new Vector3(0, 0, 0));

            // 3. ũ�� ����
            transform.localScale = new Vector3(1, 1, 1);

            //transform.position.X = 3.4;
           
        }

        //  �ݺ��Ǵ� ������ ó���� �� �ִ�.
        //  Frame : 1�ʿ� 60Frame FPS : Frame Per Second
        //  1Frame�� ������ �� update�� �ѹ� ����ȴ�.
        // Update is called once per frame
        void Update()
        {
            //  �÷��̾��� �Է��� �����غ���!
            //  Ű���� �Է�.

            if(Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("DŰ�� �Է��߽��ϴ�."); // ������ �����δ�.



            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                Debug.Log("DŰ�� �½��ϴ�.");
                gauge = 0;
                //  gauge ��ġ ��ŭ Ư�� ����� �����Ѵ�.
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(moveSpeedModifier, 0, 0) * Time.deltaTime);
                                
            }

            if (Input.GetKeyDown(KeyCode.W) && isGrounded) //  ���� ���� ���� �����ض�.
            {
                Debug.Log("������ �߽��ϴ�.");
                transform.Translate(new Vector3(0, jumpPower, 0) * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(-moveSpeedModifier, 0, 0) * Time.deltaTime);

            }
        
                //  ���콺 �Է�.
                if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("���콺 ���� Ŭ���� �߽��ϴ�.");
            }

            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("���콺 ������ Ŭ���� �߽��ϴ�.");
            }

            if (Input.GetMouseButtonDown(2))
            {
                Debug.Log("���콺 ��Ŭ���� �߽��ϴ�.");
            }

            // transform.Translate(new Vector3(0, -9.8f, 0) * Time.deltaTime);

            //  ���� �÷��̾ ���� ��Ҵ��� �ƴ��� üũ���ִ� �Լ�            
                isGrounded = IsGround();
            
        }

        bool IsGround()
        {
            return Physics.Raycast(transform.position, Vector3.down, 1, ground) ? true : false;
        }

    }
}