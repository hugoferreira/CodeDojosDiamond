# Diamond Maker

Diamond Maker is a console application written in C# that generates a diamond pattern of letters. Given a letter of the alphabet, it creates a diamond pattern where the given letter represents the widest point of the diamond. Essentially it solves [this kata](https://github.com/davidwhitney/CodeDojos/tree/master/Diamond%20Kata).

## Example Output

For example, if the input letter is 'C', the output will be:

```
  A  
 B B 
C   C
 B B 
  A  
```

## Compilation, Testing and Publishing

1. **Compilation:**

   - Install [.NET 5.0 SDK](https://dotnet.microsoft.com/download) or later (this was tested on .NET Core 7.0.203 on Apple Silicon running MacOS Ventura 13.3.1).
   - Navigate to the project root directory via the command line.
   - Run `dotnet build`.

2. **Testing:**

   - Install NUnit Test Adapter extension for your IDE (e.g., [NUnit 3 Test Adapter for Visual Studio](https://marketplace.visualstudio.com/items?itemName=NUnitDevelopers.NUnit3TestAdapter)).
   - Run `dotnet test`.

3. **Running without Publishing:**

   - Run `dotnet run --project src/Diamond/Diamond.csproj <letter>` to test the execution without
     creating a self-contained deployment.

4. **Publishing:**

   - Run `dotnet publish -c Release` to create a self-contained deployment.

## Unit Tests

The Diamond Maker project utilizes both traditional unit tests and Property-Based Testing (PBT). The traditional unit tests verify the correctness of the diamond generation under specific conditions or inputs.

PBT is used to test various properties that should hold true for all possible valid inputs. For instance, properties like "diamonds have vertical" and "horizontal symmetry" are checked. 

## Philosophy: What Constitutes a Diamond?

In the context of this program, a diamond is defined as a pattern of letters that is widest at a given character and that decreases in width on either side of this character. The diamond is symmetric both horizontally and vertically. This means that the pattern of letters is the same on the left and right of the vertical center line, as well as above and below the horizontal center line.

The properties captured by PBT reflect this understanding of what constitutes a diamond:

- **Symmetry:** The diamond is symmetric vertically and horizontally. This is checked by comparing the sequence of lines in the diamond to its reverse, as well as by checking that each line remains the same when reversed.

- **Letter Positioning:** All diamonds start and end with the letter 'A'.

- **Letter Order:** The upper half of the diamond follows a lexical order, meaning each line's letter is less than the next line's letter. By symmetry, the lower half follows a reversed lexical order.

- **Diagonal Formation:** In the upper-right quarter of the diamond, there is only one letter per line, and these letters form a diagonal. By the two symmetries, the diamond shape is asserted.

These properties, when tested across a wide range of valid inputs, help ensure that the diamond generation logic is working correctly.
