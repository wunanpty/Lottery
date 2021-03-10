# Lottery
- Lottery Application
- A project to practice multi threading

### DoubleColorball Rules
- To play DoubleColorball, you must select six red numbers from a pool between 1 and 33, and one blue number between 1 and 16. The blue number you select can be the same as one of the six red numbers.
- The six red numbers should not have duplicated number.

### Some Thoughts
- Select number should be time-consuming tasks,  the optimal way to handle it is to schedule multi-threads
- How to do real randomization, a proper way to use Random class
- Update blue ball
- Update red balls, note that "The six red numbers should not have duplicated number"
- A correct timing to enable the Stop button
- A correct timing to show the result
- How to terminate threads run

### Snapshot
- Lanuch Appliction
  - ![image](https://user-images.githubusercontent.com/29477330/110700710-1d887080-81a5-11eb-8bce-e3140116905d.png)

- After Click Start Button
  - ![image](https://user-images.githubusercontent.com/29477330/110700779-342ec780-81a5-11eb-8b92-d524ece2ddf8.png)

- After Click Stop Button
  - ![image](https://user-images.githubusercontent.com/29477330/110700895-57597700-81a5-11eb-95e9-142e54b5e7ae.png)

