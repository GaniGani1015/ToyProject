using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Falling : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision) // 충돌했을 때
        {
            //  Tag가 NonDisable이면 충돌하지 말라. 이 코드를 작성하지 마세요
            if(collision.collider.CompareTag("NonDisable"))
            {
                return;
            }

            //직접 태그를 만들어보기.

            Debug.Log(collision.gameObject.name);   //   충돌한 오브젝트의 이름 출력
            collision.gameObject.SetActive(false);  //  충돌한 오브젝트를 비활성화

            
        }

        private void OnCollisionExit(Collision collision) // 충돌이 끝났을 때
        {

        }

        private void OnCollisionStay(Collision collision) // 충돌중일 때

        {

        }
    }
}
