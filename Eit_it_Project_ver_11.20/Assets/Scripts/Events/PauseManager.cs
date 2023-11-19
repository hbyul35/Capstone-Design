using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class PauseManager : MonoBehaviour
{
    [Header("GameMenu")]
    public GameObject targetObject; // �̵��� ��� ������Ʈ
    public Vector3 startPosition;
    public Vector3 endPosition; 
    public float movementSpeed = 10.0f; // �̵� �ӵ�
    private bool isMoving = false;

    [Header("GameTutorials")]
    public ScrollRect gameTutorialsInstance;

    void Start()
    {
        targetObject = GameObject.Find("MenuPanel");
        startPosition = targetObject.transform.position;
        endPosition = startPosition - new Vector3(startPosition.x, 0, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isMoving)
        {
            if (Vector3.Distance(targetObject.transform.position, startPosition) > 0.01f)
            {
                StartCoroutine(MoveToTargetPositionCoroutine(startPosition));
                gameTutorialsInstance.gameObject.SetActive(false);
            }
            else
            {
                StartCoroutine(MoveToTargetPositionCoroutine(endPosition));
            }
        }
    }

    private IEnumerator MoveToTargetPositionCoroutine(Vector3 target)
    {
        isMoving = true;
        while (Vector3.Distance(targetObject.transform.position, target) > 0.01f)
        {
            targetObject.transform.position = Vector3.Lerp(targetObject.transform.position, target, movementSpeed * Time.deltaTime);
            yield return null;
        }

        // ���� ��ġ�� �����ϸ� �ڷ�ƾ ����
        targetObject.transform.position = target;
        isMoving = false;
    }
}
