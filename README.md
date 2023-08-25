# 2022DEVF3_XTR_PairProgrammingDRD_Apr21/22
Repository for 3 academic prototypes - XR Terra (Pair Programming Exercises)

![IMG_6225](https://github.com/KateBiel/2022DEVF3_XTR_PairProgramming/assets/103016794/a8603f1a-cc93-444e-9018-e2b176c21022)

# ⚽🚦🚖 Pair Programming DRD 

Pair Programming DRD (Defend, Run, Display) is a collection of three distinct prototypes: Soccer Field Gradient, Red Light Green Light, and Car Showroom. These prototypes were developed during the Unity Foundation course at XRTerra. Throughout this project, I collaborated in pairs, partnering with different individuals each time to hone our pair programming skills. I embraced various roles, alternating between the 'driver' and 'navigator' positions. Additionally, I incorporated enhanced visuals, diving into a design role to enrich the development experience and make it more enjoyable for myself.

One of these prototypes, "Car Showroom," was selected for the final project iteration, with a primary focus on integrating Virtual Reality mechanics. [Learn more about Car Showroom VR. ](https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR)

✨ Timeline: 3 weeks

🔴 YouTube Demo: [Soccer Field Gardient](https://www.youtube.com/watch?v=ewFjK0WCmz4)

🔴 YouTube Demo: [Red Light Green Light](https://www.youtube.com/watch?v=loCCt3vq40w)

🔴 YouTube Demo: [Car Showroom](https://www.youtube.com/watch?v=J6YSGGTOE7c)

    - Unity 2021.3.13
    - 3D URP
    - PC Only 
<div style="border-top: 0px solid #3a3c43; margin-bottom: 20px;"></div>
📚 The main objectives of Pair Programming DRD were to enrich my understanding of Unity while building a strong grasp of fundamental C# principles and to become adept at working with other developers as a team.

<div style="border-top: 1.4px solid #3a3c43; margin-top: 50px; margin-bottom: 10px;"></div>
<div style="border-top: 1.4px solid #3a3c43; margin-top: 10px; margin-bottom: 10px;"></div>

<summary><h2>⚽ Soccer Field Gardient (Defend) </h2></summary>

<div style="border-top: 1.4px solid #3a3c43; margin-top: 20px;"></div>

![soccer2](https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD/assets/103016794/6075add1-82f7-4449-97c9-fe79a8d45d69)



    
 1. Description: In this game, the player taking on the role of a young kid who wants to play soccer. Your mom pops up from different corners, trying to take you home. To stop her, stand on "firing pads" to shoot soccer balls. You'll need fast reactions and a good plan to stay on the field.

 2. Controls: WASD

 3. What I Learned: 
    - How to design core game mechanics, including creative base defense and third-person control.
    - How to enhance gameplay with scoring systems, enemy spawning, and projectile design.
    - How to leverage Unity's features for event scripting, prefabs creation, and particle-collision integration.
    - How to create materials, import textures and assign them to objects.
    - How to utilize the console for feedback and debugging.


4. Console:
    - "Current score: int " -  activated upon the soccer ball hitting an enemy.
    - "Player triggered this firing pad!!!" - triggered when the player steps onto one of the pads.
    - "Your Mom has reached the soccer field! Time to go home :( " - triggered when an enemy enters the player's base area.

<div style="border-top: 0px solid #3a3c43; margin-top: 20px;"></div>

![soccer5](https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD/assets/103016794/d73fde4b-6526-4345-931d-d47efd2e1010) 


<div style="border-top: 1.4px solid #3a3c43; margin-top: 50px; margin-bottom: 20px;"></div>

<summary><h2>🚦 Red Light Green Light (Run) </h2></summary>

<div style="border-top: 0px solid #3a3c43; margin-top: 20px;"></div>

![soccer1](https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD/assets/103016794/9367c29b-f9a7-45d6-8f02-d2c51a4bfdfb)

1. Description: Inspired by the TV show "Squid Game", this game adopts rules resembling "Red Light & Green Light," yet with certain modifications. Players begin at the start of a sandy path. They must run when the light turns green and stay still when it turns red. Moving during the red light results in the player being respawned at the initial starting point. As players reach the end, the challenge increases: they must not only heed the lights but also evade the doll's laser gaze. If caught in its beams, it's game over. Victory is achieved by crossing the red line.

 2. Controls: WASD

 3. What I Learned: 
    - Transforming limitations into creative solutions.
    - Declaring colors for game object mesh renders using scripts.
    - Implementing Coroutines effectively.
    - Utilizing if-else statements for decision-making.

  <div style="border-top: 0px solid #3a3c43; margin-top: 10px;"></div>

4. Console:
    - "I think I can go now" - triggered by pressing the "W" key.
    - "So scared!!! I should take a break" - triggered when the "W" key is released.
     - "You moved!!! You was shoot!!!" - triggeres when player moves during the red light. 
    - "Oh no!!! Dall detected you!!!" - triggeres when player's colider intersects with doll's laser gaze colider.


  ![soccer4](https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD/assets/103016794/58fe577c-6263-442e-8d88-92352f82876d)


    
<div style="border-top: 1.4px solid #3a3c43; margin-top: 50px; margin-bottom: 10px;"></div>

<summary><h2>🚖 Car Showroom (Display)</h2></summary>

<div style="border-top: 0px solid #3a3c43; margin-bottom: 20px;"></div>

![soccer3](https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD/assets/103016794/01783a75-7d2c-4f06-9253-962b5143ce05)

  
    
1. Description: In this showroom, the player can customize a car's color to their liking, with control over three primary components: Base, which affects the entire car; Glass, altering the color of the car's windows; and Details, changing the color of the headlights. Additionally, the player can rotate the car using the left slider and adjust the environment's lighting with the right slider. 

    Explore the Virtual Reality implementation of this prototype [ here ](https://github.com/username/repository-name)

 2. Controls: LMB
 
 3. What I Learned: 
    - How to use UI components, including canvases, buttons, text, and sliders, and how to manage their events and implement corresponding logic through scripting.
    - How to simulate a day cycle by manipulating directional light with the skybox sun.
    - How to detect mouse inputs.
 
<div style="border-top: 1.4px solid #3a3c43; margin-top: 50px;"></div>
<div style="border-top: 1.4px solid #3a3c43; margin-top: 10px;"></div>

<div style="margin-top: 20px;">
  <h2>There is Always Room for Improvements!!!
  </h4>
</div>


 - Implement console outputs directly into the game's UI for better user feedback.
- djust colliders to ensure the player remains within the designated playground area.
- Set up a mechanism to destroy enemies once they enter a particular zone, ensuring smoother gameplay even with numerous adversaries.
- Incorporate sounds that respond to player actions, enhancing the interactive feedback within the game.


<div style="margin-top: 20px;">
  <h2>Reflection
  </h4>
</div>

<div style="margin-top: 0px;">
  <h4>This project was my first time working with Unity and game engines in general.Never coded in C#, debugging, and problem-solving before but now i know how to do this.</h4>
</div>

<div style="margin-top: 20px;">
  <h4> During the initial pair programming sessions, I felt nervous working with different individuals each time. However, by the second session, it began to feel more natural. I noticed significant improvements such as rapidly identifying errors and a heightened focus on the code, which substantially boosted the project's troubleshooting speed.</h4>
</div>

<div style="margin-top: 20px;">
  <h4> In brief, I was venturing into unfamiliar Unity territory as a complete newcomer! Yet, I'm proud of the knowledge I've acquired and motivated to keep progressing as a developer.</h4>
</div>

<div style="<h2>⚽ Soccer Field Gardient (Defend) </h2>; margin-top: 20px;"></div>
<div style="margin-top: 20px;">
  <h4> 🐱‍💻 Thanks for your time! I hope you have a joyful day and feel motivated to learn new things. 🧠</h4>
</div>




<div style="border-top: 1.4px solid #3a3c43; margin-top: 20px;"></div>

# 🤟 Featured Repositories

<p style="text-align:center;">
<a href="https://github.com/KateBiel/2022CS_SolarSystem#readme" target="_blank">
  <img src="https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD/assets/103016794/6f6d3969-9151-4ae2-be92-098743864af6" width="49%" />
</a>
<a href="https://github.com/KateBiel/2022DEVF3_XTR_CarShowroomVR" target="_blank">
  <img src="https://github.com/KateBiel/2022DEVF3_XTR_PairProgrammingDRD/assets/103016794/b8d1190a-0456-4fb9-8fc0-901b93b6b1d5" width="49%" />
</a>
  
</p>