# Web API Project (notes.webapi)

## This project has dependencies on two Libraries

## Folder Structure
  ### `Notes.Core`
     INotesService.cs-> Interface for the notes class
     NotesServices.cs -> Service to carry out operations on the notes, implents the INotesService interface

  ### `Notes.DB`
     AppDbContext.cs-> Class to talk to the SQL database, using Entity Framework

### `Notes.WebApi`
     NotesController.cs-> Controller with endpoints to handle requests

### `Note`

The .Net Core Web API project is configured to use IIS express, the baseURL to which is specified in `notes.frontend/src/services/notes.js`


# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Build and Test
TODO: Describe and show how to build your code and run the tests. 

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
