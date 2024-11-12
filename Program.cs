using System;
using System.Net.Http;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            JumpGame jumpGame = new JumpGame();
            jumpGame.PlayGame();
            
            RestAPI restAPI = new RestAPI();
            restAPI.GetRestData();
        }
    }
}