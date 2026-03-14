# GameControlSystem
A simple project that demonstrates design patterns and how they can be implemented in a project. The theme is a Gaming Control System.

GameControlSystem is an example of how design patterns can look when developing a game. In this project I've chosen the Observer, Strategy and Command patterns in which I will explain in detail what they do and how they work.

---------

# Observer
The Observer pattern is used to notify multiple parts of the system when something changes.

In this project, devices such as Door, Light, and MusicPlayer act as subjects.
Observers like DashboardObserver, LoggerObserver, and AuditObserver subscribe to these devices.

When a device changes state (for example when a door opens), all attached observers automatically receive an update.

# Command
The Observer pattern is used to notify multiple parts of the system when something changes.

In this project, devices such as Door, Light, and MusicPlayer act as subjects.
Observers like DashboardObserver, LoggerObserver, and AuditObserver subscribe to these devices.

When a device changes state (for example when a door opens), all attached observers automatically receive an update.

# Strategy
The Strategy pattern allows the system to change behavior depending on the current mode.

Different game modes are implemented as strategies:

StealthMode
CombatMode
ExplorationMode

Each mode decides whether commands are allowed to execute by implementing the IModeStrategy interface.

This allows the system behavior to change without modifying the core logic.

# Facade
The Strategy pattern allows the system to change behavior depending on the current mode.

Different game modes are implemented as strategies:

StealthMode
CombatMode
ExplorationMode

Each mode decides whether commands are allowed to execute by implementing the IModeStrategy interface.

This allows the system behavior to change without modifying the core logic.

# Singleton
The Facade pattern is used to simplify interaction with the system.

The GameFacade class acts as a single entry point that connects commands, devices, and strategies.
Instead of interacting with many classes directly, the main program communicates through the facade.

This keeps the main program clean and easy to understand.

## Example Output
```text
Game Control System started
Door opened
Dashboard: Door opened
LOG: Door opened
Audit: Door opened

Light turned on
Music started

Replaying last commands...

# How to run
Clone the repo to your local directory and open .csproj using Visual Studio
