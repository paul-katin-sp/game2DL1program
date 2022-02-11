using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameTest1 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake Test 1 *******      ");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable Test 1 *******");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Test 1 *******");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Test 1 *******");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate Test 1 *******");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate Test 1 *******");
    }

    private void OnGUI()
    {
        Debug.Log("OnGUI");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
