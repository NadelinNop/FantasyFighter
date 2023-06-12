using System;
using System.IO;
using SplashKitSDK;
namespace TestingGUI
{
    public class Program
    {
        //private Boolean begin;
       
        public static void Main()
        {
       
            Window w = new Window("GUI", 800, 370);
            //Bitmap menubackground = new Bitmap("MenuBackground", "menuimage.png");
            WelcomeGUI _welcomeScreen = new WelcomeGUI();
            StartGameGUI _startgameScreen = new StartGameGUI();
            GamePlayGUI _gameScreen = new GamePlayGUI();
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();

            CharacterFactory p1 = new CharacterFactory();
            CharacterFactory p2 = new CharacterFactory();
           

            while (!w.CloseRequested)
            {
                SplashKit.ClearScreen();
                SplashKit.ProcessEvents();
                string[] lines = File.ReadAllLines("CharNames.txt");
                _welcomeScreen.Draw(w);
               
                if ( _welcomeScreen.CheckInput() == 1)
               {
                    SplashKit.ClearScreen();
                    _startgameScreen.Draw(w);
                   if (player1.Turn == true)
                   {
                        player1.Draw();
                        player1.CharSelection(_startgameScreen.CheckInput());
                       

                    }
                   else if(player1.Turn == false)
                    {
                        
                        player1.Draw();
                        player2.CharSelection(_startgameScreen.CheckInput());
                        player2.Draw();
                      

                        if (player2.Turn == true)
                        {
                            
                            SplashKit.ClearScreen();
                            _gameScreen.Draw(w);

                           

                            State state = new State();
                            Console.WriteLine(player1.I);
                            
                            Character first = p1.CreateChar(player1.I);
                          

                            Character second = p2.CreateChar(player2.I);
                           
                            state.TakeAction(first, second);
                                while (state.currentState == State.StateBase.Move)
                                {
                                    

                                    SplashKit.ClearScreen();
                                    SplashKit.ProcessEvents();
                                    _gameScreen.Draw(w);
                                    player1.Move(first, second);
                                    player2.Move(second, first);
                                    SplashKit.RefreshScreen(60);
                             
                                    if(first.Health == 0)
                                    {
                                    break;
                                    }
                              
                                }
                            state.TakeAction(first, second);
                            while (state.currentState == State.StateBase.End)
                            {

                                
                                SplashKit.ClearScreen();
                                if (first.Health<1)
                                {
                                    SplashKit.DrawText("Player 2 Won", Color.Black, "Retro Gaming.ttf", 18, 348, 160);

                                }
                                if (second.Health < 1)
                                {
                                    SplashKit.DrawText("Player 1 Won", Color.Black, "Retro Gaming.ttf", 18, 348, 160);

                                }
                                SplashKit.ProcessEvents();
                                SplashKit.RefreshScreen(60);

                            }















                            SplashKit.RefreshScreen(60);

                        }


                    }
                }
               else if(_welcomeScreen.CheckInput() == 2)
               {
                    w.Close();
                    
               }



                SplashKit.RefreshScreen(60);
            }
          
        }
    }
}