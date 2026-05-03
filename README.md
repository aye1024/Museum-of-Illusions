# Museum of Illusions

Museum of Illusions is a VR museum built in Unity for the TSA Virtual Reality Simulation event. The experience turns classic optical illusions into walkable 3D exhibits, letting players see how perspective, distance, and viewing angle change what an object appears to be.

The museum includes forced-perspective exhibits such as a Penrose triangle, ambiguous cylinders, scale-based illusions, guided audio triggers, and teleport-based scene transitions. Players explore the space in VR, line themselves up with marked viewing spots, and move around each object to understand how the illusion works.

## Project Details

- Built with Unity `6000.3.8f1`
- Target hardware: Meta Quest 2
- Main build scene: `Assets/Scenes/BasicScene.unity`
- Uses Meta XR SDK, Unity XR Interaction Toolkit, OpenXR, URP, and Unity Input System
- Custom scripts handle distance scaling, trigger-based teleporting, and exhibit voice lines

## How to Run

1. Open the project folder in Unity Hub using Unity `6000.3.8f1`.
2. Let Unity restore the packages from `Packages/manifest.json`.
3. Open `Assets/Scenes/BasicScene.unity`.
4. Connect a Meta Quest 2 or use the configured XR simulator for testing.
5. Build for Android/Quest through Unity's build settings.

## Credits

Created by Team 1023-1 for the 2026 TSA State Conference in Greensboro, North Carolina. Third-party assets and references are documented in the project portfolio.
