﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieApplication
{
    public class Movie
    {
        public string Title { get; set;}
        public string Genre { get; set; }
        public double ReviewScore { get; set;}
        public string Director { get; set;}
        public int Length { get; set;}
        public string NumberOfActors { get; set;}

        //public List<string> Actors;

        public Movie(string title, string genre, double reviewScore, string director, int length, string numberOfActors)
        {
            Title = title;
            Genre = genre;
            ReviewScore = reviewScore;
            Director = director;
            Length = length;
            NumberOfActors = numberOfActors;
        }
        public void DisplayInformation()
        {
            MessageBox.Show($"Title: {Title} \n Genre: {Genre} \n ReviewScore: {ReviewScore} \n Director: {Director} \n How Long is the Movie? (in mins): {Length} minutes \n Amount Of Actors: {NumberOfActors}"); 
        }
    }
}
