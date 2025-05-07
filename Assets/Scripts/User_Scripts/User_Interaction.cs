using UnityEngine;

public class User_Interaction : MonoBehaviour
{

    public bool _Is_In_Interaction_Area;

    public NPC_Task _NPC_Task_Script;
    public Dialog_Controller _Dialog_Controller_Script;
    public Reset_Dialogs _Reset_Dialogs_Script;

    private User_Movement _User_Movement_Script;

    private void Start()
    {
        _User_Movement_Script = GetComponent<User_Movement>();
    }

    void Update()
    {
        Interaction_Input();
    }

    void Interaction_Input()
    {
        if (_Is_In_Interaction_Area == true && _NPC_Task_Script._Task_Has_Been_Enabled == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _Dialog_Controller_Script.Start_Dialog();
                _User_Movement_Script.Stop_Movementation();
                _User_Movement_Script.enabled = false;
                this.enabled = false;
            }
        }

        if (_NPC_Task_Script._Task_Has_Been_Enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                _NPC_Task_Script.Reset_Task();
                _Reset_Dialogs_Script.Reset_Dialog();
            }
        }
    }

}