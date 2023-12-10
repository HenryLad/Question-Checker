# C# Quiz Application

A simple C# console application that quizzes the user with random questions read from a file.

## Features

- Reads questions and answers from a specified file.
- Asks the user to input the number of questions they want to answer.
- Randomly selects questions, ensuring no repetition.
- Evaluates user answers and provides feedback.
- Calculates and displays the total number of right and wrong answers.
- Calculates and displays the percentage of correct answers.

## How to Use

1. Clone the repository to your local machine.
2. Ensure you have the .NET SDK installed.
3. Open a terminal and navigate to the project directory.
4. Compile the C# program using `dotnet build`.
5. Run the compiled program using `dotnet run`.
6. Follow the on-screen instructions to input the number of questions you want to answer.
7. Answer each question and receive feedback.

## File Format

The questions and answers should be stored in a text file (`Cabs_Fragen.txt`) with each line formatted as follows:


Question;Answer

Separate questions and answers with a semicolon.
Example File Content


What is the capital of France?;Paris
Who wrote Romeo and Juliet?;William Shakespeare
...

Note

Ensure that the file path in the code (Cabs_Fragen.txt) is correctly specified.

Improvements and Contributions

Feel free to contribute to this project by opening issues or submitting pull requests. Contributions are welcome!
License

This project is licensed under the MIT License - see the LICENSE file for details.

arduino

