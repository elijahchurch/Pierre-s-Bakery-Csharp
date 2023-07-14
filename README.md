#  Pierre's Bakery

#### By: Jason Elijah Church

#### Brief Description
A console application that will calculate an order cost for a bread delivery company based on the user's selections.

## Technologies Used
* C#
* Markdown
* Git Bash
* Visual Code Studio
* .NET

## Description:
This application was made using C# and the .NET framework. It guides the user through prompts asking for how many loaves of bread and how many pastries they order. Information for how much a loaf of bread and how much a pastry costs is stored in a static field in a Bread and Pastry class, respectively. These classes also have built in static methods to take in the order amount the user inputted and calculate the total cost. For the Bread class, a buy 2-get-1-free deal is implemented by running a for loop and adding an individual bread cost to the total cost only when the incremented index number doesn't have a modulus of 0 when divided by 3. Likewise, with the Pastry class, a buy 3-get-1-free deal is implemented by running a for loop and adding an individual pastry cost to the total cost only when the incremented index number doesn't have a modulus of 0 when divided by 4. Try/Catch blocks and branching logic is implemented in the application to account for and catch bad user inputs. 


## Setup/ Installation Requirements

1. Clone this repo.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "Bakery".
3. In the command line, run the command "dotnet run" to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
4. Optionally, you can run "dotnet build" to compile this console app without running it.
5. To run the tests for this project, navigate to this project's test directory called "Bakery.Tests".
6. in the command line, run the command "dotnet restore" then "dotnet test" to run all the tests that are found in the ModelTests directory.

## Known Bugs
The logic for the CalculateBreadOrder and CalculatePastryOrder methods didn't work as I initially imagined it would. The quick fix I made was to set the totalCost fields they alter back to 0 in the UI logic that runs when a user wants to order more bread or pastries. 

## License

MIT License

Copyright (c) (2023) Jason Elijah Church

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.