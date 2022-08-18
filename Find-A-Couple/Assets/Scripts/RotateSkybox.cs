using UnityEngine;

[RequireComponent(typeof(Skybox))]
public class RotateSkybox : MonoBehaviour
{
    public float _speed_rotation;

    private Skybox _skybox;

    private void Start()
    {
        _skybox = GetComponent<Skybox>();
    }

    private void Update()
    {
        _skybox.material.SetFloat("_Rotation", Time.time * _speed_rotation);
    }
}
