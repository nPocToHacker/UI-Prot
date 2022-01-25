# UI-Prot
UI prototype on Unity engine

  The main goal of this project is creating a title screen for a game with following functions: opening a shop window, which contains adjustable items and lays them out in a grid (items must be scrollable); opening a settings window, which contains music, sound, notification toggles, buttons opening web pages; opening a chat window, which visualizes messages the player types in corresponding field; showing loading screen (not specified where to show it up). Dynamically loaded contents should be addressable, non-dynamically loaded ones should be packed in sprite atlases – but i'm pretty sure i messed this up.

  There are three scenes in the project: PersistentScene, MainMenu and Shop. The first one must be loaded first since only it has the SceneLoader script managing loading other scenes. For the same reason it must never be unloaded. Other scenes use CallSceneLoader script to swicth between each other. This was made to make only one loading screen be present and be able to show up while other scenes are loading. Event system and audio listener are also present in persistent scene only.

  MainMenu and Shop scenes were separated only for showing that loading screen exists and works.
