using UnityEngine;
using System.Collections;

public class BillboardedSprite : MonoBehaviour
{
    public Camera m_Camera;

    private void Start()
    {
        if(m_Camera == null) m_Camera = GameObject.FindObjectOfType<Camera>();
    }

    void Update()
    {
        //transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
        //    m_Camera.transform.rotation * Vector3.up);
		transform.LookAt(m_Camera.transform);
    }
}
