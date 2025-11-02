# AR Fitness - Unity AR Project

This folder contains a ready-to-import minimal Unity project scaffold for an AR fitness application. It provides a structure, core scripts, and placeholder assets so you can open it in Unity and continue development.

Recommended Unity version: 2021.3 LTS or newer (2020.3+ may also work). Install AR Foundation, ARCore XR Plugin or ARKit XR Plugin through the Package Manager after opening the project.

Notes:

- This scaffold includes scripts for placement, routine management, basic UI wiring, and an innovative gameplay concept: "Adaptive Micro-Routines" — short AR-guided fitness bursts that adapt difficulty using camera-based pose estimation (stubbed).
- The project does not include proprietary Unity packages (AR Foundation) because those must be added through Unity Package Manager.

How to open:

1. In Unity Hub choose "Add" and point to this folder, or open Unity and select "Open Project" and choose this directory.
2. Open Package Manager (Window → Package Manager) and install:
   - AR Foundation
   - ARCore XR Plugin (Android) or ARKit XR Plugin (iOS)
   - (Optional) AR Foundation Samples

Files added:

- `Assets/Scripts/ARPlacement.cs` - simple AR object placement and anchor management
- `Assets/Scripts/ARFitnessManager.cs` - high-level routine, exercise handling, adaptive difficulty stub
- `Assets/Scripts/ExerciseRoutine.cs` - data model for exercises
- `Assets/Scripts/UIManager.cs` - basic UI control for starting/stopping routines
- `Assets/Scenes/Main.unity` - placeholder scene file (empty scene)
- `Packages/manifest.json` - minimal manifest allowing Unity to open the project; add AR packages manually after opening
- `ProjectSettings/ProjectSettings.asset` and `EditorBuildSettings.asset` - minimal settings stubs

Next steps:

- Open the project in Unity and install AR packages.
- Replace placeholder assets and extend pose estimation using ML/third-party libraries or ARKit body tracking.

Enjoy building your AR fitness app!
