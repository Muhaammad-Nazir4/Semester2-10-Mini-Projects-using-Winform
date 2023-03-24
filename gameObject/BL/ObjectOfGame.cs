using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameObject.BL
{
    class ObjectOfGame
    {
        public static bool flag = false;
        //constructors....................
        public ObjectOfGame()
        {
            shape = new char[6, 6] { { ' ', ' ', 'O','O', ' ', ' '} , { ' ', 'O', 'O','O', 'O', ' '} ,
               { 'O', 'O', 'O','O', 'O', 'O'} ,{ ' ', 'O', 'O','O', 'O', ' '} , { ' ', ' ', 'O','O', ' ', ' '},
               { ' ', 'O', 'O','O', 'O', ' '}};
            startingPoint.setXY(0, 0);
            premises = new boundary(new point(0, 0), new point(0, 90), new point(90, 0), new point(90, 90));
            direction = "LeftToRight";

        }

        public ObjectOfGame(char[,] shape, point startingpPoint)
        {
            this.shape = shape;
            this.startingPoint = startingpPoint;

            direction = "LeftToRight";

        }
        public ObjectOfGame(char[,] shape, point startingpPoint, string direction, boundary premises)
        {
            this.shape = shape;
            this.startingPoint = startingpPoint;
            this.direction = direction;
            this.premises = premises;

        }

        //attributes....................
        public char[,] shape;
        public point startingPoint;
        public boundary premises;
        public string direction;

        //member functions...................
        public void moveLeft()
        {
            if(startingPoint.getX() <= 90)
                startingPoint.setXY(startingPoint.getX() + 1, startingPoint.getY());
            
        }
        public void moveRight()
        {
            if (startingPoint.getX() >= 1)
                startingPoint.setXY(startingPoint.getX() - 1, startingPoint.getY());
          
                }
       
        public void moveDiagonals()
        {
            if (startingPoint.getX() <= 90 && startingPoint.getY() <= 90)
                startingPoint.setXY(startingPoint.getX() + 1, startingPoint.getY() + 1);
        }
        public void movePetrolling()
        {
            if (flag == false)
            {
                if (startingPoint.getX() < 90)
                {
                    startingPoint.setXY(startingPoint.getX() + 1, startingPoint.getY());
                }
                else if(startingPoint.getX() == 90)
                {
                    flag = true;
                }
            }
            else if (flag == true)
            {
                if (startingPoint.getX() > 2)
                {
                    startingPoint.setXY(startingPoint.getX() - 1, startingPoint.getY());
                }
                else if(startingPoint.getX() == 2)
                {
                    flag = false;
                }
            }
            
         
        }
        
        public void moveProjectile()
        {
            if (flag == false)
            {
                if (startingPoint.getY() > 2)
                {
                    startingPoint.setXY(startingPoint.getX() + 1, startingPoint.getY() - 1);
                }
                else if (startingPoint.getY() == 2)
                {
                    flag = true;
                }
            }
            else if (flag == true)
            {
                    if (startingPoint.getY() < 12)
                    {
                        startingPoint.setXY(startingPoint.getX() + 1, startingPoint.getY() + 1);
                    }                  
                }
            }
        public void moveObject()
        {
          if (direction == "LeftToRight")
            {
                moveRight();
            }
            if (direction == "RightToLeft")
            {
                moveLeft();
            }
           
            if (direction == "Diagonals")
            {
                moveDiagonals();
            }
            if (direction == "Random")
            {
                movePetrolling();
            }
            if (direction == "Projectile")
            {
                moveProjectile();
            }
           

        }
       
    }
    }
   


