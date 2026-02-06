using UnityEngine;

public class GamePanelController : MonoBehaviour
{


    // 뒤로 가기 버튼 클릭 시
    public void OnClickBackButton()
    {
        GameManager.Instance.ChangeToMainScene();
    }
    
    // 설정 팝업 표시
    public void OnClickSettingsButton()
    {
        GameManager.Instance.OpenSettingsPanel();
    }
}
