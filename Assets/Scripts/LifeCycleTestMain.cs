using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testClass
{
    public string value = "This is Non-Mono Class";
}

public class testClassMono : MonoBehaviour
{
    public string value = "This is Mono Class";
}

[System.Serializable]
public class testClassSerializable
{
    public string value = "This is Serializable Class";
}

public struct testStruct
{
    string value;
    // string value = "This is Struct";
}

[System.Serializable]
public struct testStructSerializable
{
    string value;
}

public enum FunctionName
{
    Awake,
    OnEnable,
    Reset,
    Start,
    FixedUpdate,
    OnTriggerEnter,
    OnCollisionEnter,

    OnMouseEnter,
    OnMouseExit,
    OnMouseDrag,
    OnMouseDown,
    OnMouseUp,
    OnMouseOver,

    Update,
    LateUpdate,
    
    OnGUI,
    OnApplicationPause,
    OnApplicationQuit,

    OnDisable,
    OnDestory,
}

[RequireComponent(typeof(BoxCollider))]
public class LifeCycleTestMain : MonoBehaviour
{
    [SerializeField] FunctionName currentFunction;
    public FunctionName CurrentFunction
    {
        get{return currentFunction;}
        set
        {
            Debug.LogFormat("Function moved from {0} to {1}.", currentFunction, value); 
            currentFunction = value;
        }
    }

    [Space(10)]
    [Header("Native Value Types")]
    public int PubInt;
    private int PriInt;
    [SerializeField] private int PriSerializedInt;
    
    [Space(10)]
    [Header("Classes")]
    public testClassSerializable PubSerializableClass;
    private testClassSerializable PriSerializableClass;
    [SerializeField] private testClassSerializable PriSerializedClass;

    [Space(10)]
    public testClass PubClass;
    private testClass PriClass;


    [Space(10)]
    public testClassMono PubMono;
    private testClassMono PriMono;
    [SerializeField] private testClassMono PriSerializedMono;
    [Space(20f)]


    [Space(10)]
    [Header("Structs")]
    public testStruct PubStruct;
    private testStruct PriStruct;

    
    [Space(10)]
    [Header("Components")]
    public Collider PubCollider;
    private Collider PriCollider;

    public AnimationCurve curve;
    

    [Space(20)]
    public bool LogUpdates;

    void Awake()
    {
        CurrentFunction = FunctionName.Awake;
        
        PubCollider = GetComponent<BoxCollider>();
        PriCollider = GetComponent<BoxCollider>();

        PubMono = gameObject.AddComponent<testClassMono>();
        PriMono = gameObject.AddComponent<testClassMono>();

        // Do Not Use these constructor. Unity will hate you
        // PubMono = new testClassMono();
        // PriMono = new testClassMono();

        curve = new AnimationCurve(new Keyframe(0, 1), new Keyframe(0.4f, 0.4f, -1.8f, -1.2f), new Keyframe(1, 0));
    }

    void OnEnable()
    {
        CurrentFunction = FunctionName.OnEnable;
    }

    void Reset()
    {
        CurrentFunction = FunctionName.Reset;
    }

    void Start()
    {
        CurrentFunction = FunctionName.Start;
    }

    void FixedUpdate()
    {
        if (LogUpdates)
        {
            CurrentFunction = FunctionName.FixedUpdate;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " triggerenter " + other.gameObject.name);
        CurrentFunction = FunctionName.OnTriggerEnter;
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(gameObject.name + " collisionenter " + other.gameObject.name);
        CurrentFunction = FunctionName.OnCollisionEnter;
    }

    void Update()
    {
        if (LogUpdates)
        {
            Debug.Log(Time.frameCount + " Frame");
            
            CurrentFunction = FunctionName.Update;
        }
        
    }

    void LateUpdate()
    {
        if (LogUpdates)
        {
            CurrentFunction = FunctionName.LateUpdate;
        }

    }

    // void OnGUI()
    // {
    //     CurrentFunction = FunctionName.OnGUI;

    // }

    void OnMouseEnter()
    {
        CurrentFunction = FunctionName.OnMouseEnter;
    }

    void OnMouseExit()
    {
        CurrentFunction = FunctionName.OnMouseExit;
        
    }
    
    void OnMouseDown()
    {
        CurrentFunction = FunctionName.OnMouseDown;

    }
    
    public Plane plane;
    void OnMouseDrag()
    {
        CurrentFunction = FunctionName.OnMouseDrag;
    }
    
    void OnMouseOver()
    {
        CurrentFunction = FunctionName.OnMouseOver;

    }
    
    void OnMouseUp()
    {
        CurrentFunction = FunctionName.OnMouseUp;

    }
    
    void OnApplicationPause()
    {
        CurrentFunction = FunctionName.OnApplicationPause;

    }

    void OnApplicationQuit()
    {
        CurrentFunction = FunctionName.OnApplicationQuit;

    }

    void OnDisable()
    {
        CurrentFunction = FunctionName.OnDisable;

    }

    void OnDestory()
    {
        CurrentFunction = FunctionName.OnDestory;
    }
}

