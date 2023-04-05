using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//視線の表示非表示の切り替え
//作成中視線を取得できているか確認するために使用。実験中影響が出ない様非表示にしている
public class gazeposition_image_manager : MonoBehaviour
{
    //視線表示の管理

    
    [SerializeField] GetGazePosition gaze_c;    //クラス取得
    [SerializeField] GameObject gaze_object;    //現在の視線位置を可視化するオブジェクト
    RectTransform gaze_position;    //視線の位置変数
    // Start is called before the first frame update
    void Start()
    {
        gaze_position = gaze_object.GetComponent<RectTransform>();  //オブジェクトの位置を取得
        GazeImage_hide();

    }

    // Update is called once per frame
    void Update()
    {
        gaze_position.position = gaze_c.View_Position();    //現在の視線の位置を可視化オブジェクトに代入
    }

    //オブジェクトの表示
    public void GazeImage_show()
    {
        gaze_object.SetActive(true);

    }

    //オブジェクトの非表示
    public void GazeImage_hide()
    {
        gaze_object.SetActive(false);
    }
}
