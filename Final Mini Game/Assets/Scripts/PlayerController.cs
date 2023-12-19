using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public AudioClip coinSound;
    public AudioClip zombieSound;

    private float _horizontalInput;
    private float _forwardInput;
    private Rigidbody _playerRb;
    private AudioSource _playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = Getcomponent<Rigidbody>();
        _player Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_gameManager.IsGameActive)
        {
        _horizontalInput = Input.GetAxis("Horizontal");
        _fprwardInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(_horizontalInput, 0f, _forwardInput);
        _playerRb.Addforce(moveDirection * speed);
        }
    }

    void OnTriggerEnter( Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            _playerAudio.PlayOnceShot(coinSound, 1f);
            GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().SpawnCollectibleObject();

        }

    }
    
    void OnCollisionEnter(Collision other)
    {
         if(other.gameObject.CompareTag("Zombie"))
         {
            _playerAudio.PlayOneShot(zombieSound, 1f);
         }
    }
}
