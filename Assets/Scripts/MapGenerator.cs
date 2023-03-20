using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField]
    private RoomManager[] rooms;
    [SerializeField]
    private RoomManager standartRoom;
    [SerializeField]
    private ScriptableObject mapStats;
    private RoomManager[,] mapOfRooms;
    private int maxY, maxX;

    public enum pointsOfRoom
        {
            left = 0,
            top = 1,
            right = 2,
            bottom = 3
        }

    private IEnumerator Start()
    {
        mapOfRooms = new RoomManager[11, 11];
        mapOfRooms[5, 5] = standartRoom;
        for(int i = 0; i < mapOfRooms.Length; i++)
        {
            GenerateRoom();
            yield return new WaitForSeconds(0.5f);
        }
    }
    private void GenerateRoom()
    {
        HashSet<Vector2Int> availablePlaces = new HashSet<Vector2Int>();

        for(int x = 0; x < mapOfRooms.GetLength(0); x++)
        {
            for (int y = 0; y < mapOfRooms.GetLength(1); y++)
            {
                if (mapOfRooms[x, y] == null)
                    continue;
                maxX = mapOfRooms.GetLength(0) - 1;
                maxY = mapOfRooms.GetLength(1) - 1;
                if (x > 0 && mapOfRooms[x - 1, y] == null) availablePlaces.Add(new Vector2Int(x - 1, y));
                if (y > 0 && mapOfRooms[x, y - 1] == null) availablePlaces.Add(new Vector2Int(x, y - 1));
                if (x < maxX && mapOfRooms[x + 1, y] == null) availablePlaces.Add(new Vector2Int(x + 1, y));
                if (y < maxY && mapOfRooms[x, y + 1] == null) availablePlaces.Add(new Vector2Int(x, y + 1));


            }
        }
        RoomManager newRoom = Instantiate(rooms[Random.Range(0, rooms.Length)]);

        int countToTry = 200;
        while (countToTry-->0)
        {
            Vector2Int position = availablePlaces.ElementAt(Random.Range(0, availablePlaces.Count));
            if (OptimizeConnect(newRoom, position))
            {
                newRoom.transform.position = new Vector3((position.x - 10) * 21, (position.y - 4) * 10, 0);
                mapOfRooms[position.x, position.y] = newRoom;
                break;
            }
        }
      
    }


    private bool OptimizeConnect(RoomManager room, Vector2Int position)
    {
        maxX = mapOfRooms.GetLength(0) - 1;
        maxY = mapOfRooms.GetLength(1) - 1;

        List<Vector2Int> neighbours = new List<Vector2Int>();
       
        if (room.doors[((int)pointsOfRoom.top)]!=null && position.y < maxY && mapOfRooms[position.x, position.y + 1]?.doors[((int)pointsOfRoom.bottom)]!= null) neighbours.Add(Vector2Int.up);
        if (room.doors[((int)pointsOfRoom.bottom)] != null && position.y > 0 && mapOfRooms[position.x, position.y - 1]?.doors[((int)pointsOfRoom.top)] != null) neighbours.Add(Vector2Int.down);
        if (room.doors[((int)pointsOfRoom.right)] != null && position.x < maxX && mapOfRooms[position.x + 1, position.y]?.doors[((int)pointsOfRoom.left)] != null) neighbours.Add(Vector2Int.right);
        if (room.doors[((int)pointsOfRoom.left)] != null && position.x > 0 && mapOfRooms[position.x - 1, position.y]?.doors[((int)pointsOfRoom.right)] != null) neighbours.Add(Vector2Int.left);

        if(neighbours.Count == 0)
        {
            return false;
        }
        Vector2Int selectedDirections = neighbours[Random.Range(0, neighbours.Count)];
        RoomManager selectedRoom = mapOfRooms[position.x + selectedDirections.x, position.y + selectedDirections.y];

        
        if(selectedDirections == Vector2Int.up)
        {
            room.doors[((int)pointsOfRoom.top)].SetActive(false);
        }
        else if (selectedDirections == Vector2Int.down)
        {
            room.doors[((int)pointsOfRoom.bottom)].SetActive(false);
        }
        else if (selectedDirections == Vector2Int.left)
        {
            room.doors[((int)pointsOfRoom.left)].SetActive(false);
        }
        else if (selectedDirections == Vector2Int.right)
        {
            room.doors[((int)pointsOfRoom.right)].SetActive(false);
        }
        return true;
    }
}
