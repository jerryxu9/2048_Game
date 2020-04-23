using System;


namespace Game
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game myGame = new Game(4);
            int[,] arr = new int[4, 4]{
                { 2, 0, 4, 4},
                { 0, 2, 0, 8},
                { 0, 4, 2, 8},
                { 2, 0, 2, 0}

            };
            Console.WriteLine("initial game: ");
            myGame.PrintGame(arr);
            //Console.WriteLine("Move Down: ");
            //myGame.MoveDown(arr);
            //myGame.PrintGame(arr);
            //Console.WriteLine("Move Up: ");
            //myGame.MoveUp(arr);
            //myGame.PrintGame(arr);
            Console.WriteLine("Move Right: ");
            myGame.Move(arr, MoveDirection.RIGHT);
            myGame.PrintGame(arr);
            //Console.WriteLine("Move Left: ");
            //myGame.MoveLeft(arr);
            //myGame.PrintGame(arr);
            
        }
    }

    //class Game{
    //    int size;

    //    public Game(int size){
    //        this.size = size;
    //    }

    //    public void PrintGame(int[,] arr){
    //        for(int i = 0; i < arr.GetLength(0); i++){
    //            for(int j = 0; j < arr.GetLength(1); j++){
    //                Console.Write(arr[i, j] + "\t");
    //            }
    //            Console.WriteLine();
    //        }
    //    }

    //    public void Move(int[,] arr, MoveDirection direction){
    //        switch(direction){
    //            case MoveDirection.UP:
    //                MoveUp(arr);
    //                break;
    //            case MoveDirection.DOWN:
    //                MoveDown(arr);
    //                break;
    //            case MoveDirection.LEFT:
    //                MoveLeft(arr);
    //                break;
    //            case MoveDirection.RIGHT:
    //                MoveRight(arr);
    //                break;


    //        }
    //    }

    //    private int[] ClearZeros(int[] arr){
    //        int[] newArr = new int[this.size];
    //        int index = 0;
    //        for(int i = 0; i < arr.Length; i++){
    //            if(arr[i] != 0){
    //                newArr[index++] = arr[i];
    //            }
    //        }
    //        return newArr;
    //    }

    //    private int[] Merge(int[] arr){
    //        int[] newArr = ClearZeros(arr);         

    //        for(int i = 0; i < arr.Length; i++){
    //            if(newArr[i] != 0 && newArr[i] == newArr[i + 1]){
    //                newArr[i] *= 2;
    //                newArr[i + 1] = 0;
    //            }
    //        }
    //        return ClearZeros(newArr);
    //    }

    //    private void MoveUp(int[,] arr){
    //        int[] temp = new int[arr.GetLength(0)];
    //        for(int i = 0; i < arr.GetLength(1); i++){             
    //            for(int j = 0; j < arr.GetLength(0); j++){
    //                temp[j] = arr[j, i];
    //            }
    //            temp = Merge(temp);
    //            for(int z = 0; z < arr.GetLength(0); z++){
    //                arr[z, i] = temp[z]; 
    //            }
    //        }
    //    }

    //    private void MoveDown(int[,] arr){
    //        int[] temp = new int[arr.GetLength(0)];
    //        for(int i = 0; i < arr.GetLength(1); i++){
    //            for(int j = 0; j < arr.GetLength(0); j++){
    //                temp[j] = arr[j, i];
    //            }
    //            Array.Reverse(temp);
    //            temp = Merge(temp);
    //            for(int z = 0; z < arr.GetLength(0); z++){
    //                arr[arr.GetLength(0) - 1 - z, i] = temp[z]; 
    //            }
    //        }
    //    }

    //    private void MoveLeft(int[,] arr){
    //        int[] temp = new int[arr.GetLength(1)];
    //        for(int row = 0; row < arr.GetLength(0); row++){
    //            for(int col = 0; col < arr.GetLength(1); col++){
    //                temp[col] = arr[row, col];
    //            }
    //            temp = Merge(temp);
    //            for(int col = 0; col < arr.GetLength(1); col++){
    //                arr[row, col] = temp[col];
    //            }
    //        }
    //    }

    //    private void MoveRight(int[,] arr){
    //        int[] temp = new int[arr.GetLength(1)];
    //        for(int row = 0; row < arr.GetLength(0); row++){
    //            for(int col = 0; col < arr.GetLength(1); col++){
    //                temp[col] = arr[row, col];
    //            }
    //            Array.Reverse(temp);
    //            temp = Merge(temp);
    //            for(int col = 0; col < arr.GetLength(1); col++){
    //                arr[row, arr.GetLength(1) - 1 - col] = temp[col];
    //            }
    //        }
    //    }
    //}
  
}
