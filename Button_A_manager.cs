using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_A_manager : MonoBehaviour
{
    RectTransform canvas_size;  //��ʃT�C�Y
    RectTransform button_size;  //4���̃{�^���T�C�Y
    Image button_image;     //�{�^���̘g�摜
    public Color color;     //�{�^���̘g�̐F
    int color_controller;   //�F�ԍ�

    // Start is called before the first frame update
    void Start()
    {
        
        canvas_size = GameObject.Find("Canvas").GetComponent<RectTransform>();  //��ʃL�����o�X�̎擾
        button_size = GetComponent<RectTransform>();    //�{�^���̈ʒu�Ƒ傫���̎擾
        button_image = GetComponent<Image>();   //�g�̉摜���擾
        Debug.Log("Screen Width : " + canvas_size.sizeDelta.x);
        Debug.Log("Screen  height: " + canvas_size.sizeDelta.y);
        Vector2 button_size_set = new Vector2(canvas_size.sizeDelta.x * 0.48f, canvas_size.sizeDelta.y * 0.48f);    //�{�^���̈ʒu�̕ϐ�
        Vector2 button_anchored_set = new Vector2(0f, 0f);  //��ʏ�̊�̕ϐ�
        button_size.sizeDelta = button_size_set;            //�{�^���̈ʒu��ݒ�
        button_size.anchoredPosition = button_anchored_set; //���ݒ�
        color = new Color(1.0f, 0.0f, 0.0f, 1.0f);  //�{�^���̐F�̐ݒ�
        /*
        // �������̃T�C�Y
        button_size.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width * 0.5f);
        // �c�����̃T�C�Y
        button_size.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.height * 0.5f);
        */
    }

    // Update is called once per frame
    void Update()
    {
        //color = Color.Lerp(Color.blue, Color.cyan, Mathf.PingPong(Time.time, 1));
        color = Color.blue;
        
        //colorful_button();

        button_image.color = color;
        /*
        button_size.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Screen.width * 0.5f);
        // �c�����̃T�C�Y
        button_size.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Screen.height * 0.5f);
        */
    }

    private void colorful_button()
    {

        if(color_controller < 100)
        {
            color = Color.Lerp(Color.red, Color.green, color_controller * 0.01f);//�ԐF����ΐF�ɕω�������
            color_controller++;
        }
        else if(color_controller < 200)
        {
            color = Color.Lerp(Color.green, Color.blue, (color_controller-100) * 0.01f);//�ΐF����F�ɕω�������
            color_controller++;
        }
        else if(color_controller < 300)
        {
            color = Color.Lerp(Color.blue, Color.red, (color_controller - 200) * 0.01f);//�F����ԐF�ɕω�������
            color_controller++;
        }
        else
        {
            color = Color.red;
            color_controller = 0;
        }


    }


}
