using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Quiz.Data;

namespace Quiz.Models
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();


            if (context.Roles.Any())
            {
                return;   // DB has been seeded
            }

            context.Roles.AddRange(
                new IdentityRole
                {
                    Id = "0",
                    Name = "Admin"
                },
                new IdentityRole
                {
                    Id = "1",
                    Name = "Member"
                });

            //TODO: Something doesn't work when seeding questions

            //context.Questions.AddRange(
            //    new Question
            //    {
            //        Id = 0,
            //        Text = "Have you ever been so far as to decided to go do look more like?",
            //        AnswerA = "Yes",
            //        AnswerB = "No",
            //        AnswerC = "Maybe",
            //        AnswerD = "What?",
            //        CorrectAnswer = "D"
            //    },
            //    new Question
            //    {
            //        Id = 1,
            //        Text = "What is the airspeed velocity of an unladen swallow?",
            //        AnswerA = "20 km/h",
            //        AnswerB = "30 km/h",
            //        AnswerC = "40 km/h",
            //        AnswerD = "What do you mean, an african or a european swallow?",
            //        CorrectAnswer = "D"
            //    },
            //    new Question
            //    {
            //        Id = 2,
            //        Text = "Question 3",
            //        AnswerA = "Answer A",
            //        AnswerB = "Answer B",
            //        AnswerC = "Answer E",
            //        AnswerD = "Answer D",
            //        CorrectAnswer = "C"
            //    },
            //    new Question
            //    {
            //        Id = 3,
            //        Text = "If animals could talk, which would be the rudest?",
            //        AnswerA = "Giraffe",
            //        AnswerB = "Pigeon",
            //        AnswerC = "Moose",
            //        AnswerD = "Fish",
            //        CorrectAnswer = "A"
            //    },
            //    new Question
            //    {
            //        Id = 4,
            //        Text = "How many chickens would it take to kill an elephant",
            //        AnswerA = "10",
            //        AnswerB = "100",
            //        AnswerC = "50 000",
            //        AnswerD = "1",
            //        CorrectAnswer = "B"
            //    });

            context.SaveChanges();
        }
    }
}