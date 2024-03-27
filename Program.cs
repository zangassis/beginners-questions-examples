using BeginnersQuestionsExamples.Classes;
using System;
var builder = WebApplication.CreateBuilder(args);

var newUser = new User();

newUser.Id = Guid.NewGuid();
newUser.Name = "John Smith";
newUser.Age = 18;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.Run();
