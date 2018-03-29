# 2D-Portal-
C# Implementing Dijkstra algorithm on a 2D given map to find shortest route
PortalTM is a first-person puzzle/platform game developed and published by Valve Software. This
problem has a similar idea to PortalTM but it does not assume you have played the game.  

For this problem you find yourself in a grid of size R by C. There is also a cake somewhere in the
grid. The aim is to arrive at the cake with as few moves as possible. You can move north, south,
east or west to an empty cell. Additionally, you have the ability to create portals on walls.
Portals are created with a special patented portal gun, which can fire a yellow portal or a blue portal.
The portal gun can be fired in the same directions that you can move. Once fired the gun emits a
ball of energy that creates a portal on the first wall it hits. Note that for this problem shooting the
portal gun does not count as a move. If you fire your portal gun at the cake, the energy ball will go
right through it. After creating a yellow portal and a blue portal, you can move through the yellow portal to arrive at
the blue portal or vice versa. Using these portals you may be able to reach the cake even faster!
You can only use portals after you create both a yellow and a blue portal.  
  
The program mimicks the game behaviour by analysing different map inputs witten in a text file as follows
The first line of each test case will contain the integers R and C separated by a space. R lines follow
containing C characters each, representing the map:  
. indicates an empty cell;  
(#) indicates a wall;  
O indicates your starting position; and  
X indicates the cake's position.  
  
There will be exactly one O and one X character per case.
Cells outside of the grid are all walls and you may use them to create portals.
  
Objectives (Output)
For each test case you should output one line containing "Case #X: Y" (quotes for clarity) where X
is the number of the test case and Y is the minimum number of moves needed to reach the cake or
"THE CAKE IS A LIE" (quotes for clarity) if the cake cannot be reached.
  
Implementation Constraints (Limits)  
1 ≤ N ≤ 20  
1 ≤ R ≤ 9  
1 ≤ C ≤ 9  

Example of input (first number is the maps to test)  
3                    
4 7  
.O..##.  
.#.....  
.#.####  
.#...X.  
5 5  
O....  
.....  
.....  
.....  
....X  
1 3  
O#X  

Their corresponding Output  
Case #1: 4  
Case #2: 2  
Case #3: THE CAKE IS A LIE  
