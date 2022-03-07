// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using BestRestaurants.Models;
// using System.Collections.Generic;
// using System;

// namespace BestRestaurants.Tests
// {
//   [TestClass]
//   public class CuisineTests : IDisposable
//   {

//     public void Dispose()
//     {
//       Cuisine.ClearAll();
//     }

//     [TestMethod]
//     public void CuisineConstructor_CreatesInstanceOfCuisine_Cuisine()
//     {
//       Cuisine newCuisine = new Cuisine("test cuisine");
//       Assert.AreEqual(typeof(Cuisine), newCuisine.GetType());
//     }

//     [TestMethod]
//     public void GetName_ReturnsName_String()
//     {
//       //Arrange
//       string name = "Test Cuisine";
//       Cuisine newCuisine = new Cuisine(name);

//       //Act
//       string result = newCuisine.Name;

//       //Assert
//       Assert.AreEqual(name, result);
//     }

//     [TestMethod]
//     public void GetId_ReturnsCuisineId_Int()
//     {
//       //Arrange
//       string name = "Test Cuisine";
//       Cuisine newCuisine = new Cuisine(name);

//       //Act
//       int result = newCuisine.Id;

//       //Assert
//       Assert.AreEqual(1, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsAllCuisineObjects_CuisineList()
//     {
//       //Arrange
//       string name01 = "Work";
//       string name02 = "School";
//       Cuisine newCuisine1 = new Cuisine(name01);
//       Cuisine newCuisine2 = new Cuisine(name02);
//       List<Cuisine> newList = new List<Cuisine> { newCuisine1, newCuisine2 };

//       //Act
//       List<Cuisine> result = Cuisine.GetAll();

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void Find_ReturnsCorrectCuisine_Cuisine()
//     {
//       //Arrange
//       string name01 = "Work";
//       string name02 = "School";
//       Cuisine newCuisine1 = new Cuisine(name01);
//       Cuisine newCuisine2 = new Cuisine(name02);

//       //Act
//       Cuisine result = Cuisine.Find(2);

//       //Assert
//       Assert.AreEqual(newCuisine2, result);
//     }

//     [TestMethod]
//     public void AddRestaurant_AssociatesRestaurantWithCuisine_RestaurantList()
//     {
//       //Arrange
//       string description = "Walk the dog.";
//       Restaurant newRestaurant = new Restaurant(description);
//       List<Restaurant> newList = new List<Restaurant> { newRestaurant };
//       string name = "Work";
//       Cuisine newCuisine = new Cuisine(name);
//       newCuisine.AddRestaurant(newRestaurant);

//       //Act
//       List<Restaurant> result = newCuisine.Restaurants;

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//   }
// }