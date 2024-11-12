namespace HelloWorldApp;

public class JumpGame
{
  //This class provides an implementation of the Jump Game. Arrays of nums are passed into the PlayGame method
  //which performs a set of arbitrary "jumps" throughout
  //the array based on the array's values. A boolean determines whether the player won (true) or lost (false) the game.

//The game is played as follows. You are given an integer array nums. You are initially positioned at the array's first index,
//and the value at that array position represents how far you will "jump" to the next array position.
//After the jump, you will evaluate for the following conditions:

// If after jumping you are in the last position of the array, the game ends and a True value is returned
// indicating the game is won

// If after jumping you exceed the boundaries of the array, the game ends and a False value is returned indicating
// the game is lost

// If after jumping the value of the current array position is 0 and you are not at the end of the array,
// a False value is returned indicating the game is lost

// If none of the above conditions apply, add the current array value to the current array position.
// This gives you the new position in the array to jump to. Jump to that new position and perform the previous
// validations again to determine if the game is won, lost, or needs to continue

//Example: Given the array below, the following moves would occur during a game:

//          _____________
//Position: |0,1,2,3,4,5|
//          |-----------|
//Value:    |3,4,1,2,2,7|
//          -------------

//Move 1: The value at position zero of the array is 3. It satisfies none of the criteria so the value is used to
//calculate the next jump which results in a change to position three of the array

//Move 2: The value at position three of the array is 2. It satisfies none of the criteria so this value is used to
//calculate the next jump which results in a change to position five of the array

//Move 3: Position five is the last position in the array so it satisfies the "Win" condition of the game,
//so the game ends with a value of True returned from the PlayGame method

  public bool PlayGame()
  {
    
    int[] nums = {2, 7, 3, 6, 3, 1, 6, 8, 9, 2, 3, 5, 1}; //This is the array of integers that will be used to play the game
    
    //The following variables are used to track the game state
    int currPosition = 0;
    int arrayBoundary = nums.Length;
    bool gameOver = false;
    bool gameResult = false;

    while(!gameOver) {
      
      //Write code here to satisfy the game logic described above

      //Determine if game is won or lost.
      gameOver = true; //YOU WILL NEED TO CHANGE THIS LINE
    
    }

    //Return True if the game is Won and False if it is Lost
    return gameResult;
    
  }

}
