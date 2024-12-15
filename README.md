# F# Mutable Variable Bug

This repository demonstrates a simple F# program with a potential bug related to mutable variables. The `bug.fs` file shows the buggy code, while `bugSolution.fs` provides a corrected version using immutable values and pattern matching.

The bug involves a recursive function that uses mutable variables (`x` and `y`). While the function appears correct at first, there's a potential for unexpected outcomes due to side effects and the mutable state.