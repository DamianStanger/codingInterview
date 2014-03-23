Coding Interview Frameworks
================

Sample C# solutions to form a basis of code interviews

## Shapes Interview (Basic C#) ##
This solution is designed to test very basic knowledge of C#, it does use unit tests using nunit but the candidate need not really know about unit testing or nunit to do this.

## Tests ##
Basic C# knowledge, consuming interfaces, constructors, simple logic. Creating simple classes and methods, foreach and or linq. Nuget and mocking frameworks.

## Steps ##

**First**: Get them to create a square class to fix the failing test.

**Second**: Un-ignore the next test and create a service or something (its upto them) to fix this test also.

**Third**: Ask the candidate to add a new method to the service to calculate the perimeter of a shape. (called totalPerimeter, takes an enumerable of IShape returns a double)

- Add the property 'double Perimeter { get; }' to the IShape interface, and add also to the square class (but dont make it work, leave as unset empty property).
- Include in the file 'ShapeServiceTests' into the project. (This might need modification depending on how the candidate did the second part but its quite generic)
- Then ask them to use a mocking framework to test drive the creation of a totalPerimeter method so that no actual squares are used. (this should test basic knowledge of what mocking frameworks are and how to use nuget to get the package)
