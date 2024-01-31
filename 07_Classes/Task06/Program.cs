namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Player("Forko");
            
            // see the initial values
            player.PrintInfo();

            // test the leveling up
            player.LevelUp();
            player.LevelUp();
            player.LevelUp();
            player.PrintInfo();

            // test the name change
            player.ChangeName("Player 2");
            player.PrintInfo();

            // test the stepping left, forward and climbing up
            player.StepLeft();
            player.StepForward();
            player.ClimbUp();
            player.PrintInfo();

            // test the rest of the movements. we should be back to [0, 0, 0] position
            player.StepRight();
            player.StepBackward();
            player.ClimbDown();
            player.PrintInfo();
        }
    }
}
