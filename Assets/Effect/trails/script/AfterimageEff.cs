using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterimageEff : MonoBehaviour
{
    [SerializeField] private float timeFromStart;
    [SerializeField] private float deltaTimeBtw;
    [SerializeField] private float AfterimageLength;

    private Params parameters;

    public GameObject[] echo;

    // Start is called before the first frame update
    void Start()
    {
        parameters = GetComponent<Params>();
    }

    // Update is called once per frame
    void Update()
    {
        if (parameters.hasInput){
            if (timeFromStart <= 0){
                int rand = Random.Range(0, echo.Length);
                GameObject instance = (GameObject) Instantiate(echo[rand], transform.position, Quaternion.identity);
                Destroy(instance, AfterimageLength);
                timeFromStart = deltaTimeBtw;
            }
            else {
                timeFromStart -= Time.deltaTime;
            }
        }
    
    }
}
