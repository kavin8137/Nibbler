# Overview
I built this program to design a snake game with two players interacting with the GUI. I have learned that C# is a great language to build game console. The snake game is being inspired by a YouTube tutorial, the link is provided below if interested. I have made different modification when I am learning and following the instruction. It is indeed incredible to learn about the power of namespace in C#, eventhough C++ has similar feature of namespace, C# can directly reference other classes and functions by directly importing the namespace. Instead of Python, where we have to specify the location of the library.

I enjoyed using the concept of namespace and Raylib library to help me completing this project. The Raylib library is indeed a powerful library that allows us to create input connection between the user using keyboard and mouse as well as output interefence such as playing the audio and presenting video updates on the GUI for the user.

To make the entire program readable, I have attempted to input different comments to help negivate the process of coding, and my understanding of the resolution that I have found when I was trying to debug. 

In order to have the program work, DotNet 9.0 has to be installed to your current computer. You also have to install Raylib packages to your local computer in order to advoid any potential error messages that will cause the program to a fatal.

To run the program or game, you have to run the following command:
```
dotnet build
dotnet run
```

I have hiden some of the file and only giving you the essential files here for the game. Hence, you might potential have to create a new project and migrate the core file to your local computer. You can create a new project for C# by doing the following command:
```
dotnet new console -o <Project-Name>
```

The design of this project is a demonstration of my learning process on making a game by using C# environment and make familiar to the language and its behavior.

**To control the snakes, Player 1 will press "W, A, S, D" to negivate for up, left, down, and right. Player 2 will press "Up, Left, Down, Right" arrows to nevigate for similar functions.**

I have include a short demonstration video on explaning how the program works.

[Software Demo Video](https://somup.com/cThY3HMBDB)

# Development Environment

The libraries and tool below is the tool that I have used to build the program. 

* C#
* DotNet 9.0
* Raylib Library
* Namespace
* Dictionary
* YouTube Tutorial
* Inheritance in C#
* Resize Image
* Game Audio
* Nullable Reference
* Null-Forgiving Reference

# Useful Websites

Here are the links that I have used to help me build better understanding about the program. I have used some help from ChatGPT on my debugging process. The understanding of the debugging processs is also included in the link below.

- [C# Document](https://www.geeksforgeeks.org/install-and-setup-dotnet-sdk-on-windows-macos-and-linux/)
- [DotNet 9.0](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-9/overview)
- [Raylib Library](https://www.raylib.com/)
- [Namespace](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace)
- [Dictionary](https://www.geeksforgeeks.org/c-sharp-dictionary-class/)
- [YouTube Tutorial](https://www.youtube.com/watch?v=uzAXxFBbVoE)
- [Inheritance in C#](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/inheritance)
- [Resize Image](https://www.resizepixel.com/)
- [Game Audio](https://pixabay.com/sound-effects/search/game/)
- [Nullable Reference](https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references)
- [Null-Forgiving Reference](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving)

# Future Work

- The quality of the background audio is not playing as expected in good quality. I have to study more in the future on how to appropriately include the audio in a good sound quality.
- I wanted to add a feature of play again to the end of the game so that the user don't have to close the program and rerun the game if they ever wanting to play again.
- Adding the scoring system and the audio respond when the snake is dead will be a great interation for the user.