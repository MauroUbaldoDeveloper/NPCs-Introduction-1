using UnityEngine;

public class User_Trigger_System : MonoBehaviour
{

    private User_Interaction _User_Interaction_Script;

    private void Start()
    {
        _User_Interaction_Script = GetComponent<User_Interaction>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
            _User_Interaction_Script._Is_In_Interaction_Area = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
            _User_Interaction_Script._Is_In_Interaction_Area = false;
    }

}
