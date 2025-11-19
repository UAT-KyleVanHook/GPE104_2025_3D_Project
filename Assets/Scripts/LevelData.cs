using UnityEngine;

public class LevelData : MonoBehaviour
{
    [Header("Game Bounds")]
    public int MaxXBounds;
    public int MaxYBounds;
    public int MaxZBounds;

    public int MinXBounds;
    public int MinYBounds;
    public int MinZBounds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //max bounds
        GameManager.instance.maxX = MaxXBounds;
        GameManager.instance.maxY = MaxYBounds;
        GameManager.instance.maxZ = MaxZBounds;

        //min bounds
        GameManager.instance.minX = MinXBounds; 
        GameManager.instance.minY = MinYBounds;
        GameManager.instance.minZ = MinZBounds;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
