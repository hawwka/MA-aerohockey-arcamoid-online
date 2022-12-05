using UnityEngine;

public class BlockBehavior : MonoBehaviour
{
    // private BoxCollider boxCollider;
    // private MeshRenderer meshRenderer;
    // public HCEvent OnBlockDestroyed = new HCEvent();
    //
    // [Inject] private IPrefabFactory prefabFactory;
    // public GameObject BoomEffect;
    //
    // private Animator animator;
    // private AudioSource audioSource;
    

    // private void OnEnable()
    // {
    //     meshRenderer = GetComponent<MeshRenderer>();
    //     boxCollider = this.gameObject.GetComponent<BoxCollider>();
    //     animator = GetComponentInChildren<Animator>();
    //     animator.SetTrigger("On");
    //     audioSource = GetComponent<AudioSource>();
    //     boxCollider.enabled = true;
    //     meshRenderer.enabled = true;
    // }
    //
    // private void OnCollisionEnter(Collision other)
    // {
    //     var pos = this.gameObject.transform.position;
    //     prefabFactory.Create(BoomEffect, pos, Quaternion.identity, null);
    //     boxCollider.enabled = false;
    //     meshRenderer.enabled = false;
    //     Destroy(this.gameObject, 2f);
    //     
    //     audioSource.Play();
    //         
    //     
    //     OnBlockDestroyed?.Invoke(null);
    //     animator.SetTrigger("Off");
    // }
}
