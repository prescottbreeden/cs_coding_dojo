using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace wedding_planner.Models
{
  public class WeddingDb : DbContext
  {
    public WeddingDb(DbContextOptions<WeddingDb> options) : base(options) { }
    public DbSet<User> users { get; set; }
    public DbSet<Wedding> weddings { get; set; }
    public DbSet<Guest> guests { get; set; }

    public List<User> GetAllUsers()
    {
      return users.ToList();
    }

    public User GetOneUser(int id)
    {
      return users.FirstOrDefault(u => u.user_id == id);
    }

    public User GetOneUser(string email)
    {
      return users.FirstOrDefault(u => u.email == email);
    }

    public string LoginValidation(LoginUser user)
    {
      var isUser = users.FirstOrDefault(u => u.email == user.LogEmail);
      if(isUser is null)
      {
        return "Email not found";
      }
      else 
      {
        var hasher = new PasswordHasher<LoginUser>();
        var result = hasher.VerifyHashedPassword(
          user, isUser.password, user.LogPassword);

          if(result == 0)
          {
            return "Incorrect password";
          }
      }
      return "Success";
    }

    public void CreateNewUser(User newUser)
    {
      PasswordHasher<User> Hasher = new PasswordHasher<User>();
      newUser.password = Hasher.HashPassword(newUser, newUser.password); 
      users.Add(newUser);
      SaveChanges();
    }

    public void UpdateUser(User user)
    {
      User current = GetOneUser(user.user_id);
      current.name = user.name;
      current.email = user.email;
      current.updated_at = DateTime.Now;
      SaveChanges();
    }

    public void DeleteUser(WeddingDb dbContext, int id)
    {
      User removeThis = dbContext.users.SingleOrDefault(u => u.user_id == id);
      dbContext.users.Remove(removeThis);
      dbContext.SaveChanges();
    }

    public List<Wedding> GetAllWeddings(WeddingDb dbContext)
    {
      return dbContext.weddings.ToList();
    }

    public Wedding GetOneWedding(WeddingDb dbContext, int id)
    {
      return dbContext.weddings.FirstOrDefault(w => w.wedding_id == id);
    }

    public void CreateNewWedding(WeddingDb dbContext, Wedding newWedding)
    {
      dbContext.Add(newWedding);
      dbContext.SaveChanges();
    }

    public void UpdateWedding(WeddingDb dbContext, Wedding wedding)
    {
      Wedding current = GetOneWedding(dbContext, wedding.wedding_id);
      current.wedder_one = wedding.wedder_one;
      current.wedder_two = wedding.wedder_two;
      current.wedding_date = wedding.wedding_date;
      current.updated_at = DateTime.Now;
      dbContext.SaveChanges();
    }

    public void DeleteWedding(WeddingDb dbContext, int id)
    {
      Wedding removeThis = dbContext.weddings.SingleOrDefault(w => w.wedding_id == id);
      dbContext.weddings.Remove(removeThis);
      dbContext.SaveChanges();
    }
  }

}