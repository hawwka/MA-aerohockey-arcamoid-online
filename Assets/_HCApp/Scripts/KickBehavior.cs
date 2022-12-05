using UnityEngine;

public class KickBehavior : MonoBehaviour
{

    // [HCFunction(nameof(Kick))] public HCFunction KickSubscribe = new HCFunction();
    public GameObject Ball;
    public float MaxForce = 10f;
    public float MinForce = 5f;
    public float MaxRadius = 2f;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // [ActionFunction]
    // public void Kick(EventParams p)
    // {
    //     if (Ball == null)
    //     {
    //         return;
    //     }
    //     
    //     var touchPos = p.GetPosition();
    //     var touchPosToVector2 = new Vector2(touchPos.x, touchPos.z);
    //     var ballPos = new Vector2(Ball.transform.position.x, Ball.transform.position.z);
    //
    //     var distance = Vector2.Distance(touchPosToVector2, ballPos);
    //     
    //     if (distance < MaxRadius)
    //     {
    //         var dir = ballPos - touchPosToVector2;
    //         var force = dir.normalized * Mathf.Lerp(MaxForce, MinForce, MaxRadius);
    //         
    //         Ball.GetComponent<Rigidbody>().AddForce(new Vector3(force.x, 0f, force.y), ForceMode.Impulse);
    //     }
    //     
    //     
    // }
}
