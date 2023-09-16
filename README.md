# My-Bikes-Factory
This project aims to create a user-friendly interface enabling bike selection (Mountain or Road). User picks a bike type, they can further customize it by specifying color, model, tire type, and suspension. Users can uniquely identify, update, save, or delete bikes via a console window. C# is used to code.
This console can serve as the first form of user interface in an application which processes data entered by the user to filter the options requested by the user.  

  



The Project is coded in  <h1>C#</h1> and Microsoft Visual Studio has been used as the IDE environment.  

  

***Project Layers -*** 



  

>Business Layer 

>UI Layer  

>Data Layer

  

  

Business Layer :  

`The Business Logic layer manages all the business rules, calculations and actual logic within your application that enables it to actually implement the functionalities and it may often use some of the objects retrieved from your data-access layer `

  



  

  

UI Layer : 

`The user interface layer in the entry point for the application. It interacts with the infrastructure. UI Layer is the User Interface Layer  `

  

  



Data Layer :

`Data Access Layers typically contain methods for accessing the underlying database data.  This allows the client (or user) modules to be created with a higher level of abstraction` 

  

  



 

 

![Image](https://user-images.githubusercontent.com/42598861/268406995-e6951457-656d-47e7-8604-f93b3ed5933e.png)



<h1>Classes</h1> 

 

>>EColor:  Contained inside the Enum folder, EColor class contains the list of colors which are to be used by the user while selecting the bike 

 

>>ESuspensionType: Contained inside the Enum folder, ESuspensionType class contains the list of suspension types which are to be used by the user while selecting the bike 

 

 

>>ETireType: Contained inside the Enum folder, ETireType class contains the list of colors which are to be used by the user while selecting the bike 

 

 

>>Bikes: Bikes class contains the list of the attributes which are common to both the bike types 

 

>>MountainBikes: This class contains the attributes which are exclusive  to the Mountain bike type 

 

>>RoadBikes: This class contains the attributes which are exclusive only to the Road bike type 

 

>>User: Contains the attributes password and username required to be put inside the Login Form as a user 

 

>>Validator: Contains the methods to validate all the buttons, labels and boxed added in the main form so the application does what it has been designed to do 

 

>>BikesXMLData: Extensible Markup Language (XML) is a markup language that defines a set of rules for encoding documents in a format that is both human-readable and machine-readable. XML is often used for application configuration, data storage and exchange. The XmlData represents an XML document. It can be used to load, modify, validate, an navigate XML documents  

 

>>UserSequentialData: The C# Sequence class is used to manage database fields of type sequence. As sequences are effectively vectors of values, they are accessed through iterators.  

 

>>LoginForm: This class is used to validate the login credentials entered by the user using the data from the UserSequentialData class 

 

>>MainForm: This class contains all the labels, textboxes and buttons of the console as well as the validation code applied to these entities




