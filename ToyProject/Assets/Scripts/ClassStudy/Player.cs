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

        void Start()
        {
            Debug.Log("���� �̸��� Player�Դϴ�.");

            //  �÷��̾��� ��ġ X : 3.4���� �̵��Ѵ�.
            // ���� Transform�� Position�� X�� 3.4�� �ٲ��
            // 1. ��ġ�� �̵�
            transform.position = new Vector3(3, 17, -12);

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
                gauge = gauge + 1;

                Debug.Log($"���� ������ : {gauge}");

                
            }

            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("������ �߽��ϴ�.");
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("AŰ�� �������ϴ�.");
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                Debug.Log("AŰ�� �½��ϴ�.");
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
        }
    }
}