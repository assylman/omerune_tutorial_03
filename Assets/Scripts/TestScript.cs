using System.Runtime.CompilerServices;
using OpenCover.Framework.Model;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Floor[] floors;
    public int[] numbers = new int[4] { 1, 2, 3, 4 };
    public float speed = 5f;

    void Start()
    {
        floors = new Floor[5];
        for (int i = 0; i < floors.Length; i++)
        {
            floors[i] = new Floor();
            if (i > 0)
            {
                floors[i].peopleCount = Random.Range(0, 10);
            }

            Debug.Log("Floor: " + i + ", peopleCount: " + floors[i].ToString());
        }

        foreach(Floor floor in floors)
        {
            if (floor.peopleCount > 0)
            {
                Debug.Log("There is a people inside this house");
                break;
            }
        }
    }

    


    void Update()
    {
        // if (Input.GetKey(KeyCode.W))
        //     transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        // else if (Input.GetKey(KeyCode.S))
        //     transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
        // else if (Input.GetKey(KeyCode.A))
        //     transform.position = transform.position + new Vector3(0, 0, speed * Time.deltaTime);
        // else if (Input.GetKey(KeyCode.D))
        //     transform.position = transform.position + new Vector3(0, 0, -speed * Time.deltaTime);

        // var moveHorizontal = Input.GetAxis("Horizontal");
        // var moveVertical = Input.GetAxis("Vertical");
        // var movement = new Vector3(moveHorizontal, 0, moveVertical);
        // transform.position = transform.position + movement * speed * Time.deltaTime;
    }

    // public int variableA;
    // public int variableB;

    private void tutorialInit()
    {
        // var summ = variableA + variableB;
        // Debug.Log("Sum: " + summ);
        // bool isSuccess = true;
        // Debug.Log("isSuccess: " + isSuccess);

        // integers();
        // decimals();
        // characters();

        // object objVar = 'A';
        // Debug.Log("objVar - " + objVar + "; type: " + objVar.GetType());

        // var inferredInt = 100;
        // Debug.Log("inferredInt: " + inferredInt + "; type: " + inferredInt.GetType());
    }

    private void integers()
    {
        byte byteVar = 255;
        Debug.Log("byteVar: " + byteVar);
        sbyte sbyteVar = 127;
        Debug.Log("sbyteVar: " + sbyteVar);
        short shortVar = 32767;
        Debug.Log("shortVar: " + shortVar);
        ushort ushortVar = 65535;
        Debug.Log("ushortVar: " + ushortVar);
        int intVar = 2147483647;
        Debug.Log("intVar: " + intVar);
        uint uintVar = 4294967295;
        Debug.Log("uintVar: " + uintVar);
        long longVar = 9223372036854775807;
        Debug.Log("longVar: " + longVar);
        ulong ulongVar = 18446744073709551615;
        Debug.Log("ulongVar: " + ulongVar);
    }

    private void decimals()
    {
        float floatVar = 3.40f;
        Debug.Log("floatVar: " + floatVar);
        double doubleVar = 1.79769313486232f;
        Debug.Log("doubleVar: " + doubleVar);
        decimal decimalVar = 79228162514264337593543950335M;
        Debug.Log("decimalVar: " + decimalVar);
    }

    private void characters()
    {
        char charVar = 'A';
        Debug.Log("charVar: " + charVar);
        string stringVar = "Hello, World!";
        Debug.Log("stringVar: " + stringVar);
    }
}
