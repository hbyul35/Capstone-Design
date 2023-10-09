using UnityEngine;

public enum BodyType
{
    Obese,                                               // ��
    Diabetic,                                            // �索
    Athlete,                                             // � ����
    Underweight,                                         // ��ü��
    Basic                                                // �⺻
}

// �̱��� ����
public class DataMgr : MonoBehaviour
{
    public static DataMgr Instance;
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else if (Instance == null) return;
        DontDestroyOnLoad(gameObject);
    }

    public BodyType currentBody;
}