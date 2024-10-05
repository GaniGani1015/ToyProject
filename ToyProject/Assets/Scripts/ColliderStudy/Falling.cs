using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Falling : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision) // �浹���� ��
        {
            //  Tag�� NonDisable�̸� �浹���� ����. �� �ڵ带 �ۼ����� ������
            if(collision.collider.CompareTag("NonDisable"))
            {
                return;
            }

            //���� �±׸� ������.

            Debug.Log(collision.gameObject.name);   //   �浹�� ������Ʈ�� �̸� ���
            collision.gameObject.SetActive(false);  //  �浹�� ������Ʈ�� ��Ȱ��ȭ

            
        }

        private void OnCollisionExit(Collision collision) // �浹�� ������ ��
        {

        }

        private void OnCollisionStay(Collision collision) // �浹���� ��

        {

        }
    }
}
