using UnityEngine;

public class InputView : MonoBehaviour
{
    [SerializeField] private bool _anyKey;
    [SerializeField] private bool _anyKeyDown;

    private void Update()
    {
        _anyKey = Input.anyKey;
        _anyKeyDown = Input.anyKeyDown;
    }
}
