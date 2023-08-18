public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var visitedRooms = new HashSet<int> {0};
        DepthFirstSearch(rooms, 0, visitedRooms);

        return visitedRooms.Count == rooms.Count;
    }

    private void DepthFirstSearch(IList<IList<int>> rooms, int roomNumber, HashSet<int> visitedRooms)
    {
        var roomsToVisit = rooms[roomNumber];
        
        foreach (var room in roomsToVisit)
        {
            if (!visitedRooms.Contains(room))
            {
                visitedRooms.Add(room);
                DepthFirstSearch(rooms, room, visitedRooms);
            }
        }
    }
}