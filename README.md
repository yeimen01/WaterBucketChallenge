
# WaterBucketChallenge with .NET CORE 6 Web API

This repository contains a solution to the Water Jug Challenge, which involves measuring a specific volume of water using two jugs of different sizes, trying to give the shortest way possible to transfer the volume of water between jugs. The solution is implemented in C# using .NET CORE 6 Web API.

## Prerequisites

Before getting started, you will need to have the following installed on your computer:

-   [Visual Studio](https://visualstudio.microsoft.com/downloads/)
-   [.NET CORE 6 runtime](https://dotnet.microsoft.com/download/dotnet-core/6.0)

## Getting Started

The easiest way to see how this works is by following the next steps:

1.  Clone this repository to your computer.
2.  Open Visual Studio and select "Open a project or solution".
3.  Navigate to the cloned repository and select the `WaterBucketChallenge.sln` file
4.  Once the project is loaded in Visual Studio, right-click on the `WaterBucketChallenge` project and select "Set as Startup Project"
5.  Press `F5` to run the project and launch the .NET CORE 6 Web API

## Usage

This solution implements a recursive algorithm in order to solve the challenge, because it was the most efficient way to solve this problem. There is two possible stages, one with the solution and one with no solution, the solution stage provides an endpoint to retrieve the steps required to reach the target volume of water, but if there is no possible solution, it will return "No Solution" and a brief description letting know why there's no solution with the given values.

The initial values of the jugs and the target volume can be modified by changing the values of the `x`, `y`, and `z` variables in the `WaterBucketController` class.

To retrieve the solution, send a GET request to the endpoint `api/waterBucket` in your web browser when executing the app using swagger or using a tool like [Postman](https://www.postman.com/).

one example either using steps or stepsDetail endpoint:

`Get /api/waterBucket/steps?x=2&y=10&z=4`

given `x`, `y`, `z` parameters valid values for steps endPoint:

Respose
```json
{
Filled 2 to bucket X
Transfer 2 from bucket X to bucket Y
Filled 2 to bucket X
Transfer 2 from bucket X to bucket Y
}
```

given `x`, `y`, `z` parameters valid values for stepsDetail endPoint:

`Get /api/waterBucket/stepsDetail?x=2&y=10&z=4`

```json
[
    {
        "number": 1,
        "action": "Fill",
        "value": 2,
        "affedtedBucket": {
            "name": "X",
            "value": 2,
            "cap": 2
        },
        "toBucket": null,
        "description": "Filled 2 to bucket X"
    },
    {
        "number": 2,
        "action": "Transfer",
        "value": 2,
        "affedtedBucket": {
            "name": "X",
            "value": 0,
            "cap": 2
        },
        "toBucket": {
            "name": "Y",
            "value": 2,
            "cap": 10
        },
        "description": "Transfer 2 from bucket X to bucket Y"
    },
    {
        "number": 3,
        "action": "Fill",
        "value": 2,
        "affedtedBucket": {
            "name": "X",
            "value": 2,
            "cap": 2
        },
        "toBucket": null,
        "description": "Filled 2 to bucket X"
    },
    {
        "number": 4,
        "action": "Transfer",
        "value": 2,
        "affedtedBucket": {
            "name": "X",
            "value": 0,
            "cap": 2
        },
        "toBucket": {
            "name": "Y",
            "value": 4,
            "cap": 10
        },
        "description": "Transfer 2 from bucket X to bucket Y"
    }
]
```

## Limitations

The only actions allowed in this solution are filling the jugs, emptying the jugs, and transferring water from one jug to the other.

## Conclusion

This repository provides a solution to the Water Jug Challenge using .NET CORE 6 Web API. It can be used as a starting point for further development, to create another solve the problem on lest steps or in a more efficient way or as an educational tool for learning about web API development and problem-solving in C#.

## Contact

Yeisson Mendoza - @yeimen01 - yeimen01@gmail.com

GitHub: (https://github.com/yeimen01/WaterBucketChallenge).

LinkedIn: (https://www.linkedin.com/in/yeisson-mendoza-7b3580204/).
