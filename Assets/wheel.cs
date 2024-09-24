using TMPro;
using UnityEngine;

public class wheel : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _wheel;
    [SerializeField] private TMP_Text _wheelText;
    [SerializeField] private ParticleSystem _wheelParticleSystem;

    private void Update()
    {
        if(_speed > 0)
        {
            _wheel.transform.Rotate(transform.forward * _speed);
            _speed -= Time.deltaTime;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if(_speed < 0 && other.gameObject.GetComponent<TMP_Text>() != null)
        {
            _wheelText.text = other.gameObject.GetComponent<TMP_Text> ().text;
            _wheelParticleSystem.Play();
        }
    }
}
