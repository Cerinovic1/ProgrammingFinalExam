﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEamDemoProgram
{
    class PoolGenerator
    {
        //holds the array of pool of numbers
        private List<int> numbersPool;

        //holds the ma number or the limit
        private int _maxLimit, _poolSize;

        //constructor
        //pool size determine how many numbers in the winning pool
        //identify the the maximum or the number limit and the pool size
        public PoolGenerator(int limit, int poolSize)
        {
            //initializes the max or number limit and the pool size based on the parameters
            /*
                ------------- write your code in this line --------------------
            */

            //initialized the pool of winning numbers
            numbersPool = new List<int>();
        }

        //GenerateWinningPool() - Method that generate the winning pool of numbers
        public void GenerateWinningPool()
        {
            //declare a variable that holds the winning number
            int newNumber;

            //generate a random numbers n times base on the length of the winning pool
            for (int i = 0; i < this._poolSize; i++)
            {
                //repetitively generate a random number until a non-existing number from the winning pool is generated
                while (true)
                {
                    //generate a random number and store it in the variable
                    /*
                        ------------- write your code in this line --------------------
                    */

                    //check if the number generated is not yet already in the winning pool
                    if (!IsNumberExisted(newNumber))
                    {
                        //add the random number to the winning pool and stop the loop (while)
                        AddNumberToPool(newNumber);
                        break;
                    }
                }
            }

            //display the numbers in the winning pool
            DisplayNumbersPool();
        }

        //IsNumberExisted() - Method that returns a boolean value if a given number is ALREADY in the winning pool
        public bool IsNumberExisted(int newNumber)
        {
            //declare a variable that will hold the result and set ot false by default
            /*
                ------------- write your code in this line --------------------
            */

            //loops through every value of the winning pool of numbers
            foreach (var winningNumber in this.numbersPool)
            {
                //compare the new random number to the every winning number already in the pool if it is the same
                if (newNumber == winningNumber)
                {
                    //if it is the same then change the isExisted to true then stop the loop
                    /*
                        ------------- write your code in this line --------------------
                    */
                }
            }
            //return the isExisted
            return isExisted;
        }

        //GenerateRandomNumber() - Method that generate a random number from 1 to a given range or limit
        private int GenerateRandomNumber()
        {
            //declare a variable that holds the newly generated random number
            int randomNumber = 0;

            //create an instance of the Random class to generate a random number;
            Random random = new Random();

            //assign the random number generated by the random class to the variable
            randomNumber = random.Next(1, this._maxLimit);

            //return the random number that was generated
            return randomNumber;
        }

        //AddNumberToPool() - Method for adding the number to the winning pool
        public void AddNumberToPool(int number)
        {
            //add the number to the pool of winning numbers
            numbersPool.Add(number);
        }

        //DisplayWinningPool() - Method to display all the numbers in the winning pool
        public void DisplayNumbersPool()
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            
            //using foreach loop to display the numbers
            foreach (var winningNumber in this.numbersPool)
            {
                Console.Write("{0} \t",winningNumber);
            }

            Console.WriteLine("\n---------------------------------------------------------------------------");
        }

        //GetCurrentPool() - Method to get the current numbers in the pool
        public List<int> GetCurrentPool()
        {
            //return the numbers in the pool
            /*
                ------------- write your code in this line --------------------
            */
        }

    }
}
