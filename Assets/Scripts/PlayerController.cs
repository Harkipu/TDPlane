using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public InputHandler inputHandler;

    private Moveable moveable;
    // Start is called before the first frame update
    void Awake()
    {
        moveable = GetComponent<Moveable>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSetDirect(Vector2 direction)
    {
        Debug.Log("OnSetDirect");
        moveable.setDirection(direction);
    }

    private void OnEnable()
    {
        inputHandler.OnSetDirectionAction += OnSetDirect;
    }

    private void OnDisable()
    {
        inputHandler.OnSetDirectionAction -= OnSetDirect;
    }
}
