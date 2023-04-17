using Raylib_cs;
Raylib.InitWindow(750,1000, "Frogger");
Raylib.SetTargetFPS(60);
String scene = "Start";
bool alive = true;
Rectangle frog = new Rectangle(350,950,50,50);
//int level = 0;



while(Raylib.WindowShouldClose() == false){
//UI logic
if(scene == "Start" && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
    scene = "Game";
}
if(scene == "Game" && alive == false){
    scene = "End";
    Reset();
}
if(scene == "End" && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)){
    scene = "Start";
}
if(scene == "Game" && frog.y <= 0){
    scene = "Win";
}
if(Raylib.IsKeyPressed(KeyboardKey.KEY_L)){ //for testing purposes
    alive = false;
}
//other logic
void Reset(){
alive = true;
frog.x = 350;
frog.y = 950;
//level = 0;
}
if(scene == "Game" && Raylib.IsKeyPressed(KeyboardKey.KEY_W)){
frog.y -=50;    
}
else if(scene == "Game" && Raylib.IsKeyPressed(KeyboardKey.KEY_S)){
frog.y +=50;
}
else if(scene == "Game" && Raylib.IsKeyPressed(KeyboardKey.KEY_D)){
frog.x +=70;
}
else if(scene == "Game" && Raylib.IsKeyPressed(KeyboardKey.KEY_A)){
frog.x -=70;
}
frog.x = Math.Max(0, Math.Min(700, frog.x));
frog.y = Math.Max(0, Math.Min(950, frog.y));

//characters & obsticles


if(scene == "Game"){
Raylib.DrawRectangle((int)frog.x,(int)frog.y,50,50, Color.GREEN);
}
//graphics
    
  if(scene == "Game"){
    Raylib.ClearBackground(Color.GRAY);
    Raylib.DrawRectangle(0,900,750,100,Color.DARKGREEN); //1000 -> 900
    //road '                                             //900 -> 750
    Raylib.DrawRectangle(0,798,750,4,Color.WHITE);
    Raylib.DrawRectangle(0,848,750,4,Color.WHITE);
    Raylib.DrawRectangle(0,700,750,50,Color.DARKGREEN); //750 -> 700
    //road                                              //700 -> 550
    Raylib.DrawRectangle(0,598,750,4,Color.WHITE);
    Raylib.DrawRectangle(0,648,750,4,Color.WHITE);
    Raylib.DrawRectangle(0,400,750,150,Color.BLUE); //550 -> 400
    Raylib.DrawRectangle(0,350,750,50,Color.DARKGREEN); //400 -> 350
    //road                                              //350 -> 100
    Raylib.DrawRectangle(0,148,750,4,Color.WHITE);
    Raylib.DrawRectangle(0,198,750,4,Color.WHITE);
    Raylib.DrawRectangle(0,248,750,4,Color.WHITE);
    Raylib.DrawRectangle(0,298,750,4,Color.WHITE);
    Raylib.DrawRectangle(0,0,750,100,Color.DARKGREEN); // 100 -> 0
   //Raylib.DrawText($"Distance: {level}",25,25,25,Color.BLACK);
    Raylib.DrawRectangle((int)frog.x,(int)frog.y,50,50, Color.GREEN);

  }
  if(scene == "Start"){
    Raylib.ClearBackground(Color.BLUE);
    Raylib.DrawText("FROGGER",265,250,40, Color.BLACK);
   Raylib.DrawText("Press ENTER to start", 175, 300, 32, Color.BLACK); 
  }
  
  if(scene == "End"){
    Raylib.ClearBackground(Color.BLUE);
    Raylib.DrawText("Press SPACE to restart", 170, 300, 32, Color.BLACK);
    Raylib.DrawText("Game Over!", 285, 250, 32, Color.BLACK);
  }
  if(scene == "Win"){
    Raylib.ClearBackground(Color.BLUE);
    Raylib.DrawText("Press SPACE to restart", 170, 300, 32, Color.BLACK);
    Raylib.DrawText("Game Over!", 285, 250, 32, Color.BLACK);
  }

    Raylib.EndDrawing();
}

/*Raylib.InitWindow(1024,768, "Topdown game");
Raylib.SetTargetFPS(60);
String CScene = "Start"; 
Color myColor = new Color(200,50,200,255);
Rectangle bozo = new Rectangle(0,0,50,70);
Rectangle trap = new Rectangle(200,200,50,50); 
Texture2D stickfigure = Raylib.LoadTexture("stickfigure.png");
//bozo.x = Math.Max(bozo.x, 0);
//bozo.y = Math.Max(bozo.y, 0);
//bozo.x = Math.Min(bozo.x, 974);
//bozo.y = Math.Min(bozo.y, 708 );
bozo.x = Math.Max(0, Math.Min(974, bozo.x));
bozo.y = Math.Max(0, Math.Min(708, bozo.y));



while(Raylib.WindowShouldClose() == false)
{
  Raylib.BeginDrawing();
  //LOGIC

if(CScene == "Game")
{
       
if(Raylib.IsKeyDown(KeyboardKey.KEY_BACKSPACE)) 
{
    CScene = "Pause";
}     
if(Raylib.IsKeyDown(KeyboardKey.KEY_D) || Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
{
    bozo.x += 2f;
}
if(Raylib.IsKeyDown(KeyboardKey.KEY_A) || Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
{
    bozo.x -= 2f;
}
if(Raylib.IsKeyDown(KeyboardKey.KEY_S) || Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
{
    bozo.y += 2f;
}
if(Raylib.IsKeyDown(KeyboardKey.KEY_W) || Raylib.IsKeyDown(KeyboardKey.KEY_UP ))
{
    bozo.y -= 2f;
}
if(bozo.y < 0)
{
    bozo.y = 0;
}
if(bozo.x < 0)
{
    bozo.x = 0;
}
if(bozo.y > 700)
{
    bozo.y = 700;
}
if(bozo.x > 974)
{
    bozo.x = 974;
}
}
if(Raylib.CheckCollisionRecs(trap, bozo) == true){
    CScene = "End";
    bozo.y = 0;
    bozo.x = 0;
}
if(CScene == "Start" && Raylib.IsKeyDown(KeyboardKey.KEY_ENTER)){
CScene = "Game";
}
if(CScene == "Pause" && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
CScene = "Game";
}
if(CScene == "Pause" && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)){
CScene = "Start";
}
if(CScene == "End" && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)){
    CScene = "Start";
}

//GRAPHICS

Raylib.ClearBackground(Color.BLUE);

  if(CScene == "Start"){
   Raylib.DrawText("Press ENTER to start", 300, 300, 32, Color.BLACK); 
  }
  if(CScene == "Game"){
     Raylib.DrawText("Press BACKSPACE to pause", 720, 15, 20, Color.BLACK);
     Raylib.DrawTexture(stickfigure, (int) bozo.x , (int) bozo.y ,Color.WHITE);
     Raylib.DrawRectangle((int) trap.x, (int)trap.y,  50, 50,Color.BLACK); 
  }
  if(CScene == "Pause"){
   Raylib.DrawText("Press ENTER to resume game", 250, 300, 32, Color.BLACK); 
   Raylib.DrawText("Press SPACE to return to start page", 175, 350, 32, Color.BLACK); 
  }
  if(CScene == "End"){
    Raylib.DrawText("Press SPACE to go back to start menu", 165, 350, 32, Color.BLACK);
    Raylib.DrawText("Game Over!", 410, 300, 32, Color.BLACK);
  }
  Raylib.EndDrawing();
}
*/
