using UnityEngine;

public class MoveCubesScript : MonoBehaviour
{
    private GameObject[] cubes = new GameObject[3];
    int selectedCubeIndex = 0;
    private float[] cubesPositions = new float[3] { 2.0f, 0.0f, -2.0f };
    public float speed = 5f;
    private const float maxMovementPosition = 5f;
    private const float minMovementPosition = -5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // textObject.text = "Click on mouse to select next cube";

        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubes[i].transform.position = new Vector3(cubesPositions[i], 0, 0);
        }

        cubes[selectedCubeIndex].GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cubes[selectedCubeIndex].GetComponent<Renderer>().material.color = Color.white;
            if (selectedCubeIndex < cubes.Length - 1)
            {
                selectedCubeIndex++;
            }
            else
            {
                selectedCubeIndex = 0;
            }
            cubes[selectedCubeIndex].GetComponent<Renderer>().material.color = Color.red;
        }

        var moveHorizontal  = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHorizontal, 0, moveVertical);

        var newPosition = cubes[selectedCubeIndex].transform.position + movement * speed * Time.deltaTime;
        if (newPosition.x > maxMovementPosition)
        {
            newPosition.x = maxMovementPosition;
        }
        else if (newPosition.x < minMovementPosition)
        {
            newPosition.x = minMovementPosition;
        }
         if (newPosition.z > maxMovementPosition)
        {
            newPosition.z = maxMovementPosition;
        }
        else if (newPosition.z < minMovementPosition)
        {
            newPosition.z = minMovementPosition;
        }

        Debug.Log("Position: " + newPosition.ToString());

        cubes[selectedCubeIndex].transform.position = newPosition;
    }
}
