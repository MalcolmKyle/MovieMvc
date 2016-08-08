# MovieMvc

A MVC model and ASP.NET web application with a basic CRUD database.
I wanted to explore my abilities in the .NET framework so I started out trying to create a basic web application.
A walkthrough can be found at: https://docs.asp.net/en/latest/tutorials/first-mvc-app/start-mvc.html
This tutorial shows how to create an application for creating, editing, and delities movies in a database.
The database has entries for a movie's title, date created, price, rating, and genre.
Something to note is that the walkthrough uses ASP.NET CORE, but I did not have that downloaded so I just used ASP.NET.

The walkthrough is very straight forward, but the main thing I wanted to understand was exactly what is a MVC architecture, and how does it all work together.
Through my understanding a MVC works like this:
M - Model: The model manages the fundamental domain logic. For instance, the main objects and variables to be used by your application.
V - View: A view, as you would expect, sets up exactly what is says. The view outlines how the outside world will view your applicatioon.
C - Controller: The controller is the entity that will handle all of the application logic. This is where the logic will go for handleing all of the URL request and other logic as well.

There are numerous examples and explinations on what exactly each component is supposed to do, but the easiest way I like to think of it is this:
A model will have to primar (public and private) objects and varaibles to be used. The controller handles the logic for various senarious. 
In the walkthrough, the index function of the MovieController handles the index view of when the main web application is requested. 
The controller also has functions for creating, deleting, and editing the entries of the database.
The view laysout the format of how the data requested will be shown to the user.
