using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    private Animator animator;

    protected float runSeconds = 0; //player's running time in seconds

    public CharacterController Controller   
    {
        get { return controller; }  
    }

    public Animator Animator   
    {
        get { return animator; }   
    }

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }  
}
