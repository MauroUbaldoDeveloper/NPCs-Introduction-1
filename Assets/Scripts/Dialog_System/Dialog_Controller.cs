using UnityEngine;
using UnityEngine.UI;

public class Dialog_Controller : MonoBehaviour
{

    public Text _Dialog_Text;
    public Text _Dialog_Name;

    public Dialog_Box _Dialog_Box_Script;
    public NPC_Task _NPC_Task_Script;

    public int _User_Speech_Counter;
    public int _NPC_Speech_Counter;

    private int _User_ID;
    private int _NPC_ID;
    private int _Speeching_ID;

    private float _Time_For_Close_Box;

    private string _Name;
    private string _User_Name;
    private string _NPC_Name;
    private string[] _User_Speechs = new string[5];
    private string[] _NPC_Speechs = new string[4];

    private void Start()
    {
        _User_ID = 1;
        _NPC_ID = 2;
        _Speeching_ID = _User_ID;
        _Time_For_Close_Box = 5;

        _NPC_Name = "NPC:";
        _User_Name = "User:";

        _User_Speechs[0] = "Hello !!!";
        _User_Speechs[1] = "How are you?";
        _User_Speechs[2] = "I am fine, thanks for to ask.";
        _User_Speechs[3] = "What do I do?";
        _User_Speechs[4] = "Okay.";

        _NPC_Speechs[0] = "Hello Friend !!!";
        _NPC_Speechs[1] = "I am fine, and you?";
        _NPC_Speechs[2] = "Can you help-me?";
        _NPC_Speechs[3] = "Please press the key F.";
    }

    // Called in User_Interaction class for start dialog.

    public void Start_Dialog()
    {
        _Name = _User_Name;
        Dialog(_User_Speechs, _User_Speech_Counter);
    }

    void Dialog(string[] _Speechs, int _Speech_Counter)
    {
        _Dialog_Box_Script.Open_Dialog_Box();

        if (_Speech_Counter < _Speechs.Length)
        {
            _Dialog_Name.text = _Name;
            _Dialog_Text.text = _Speechs[_Speech_Counter];
            _Speech_Counter++;
            Set_Speech_Value(_Speech_Counter);
            Invoke("Close_Dialog_Box", _Time_For_Close_Box);
        }
    }

    void Set_Speech_Value(int _Speechs)
    {
        if (_Speeching_ID == _User_ID)
            _User_Speech_Counter = _Speechs;
        else
            _NPC_Speech_Counter = _Speechs;
    }

    void Close_Dialog_Box()
    {
        _Dialog_Box_Script.Close_Dialog_Box();
        Prepare_Next_Dialog_Or_Finish_Interaction();
    }

    void Prepare_Next_Dialog_Or_Finish_Interaction()
    {
        if (_NPC_Speech_Counter < _NPC_Speechs.Length)
            Invoke("Change_Infos_And_Start_New_Dialog", 2);
        else
            _NPC_Task_Script.Give_The_Task_And_Enable_Scripts();
    }

    void Change_Infos_And_Start_New_Dialog()
    {
        string[] _Speechs;
        int _Speech_Counter;

        if (_Speeching_ID == _User_ID)
        {
            _Speeching_ID = _NPC_ID;
            _Name = _NPC_Name;
            _Speechs = _NPC_Speechs;
            _Speech_Counter = _NPC_Speech_Counter;
        }
        else
        {
            _Speeching_ID = _User_ID;
            _Name = _User_Name;
            _Speechs = _User_Speechs;
            _Speech_Counter = _User_Speech_Counter;
        }

        Dialog(_Speechs, _Speech_Counter);
    }

}