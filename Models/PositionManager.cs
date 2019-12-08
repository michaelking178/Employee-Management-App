using System;
using System.Collections.Generic;

namespace Employee_Management_App.Models
{
    public class PositionManager
    {
        public List<Position> Positions { get; set; }

        public PositionManager()
        {
            Positions = new List<Position>();
        }

        public void AddPosition(string title, int salary)
        {
            foreach(Position position in Positions)
            {
                if (position.Title == title) {
                    // Throw message: position already exists
                    return;
                }
            }
            Position newPosition = new Position(title, salary);
            Positions.Add(newPosition);
        }

        public void RemovePosition(string title)
        {
            Position positionToRemove = Positions.Find(position => position.Title == title);
            Positions.Remove(positionToRemove);
        }

        public Position GetPosition(string title)
        {
            return Positions.Find(position => position.Title == title);
        }
    }
}
