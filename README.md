# Space Shooter Game

A Unity-based space shooter game developed with Unity 5.6.3p1 for Android platforms.

## Overview
Space Shooter is an action-packed arcade-style game where players control a spacecraft, dodge asteroids, battle enemy ships, and try to achieve the highest score possible. The game features dynamic backgrounds, various enemy types, and power-ups to enhance gameplay.

![image](https://github.com/user-attachments/assets/90245eb8-e1bf-464b-92be-90b730e2cd6a)


## Project Structure
The project contains two main implementations:
- **Main Implementation**: Found in the `Assets/Scripts` folder
- **Complete Implementation**: Found in the `Assets/_Complete-Game/Scripts` folder

## Features
- Player-controlled spacecraft with intuitive controls
- Multiple enemy types with different attack patterns
- Asteroid hazards with random rotation behavior
- Scrolling background for immersive gameplay
- Weapon systems and projectiles
- Score tracking system
- Time-based game progression

## Scripts
The game functionality is split across several scripts:

### Player Control
- `PLayer_controller.cs`: Handles player input and movement
- `Done_PlayerController.cs`: Complete implementation of player controls

### Enemy Behavior
- `EvasiveManeuver.cs`: Controls enemy ship evasion patterns
- `WeaponsController.cs`: Manages enemy weapons systems

### Game Environment
- `BGSroller.cs`: Creates parallax scrolling background
- `Random_Rotator.cs`: Applies random rotation to asteroids
- `DestroybyBoundary.cs`: Removes objects that exit the playable area

### Game Logic
- `GameController.cs`: Main game state controller and spawning system
- `DestoyByContact.cs`: Handles collision detection and response
- `DestroyByTime.cs`: Removes temporary objects after set duration
- `Mover.cs`: Basic movement behavior for projectiles and other objects

## Development Information
- Built with Unity 5.6.3p1
- Targeted for Android platform
- Configured for development builds with profiler enabled

## Requirements
- Unity 5.6.3p1 or compatible version
- For development: Unity Editor (Windows 64-bit used in original development)

## Installation
1. Clone or download the repository
2. Open the project in Unity
3. Build and deploy to target Android device or emulator

##Extending the Project in hte 

create a AI player that can fight alongside the human player

- Threat Detection: AI analyzes surrounding objects to identify threats
- Evasive Maneuvers: AI performs intelligent dodging of asteroids and enemy fire
- Combat Strategy: AI positions itself optimally for attack while maintaining safety
- Autonomous Decision Making: AI evaluates the battlefield and makes tactical decisions

## Credits
This project was created as part of a Unity development exercise, with both learning implementation and complete reference implementation included.

