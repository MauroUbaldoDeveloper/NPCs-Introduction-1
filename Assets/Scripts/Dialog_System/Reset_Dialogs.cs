using UnityEngine;

public class Reset_Dialogs : MonoBehaviour
{

    public Dialog_Controller _Dialog_Controller_Script;
    public GameObject _Dialog_Box;

    // Called in User_Interaction class, after the Key F to be pressed.

    public void Reset_Dialog()
    {
        _Dialog_Controller_Script._User_Speech_Counter = 0;
        _Dialog_Controller_Script._NPC_Speech_Counter = 0;
        _Dialog_Controller_Script._Dialog_Text.text = "";
        _Dialog_Controller_Script._Dialog_Name.text = "";
        _Dialog_Box.SetActive(false);
    }

}
