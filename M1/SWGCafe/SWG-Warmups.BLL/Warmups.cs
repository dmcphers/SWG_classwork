﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWG_Warmups.BLL
{
    public class Warmups
    {
        //Here at Software Guild Cafe, we are sure to enter the customer's name with 100% accuracy so we can print labels with their name 
        //out when their super-cha-latte-espresso with extra whipped cream is ready. Also, each day we randomly give people whose first names 
        //start with a specific letter 50% off their order. 

        //Given a person’s first name, a letter of the day, and a total dollar amount for an order, return a double with the cost of their order. 
        //(Hint - If no name is entered, then there is no chance of a discount for the customer.)
        public double NameoftheDay(string Name, string specialLetter, double orderTotal)
        {
            if (Name.StartsWith(specialLetter))
            {
                return orderTotal * .5;
            }
            return orderTotal;
        }

        //Too many people started lying about their names and profit margins started to shrink at the cafe. So marketing decided to 
        //try this new random discount so if a “random” place in your name contained the special letter, you’d get that same 50% off 
        //your order. 

        //Given a person’s first name, a letter of the day, the position in their name to check, and a total dollar 
        //amount for an order, return a double with the cost of their order. 
        //(Note, if for some reason the person’s name is too long, we count the last letter in their name)
        //(Hint - a string is a array of char)
        //(Hint - a lower case letter and upper case letter are not equal to each other)
        public double RandomLetterDiscount(string Name, char specialLetter, int lettertoCheck, double orderTotal)
        {
            Random rnd = new Random();
            //int index = rnd.Next(0, Name.Length - 1);
            if (Name == "")
            {
                return orderTotal;
            }
            if (lettertoCheck > Name.Length)
            {
                lettertoCheck = Name.Length - 1;
            }
            if (Name[lettertoCheck] == specialLetter)
            {
                return orderTotal * .5;
            }
            return orderTotal;
        }

        //So sales are booming and everyone is having a fun morning guessing if they are going to get the discount or not. 
        //However, some of our baristas are so excited to get the sale complete they are typing in names incorrectly which 
        //is leading to people feeling like they are getting cheated. We decided that the most common mistake was people typing 
        //in the same first letter or last letter twice. 

        //Given a person’s first name, return the name removing any instances of duplicate first letters or last letters from the name.
        public string CheckingForTypos(string firstName)
        {
            if (firstName[0] == firstName[1])
            {
                firstName = firstName.Substring(1, firstName.Length - 1);
            }
            if (firstName[firstName.Length - 1] == firstName[firstName.Length - 2])
            {
                firstName = firstName.Substring(0, firstName.Length - 1);
            }

            return firstName;

        }

        //So our typo plan worked, but barrista’s found out a bunch of Aaron, Bill, and Analee actually come into the shop. 
        //As such, we decided “a” is safe as a first letter and “l & e” is safe as a last letter. 

        //Given a person’s first name, return the name removing any instances of duplicate first letters (unless the letter is 'a') or 
        //last letters (unless the letter is 'l' or 'e') from the name.
        public string QualityAssurance(string firstName)
        {
            if ((firstName[0].ToString().ToLower() == "a") || 
                (firstName[firstName.Length - 1].ToString().ToLower() == "l") ||
                (firstName[firstName.Length - 1].ToString().ToLower() == "e"))
            {
                return firstName;
            }
            else
            {
                if (firstName[0] == firstName[1])
                {
                    firstName = firstName.Substring(1, firstName.Length - 1);
                }
                if (firstName[firstName.Length - 1] == firstName[firstName.Length - 2])
                {
                    firstName = firstName.Substring(0, firstName.Length - 1);
                }
            }
            
            return firstName;
        }

        //So some of our barista's liked to start throwing bad words into customer’s names (and say that is what the customer told them 
        //their name was). So we need to clean up any “bad” names.

        //Given a person’s name, remove any instances of the phrase “bad” and return the name. (Note, a person’s name can be less than 3 letters)
        public string NoBadWords (string firstName)
        {
            if (firstName.Contains("bad"))
            {
                int pos = firstName.IndexOf("bad");

                firstName = firstName.Remove(pos,3);
                return firstName;
            }
            return firstName;
        }

        //For April Fool’s Day we decide to run a promotion where the label that prints off for the customer’s cup blows 
        //up their name by changing it to their first letter, followed by the first two letters, etc. 
        //(For example, Alex becomes AAlAleAlex). 

        //Given a person’s name, expand the string like in the example. (See the unit tests for more examples)
        public string FunnyNameDay(string firstName)
        {

            string longName = "";
            for (int i = 1; i <= firstName.Length; i++)
            {
                longName = longName + firstName.Substring(0, i);
            }
            return longName;
        }

        //On every receipt we give the customer a phone number to go fill out a survey and they press a number (1-10) to 
        //describe their quality of experience (10 being the best). While we may want to do more with this survey later, 
        //for now we just want to know the number of customers that scored us at an 8 or higher. 

        //Given an array of integers, return the number of times an 8 or higher appears.
        public int CustomerSurvey(int[] surveyResults)
        {
            int counter = 0;
            for (int i = 0; i < surveyResults.Length; i++)
            {
                if (surveyResults[i] > 7)
                {
                    counter++;
                }
            }
            return counter;

        }

        //Each day our managers want us to report to them the average score of all completed surveys for a day and let them know 
        //if our average customer satisfaction rating is less than 8. 

        //Given an array of integers, return true if the average satisfaction rating is greater than 8 or return false if it is not.
        public bool AreCustomersHappy(int[] surveyResults)
        {
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < surveyResults.Length; i++)
            {
                sum = sum + surveyResults[i];
            }
            avg = sum / surveyResults.Length;
            if (avg > 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Our managers now want a weekend report giving us the average of both Saturday and Sunday’s surveys.
        
        //Given two arrays of integers, return the average rating of the two days.
        public double WeekendAverage(int[] saturdayResults, int[] sundayResults)
        {
            int satsum = 0;
            int sunsum = 0;
            int totsum = 0;
            int satavg = 0;
            int sunavg = 0;
            int totavg = 0;

            for (int i = 0; i < saturdayResults.Length; i++)
            {
                satsum = satsum + saturdayResults[i];
            }
            satavg = satsum / saturdayResults.Length;
            for (int i = 0; i < sundayResults.Length; i++)
            {
                sunsum = sunsum + sundayResults[i];
            }
            sunavg = sunsum / sundayResults.Length;
            totsum = satavg + sunavg;
            totavg = totsum / 2;
            return totavg;
        }

        //We take customer service very seriously. If more than 3 people gave us a score of 3 or less in a given day, 
        //we want to address the situation with the team.

        //Given an array of integers, return true if a score of 3 or less appears more than 3 times, or false if it does not.
        public bool TooMuchUnsatisfaction(int[] surveyResults)
        {
            int counter = 0;
            for (int i = 0; i < surveyResults.Length; i++)
            {
                if (surveyResults[i] <= 3)
                {
                    counter++;
                }
            }
            if (counter >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //One of the things a few of our customers commented on was the coffee did not taste fresh all the time. 
        //We decided our coffee should still taste fresh 2 hours after brew, so every even numbered hour we should change it.
        
        //Given an hour, return a boolean on if we need to change the coffee or not.
        public bool FreshCoffee (int hourofDay)
        {
            if (hourofDay % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Our normal staffing needs for the day are 6 people. During the winter time, we need 2 additional people to help 
        //the additional traffic. During the weekends we need an additional 3 people on top of that to meet our customer’s 
        //needs and go for that “10”.

        //Given if it is the winter and if it is the weekend, return the number of staff we need.
        public int StaffingNeeds (bool isWinter, bool isWeekend)
        {
            if (isWinter && isWeekend)
            {
                return 6 + 2 + 3;
            }
            else if(isWinter)
            {
                return 6 + 2;
            }
            else if(isWeekend)
            {
                return 6 + 3;
            }
            return 6;
        }

        //If the store is closed, we do not answer the phone. If it is the morning time, we do not answer the phone because we are so busy. 
        //However, if we recognize the number on the caller ID as the District Manager we pick it up as quick as possible regardless 
        //of what time it is.

        //Given if the store is open, if it is the morning, and if it is the District Manager - determine if we should answer the phone or not.
        public bool PhoneSupport(bool isStoreOpen, bool isMorning, bool isDistrictManager)
        {
            if (isDistrictManager)
            {
                return true;
            }
            else if (isStoreOpen && !isMorning)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //We installed a new machine that allows our customers to put in dollars and coins to pay for their purchase. 
        //However, we have been tasked with making sure that we have been given enough money.

        //Given a price of a purchase, a number of dollars, number of quarters, number of dimes, number of nickels, 
        //and number of pennies, return if we have been given enough money to make the purchase.
        public bool CashOnly(double itemPrice, int numberDollars, int numberQuarters, int numberDimes, int numberNickels, int numberPennies)
        { 
            double totGiven = (numberDollars * 1) + (numberQuarters * .25) + (numberDimes * .10) + (numberNickels * .05) + (numberPennies * .01);
            if (totGiven >= itemPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Our customers have been getting bored while they wait for their coffee, so we have created a few fun little games 
        //for them to play while they wait. We will select a random word, and they will guess a letter. 
        //If the letter is in the word we return a string with the letters showing and all other letters 
        //represented as a ‘-’. (For example if an ‘e’ was selected and the word was coffee, it would return “----ee”). 

        //Given a target word and given a letter guess by a customer, return a string that shows those letters revealed and 
        //the unknown letters as ‘-’ (minus sign)
        public string Hangman(string secretWord, char letterGuess)
        {
            string wordShown = secretWord;
            for (int i = 0; i < wordShown.Length; i++)
            {
                if (wordShown[i] != letterGuess)
                {
                    wordShown = wordShown.Replace(wordShown[i], '-');
                }
                
            }
            return wordShown;
        }

        //Hangman was such a hit they want us to add a new spin on it (literally). You will spin a wheel and get a point value. 
        //For each letter you find, you get that number of points. If you choose a vowel (‘a’,’e’,’i’,’o’,’u’), you get half as many points 
        //for each letter. 

        //Given a target word, a letter guess by a customer, and a point value. Return the number of points earned.
        public int WheelofFortune(string secretWord, char letterGuess, int pointValue)
        {
            //if (secretWord.Contains(letterGuess))
            int totalPoints = 0;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (letterGuess == secretWord[i])
                {
                    if ((letterGuess == 'a' || letterGuess == 'e' || letterGuess == 'i' ||
                    letterGuess == 'o' || letterGuess == 'u'))
                    {
                        totalPoints = totalPoints + (pointValue / 2);
                    }
                    else
                    {
                        totalPoints = totalPoints + pointValue;
                    }
                }
            }
            return totalPoints;
        }

        //Here at Software Guild Cafe, our labels for our cups are only so long so we want to limit the length of the names entered.
        
        //Given a name, and a maximum length the name can be (minimum 1), return if the name meets our requirements or not.
        public bool ValidateStringLength(string userEntry, int maxLength)
        {
            if (userEntry.Length > maxLength || userEntry == "")
            {
                return false;
            }
            return true;
        }

        //Our software allows us to type in any character we want in the quantity field. While we will do a software update 
        //in the future to fix this, for now we want to write some code that checks to see if the user typed in a number or not.
        
        //Given a string, return if it is a number or not.
        //(Hint - Look Up Try Parse Methods)
        public bool ValidateInteger(string userEntry)
        {
            if (Int32.TryParse(userEntry, out int result))
            {
                return true;
            }
            return false;
        }

        //We want to be sure someone doesn’t fat finger a number when entering quantity, so we want to make sure 
        //the number fits within our requirements.

        //Given a string and a maximum quantity (minimum 1), return if the number is within the allotted range.
        public bool ValidateIntegerinRange(string userEntry, int maxValue)
        {
            bool userNumber = Int32.TryParse(userEntry, out int result);
            if (userNumber == true)
            {
                if (result > 0 && result <= maxValue)
                {
                    return true;
                }
            }
                return false;
        }

        //In some cases we want to manually override the price of a product. But once again the user can type in whatever 
        //they want in the field.

        //Given a string, return if it is a double or not.
        //(Hint - Look Up Try Parse Methods)
        public bool ValidateDouble(string userEntry)
        {
            bool userDouble = Double.TryParse(userEntry, out double result);
            if (userDouble == true)
            {
                return true;
            }
            return false;
        }

        //We don’t want someone over-charging like crazy or giving away free things so we want to limit the maximum price of our items.
        
        //Given a string, maximum price, and minimum price, return if it is within range or not.
        public bool ValidateDoubleinRange(string userEntry, double minPrice, double maxPrice)
        {
            bool userNumber = double.TryParse(userEntry, out double result);
            if (userNumber == true)
            {
                if (result >= minPrice && result <= maxPrice)
                {
                    return true;
                }
            }
            return false;
        }

        //As a back-up to our touch screen system, the barista’s can enter a code to reference the specific items we have to offer. 
        //This code is always a single letter followed by up to 2 numbers.

        //Given a string, return if this code is a valid item entry code. (ex A5, C10, Z99)
        public bool ValidateItemEntry(string userEntry)
        {
            if (userEntry.Length > 0 && userEntry.Length <= 3)
            {
                if (userEntry.Length == 1)
                {
                    return false;
                }
                if (!char.IsLetter(userEntry[0]))
                {
                    return false;
                }
                for (int i = 1; i < userEntry.Length; i++)
                {
                    if (!char.IsDigit(userEntry[i]))
                    {
                        return false;
                    }
                }
                return true;
                
            }
            return false;
        }

        //Now that we have the entry item validated, we need to be sure its a valid item in our list.
        
        //Given a string selection from user and an array of valid item selections, return if this item is one we offer.
        public bool ValidateSelectionFromArray(string userEntry, string[] productSelections)
        {
            for (int i = 0; i < productSelections.Length; i++)
            {
                if (userEntry == productSelections[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
