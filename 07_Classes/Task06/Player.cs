namespace Task06
{
    internal class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Vector3D Position { get; set; }

        public Player(string name)
        {
            Name = name;
            Level = 1;
            Position = new Vector3D();
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }

        public void LevelUp()
        {
            Level++;
        }

        public void StepLeft()
        {
            Position.X--;
        }

        public void StepRight()
        {
            Position.X++;
        }

        public void StepForward()
        {
            Position.Z++;
        }

        public void StepBackward()
        {
            Position.Z--;
        }

        public void ClimbUp()
        {
            Position.Y++;
        }

        public void ClimbDown()
        {
            Position.Y--;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"[{Level} LVL] {Name}");
            Console.WriteLine($"Position: [{Position.X}, {Position.Y}, {Position.Z}]");
            Console.WriteLine();
        }
    }
}
