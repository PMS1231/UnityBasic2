using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    //이미지
    [SerializeField] Image img_BG;
    [SerializeField] Image[] img_Character;

    //텍스트
    [SerializeField] TextMeshProUGUI txt_Name;
    [SerializeField] TextMeshProUGUI txt_School;
    [SerializeField] TextMeshProUGUI txt_Dialogue;

    int id = 1;

    private void Start()
    {
        UpdateDialogue();
    }

    public void UpdateCharacterHighlight(int speakingIndex)
    {
        for (int i = 0; i < img_Character.Length; i++)
        {
            if (i == speakingIndex)
            {
                // 말하는 캐릭터는 원래 색
                img_Character[i].color = Color.white; 
            }
            else
            {
                // RGB 170, 170, 170 값 수정 
                img_Character[i].color = new Color(0.6667f, 0.6667f, 0.6667f, 1f);
            }
        }
    }

    public void OnClickNextDialogue()
    {
        id++;
        UpdateDialogue();
    }

    public void UpdateDialogue()
    {
        int characterID = SData.GetDialogueData(id).Character_ID;

        txt_Name.text = SData.GetCharacterData(characterID).Name;
        txt_School.text = SData.GetCharacterData(characterID).School;
        txt_Dialogue.text = SData.GetDialogueData(id).Dialogue;

        img_BG.sprite = Resources.Load<Sprite>("Img/BG/" + SData.GetDialogueData(id).BG); 

        for (int i = 0; i < img_Character.Length; i++)
        {
            if (i==SData.GetDialogueData(id).Position)
            {
                img_Character[i].sprite = Resources.Load<Sprite>("Img/Character/" + SData.GetCharacterData(characterID).Image);
                img_Character[i].SetNativeSize();
                img_Character[i].gameObject.SetActive(true);
            }
            else
            {
                img_Character[i].gameObject.SetActive(false);
            }
        }
    }
}
