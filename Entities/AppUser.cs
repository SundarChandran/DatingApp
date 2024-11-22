using System;

namespace API.Entities;

public class AppUser
{
    //It could be the primary key and auto increment by entitty frame work
    public int Id {get; set;} 
    public required string UserName { get; set;} 

    public required byte[] PasswordHash { get; set;} 
    public required byte[] PasswordSalt { get; set;} 

}
