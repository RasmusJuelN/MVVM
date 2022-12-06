using MVVM.Domain.Models;
using MVVM.Domain.Services;
using MVVM.EntityFramework;
using MVVM.EntityFramework.Services;

IDataService<User> userService = new GenericDataService<User>(new MVVMDbContextFactory());
// Create
userService.Create(new User { FirstName = "Rasmus", LastName = "Nielsen", Email = "Rasmusn686@hotmail.com", Username = "User1", Password = "123" }).Wait();

// GetAll
Console.WriteLine($"Getall: " + userService.GetAllAsync().Result.Count());

// Get
Console.WriteLine($"Get by Id: " + userService.Get(2));

// Update
Console.WriteLine($"Update: " + userService.Update(2, new User { Username = "User3" }).Result);

// Delete
Console.WriteLine($"Delete: " + userService.Delete(4).Result);
Console.ReadLine();