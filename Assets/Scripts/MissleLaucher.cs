using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // �̻��� ������
    public GameObject missilePrefab;

    // �̻����� �߻�Ǵ� ������ �ӵ�
    public float launchSpeed = 67.0f;

    // Update is called once per frame
    void Update()
    {
        // �÷��̾ Fire1 ��ư�� ���������� üũ
        if (Input.GetButtonDown("Fire1"))
        {
            // ���������κ��� ���ο� �̻��� ���� ������Ʈ ����
            GameObject missile = Instantiate(missilePrefab, transform.position, transform.rotation);

            // �̻��Ϸκ��� ������ٵ� 2D ������Ʈ ������
            Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();

            // �̻����� �������� �߻�
            rb.AddForce(transform.up * launchSpeed, ForceMode2D.Impulse);
        }
    }
}