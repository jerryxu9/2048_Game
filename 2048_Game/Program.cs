using System;


namespace Game
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game myGame = new Game(4);
            myGame.GenerateNum();
            myGame.GenerateNum();

            Console.WriteLine("initial game: ");
            myGame.PrintGame();

            int i = 10;
            while(i >= 0){
                ConsoleKey(myGame);
                if (myGame.isChanged == false)
                    continue;

                myGame.GenerateNum();
                myGame.PrintGame();
                i--;
            }

        }

        public static void ConsoleKey(Game game){
        
            switch(Console.ReadLine()){
                case "w":
                    game.Move(MoveDirection.UP);
                    break;
                case "a":
                    game.Move(MoveDirection.LEFT);
                    break;
                case "d":
                    game.Move(MoveDirection.RIGHT);
                    break;
                case "s":
                    game.Move(MoveDirection.DOWN);
                    break;

            }
        }
    }
  
}
