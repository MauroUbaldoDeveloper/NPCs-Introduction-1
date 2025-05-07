using UnityEngine;
using UnityEngine.UI;

public class NPC_Task : MonoBehaviour
{

    public bool _Task_Has_Been_Enabled;

    public Text _Task_Text;

    public GameObject _Task_Box;

    public User_Movement _User_Movement_Script;
    public User_Interaction _User_Interaction_Script;

    private string _Task;


    void Start()
    {
        _Task = "Press F for finish the task.";
    }

    // This method is called in class Dialog_Controller

    public void Give_The_Task_And_Enable_Scripts()
    {
        _Task_Has_Been_Enabled = true;
        _Task_Text.text = _Task;
        _Task_Box.SetActive(true);
        Enable_Scripts();
    }

    void Enable_Scripts()
    {
        _User_Movement_Script.enabled = true;
        _User_Interaction_Script.enabled = true;
    }

    // This method is called in class User_Interaction

    public void Reset_Task()
    {
        _Task_Has_Been_Enabled = false;
        _Task_Box.SetActive(false);
    }

}
