# GuessTheName — Multiplayer Word Guessing Game

An interactive, multiplayer word guessing game built with a client-server architecture in C#.  

---

## 🧩 About the Project

GuessTheName is a real-time multiplayer game where one or more clients connect to a server, and attempt to guess the name (or word) by revealing letters or submitting full guesses. The server handles game logic, turn management, score, and broadcasting updates to clients.

---

## 🚀 Features

- Real-time client-server communication  
- Turn-based or simultaneous guessing logic  
- Letter reveal / guess mechanisms  
- Score tracking / win detection  
- Protocol / messaging models (shared between client & server)  
- Basic UI client (console, or GUI if applicable)  
- Handling client disconnections / game restarts  

---

## 💻 Tech Stack

| Component       | Technology / Approach |
|----------------|-------------------------|
| Client / UI     | C# (Console or Windows Forms / WPF) |
| Server / Backend | C# (TCP / sockets or higher-level network library) |
| Shared Protocol | Shared serialization / message models (e.g. JSON, binary) |
| Concurrency / Async | Asynchronous methods, threading or async/await |
| Communication | Event-based / message passing over TCP or WebSockets |

---

## 🏗 Architecture & Components

This project is organized into three core parts:

1. **Server** — Manages game state, client connections, message routing, game logic  
2. **Client** — Handles UI / player input, receives server updates, displays current state  
3. **Shared / Protocol Models** — Message definitions, DTOs, command / response types, shared between client & server  
