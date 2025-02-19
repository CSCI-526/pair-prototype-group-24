# Config

## Dependency

In order to prevent compile errors:
- Go to Window > Package Manager in the menubar.
- Select Unity Register in the top-left dropdown list, install Cinemachine.
- Restart Unity Editor.

## How to attach

### Player

- Mechanics/KinematicObject.cs
- Mechanics/PlayerController.cs (controls movement)
- Mechanics/Health.cs (handles health/death)
- Collider2D: Is Trigger
- Rigidbody2D
  - Body Type: Kinematic
  - Collision Detection: Continuous
  - Interpolate: Interpolate
  - Constraints: Freeze Rotation Z
- Animator
  - Controller: Player (Parameters)
    - grounded
    - velocityX
    - dead
    - hurt
    - victory

### Token(Collectible)

- Mechanics/TokenInstance.cs (individual token behavior)
- Collider2D: Is Trigger

### Platforms

- Collider2D

### No Gravity Shift Zone

- Mechanics/NoGravityShiftZone.cs
- Collider2D: Is Trigger

### Death Zone

- Mechanics/DeathZone.cs (for death zones)
- Collider2D: Is Trigger

### Victory Zone

- Mechanics/VictoryZone.cs (for exits)
- Collider2D: Is Trigger

### Spawn Point (Empty Object)

- Mechanics/SpawnPoint.cs

### Main Camera

- Tag: MainCamera
- CinemachineBrain
  - Live Camera: CM vcam1

### CM vcam1

- CinemachineVirtualCamera
  - Follow: Player
  - Look At: Player

### GameController(Empty Object)

- Mechanics/GameController.cs
- Mechanics/TokenController.cs
- UI/MetaGameController.cs
  - Main Menu: UI Canvas (Main UI Canvas)
  - Came Controller: GameController

### UI Canvas

- UI/MainUIController.cs

### Background

- View/ParallaxLayer.cs
