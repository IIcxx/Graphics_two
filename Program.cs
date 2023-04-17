using Raylib_cs;

Raylib.InitWindow(750,1000, "Frogger");
Raylib.SetTargetFPS(60);

String scene = "Start";
bool alive = true;
Rectangle frog = new Rectangle(350,950,45,45);
Rectangle carOne = new Rectangle(0,302,90,45);
Rectangle carTwo = new Rectangle(750,252,60,45);
Rectangle carThree = new Rectangle(0,202,75,45);
Rectangle carFour = new Rectangle(750,152,90,45);
Rectangle carFive = new Rectangle(0,102,40,45);
Rectangle carSix = new Rectangle(0,848,70,45);
Rectangle carSeven = new Rectangle(0,798,90,45);
Rectangle carEight = new Rectangle(750,748,90,45);
Rectangle carNine = new Rectangle(0,648,90,45);
Rectangle carTen = new Rectangle(0,598,90,45);
Rectangle carEleven = new Rectangle(750,548,90,45);
Rectangle carTwelve = new Rectangle(0,498,90,45);
Rectangle carThirteen = new Rectangle(0,448,90,45);
Rectangle carFourteen = new Rectangle(750,398,90,45);
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
if(Raylib.CheckCollisionRecs(carOne, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carTwo, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carThree, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carFour, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carFive, frog) == true){
alive = false;
}
if(Raylib.CheckCollisionRecs(carSix, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carSeven, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carEight, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carNine, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carTen, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carEleven, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carTwelve, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carThirteen, frog) == true){
    alive = false;
}
if(Raylib.CheckCollisionRecs(carFourteen, frog) == true){
    alive = false;
}
void Reset(){
alive = true;
frog.x = 350;
frog.y = 950;
carOne.x = 0;
carTwo.x = 750;
carThree.x = 0;
carFour.x = 750;
carFive.x = 0;
carSix.x = 0;
carSeven.x =0;
carEight.x = 750;
carNine.x = 0;
carTen.x = 0;
carEleven.x = 750;
carTwelve.x = 0;
carThirteen.x = 0;
carFourteen.x = 750;

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
Raylib.DrawRectangle((int)carOne.x,(int)carOne.y,(int)carOne.width,(int)carOne.height,Color.BROWN);
Raylib.DrawRectangle((int)carTwo.x,(int)carTwo.y,(int)carTwo.width,(int)carTwo.height,Color.BLUE);
Raylib.DrawRectangle((int)carThree.x,(int)carThree.y,(int)carThree.width,(int)carThree.height,Color.BROWN);
Raylib.DrawRectangle((int)carFour.x,(int)carFour.y,(int)carFour.width,(int)carFour.height,Color.RED);
Raylib.DrawRectangle((int)carFive.x,(int)carFive.y,(int)carFive.width,(int)carFive.height,Color.BLUE);
Raylib.DrawRectangle((int)carSix.x,(int)carSix.y,(int)carSix.width,(int)carSix.height,Color.RED);
Raylib.DrawRectangle((int)carSeven.x,(int)carSeven.y,(int)carSeven.width,(int)carSeven.height,Color.BLACK);
Raylib.DrawRectangle((int)carEight.x,(int)carEight.y,(int)carEight.width,(int)carEight.height,Color.BLUE);
Raylib.DrawRectangle((int)carNine.x,(int)carNine.y,(int)carNine.width,(int)carNine.height,Color.WHITE);
Raylib.DrawRectangle((int)carTen.x,(int)carTen.y,(int)carTen.width,(int)carTen.height,Color.YELLOW);
Raylib.DrawRectangle((int)carEleven.x,(int)carEleven.y,(int)carEleven.width,(int)carEleven.height,Color.BROWN);
Raylib.DrawRectangle((int)carTwelve.x,(int)carTwelve.y,(int)carTwelve.width,(int)carTwelve.height,Color.BLACK);
Raylib.DrawRectangle((int)carThirteen.x,(int)carThirteen.y,(int)carThirteen.width,(int)carThirteen.height,Color.RED);
Raylib.DrawRectangle((int)carFourteen.x,(int)carFourteen.y,(int)carFourteen.width,(int)carFourteen.height,Color.YELLOW);
carOne.x += 2;
carTwo.x -= 5;
carThree.x += 3.5f;
carFour.x -= 1.5f;
carFive.x += 3;
carSix.x += 3.5f;
carSeven.x += 5;
carEight.x -= 3;
carNine.x += 2;
carTen.x += 3;
carEleven.x -=5;
carTwelve.x += 1.5f;
carThirteen.x += 3;
carFourteen.x -= 2;
if(carOne.x > 750){
    carOne.x = -50;
}
if(carTwo.x < -50){
    carTwo.x = 750;
}
if(carThree.x > 750){
    carThree.x = -50;
}
if(carFour.x < -50){
    carFour.x = 750;
}
if(carFive.x > 750){
    carFive.x = -50;
}
if(carSix.x > 750){
    carSix.x = -50;
}
if(carSeven.x > 750){
    carSeven.x = -50;
}
if(carEight.x < -50){
    carEight.x = 750;
}
if(carNine.x > 750){
    carNine.x = -50;
}
if(carTen.x > 750){
    carTen.x = -50;
}
if(carEleven.x < -50){
    carEleven.x = 750;
}
if(carTwelve.x > 750){
    carTwelve.x = -50;
}
if(carThirteen.x > 750){
    carThirteen.x = -50;
}
if(carFourteen.x < -50){
    carFourteen.x = 750;
}
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
    Raylib.DrawRectangle(0,548,750,4,Color.WHITE);
    Raylib.DrawRectangle(0,498,750,4,Color.WHITE); 
    Raylib.DrawRectangle(0,448,750,4,Color.WHITE);  
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
