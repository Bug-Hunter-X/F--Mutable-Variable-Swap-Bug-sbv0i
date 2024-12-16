# F# Mutable Variable Swap Bug

This repository demonstrates a common error when working with mutable variables in F#. The `swap` function attempts to swap the values of two mutable variables, but it fails to do so correctly.  This is due to F#'s immutability by default. The function appears to work but the values passed from outside the function's scope are not changed.

## Bug Description

The issue lies in how F# handles mutable variables and parameter passing.  The `swap` function receives copies of the variables' values, not references.  Therefore, modifying `x` and `y` within the function does not affect the original variables outside its scope.

## Solution

The correct approach involves using references or tuples.