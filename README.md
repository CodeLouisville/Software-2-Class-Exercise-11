# Software 2 - Class Exercise 11
# Goals
Convert the application to an API

# Instructions
This exercise is going to be a bit different.  You will mainly be following some tutorials and trying to apply them to your project.
It will be broken down into sections so that if you get stuck, your mentor will be able to easily help.

## Converting the Project
You will only need to do this on the main `PetStore` project.  Follow this tutorial to convert the project: https://dotnettutorials.net/lesson/build-asp-net-core-web-api-project/ 

## Adding WebHost
In this step, it will be okay to wipe out your program class and replace it with only what you need to run the API. We will replace the functionality we get with the console input with web endpoints. Be sure to copy and save the section where you are adding your services before deleting everything.

https://dotnettutorials.net/lesson/adding-web-host-builder/

## Adding Startup file
This class is where you will add your services that we had in the program file.  

https://dotnettutorials.net/lesson/configuring-startup-class/

## Adding a Controller
Add a controller to replace the functionality of the program file.  For now, you will only have to do the `GET` methods.  One to get a product and the other to get an order.  If you have time, make the `POST` methods to add a product and order.

https://dotnettutorials.net/lesson/adding-controller-in-asp-net-core/

## Test
When you run your application, a web browser should open.  If you don't know how the routing works, do some research before testing.  This is how the I set my route up: `https://localhost:62235/product/getorder/1`.  Product is my controller, getorder is my method, and 1 is my id.

Talk to your mentor if you get stuck and can't figure out how to access your data using the web browser.

For testing `POST` methods, you will probably need to download some kind of program to interact with your application.  Postman is a popular application.  There are a few more good ones too, so feel free to do your research to find which http request tool you like most.
