using UnityEngine;

public class Dialog_Box : MonoBehaviour
{

    public GameObject _Dialog_Box;

    public void Open_Dialog_Box()
    {
        _Dialog_Box.SetActive(true);
    }

    public void Close_Dialog_Box()
    {
        _Dialog_Box.SetActive(false);
    }

}
