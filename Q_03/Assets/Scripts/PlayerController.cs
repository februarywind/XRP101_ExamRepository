using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField]
    [field: Range(0, 100)]
    public int Hp { get; private set; }

    private AudioSource _audio;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _audio = GetComponent<AudioSource>();
    }
    
    public void TakeHit(int damage)
    {
        Hp -= damage;

        if (Hp <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        _audio.Play();
        transform.GetChild(0).gameObject.SetActive(false);
        StartCoroutine(SoundPlayAfter());
    }
    IEnumerator SoundPlayAfter()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }
}
