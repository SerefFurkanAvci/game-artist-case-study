using UnityEngine;

public class ModelLoader : MonoBehaviour
{
    public GameObject[] models; // Modellerin listesini tutacak

    void Start()
    {
        float offsetX = 0;

        foreach (GameObject model in models)
        {
            GameObject obj = Instantiate(model, new Vector3(offsetX, 0, 0), Quaternion.identity);
            offsetX += 2; // Modellerin yan yana dizilmesi için
        }
    }
}