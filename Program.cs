using System;
using Raylib_cs;


Raylib.InitWindow(750, 1000, "Frogger");
Raylib.SetTargetFPS(60);

String scene = "Start";   //variables
bool alive = true;
int passes = 0;
float speedOne = -0;
float speedTwo = -0;
float speedThree = -0;
float speedFour = 0;
float speedFive = -500;
float speedSix = -500;
float speedSeven = -500;
float speedEight = -500;
int sizeOne = 60;
int sizeTwo = 75;
int sizeThree = 90;
Rectangle frog = new Rectangle(350, 950, 45, 45); //the frog


while (Raylib.WindowShouldClose() == false)
{
    //UI logic

    if (scene == "Start" && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
    { // makes sure you can start the game from the start screen
        scene = "Game";
    }
    if (scene == "Game" && alive == false)
    { // takes you to the end screen and does the hard reset when you die.
        scene = "End";
        reset();
    }
    if (scene == "End" && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
    {
        scene = "Start";
    }

    if (scene == "Win" && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
    {
        scene = "Start";
        reset();
    }
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_L))
    { //for testing purposes
        passes++;
    }
    //other logic
    List<Rectangle> cars = new List<Rectangle>();  // list of all the cars, 28 of them to be exact, 2 for each lane of traffic, some go left and some go right
    cars.Add(new Rectangle(speedFour, 98, sizeTwo, 45));
    cars.Add(new Rectangle(750 - speedThree, 148, sizeThree, 45));
    cars.Add(new Rectangle(speedTwo, 198, sizeTwo, 45));
    cars.Add(new Rectangle(750 - speedTwo, 248, sizeThree, 45));
    cars.Add(new Rectangle(speedThree, 298, sizeOne, 45)); //5
    cars.Add(new Rectangle(speedFour, 398, sizeTwo, 45));
    cars.Add(new Rectangle(speedTwo, 448, sizeThree, 45));
    cars.Add(new Rectangle(750 - speedOne, 498, sizeThree, 45));
    cars.Add(new Rectangle(speedFour, 548, sizeThree, 45));
    cars.Add(new Rectangle(speedThree, 598, sizeTwo, 45)); //10
    cars.Add(new Rectangle(750 - speedFour, 648, sizeThree, 45));
    cars.Add(new Rectangle(speedTwo, 748, sizeTwo, 45));
    cars.Add(new Rectangle(speedThree, 798, sizeThree, 45));
    cars.Add(new Rectangle(750 - speedOne, 848, sizeOne, 45)); //14

    cars.Add(new Rectangle(speedEight, 98, sizeTwo, 45));                // |  duplicates, dupes are on the same respective line
    cars.Add(new Rectangle(750 - speedSeven, 148, sizeThree, 45));         // v
    cars.Add(new Rectangle(speedSix, 198, sizeTwo, 45));
    cars.Add(new Rectangle(750 - speedSix, 248, sizeThree, 45));
    cars.Add(new Rectangle(speedSeven, 298, sizeOne, 45)); //5
    cars.Add(new Rectangle(speedEight, 398, sizeTwo, 45));
    cars.Add(new Rectangle(speedSix, 448, sizeThree, 45));
    cars.Add(new Rectangle(750 - speedFive, 498, sizeThree, 45));
    cars.Add(new Rectangle(speedEight, 548, sizeThree, 45));
    cars.Add(new Rectangle(speedThree, 598, sizeTwo, 45)); //10
    cars.Add(new Rectangle(750 - speedEight, 648, sizeThree, 45));
    cars.Add(new Rectangle(speedSix, 748, sizeTwo, 45));
    cars.Add(new Rectangle(speedSeven, 798, sizeThree, 45));
    cars.Add(new Rectangle(750 - speedFive, 848, sizeOne, 45)); //14
    if (speedOne > 750)
    {   //resets the cars X possition to reuse they characters
        speedOne = -90;
    }
    if (speedTwo > 750)
    {
        speedTwo = -90;
    }
    if (speedThree > 750)
    {
        speedThree = -90;
    }
    if (speedFour > 750)
    {
        speedFour = -90;
    }
    if (speedFive > 750)
    {
        speedFive = -90;
    }
    if (speedFive > 750)
    {
        speedFive = -90;
    }
    if (speedSix > 750)
    {
        speedSix = -90;
    }
    if (speedSeven > 750)
    {
        speedSeven = -90;
    }
    if (speedEight > 750)
    {
        speedEight = -90;
    }


    void reset()
    { //a hard reset that resets the cars as well, used for when you die and win
        alive = true;
        frog.x = 350;
        frog.y = 950;
        speedOne = 0;
        speedTwo = 0;
        speedThree = 0;
        speedFour = 0;
        speedFive = -500;
        speedSix = -500;
        speedSeven = -500;
        speedEight = -500;
        passes = 0;
    }
    void softReset()
    {  //resets you to the starts when you get through the map
        passes += 1;
        frog.x = 350;
        frog.y = 950;
    }
    if (scene == "Game" && frog.y <= 0)
    {
        softReset();
    }
    if (scene == "Game" && Raylib.IsKeyPressed(KeyboardKey.KEY_W))
    {  //movement for the frog
        frog.y -= 50;
    }
    else if (scene == "Game" && Raylib.IsKeyPressed(KeyboardKey.KEY_S))
    {
        frog.y += 50;
    }
    else if (scene == "Game" && Raylib.IsKeyPressed(KeyboardKey.KEY_D))
    {
        frog.x += 70;
    }
    else if (scene == "Game" && Raylib.IsKeyPressed(KeyboardKey.KEY_A))
    {
        frog.x -= 70;
    }
    frog.x = Math.Max(0, Math.Min(700, frog.x));  //makes sure you can't go out of bounds
    frog.y = Math.Max(0, Math.Min(950, frog.y));

    //characters & obsticles


    if (scene == "Game")
    {  // speeds for the cars
        speedOne += 1.3f;
        speedTwo += 2.2f;
        speedThree += 3.5f;
        speedFour += 5.5f;
        speedFive += 1.3f;
        speedSix += 2.2f;
        speedSeven += 3.5f;
        speedEight += 5.5f;

        foreach (Rectangle car in cars)
        {     //draws the cars from the list
            Raylib.DrawRectangle((int)car.x, (int)car.y, (int)car.width, (int)car.height, Color.BLACK);
        }
        foreach (var car in cars)
        {
            if (Raylib.CheckCollisionRecs(frog, car) == true)
            {    //checks collision between the frog and the cars
                alive = false;
            }
        }
        if (passes >= 5)
        { //makes it so when you pass the level 5 times you win
            scene = "Win";
        }

    }
    //graphics

    if (scene == "Game")
    {
        //roads and grass
        Raylib.ClearBackground(Color.GRAY);
        Raylib.DrawRectangle(0, 900, 750, 100, Color.DARKGREEN);
        Raylib.DrawRectangle(0, 798, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 848, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 700, 750, 50, Color.DARKGREEN);
        Raylib.DrawRectangle(0, 598, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 648, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 548, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 498, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 448, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 350, 750, 50, Color.DARKGREEN);
        Raylib.DrawRectangle(0, 148, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 198, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 248, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 298, 750, 4, Color.WHITE);
        Raylib.DrawRectangle(0, 0, 750, 100, Color.DARKGREEN);
        Raylib.DrawRectangle((int)frog.x, (int)frog.y, 50, 50, Color.GREEN);
        Raylib.DrawText($"points: {passes}", 25, 25, 25, Color.WHITE);

    }
    if (scene == "Start")
    {
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawText("FROGGER", 265, 250, 40, Color.BLACK);
        Raylib.DrawText("Press ENTER to start", 175, 300, 32, Color.BLACK);
        Raylib.DrawText("(Use WASD to move and don't get hit by the cars!)", 110, 350, 20, Color.BLACK);
    }

    if (scene == "End")
    {
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawText("Press SPACE to restart", 170, 300, 32, Color.BLACK);
        Raylib.DrawText("Game Over!", 285, 250, 32, Color.BLACK);
    }
    if (scene == "Win")
    {
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawText("Press SPACE to restart", 175, 300, 32, Color.BLACK);
        Raylib.DrawText("Congratulations you won!", 175, 250, 32, Color.BLACK);
    }

    Raylib.EndDrawing();
}


