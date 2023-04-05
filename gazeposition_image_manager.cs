using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�����̕\����\���̐؂�ւ�
//�쐬���������擾�ł��Ă��邩�m�F���邽�߂Ɏg�p�B�������e�����o�Ȃ��l��\���ɂ��Ă���
public class gazeposition_image_manager : MonoBehaviour
{
    //�����\���̊Ǘ�

    
    [SerializeField] GetGazePosition gaze_c;    //�N���X�擾
    [SerializeField] GameObject gaze_object;    //���݂̎����ʒu����������I�u�W�F�N�g
    RectTransform gaze_position;    //�����̈ʒu�ϐ�
    // Start is called before the first frame update
    void Start()
    {
        gaze_position = gaze_object.GetComponent<RectTransform>();  //�I�u�W�F�N�g�̈ʒu���擾
        GazeImage_hide();

    }

    // Update is called once per frame
    void Update()
    {
        gaze_position.position = gaze_c.View_Position();    //���݂̎����̈ʒu�������I�u�W�F�N�g�ɑ��
    }

    //�I�u�W�F�N�g�̕\��
    public void GazeImage_show()
    {
        gaze_object.SetActive(true);

    }

    //�I�u�W�F�N�g�̔�\��
    public void GazeImage_hide()
    {
        gaze_object.SetActive(false);
    }
}
