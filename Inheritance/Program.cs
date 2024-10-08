﻿using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird pigeon = new Bird() {
                HasLegs = true, 
                Age = 4, 
                Name = "Pigeon", 
                ChirpSound = "squak", 
                HasBeak = true, 
                HasEyes = true, 
                HasFeathers = true, 
                CanFly = true};
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile lizard = new Reptile()
            {
                HasLegs = true,
                Age = 20,
                Name = "Lizard",
                ColdBlooded = true,
                Legs = 4,
                HasEyes = true,
                HasScales = true,
                Type = "Komodo Dragon"
            };
            
            Console.WriteLine($"Name: {pigeon.Name}, Age: {pigeon.Age}, Sound: {pigeon.ChirpSound}");
            Console.WriteLine($"Name: {lizard.Name}, Age: {lizard.Age}, Legs: {lizard.Legs}, Type: {lizard.Type}");
        }
    }
}
