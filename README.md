# RiemannSums

Overview of Riemann Sumation********************************************************************************

A Riemann Sum is a method for approximating the integral of a function. 
By making small partitions of the curve, 
measuring their volume for the height they reach on the curve, and adding many such partitions together, we can estimate the area under a curve. 
This program performs this operation on the function F(x) = x^2, but any other quadratic function could be calculated. I have elected not to call user input to change the function, but other variables like the number of Partitions, as well as the interval of the function, are up to the user.

Read more about Riemann Approximation here: https://en.wikipedia.org/wiki/Riemann_sum

Read the Full Code************************************************************************************

RiemannSums > Program.cs

The program described below is available in the Riemann SUms Folder, and is titled Program.cs, by convention.

How this C# program works************************************************************************************

This Console App will ask the user to define a number of partitions (N), an opening to the interval (A), and an end to the interval (B).
It will then calculate the width of each partition, DeltaX.
The program then calls a loop to calculate the value of the function for each partition, and records the volume, using three separate heights. This way, the output can later show the user an exact estimate based on the midpoint, or an under/over estimate, using the left and right point estimates, depending on the function. The final sum is then displayed to the user.

A separate method handles the F(x) function, so it can be modified in one place easily. 

Notes***********************************************************************************************************

This program was simple to implement, but several upgrades worth noting were the result of trial and error.
TryParse is used instead of Parse, to prevent the user from entering a string instead of an integer. 

One potential future variant would be to use LINQ Expression Trees to handle a string input from the user, for changing the function F(x). 
